using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogProject.ViewComponents.Comment
{
	public class AddComment : ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
