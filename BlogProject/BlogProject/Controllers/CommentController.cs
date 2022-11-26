using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using BusinessLayer.Concrete;

namespace BlogProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}

	}
}
