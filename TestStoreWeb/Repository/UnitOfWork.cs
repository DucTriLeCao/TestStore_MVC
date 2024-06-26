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
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public ICategoryRepository Category {  get;private set; }
        public IProductRepository Product { get;private set; }
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }
        public IProductRepository CategoryRepository { get;private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
