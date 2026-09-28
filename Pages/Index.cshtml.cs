using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Comment { get; set; } = "";

    public void OnGet() { }

    public void OnPost()
    {
        if (Request.Form["Clear"] == "1")
        {
            Comment = "";
            return;
        }
    }
}
