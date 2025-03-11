using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.TGetList(x => x.BlogId == id);
            
        }

        public List<Comment> GetlistWithBlog()
        {
            return _commentDal.GetlistWithBlog();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
