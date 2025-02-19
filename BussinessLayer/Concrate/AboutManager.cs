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
    public class AboutManager:IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetListAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDal.GetList();
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<About> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
           _aboutDal.Update(entity);
        }
    }
}
