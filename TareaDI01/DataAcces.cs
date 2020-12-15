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
                    filtersString += "AND (pp.Name LIKE '%" + filters.Name + "%' OR Production.ProductModel.Name LIKE '%" + filters.Name + "%')";

                }
                if (filters.Filter != null && filters.Filter != "")
                {
                    filtersString += " AND " + filters.FilterCol;
                    if (filters.Filter == "SellEndDate")
                    {
                        filtersString += " IS "+filters.FilterValue;
                    } else
                    {
                        string filterValure = " = '" + filters.FilterValue + "'";
                        if (filterValure == " = 'NULL'")
                        {
                            filterValure = " IS NULL";
                        }
                        filtersString += filterValure;

                    }
                }
                string joins = " INNER JOIN Production.ProductSubcategory ON pp.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                joins += " INNER JOIN Production.ProductModel ON pp.ProductModelID = Production.ProductModel.ProductModelID";
                joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND pp.ProductModelID IS NOT NULL " + filtersString;
                string select = "SELECT DISTINCT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description," +
                "STUFF((SELECT DISTINCT '; '+p.Name FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Name,"+
                "STUFF((SELECT DISTINCT '; '+p.ProductNumber FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '')"+
                "AS ProductNumber, STUFF((SELECT DISTINCT '; '+p.Color FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Color,"+
                " STUFF((SELECT DISTINCT '; '+CAST(p.ListPrice AS VARCHAR) FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS ListPrice,"+
                " STUFF((SELECT DISTINCT '; '+p.Size FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Size, pp.ProductLine, pp.Class,"+
                " pp.Style, Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS SubCategory FROM Production.Product pp" + joins+ " ORDER BY ProductModel OFFSET " + page * limit+" ROWS FETCH FIRST "+limit+" ROWS ONLY";

                return connection.Query<Product>(select).ToList();
            }
        }

        public List<Product> GetProduct(String ProductModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {

                string joins = " INNER JOIN Production.ProductSubcategory ON pp.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                joins += " INNER JOIN Production.ProductModel ON pp.ProductModelID = Production.ProductModel.ProductModelID";
                joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND pp.ProductModelID IS NOT NULL AND  Production.ProductModel.Name = '"+ ProductModel+"' ";
                string select = "SELECT DISTINCT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description," +
                "pp.Name, " +
                "pp.ProductNumber, " +
                "pp.Color, " + 
                "pp.ListPrice," +
                " pp.Size, pp.ProductLine, pp.Class," +
                " pp.Style, Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS SubCategory FROM Production.Product pp" + joins;

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
                    filtersString += "AND (pp.Name LIKE '%" + filters.Name + "%' OR Production.ProductModel.Name LIKE '%" + filters.Name + "%')";

                }
                if (filters.Filter != null && filters.Filter != "")
                {
                    filtersString += " AND " + filters.FilterCol;
                    if (filters.Filter == "SellEndDate")
                    {
                        filtersString += " IS " + filters.FilterValue;
                    }
                    else
                    {
                        string filterValure = " = '" + filters.FilterValue + "'";
                        if (filterValure == " = 'NULL'")
                        {
                            filterValure = " IS NULL";
                        }
                        filtersString += filterValure;

                    }
                }
                string joins = " INNER JOIN Production.ProductSubcategory ON pp.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID";
                joins += " INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID";
                joins += " INNER JOIN Production.ProductModel ON pp.ProductModelID = Production.ProductModel.ProductModelID";
                joins += " INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID =Production.ProductModelProductDescriptionCulture.ProductModelID";
                joins += " INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID";
                joins += " WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND pp.ProductModelID IS NOT NULL " + filtersString;
                string select = "SELECT DISTINCT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description," +
                "STUFF((SELECT DISTINCT '; '+p.Name FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Name," +
                "STUFF((SELECT DISTINCT '; '+p.ProductNumber FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '')" +
                "AS ProductNumber, STUFF((SELECT DISTINCT '; '+p.Color FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Color," +
                " STUFF((SELECT DISTINCT '; '+CAST(p.ListPrice AS VARCHAR) FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS ListPrice," +
                " STUFF((SELECT DISTINCT '; '+p.Size FROM Production.Product p WHERE p.ProductModelID = pp.ProductModelID FOR XML PATH('')), 1, 1, '') AS Size, pp.ProductLine, pp.Class," +
                " pp.Style, Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS SubCategory FROM Production.Product pp" + joins;

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
                    string select = $"SELECT DISTINCT {col} FROM (SELECT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size, Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS SubCategory FROM Production.Product {joins}) AS ProductsList";

                    return connection.Query<string>(select).ToList();

                } else
                {
                    return null;
                }
            }
        }
    }
}
