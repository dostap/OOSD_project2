//29th June 2015
//Author: Bade-Adebowale Kehinde
//Purpose: Supplier DB Class for the Maintenance Of The Supplier's database

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public class SupplierDB // The Supplier Database Class
    {
        // Method to get Supplier
        public static Supplier GetSupplier(int supplierId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT SupplierId, SupName "
                + "FROM Suppliers "
                + "WHERE SupplierId = @SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", supplierId);

            try
            {
                // Open Connection
                connection.Open();
                SqlDataReader supReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (supReader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = (int)supReader["SupplierId"];
                    supplier.SupName = supReader["SupName"].ToString();
                    return supplier;
                }
                else
                {
                    return null;
                }

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

        // Method to get Supplier by name
        public static Supplier GetSupplierByName(string supName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "Select Top 1 SupplierId, SupName From Suppliers Where SupName Like @SupName Order By SupName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            supName = supName + "%"; // select where the supplier name starts with a string
            selectCommand.Parameters.AddWithValue("@SupName", supName);

            try
            {
                // Open Connection
                connection.Open();
                SqlDataReader supReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (supReader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = (int)supReader["SupplierId"];
                    supplier.SupName = supReader["SupName"].ToString();
                    return supplier;
                }
                else
                {
                    return null;
                }

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

        // make method to get all the suppliers of a specific product 
        public static List<Product> GetProductsOfSupplier(int supId)
        {
            List<Product> products = new List<Product>();
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
                "SELECT * " +
                "FROM Products " +
                "WHERE ProductId in (Select ProductId from Products_Suppliers where SupplierId = @SupplierId)";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", supId);

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

        public static int AddSupplier(Supplier supplier)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT Into Suppliers " +
                                     "(SupplierId, SupName) " +
                                     "VALUES (@SupId, @SupName)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

            try
            {
                // open the connection
                connection.Open();
                string selectStatement =
                  "SELECT max(SupplierId) FROM Suppliers"; // this is to select the last id so as to use the next one
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int supplierId = Convert.ToInt32(selectCommand.ExecuteScalar()) + 1;
                insertCommand.Parameters.AddWithValue("@SupId", supplierId);
                insertCommand.ExecuteNonQuery();
                return supplierId;
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

        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Suppliers SET " +
                                     "SupplierId = @NewSupplierId, " +
                                     "SupName = @NewSupName " +
                                     "WHERE SupplierId = @OldSupplierId " +
                                     "AND SupName = @OldSupName";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewSupplierId", newSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupplierId", oldSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@OldSupName", oldSupplier.SupName);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
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

        public static bool DeleteSupplier(Supplier supplier)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM SupplierContacts " +
                                     "WHERE SupplierId = @SupplierId ";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            string deleteStatement2 = "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " +
                                     "AND SupName = @SupName";
            SqlCommand deleteCommand2 = new SqlCommand(deleteStatement2, connection);
            deleteCommand2.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            deleteCommand2.Parameters.AddWithValue("@SupName", supplier.SupName);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                count = deleteCommand2.ExecuteNonQuery();
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

        // method to get all suppliers
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
                "SELECT SupplierId, SupName " +
                "FROM Suppliers Order By SupName";
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

        // method to add a relation between a product and a supplier
        public static bool AddProductToSupplier(int supId, int prodId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT Into Products_Suppliers " +
                                     "(SupplierId, ProductId) " +
                                     "VALUES (@SupId, @ProId)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@SupId", supId);
            insertCommand.Parameters.AddWithValue("@ProId", prodId);

            try
            {
                // open the connection
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
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

        public static bool RemoveProductFromSupplier(int supId, int prodId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //delete statement
            string deleteStatement =
                "DELETE Packages_Products_Suppliers FROM Packages_Products_Suppliers Left JOIN Products_Suppliers " +
                "ON Packages_Products_Suppliers.ProductSupplierId = Products_Suppliers.ProductSupplierId " +
                "WHERE Products_Suppliers.SupplierId = @SupId and Products_Suppliers.ProductId = @ProId";
            string deleteStatement2 =
                "DELETE FROM Products_Suppliers " +
                "WHERE SupplierId = @SupId and ProductId = @ProId";

            // SqL DELETE query saved in a string
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            SqlCommand deleteCommand2 = new SqlCommand(deleteStatement2, connection);

            //create and add values to parameters of the SqlCommand object (insertCommand)
            deleteCommand.Parameters.AddWithValue(
                "@SupId", supId);
            deleteCommand.Parameters.AddWithValue(
                "@ProId", prodId);
            deleteCommand2.Parameters.AddWithValue(
                "@SupId", supId);
            deleteCommand2.Parameters.AddWithValue(
                "@ProId", prodId);


            try
            {
                connection.Open();
                //Execute the Transact-SQL statement 
                int count = deleteCommand.ExecuteNonQuery();//returns number of rows affected to count
                count = deleteCommand2.ExecuteNonQuery();//returns number of rows affected to count
                if (count > 0) //if count is more than zero, means query was successful, return true to calling method
                    return true;
                else // if now rows were affected, return false to calling method
                    //this will go back to frmAddModifyPackage and display an error message that
                    //another user has modified row in the meantime
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

    }
}
