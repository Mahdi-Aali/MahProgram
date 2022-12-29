using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.DataAccess.Repositories.ProjectRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.OurWorks
{
    public class IndexModel : PageModel
    {
        private IProjectRepository _repository;

        public IndexModel(IProjectRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Project> Projects { get; set; } = null!;
        public void OnGet()
        {
            Projects = _repository.GetAll();
        }
    }
}
