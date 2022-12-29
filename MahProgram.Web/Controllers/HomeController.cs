using Microsoft.AspNetCore.Mvc;

namespace MahProgram.Web.Controllers;

public class HomeController : Controller
{
	[Route("/")]
	[HttpGet]
	public ViewResult Index()
	{
		return View(nameof(Index));
	}
}
