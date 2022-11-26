using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
