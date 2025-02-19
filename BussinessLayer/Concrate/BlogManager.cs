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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetlistWithCategory();
        }

        public void TDelete(int id)
        {
            _blogDal.Delete(id);
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> TGetListAll()
        {
            return _blogDal.GetList();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.TGetList(x => x.BlogId == id);
        }

        public List<Blog> TGetListByFilter()
        {
            throw new NotImplementedException();
        }


        public void TInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void TUpdate(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {

            return _blogDal.TGetList(x => x.WriterId == id);
        }
    }
}
