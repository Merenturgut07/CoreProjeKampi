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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writers> GetListAll(int id)
        {
            throw new NotImplementedException();

        }

        public List<Writers> GetWriterById(int id)
        {
            return _writerDal.TGetList(x => x.WriterId == id);
        }

        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }

        public Writers TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writers> TGetListAll()
        {
            return _writerDal.GetList();
        }

        public List<Writers> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Writers> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Writers entity)
        {
            _writerDal.Insert(entity);
        }

        public void TUpdate(Writers entity)
        {
            _writerDal.Update(entity);
        }
    }
}
