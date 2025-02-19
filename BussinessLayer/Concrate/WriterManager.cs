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
    public class WriterManager:IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetListAll(int id)
        {
            throw new NotImplementedException();

        }

        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> TGetListAll()
        {
            return _writerDal.GetList();
        }

        public List<Writer> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Writer> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Writer entity)
        {
           _writerDal.Insert(entity);
        }

        public void TUpdate(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
