using OnlineShoppingStore.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Models
{
    public class myDBContext: DbContext
    {
        public myDBContext() : base("MainStreetMarketDatabaseEntities")
        {
        }
        public DbSet<MainStreetMarketDatabaseEntities> Categories { get; set; }
    }
}