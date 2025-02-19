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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetListAll(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);    
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetList();
        }

        public List<Category> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
