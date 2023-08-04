using OnlineShoppingStore.Database;
using OnlineShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace OnlineShoppingStore.Repository
{
    interface IRepository : IDisposable
    {
        void SaveAdminAddProduct(Product_Admin_Model mdl);

    }

    public class CategoryRepository : IRepository
    {
        MainStreetMarketDatabaseEntities _db = new  MainStreetMarketDatabaseEntities();

        public void SaveAdminAddProduct(Product_Admin_Model mdl)
        {
            Product_Tbl obj = new Product_Tbl();
            obj.ProductId = mdl.ProductId;
            obj.ProductName = mdl.ProductName;
            obj.CategoryId = mdl.CategoryId;
            obj.SubCategory_Id = mdl.SubCategory_Id;
            obj.Description = mdl.Description;
            obj.ProductImage= mdl.ProductImage;
            obj.Quantity = mdl.Quantity;
            obj.Price = mdl.Price;  
            
            
            _db.Product_Tbl.Add(obj);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }

}