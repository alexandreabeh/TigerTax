using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Entry
    {
        public int EntryId { get; set; }
        public DateTime Date { get; set; }
        public String Location { get; set; }
        public String Description { get; set; }
        public Double Amount { get; set; }
        public Double Miles { get; set; }
        public String Other { get; set; }

        public Category Category { get; set; }
    }
}
