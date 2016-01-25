using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Category
    {
        //public Category()
        //{

        //}
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }
        [Required]
        public Double TotalAmount { get; set; }
        [Required]
        public Double TotalMiles { get; set; }

        public ICollection<Category> Subcategories;
        public ICollection<Entry> Entries;

        public virtual Record Record { get; set; }

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
