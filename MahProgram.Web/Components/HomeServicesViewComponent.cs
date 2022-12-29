using MahProgram.DataAccess.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Components
{
    public class HomeServicesViewComponent : ViewComponent
    {
        private IServiceRepository _serviceRepository;

        public HomeServicesViewComponent(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_serviceRepository.GetAll().Take(4).ToList());
        }
    }
}
