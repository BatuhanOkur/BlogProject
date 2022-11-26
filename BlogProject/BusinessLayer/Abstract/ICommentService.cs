using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	internal interface ICommentService
	{
		void CommentAdd(Comment Comment);
		//void CommentDelete(Comment Comment);
		//void CommentUpdate(Comment Comment);
		List<Comment> GetAllComments(int id);
		//Comment GetComment(int id);
	}
}
