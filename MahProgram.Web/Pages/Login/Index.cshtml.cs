using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.Login
{
    public class IndexModel : PageModel
    {
        private UserManager<IdentityUser<long>> _userManager;
        private SignInManager<IdentityUser<long>> _signInManager;

        public IndexModel(UserManager<IdentityUser<long>> userManager, SignInManager<IdentityUser<long>> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnGetAsync(string userName, string email, string password)
        {
            if (await _userManager.FindByEmailAsync(email) is not null)
            {
                var result = await _signInManager.PasswordSignInAsync(userName, password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToPage("/Errors/NotFound");
        }
    }
}
