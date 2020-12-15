using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDI01
{
    public class Product
    {
        public String ProductModel { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }
        public String ProductNumber { get; set; }
        public String Color { get; set; }
        public String ListPrice { get; set; }
        public String Size { get; set; }
        public String ProductLine { get; set; }
        public String Class { get; set; }
        public String Style { get; set; }
        public String Category { get; set; }
        public String SubCategory { get; set; }


        public string FullInfo
        {
            get
            {
                return $"{ProductModel} - {Description}, {Name}, {ProductNumber}, {Color} , {ListPrice}€, " +
                    $"{Size}, {ProductLine}, {Class}, {Style}, {Category}, {SubCategory}";
            }
        }

    }
}
