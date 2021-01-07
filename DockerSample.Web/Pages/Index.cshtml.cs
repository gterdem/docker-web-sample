using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DockerSample.Web.Pages
{
    public class Index : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public void OnPostLoginAsync()
        {
        }
    }
}