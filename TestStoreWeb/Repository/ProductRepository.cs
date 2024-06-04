﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestStoreWeb.Data;
using TestStoreWeb.Models;
using TestStoreWeb.Repository.IRepository;

namespace TestStoreWeb.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            _db.Product.Update(obj);
        }
    }
}