namespace ASPNETMaker2024.Models;

// Partial class
public partial class chatbot {
    // IAspNetMakerPage interface // DN
    public interface IAspNetMakerPage
    {
        Task<IActionResult> Run();
        IActionResult Terminate(string url = "");
    }
} // End Partial class
