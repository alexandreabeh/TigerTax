//using System.Collections.Generic;
//using System.Data.Entity.Infrastructure;

//namespace TigerTax
//{
//    using System;
//    using System.Data.Entity;
//    using System.Linq;

//    public class TigerTaxModel : DbContext
//    {
//        // Your context has been configured to use a 'TigerTaxModel' connection string from your application's 
//        // configuration file (App.config or Web.config). By default, this connection string targets the 
//        // 'TigerTax.TigerTaxModel' database on your LocalDb instance. 
//        // 
//        // If you wish to target a different database and/or database provider, modify the 'TigerTaxModel' 
//        // connection string in the application configuration file.
//        public TigerTaxModel()
//            : base("name=TigerTaxConnection")
//        {
//        }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            throw new UnintentionalCodeFirstException();
//        }

//        // Add a DbSet for each entity type that you want to include in your model. For more information 
//        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

//        public virtual DbSet<Record> Records { get; set; }
//        public virtual DbSet<Category> Categories { get; set; }
//        public virtual DbSet<Entry> Entries { get; set; }
//    }

//    public class Entry
//    {
//        public int EntryId { get; set; }
//        public DateTime Date { get; set; }
//        public String Location { get; set; }
//        public String Description { get; set; }
//        public Double Amount { get; set; }
//        public Double Miles { get; set; }
//        public String Other { get; set; }

//        public Category Category { get; set; }
//    }

//    public class Category
//    {
//        public int CategoryId { get; set; }
//        public String Name { get; set; }
//        public Double TotalAmount { get; set; }
//        public Double TotalMiles { get; set; }

//       // public ICollection<Category> Subcategories;
//        public ICollection<Entry> Entries;
//        public Record RecordId { get; set; }
//    }

//    public class Record
//    {
//        public int RecordId { get; set; }
//        public String Name { get; set; }
//        public Double TotalAmount { get; set; }
//        public DateTime DateModified { get; set; }

//        public ICollection<Category> Categories;
//    }
//}