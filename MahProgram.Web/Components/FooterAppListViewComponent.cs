using MahProgram.DataAccess.Repositories.ProjectRepository;
using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Components
{
	public class FooterAppListViewComponent : ViewComponent
	{
		private IProjectRepository _repository;

		public FooterAppListViewComponent(IProjectRepository repository)
		{
			_repository = repository;
		}

		public IViewComponentResult Invoke()
		{
			return View(_repository.GetAll());
		}
	}
}
