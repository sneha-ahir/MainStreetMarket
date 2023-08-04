using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models
{
    public class UserAuthenticationDBContext: DbContext
    {
        public UserAuthenticationDBContext() : base("myconn") 
        {
        }

        public DbSet<UserAuthenticationModel> UserAuthentication { get; set; }

    }
}