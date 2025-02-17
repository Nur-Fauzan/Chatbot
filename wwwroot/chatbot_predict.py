from fastapi import FastAPI
from pydantic import BaseModel
from transformers import AutoTokenizer, AutoModelForSequenceClassification, pipeline
import os
import pyodbc
import json

app = FastAPI()

def load_config():
    script_dir = os.path.dirname(os.path.abspath(__file__))

    config_file_path = os.path.join(script_dir, '..', 'appsettings.Development.json')

    with open(config_file_path) as f:
        config = json.load(f)

    db_config = config['Databases']['DB']
    driver = 'ODBC Driver 17 for SQL Server'
    server = 'localhost'
    database = db_config['dbname']
    username = db_config['username']
    password = db_config['password']

    conn_str = f"DRIVER={{{driver}}};SERVER={server};DATABASE={database};UID={username};PWD={password}"

    return conn_str

def fetch_data_from_sql():
    conn_str = load_config()

    conn = pyodbc.connect(conn_str)
    cursor = conn.cursor()

    cursor.execute("SELECT Tag, Answer FROM Question")

    rows = cursor.fetchall()

    data = [{"Tag": row[0], "Answer": row[1]} for row in rows]

    cursor.close()
    conn.close()

    return data

model_path = "chatbot_roberta" 
model_roberta = AutoModelForSequenceClassification.from_pretrained(model_path)
tokenizer_roberta = AutoTokenizer.from_pretrained(model_path)
chatbot_roberta = pipeline("text-classification", model=model_roberta, tokenizer=tokenizer_roberta)

class RequestBody(BaseModel):
    text: str

@app.post("/chatbot")
async def get_answer(request: RequestBody):
    text = request.text.strip().lower()

    prediction = chatbot_roberta(text)[0]
    label = prediction['label']
    score = prediction['score']

    data = fetch_data_from_sql()

    if score < 0.8:
        return {"label": label, "score": score, "answer": "I don't have an answer to that question yet!"}

    for entry in data:
        if entry["Tag"].lower() == label.lower():
            return {"label": label, "score": score, "answer": entry["Answer"]}

    return {"label": label, "score": score, "answer": "I don't have an answer to that question yet!"}
