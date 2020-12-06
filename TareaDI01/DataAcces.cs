using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TareaDI01
{
    public class DataAcces
    {

        public List<Product> GetProducts(int limit, int page, ProductFilters filters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string filtersString = "";

                if (filters.Name != null && filters.Name != "")
                {
                    filtersString += "AND Product.Name LIKE '%" + filters.Name + "%'";

                }
                if (filters.Filter != null && filters.Filter != "")
                {
                    filtersString += " AND " + filters.Filter;
                    string filterValure = " = '" + filters.FilterValue + "'";
                    if (filterValure == " = 'NULL'")
                    {
                        filterValure = " IS NULL";
                    }
                    filtersString += filterValure;

                }
                string joins = " INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                joins += " INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID";
                joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL "+ filtersString;
                string select = $"SELECT * FROM Production.Product{joins} ORDER BY ProductID OFFSET {page * limit} ROWS FETCH FIRST {limit} ROWS ONLY";

                Console.WriteLine(select);
                return connection.Query<Product>(select).ToList();
            }
        }

        public int CountProducts(ProductFilters filters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string filtersString = "";

                if (filters.Name != null && filters.Name != "")
                {
                    filtersString += "AND Product.Name LIKE '%" + filters.Name + "%'";

                }
                if (filters.Filter != null && filters.Filter != "")
                {
                    filtersString += " AND " + filters.Filter;
                    string filterValure = " = '" + filters.FilterValue + "'";
                    if (filterValure == " = 'NULL'")
                    {
                        filterValure = " IS NULL";
                    }
                    filtersString += filterValure;

                }
                string joins = " INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                joins += " INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID";
                joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL " + filtersString;

                string select = "SELECT ProductID FROM Production.Product"+joins;

                return connection.Query<Product>(select).Count();
            }
        }

        public List<string> getDisctinctCol(ProductFilters filters, string col)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                if (filters.ListFilters.Contains(col))
                {
                    string joins = " INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                    joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                    joins += " INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID";
                    joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                    joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                    joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL ";
                    string select = $"SELECT DISTINCT {col} FROM Production.Product {joins}";
                    Console.WriteLine(select);
                    return connection.Query<string>(select).ToList();

                } else
                {
                    return null;
                }
            }
        }
    }
}
