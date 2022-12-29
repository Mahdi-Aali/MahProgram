using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class _HostModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
