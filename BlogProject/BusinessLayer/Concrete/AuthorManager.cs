using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AuthorManager : IAuthorService
	{
		IAuthorDal _authorDal;

		public AuthorManager(IAuthorDal authorDal)
		{
			_authorDal = authorDal;
		}
		public void AuthorAdd(Author author)
		{
			_authorDal.Insert(author);
		}
	}
}
