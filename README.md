# AI Chatbot with RoBERTa and .NET

This project is an AI-powered chatbot trained using the **RoBERTa** model and integrated with a **.NET 8** backend for real-time interactions.

## Prerequisites

Before running the project, ensure you have the following installed:

- **.NET 8 SDK** ([Download Here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0))
- **Python 3.8+** ([Download Here](https://www.python.org/downloads/))
- **pip** (Python package manager)
- **virtualenv** (For Python environment management)
- **PyTorch** (Required for RoBERTa model)
- **Transformers** (Hugging Face library for NLP models)

## Setup Instructions

### 1. Clone the Repository

### 2. Create a Python Virtual Environment

```sh
python -m venv myenv
```

Activate the environment:
- **Windows**: `myenv\Scripts\activate`
- **Mac/Linux**: `source myenv/bin/activate`

### 3. Install Python Dependencies

```sh
pip install torch transformers flask flask-cors
```

### 4. Run the RoBERTa Chatbot API

Navigate to the `chatbot_api` folder:

```sh
cd chatbot_api
python app.py
```

This will start the API, typically running on `http://127.0.0.1:5000`.

### 5. Configure .NET Backend

Navigate back to the root directory and install dependencies:

```sh
dotnet restore
```

### 6. Update API Configuration in .NET

Modify `appsettings.json` to match the Python API settings:

```json
{
  "ChatbotApiUrl": "http://127.0.0.1:5000"
}
```

### 7. Run the .NET Backend

```sh
dotnet run
```

The backend should be running on `http://localhost:5001`.

- **Python API not starting?** Ensure `myenv` is activated and dependencies are installed.
- **Port conflicts?** Run:
  ```sh
  python app.py --port 5001
  ```
- **.NET API connection issues?** Verify `ChatbotApiUrl` in `appsettings.json`.


