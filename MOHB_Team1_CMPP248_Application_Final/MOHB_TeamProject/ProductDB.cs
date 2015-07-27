/* Author: Terry Mao
 * Purpose: Cause the M.O.H.B told me Workshop Part 2
 * Date: July 4, 2015
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    // make public static class ProductDB
    public static class ProductDB
    {
        // make method to get product by ProductId
        public static Product GetProductId(int productId)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement = 
                "SELECT ProductId, ProdName " +
                "FROM Products " +
                "WHERE ProductId = @ProductId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", productId);

            // try to catch exceptions
            try 
            {
                // open the connection
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow); // only one row; resolve CommandBehavior
                if (reader.Read()) // there is a row
                {
                    // process the row
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProdName = reader["ProdName"].ToString();
                    return product;
                }
                else // no product
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex; // throw the exception for the form to handle
            }
            finally
            {
                connection.Close();
            }
        }

        // make method to get all the suppliers of a specific product 
        public static List<Supplier> GetSuppliersOfProduct(int productId)
        {
            List<Supplier> suppliers = new List<Supplier>();
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
                "SELECT * " +
                "FROM Suppliers " +
                "WHERE SupplierId in (Select SupplierId from Products_Suppliers where ProductId = @ProductId)";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductId", productId);

            // try to catch exceptions
            try
            {
                // open the connection
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(); // retrieve multiple rows
                while (reader.Read()) // there is a row
                {
                    // process the row
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    supplier.SupName = reader["SupName"].ToString();
                    suppliers.Add(supplier);
                }
                return suppliers;
            }
            catch (SqlException ex)
            {
                throw ex; // throw the exception for the form to handle
            }
            finally
            {
                connection.Close();
            }
        }

        // public method AddProduct to insert into database
        public static int AddProduct(Product product)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // insert statement
            string insertStatement =
                "INSERT INTO Products " +
                "(ProdName) " +
                "VALUES (@ProdName)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@ProdName", product.ProdName);

            // try to catch exceptions
            try
            {
                // open the connection
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                  "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int productId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return productId;
            }
            // catch exceptions and throw it the form to handle
            catch (SqlException ex)
            {
                throw ex; // throw the exception; let the form handle it cause we are in a data access class
            }
            finally
            {
                connection.Close(); // close the connection
            }
        }

        // public method EditProduct
        public static bool EditProduct(Product oldProduct, Product newProduct)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "ProdName = @NewProdName " +
                "WHERE ProdName = @OldProdName";
            // update command for new and old product
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewProdName", newProduct.ProdName);

            updateCommand.Parameters.AddWithValue(
                "@OldProdName", oldProduct.ProdName);
            // try for exceptions
            try
            {
                // open connection
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            // throw an exception to the form to handle
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); // close the connection string
            }
        }

        // public method to delete product
        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProdName = @ProdName";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@ProdName", product.ProdName);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        // method to get all products
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
                "SELECT ProductId, ProdName " +
                "FROM Products Order By ProdName";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);

            // try to catch exceptions
            try
            {
                // open the connection
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader();
                while (reader.Read()) // there is row(s)
                {
                    // process the row(s)
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProdName = reader["ProdName"].ToString();
                    products.Add(product);
                }
                return products;
            }
            catch (SqlException ex)
            {
                throw ex; // throw the exception for the form to handle
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
