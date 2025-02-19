﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        void TInsert(T entity);
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetListAll();
        List<T> GetListAll(int id);
        T TGetById(int id);
        List<T> TGetListByFilter();
    }
}
