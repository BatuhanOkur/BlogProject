using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke()
		{
			var comments = commentManager.GetAllComments(3);
			return View(comments);
		}
	}
}
