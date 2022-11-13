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
	public class BlogManager : IBlogService
	{
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public void BlogAdd(Blog blog)
		{
			_blogdal.Insert(blog);
		}

		public void BlogDelete(Blog blog)
		{
			_blogdal.Delete(blog);
		}

		public void BlogUpdate(Blog blog)
		{
			_blogdal.Update(blog);
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogdal.GetAll();
		}

		public Blog GetBlog(int id)
		{
			return _blogdal.GetByID(id);
		}
	}
}
