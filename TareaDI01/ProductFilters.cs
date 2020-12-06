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
        public string Filter { get; set; }
        public string FilterValue { get; set; }
        public string Name { get; set; }

        public ProductFilters(string Name)
        {
            this.Name = Name;
            this.ListFilters = new List<string>
            {
                "",
                "ProductID",
                "ProductNumber",
                "MakeFlag",
                "FinishedGoodsFlag",
                "Color",
                "ReorderPoint",
                "StandardCost",
                "ListPrice",
                "Size",
                "SizeUnitMeasureCode",
                "WeightUnitMeasureCode",
                "Weight",
                "DaysToManufacture",
                "ProductLine",
                "Class",
                "Style",
                "ProductSubcategoryID",
                "ProductModelID",
                "SellStartDate",
                "SellEndDate",
                "DiscontinuedDate",
                "rowguid",
                "ModifiedDate"
            };
        }
    }
}
