using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.DataAccess.Repositories.ProjectRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MahProgram.Web.Pages.OurWorks
{
    public class SingleAppModel : PageModel
    {
        private IProjectRepository _repository;

        public SingleAppModel(IProjectRepository repository)
        {
            _repository = repository;
        }

        public Project Project { get; set; } = new();

        public async Task<IActionResult> OnGetAsync([FromRoute]int id)
        {
            Project = await _repository.FindAsync(id);
            if (Project is default(Project) || Project is null)
            {
                return RedirectToPage("/Errors/NotFound");
            }
            return Page();
        }
    }
}
