using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = categoryManager.GetAllCategories();
			return View(values);	
		}
	}
}
