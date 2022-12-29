using MahProgram.DataAccess.Repositories.ProjectRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Components
{
    public class HeaderAppIconsViewComponent : ViewComponent
    {
        private IProjectRepository _projectRepository;

        public HeaderAppIconsViewComponent(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_projectRepository.GetAll().OrderByDescending(o => o.CreateDate).Take(8));
        }
    }
}
