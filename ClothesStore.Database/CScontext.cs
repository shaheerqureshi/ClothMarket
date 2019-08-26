using ClothStore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStore.Database
{
    public class CScontext: DbContext
    {
        public CScontext(): base("ClothStoreConnection")
        {

        }
        public DbSet<Category>categories { get; set; }
        public DbSet<Product> products{ get; set; }
    }
}
