using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models
{
    public class Admin_product_info_view_Model
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategory_Id { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}