using MahProgram.DataAccess.Repositories.EmployeeRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Components;

public class OurTeamViewComponent : ViewComponent
{
    private IEmployeeRepository _employeeRepository;

    public OurTeamViewComponent(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public IViewComponentResult Invoke()
    {
        return View(_employeeRepository.GetAll());
    }
}
