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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public List<NewsLetter> GetListAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _newsLetterDal.Delete(id);
        }

        public NewsLetter TGetById(int id)
        {
            return _newsLetterDal.GetById(id);
        }

        public List<NewsLetter> TGetListAll()
        {
           return _newsLetterDal.GetList();
        }

        public List<NewsLetter> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(NewsLetter entity)
        {
            _newsLetterDal.Insert(entity);
        }

        public void TUpdate(NewsLetter entity)
        {
            _newsLetterDal.Update(entity);
        }
    }
}
