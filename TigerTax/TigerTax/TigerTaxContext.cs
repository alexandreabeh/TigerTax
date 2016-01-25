using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TigerTax
{
    class TigerTaxContext : DbContext
    {
        public TigerTaxContext() : base("name=TigerTaxConnection")
        {
            
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Entry> Entries { get; set; }

        //static TigerTaxContext()
        //{
        //    //Database initialize
        //    Database.SetInitializer<TigerTaxContext>(new DbInitializer());
        //    using (TigerTaxContext db = new TigerTaxContext())
        //        db.Database.Initialize(false);
        //}

        //class DbInitializer : DropCreateDatabaseAlways<TigerTaxContext>
        //{
        //}
    }
}
