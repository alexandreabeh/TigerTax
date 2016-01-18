using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTax
{
    public class Record
    {
        public Record()
        {
            TotalAmount = 0;
            //Categories = new Collection<Category>();
            DateModified = DateTime.Now;
        }

        public int RecordId { get; set; }
        public String Name { get; set; }
        public Double TotalAmount { get; set; }
        public DateTime DateModified { get; set; }

        public ICollection<Category> Categories;
    }
}
