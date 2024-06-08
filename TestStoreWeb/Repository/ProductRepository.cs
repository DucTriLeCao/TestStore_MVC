using System;
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
            var objFromDb = _db.Product.FirstOrDefault(u => u.ProductId == obj.ProductId);
            if (objFromDb != null)
            {
                objFromDb.ProductName = obj.ProductName;
                objFromDb.ProductId = obj.ProductId;
                objFromDb.ProductDescription = obj.ProductDescription;
                objFromDb.Brand = obj.Brand;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Price = obj.Price;
                objFromDb.Price10 = obj.Price10;
                objFromDb.Price20 = obj.Price20;
                objFromDb.Quantity = obj.Quantity;
                objFromDb.CategoryId = obj.CategoryId;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
