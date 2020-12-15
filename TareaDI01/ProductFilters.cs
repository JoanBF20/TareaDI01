using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDI01
{
    public class ProductFilters
    {
        public List<string> ListFilters { get; set; }
        private string filter;
        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
                switch (value)
                {
                    case "ProductModel":
                        FilterCol = "Production.ProductModel.Name";
                        break;
                    case "Description":
                        FilterCol = "Production.ProductDescription.Description";
                        break;
                    case "ProductNumber":
                        FilterCol = "pp.ProductNumber";
                        break;
                    case "Color":
                        FilterCol = "pp.Color";
                        break;
                    case "ListPrice":
                        FilterCol = "pp.ListPrice";
                        break;
                    case "Size":
                        FilterCol = "pp.Size";
                        break;
                    case "ProductLine":
                        FilterCol = "pp.ProductLine";
                        break;
                    case "Class":
                        FilterCol = "pp.Class";
                        break;
                    case "Style":
                        FilterCol = "pp.Style";
                        break;
                    case "Category":
                        FilterCol = "Production.ProductCategory.Name";
                        break;
                    case "SubCategory":
                        FilterCol = "Production.ProductSubcategory.Name";
                        break;
                    case "SellEndDate":
                        FilterCol = "pp.SellEndDate";
                        break;
                    default:
                        break;
                }
            }
        }
        public string FilterValue { get; set; }
        public string Name { get; set; }
        public string FilterCol { get; set; }

        public ProductFilters(string Name)
        {
            this.Name = Name;
            this.ListFilters = new List<string>
            {
                "",
                "ProductModel",
                "Description",
                "ProductNumber",
                "Color",
                "ListPrice",
                "Size",
                "ProductLine",
                "Class",
                "Style",
                "Category",
                "SubCategory",
                "SellEndDate"
            };
        }
    }
}
