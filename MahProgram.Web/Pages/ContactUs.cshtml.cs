using MahProgram.Common.ModelConvertorExtensions;
using MahProgram.DataAccess.Repositories.ContactUsRepositories;
using MahProgram.DTOs.Models.ContactUsModels;
using MahProgram.Utilities.Google.Recaptcha;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages
{
    public class ContactUsModel : PageModel
    {
        private IContactUsRepository _contactUsRepository;

        public ContactUsModel(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }
        [BindProperty]
        [FromForm]
        public ContactUsViewModel ContactUs { get; set; } = new();

        public PageResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!await GoogleRecaptchaValidator.IsValidAsync(Request.Form["g-recaptcha-response"], GoogleRecaptchaKeys.SecretKey))
            {
                ModelState.AddModelError("All", "لطفا من ربات نیستم را تائید کنید");
            }
            if (ModelState.IsValid)
            {
                bool result = await _contactUsRepository.AddAsync(ContactUs.ToContactUs());
                if (result)
                {
                    TempData["Success"] = true;
                    return RedirectToPage("/ContactUs");
                }
                ModelState.AddModelError("All", "مشگلی در ثبت تماس شما به وجود آمده لطفا دوباره امتحان کنید");
            }
            return Page();
        }
    }
}
