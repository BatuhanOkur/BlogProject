using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var comments = commentManager.GetAllComments(id);
			return View(comments);
		}
	}
}
