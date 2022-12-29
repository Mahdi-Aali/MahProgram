using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.LogOut
{
    public class IndexModel : PageModel
    {
        private SignInManager<IdentityUser<long>> _signInManager;

        public IndexModel(SignInManager<IdentityUser<long>> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if(User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToPage("/Errors/NotFound");
        }
    }
}
