namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QuestionList/{ID?}", Name = "QuestionList-Question-list")]
    [Route("Home/QuestionList/{ID?}", Name = "QuestionList-Question-list-2")]
    public async Task<IActionResult> QuestionList()
    {
        // Create page object
        questionList = new GLOBALS.QuestionList(this);
        questionList.Cache = _cache;

        // Run the page
        return await questionList.Run();
    }

    // add
    [Route("QuestionAdd/{ID?}", Name = "QuestionAdd-Question-add")]
    [Route("Home/QuestionAdd/{ID?}", Name = "QuestionAdd-Question-add-2")]
    public async Task<IActionResult> QuestionAdd()
    {
        // Create page object
        questionAdd = new GLOBALS.QuestionAdd(this);

        // Run the page
        return await questionAdd.Run();
    }

    // view
    [Route("QuestionView/{ID?}", Name = "QuestionView-Question-view")]
    [Route("Home/QuestionView/{ID?}", Name = "QuestionView-Question-view-2")]
    public async Task<IActionResult> QuestionView()
    {
        // Create page object
        questionView = new GLOBALS.QuestionView(this);

        // Run the page
        return await questionView.Run();
    }

    // edit
    [Route("QuestionEdit/{ID?}", Name = "QuestionEdit-Question-edit")]
    [Route("Home/QuestionEdit/{ID?}", Name = "QuestionEdit-Question-edit-2")]
    public async Task<IActionResult> QuestionEdit()
    {
        // Create page object
        questionEdit = new GLOBALS.QuestionEdit(this);

        // Run the page
        return await questionEdit.Run();
    }

    // delete
    [Route("QuestionDelete/{ID?}", Name = "QuestionDelete-Question-delete")]
    [Route("Home/QuestionDelete/{ID?}", Name = "QuestionDelete-Question-delete-2")]
    public async Task<IActionResult> QuestionDelete()
    {
        // Create page object
        questionDelete = new GLOBALS.QuestionDelete(this);

        // Run the page
        return await questionDelete.Run();
    }
}
