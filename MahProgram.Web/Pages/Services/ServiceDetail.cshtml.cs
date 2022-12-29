using MahProgram.DataAccess.Models.ServiceModel;
using MahProgram.DataAccess.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.Services
{
    public class ServiceDetailModel : PageModel
    {
        private IServiceRepository _serviceRepository;

        public ServiceDetailModel(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }


        public Service Service { get; set; } = new();
        public async Task<IActionResult> OnGet([FromRoute] int id)
        {
            Service = await _serviceRepository.FindAsync(id);
            if (Service is null)
            {
                return RedirectToPage("/Errors/NotFound");
            }
            return Page();
        }
    }
}
