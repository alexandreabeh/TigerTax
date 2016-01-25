using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }
        public DateTime Date { get; set; }
        [StringLength(100)]
        public String Location { get; set; }
        [StringLength(1000)]
        public String Description { get; set; }
        [Required]
        public Double Amount { get; set; }
        public Double Miles { get; set; }
        [StringLength(1000)]
        public String Other { get; set; }

        public virtual Category Category { get; set; }
    }
}
