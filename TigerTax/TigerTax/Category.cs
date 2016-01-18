using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Category
    {
        public Category()
        {

        }

        public int CategoryId { get; set; }
        public String Name { get; set; }
        public Double TotalAmount { get; set; }
        public Double TotalMiles { get; set; }

        public ICollection<Category> Subcategories;
        public ICollection<Entry> Entries;
        public Record RecordId { get; set; }

        //public Category( String name)
        //{
        //    Name = name;
        //    TotalAmount = 0;
        //    TotalMiles = 0;
        //    Subcategories = new List<Category>();
        //    Entries = new List<Entry>();
        //}

        //public void AddEntry( Entry entry )
        //{
        //    Entries.Add( entry );
        //    TotalAmount += entry.Amount;
        //    TotalMiles += entry.Miles;
        //}

        //public void DeleteEntry(Entry entry)
        //{
        //    Entries.Remove(entry);
        //    TotalAmount -= entry.Amount;
        //    TotalMiles -= entry.Miles;
        //}

        //public void AddSubcategory(Category category)
        //{
        //    Subcategories.Add(category);
        //    TotalAmount += category.TotalAmount;
        //    TotalMiles += category.TotalMiles;
        //}

        //public void DeleteSubcategory(Category category)
        //{
        //    Subcategories.Remove(category);
        //    TotalAmount -= category.TotalAmount;
        //    TotalMiles -= category.TotalMiles;
        //}

        //Update entry? Needs to update total amount
    }
}
