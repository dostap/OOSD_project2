
// OOSD Workshop 2 - Travel Experts
// July 6, 2015
//Written by Darya Ostapenko
//Purpose: creation of PackageDB class with methods connecting to the database and alidating user inputs

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class PackageDB
    {

        public static Package GetPackage(int packageId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection(); //connect to the database
            string selectStatement =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                "FROM Packages " +
                "WHERE PackageId = @PackageId"; // declare string carrying a query
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //created new SqlCommand object that will execute the select statement we saved in the string
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);
            //add value to the parameters

            try
            {
                connection.Open();

                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                //method returns true as long as there is a row to read
                {
                    //now we process the row
                    Package package = new Package(); // create a new instance of Package class
                    package.PackageId = (int)reader["PackageId"];
                    package.PkgName = reader["PkgName"].ToString();
                    package.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    package.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    package.PkgDesc = reader["PkgDesc"].ToString();
                    package.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    package.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                    return package; //return populated object to the calling emthod
                }
                else // now row = no package
                {
                    return null;
                }
            }
            catch (SqlException ex)//throws exception to the calling method if SqlException occurs
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }//end of GetPackage method



        public static bool EditPackage(Package oldPackage, Package newPackage)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Packages SET " +
                "PkgName = @newPkgName, " +
                "PkgStartDate = @newPkgStartDate, " +
                "PkgEndDate = @newPkgEndDate, " +
                "PkgDesc = @newPkgDesc, " +
                "PkgBasePrice = @newPkgBasePrice, " +
                "PkgAgencyCommission = @newPkgAgencyCommission " +
                //compare to the original package
                "WHERE " +
                "PkgName = @oldPkgName " +
                "AND PkgStartDate = @oldPkgStartDate " +
                "AND PkgEndDate = @oldPkgEndDate " +
                "AND PkgDesc = @oldPkgDesc " +
                "AND PkgBasePrice = @oldPkgBasePrice " +
                "AND PkgAgencyCommission = @oldPkgAgencyCommission";

            //new update query
            //where statemenet will ensure that package will only be modified
            //if it has not been changed by another user in the meantine
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            //add values to all parameters used
            //set newPackage parameters
            updateCommand.Parameters.AddWithValue(
                "@newPkgName", newPackage.PkgName);
            updateCommand.Parameters.AddWithValue(
                "@newPkgStartDate", newPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue(
                "@newPkgEndDate", newPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue(
                "@newPkgDesc", newPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue(
                "@newPkgBasePrice", newPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue(
                "@newPkgAgencyCommission", newPackage.PkgAgencyCommission);
            //set oldPackage parameters
            updateCommand.Parameters.AddWithValue(
                "@oldPkgName", oldPackage.PkgName);
            updateCommand.Parameters.AddWithValue(
                "@oldPkgStartDate", oldPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue(
                "@oldPkgEndDate", oldPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue(
                "@oldPkgDesc", oldPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue(
                "@oldPkgBasePrice", oldPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue(
                "@oldPkgAgencyCommission", oldPackage.PkgAgencyCommission);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();//returns number of rows affected to count
                if (count > 0) //if count is more than zero, means query was successful, return true to calling emthod
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

        public static int AddPackage(Package package)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "INSERT INTO Packages " +
                // "(PackageId, 
           "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            // SqL INSERT query saved in a string
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            //create and add values to parameters of the SqlCommand object (insertCommand)
            insertCommand.Parameters.AddWithValue(
                "@PkgName", package.PkgName);
            insertCommand.Parameters.AddWithValue(
                "@PkgStartDate", package.PkgStartDate);
            insertCommand.Parameters.AddWithValue(
                "@PkgEndDate", package.PkgEndDate);
            insertCommand.Parameters.AddWithValue(
                "@PkgDesc", package.PkgDesc);
            insertCommand.Parameters.AddWithValue(
                "@PkgBasePrice", package.PkgBasePrice);
            insertCommand.Parameters.AddWithValue(
                "@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery(); //Executes a Transact-SQL statement 
                string selectStatement =
                    "SELECT IDENT_CURRENT('Packages') FROM Packages";
                //Returns the last identity value generated for a specified table or view.
                SqlCommand selectCommand =
                   new SqlCommand(selectStatement, connection);
                int packageId = Convert.ToInt32(selectCommand.ExecuteScalar());
                //Executes the query, and returns the first column of the first row in the result set returned by the query. 
                //assigns that to the packageId

                return packageId; //return the new packageId generated for new package
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

        public static bool DeletePackage(Package package)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Packages " +
                "WHERE PackageId = @PackageId " +
                "AND PkgName = @PkgName " +
                "AND PkgStartDate = @PkgStartDate " +
                "AND PkgEndDate = @PkgEndDate " +
                "AND PkgDesc = @PkgDesc " +
                "AND PkgBasePrice = @PkgBasePrice " +
                "AND PkgAgencyCommission = @PkgAgencyCommission";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId", package.PackageId);
            deleteCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery(); //works the same way as modifying
                //gives error when there is a concurrency issue
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
        }//end of delete method

        public static List<string> GetProductsAndSuppliers(int packageId)
        {

            List<string> listOfProdSup = new List<string>();

            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
            "select packages_products_suppliers.packageId, products.prodname, " +
            "suppliers.Supname " +
            "from packages_products_suppliers inner join " +
            "(products inner join " +
                "(products_suppliers inner join suppliers on products_suppliers.supplierid = suppliers.supplierid) " + 
                    "on products.productid = products_suppliers.productid) " + 
                        "on packages_products_suppliers.productsupplierid = products_suppliers.productsupplierid " +
                            "where PackageId = @PackageId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);
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
                    product.ProdName = reader["ProdName"].ToString();
                    
                    Supplier supplier = new Supplier();
                    supplier.SupName = reader["SupName"].ToString();

                    listOfProdSup.Add(product.ProdName + "," + supplier.SupName);

                }
                return listOfProdSup;
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

public static bool AddProduct(int packageId, int productId, int supplierId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                
                //insert statement
                "INSERT INTO Packages_Products_Suppliers " +
                "VALUES (@PackageId, " +
                "( " +
                //subquery finds the corresponding ProductSupplierId
                //given the ProductId and SupplierID
                "select ps.ProductSupplierId " +
				"from Products_Suppliers ps " +
				"where ps.ProductId=@ProductId and ps.SupplierId=@SupplierId) " +
				")";

            // SqL INSERT query saved in a string
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            //create and add values to parameters of the SqlCommand object (insertCommand)
            insertCommand.Parameters.AddWithValue(
                "@PackageId", packageId);
            insertCommand.Parameters.AddWithValue(
                "@ProductId", productId);
            insertCommand.Parameters.AddWithValue(
                "@SupplierId", supplierId);
       
            try
            {
                connection.Open();
                 //Execute the Transact-SQL statement 
                int count = insertCommand.ExecuteNonQuery();//returns number of rows affected to count
                if (count > 0) //if count is more than zero, means query was successful, return true to calling emthod
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

        }//end of AddProduct method
    }
}
