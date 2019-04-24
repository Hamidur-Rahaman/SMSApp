using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Models
{
    public class VM_SearchView
    {
        public string Category { get; set; }
        public string CompanyName { get; set; }
        public string ItemName { get; set; }
        public decimal ReorderLevel { get; set; }
        public decimal AvailableQuantity { get; set; }
    }
}
