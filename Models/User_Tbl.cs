//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Tbl
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Mobile_number { get; set; }
        public string Street_Address { get; set; }
        public string City { get; set; }
        public string State_Province { get; set; }
        public Nullable<int> Postal_code { get; set; }
        public string Country { get; set; }
    }
}
