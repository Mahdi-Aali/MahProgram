using MahProgram.DataAccess.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Components;

public class ServicesViewComponent : ViewComponent
{
	private IServiceRepository _serviceRepository;

	public ServicesViewComponent(IServiceRepository serviceRepository)
	{
		_serviceRepository = serviceRepository;
	}

	public IViewComponentResult Invoke()
	{
		return View(_serviceRepository.GetAll());
	}
}
