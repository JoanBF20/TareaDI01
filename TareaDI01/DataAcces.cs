using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TareaDI01
{
    class DataAcces
    {
        public List<Product> GetAllProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                return connection.Query<Product>("SELECT * FROM Production.Product").ToList();
            }
        }

        public List<Product> GetProducts(int limit, int page, ProductFilters filters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string filtersString = "";

                if (filters.Name != null && filters.Name != "")
                    filtersString += " WHERE Name LIKE '%" + filters.Name+"%'";

                string select = $"SELECT * FROM Production.Product{filtersString} ORDER BY ProductID OFFSET {page*limit} ROWS FETCH FIRST {limit} ROWS ONLY";
                //string select = "SELECT * FROM Production.Product WHERE Name LIKE '%Fl%' ORDER BY ProductID OFFSET 0 ROWS FETCH FIRST 5 ROWS ONLY;";
                Console.WriteLine(select);
                return connection.Query<Product>(select).ToList();
            }
        }

        public int CountProducts(ProductFilters filters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string select = "SELECT ProductID FROM Production.Product";

                if (filters.Name != null && filters.Name != "")
                    select += " WHERE Name LIKE '%"+filters.Name+"%'";

                return connection.Query<Product>(select).Count();
            }
        }
    }
}
