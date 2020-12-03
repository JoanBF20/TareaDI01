using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDI01
{
    class ProductFilters
    {
        public string Name { get; set; }
        public ProductFilters(string Name)
        {
            this.Name = Name;
        }
    }
}
