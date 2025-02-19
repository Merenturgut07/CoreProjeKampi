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
    public class ContactManager:IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetListAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetList();
        }

        public List<Contact> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
           _contactDal.Update(entity);
        }
    }
}
