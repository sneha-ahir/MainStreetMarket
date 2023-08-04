using OnlineShoppingStore.Models;
using OnlineShoppingStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Admin_Dashboard()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitForm(FormCollection formCollection)
        {
            Product_Admin_Model model = new Product_Admin_Model();
            // Access the form data using the "formCollection" object and process it as needed.
            model.ProductName = formCollection["ProductName"];
            if (int.TryParse(formCollection["ProductCategory"], out int CategoryId))
            {
                model.CategoryId = CategoryId;
            }
            else
            { 
                model.CategoryId = 0; // or any other default value that makes sense in your context
            }
            if (int.TryParse(formCollection["ProductSubCategory"], out int SubCategory_Id))
            {
                model.SubCategory_Id = SubCategory_Id;
            }
            else
            {
                model.SubCategory_Id = 0; // or any other default value that makes sense in your context
            }
            
            model.Description = formCollection["ProductDescription"];
            model.ProductImage = formCollection["ProductImage"];
            
            if (int.TryParse(formCollection["ProductQuantity"], out int Quantity))
            {
                model.Quantity = Quantity;
            }
            else
            {
                model.Quantity = 0; // or any other default value that makes sense in your context
            }
            if (int.TryParse(formCollection["ProductPrice"], out int ProductPrice))
            {
                model.Price = ProductPrice;
            }
            else
            {
                model.Price = 0; // or any other default value that makes sense in your context
            }
      
            // Retrieve other form fields in a similar manner.

            // Your form data processing logic goes here.
            using (IRepository _rep = new CategoryRepository())
            {
                _rep.SaveAdminAddProduct(model);
            }
            // Redirect or return the appropriate view after processing the form data.
            return RedirectToAction("Admin_Dashboard");
        }
    }
}