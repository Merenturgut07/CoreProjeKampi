﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetlistWithCategory()
        {
            using (var c = new Context())
            {
                return c.blogs.Include(x => x.Category).ToList();
            }

        }

        public List<Blog> GetlistWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.blogs.Include(x => x.Category).Where(x => x.WriterId == id).ToList();
            }
        }
    }
}
