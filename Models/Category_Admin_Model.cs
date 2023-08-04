using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models
{
    public class Category_Admin_Model
    {
        [Key]
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
    }
}