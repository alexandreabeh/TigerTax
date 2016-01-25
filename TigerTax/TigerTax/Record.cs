using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Record
    {
        //public Record()
        //{
        //    TotalAmount = 0;
        //    //Categories = new Collection<Category>();
        //    DateModified = DateTime.Now;
        //}
        [Key]
        public int RecordId { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }
        [Required]
        public Double TotalAmount { get; set; }
        [Required]
        public DateTime DateModified { get; set; }

        public ICollection<Category> Categories;
    }
}
