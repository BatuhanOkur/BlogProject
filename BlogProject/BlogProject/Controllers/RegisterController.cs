using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	public class RegisterController : Controller
	{
		AuthorManager authorManager = new AuthorManager(new EFAuthorRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Author author)
		{
			AuthorValidator authorValidator = new AuthorValidator();
			ValidationResult results = authorValidator.Validate(author);
			if(results.IsValid)
			{
				author.AuthorStatus = true;
				author.AuthorAbout = "Kendinizden bahsedin!";
				author.AuthorImage = "Boş";
				authorManager.AuthorAdd(author);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

	}
}
