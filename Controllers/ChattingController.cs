namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Chatting (custom)
    [Route("Chatting/{**key}", Name = "Chatting-Chatting-custom")]
    [Route("Home/Chatting/{**key}", Name = "Chatting-Chatting-custom-2")]
    [AllowAnonymous]
    public async Task<IActionResult> Chatting()
    {
        // Create page object
        chatting = new GLOBALS.Chatting(this);

        // Run the page
        return await chatting.Run();
    }
}
