using MahProgram.DataAccess.Repositories.EmployeeRepository;
using MahProgram.DataAccess.Repositories.ProjectRepository;
using MahProgram.DataAccess.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MahProgram.Web.Components
{
	public class MainCounterViewComponent : ViewComponent
	{
		private IEmployeeRepository _employeeRepository;
		private IProjectRepository _projectRepository;
		private IServiceRepository _serviceRepository;


		public MainCounterViewComponent(IEmployeeRepository employeeRepository,
			IProjectRepository projectRepository,
			IServiceRepository serviceRepository)
		{
			_employeeRepository = employeeRepository;
			_projectRepository = projectRepository;
			_serviceRepository = serviceRepository;
		}


		public async Task<IViewComponentResult> InvokeAsync()
		{
			var countTuple = 
				(
				await _employeeRepository.GetAll().CountAsync(),
				await _projectRepository.GetAll().CountAsync(),
				await _serviceRepository.GetAll().CountAsync()
				);
			return View(countTuple);
		}
	}
}
