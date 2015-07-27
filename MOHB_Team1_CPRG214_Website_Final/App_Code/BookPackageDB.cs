// OOSD Workshop 2 - Travel Experts
// July 16, 2015
//Written by Darya Ostapenko, Hazem Hegazy
//Purpose: creation of BookPackageDB class with methods connecting to the database and validating user inputs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Data access class for Customers table
/// </summary>
/// 

[DataObject(true)]
    public static class BookPackageDB
    {

        //this method retrieves all the packages purchased by the customer
        //from the database
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Booking_Package> GetPackagesByCustomerId(int customerId)
        {
            //declare a new list to hold all the Booking Packages
            List<Booking_Package> bookPackages = new List<Booking_Package>();
            SqlConnection connection = TravelExpertsDB.GetConnection(); //connect to the database
            string selectStatement =
            "SELECT b.BookingDate, c.CustFirstName, c.CustLastName, " +
            "p.PackageId, PkgName, PkgStartDate, " +
            "PkgEndDate, PkgDesc, PkgBasePrice, BookingDate, " +
            "BookingNo, TravelerCount  " +
            "FROM Packages p inner join Bookings b on p.PackageId=b.PackageId " +
            "inner join Customers c on b.CustomerId = c.CustomerId " +
            "WHERE c.CustomerId = @CustomerId " +
            "order by B.BookingDate desc";
            // declare string carrying a query
            //this select joins the packages table with Bookings and Customers

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //created new SqlCommand object that will execute the select statement we saved in the string
            selectCommand.Parameters.AddWithValue("@CustomerId", customerId);
            //add value to the parameters

            try
            {
                connection.Open();

                SqlDataReader reader =
                     selectCommand.ExecuteReader();

                while (reader.Read())
                //method returns true as long as there is a row to read
                {
                    //create a new instance of Booking Package
                    Booking_Package bookPackage = new Booking_Package();
                    //write all the object's properties
                    bookPackage.BookingDate = (DateTime)reader["BookingDate"];
                    bookPackage.CustLastName = reader["CustLastName"].ToString();
                    bookPackage.CustFirstName = reader["CustFirstName"].ToString();
                    bookPackage.PackageId = (int)reader["PackageId"];
                    bookPackage.PkgName = reader["PkgName"].ToString();
                    bookPackage.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    bookPackage.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    bookPackage.PkgDesc = reader["PkgDesc"].ToString();
                    bookPackage.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    bookPackage.BookingNo = reader["BookingNo"].ToString();
                    bookPackage.TravelerCount = Convert.ToDouble(reader["TravelerCount"]);
                    //add object to the list
                    bookPackages.Add(bookPackage);
                }
                return bookPackages; //return populated list to the calling method
            }
            catch (SqlException ex)//throws exception to the calling method if SqlException occurs
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }//end of GetPackageByCustomerId method

    // Hazem revised and added new method BookPackageToCustomer()
    [DataObjectMethod(DataObjectMethodType.Insert)]
    public static string BookPackageToCustomer(int customerId, int pkgId, int travellerCount)
    {
        string bookNo = DateTime.Now.ToString("ddMMyy") + customerId + pkgId;
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string insertStatement =
            "INSERT INTO Bookings " +
       "(BookingDate, BookingNo, TravelerCount, CustomerId, TripTypeId, PackageId) " +
            "VALUES(GetDate(), @bookNo, @TravellerCount, @CustomerId, @TripType, @PkgId)";
        // SqL INSERT query saved in a string
        SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
        //create and add values to parameters of the SqlCommand object (insertCommand)
        insertCommand.Parameters.AddWithValue(
            "@bookNo", bookNo);
        insertCommand.Parameters.AddWithValue(
            "@TravellerCount", travellerCount);
        insertCommand.Parameters.AddWithValue(
            "@CustomerId", customerId);
        insertCommand.Parameters.AddWithValue(
            "@PkgId", pkgId);
        if (travellerCount > 1)
            insertCommand.Parameters.AddWithValue(
                "@TripType", "G");
        else
            insertCommand.Parameters.AddWithValue(
                "@TripType", "L");


        try
        {
            connection.Open();
            int count = insertCommand.ExecuteNonQuery(); //Executes a Transact-SQL statement 
            if (count > 0)
                return bookNo;
            else
                return null;

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

    //this method calculates the total amount due for packages
    [DataObjectMethod(DataObjectMethodType.Select)] // identify GetInvoice as data object method for select
    public static decimal GetTotalAmountDueForPackages(int CustomerId)
    {
        //declare a new variable to hold the final total amount due
        decimal TotalAmountDue = 0m;

        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement
         = "SELECT SUM(PkgBasePrice) as TotalPrice "
            + "FROM Packages p inner join Bookings b on p.PackageId=b.PackageId "
            + "inner join Customers c on b.CustomerId = c.CustomerId "
            + "WHERE c.CustomerId = @CustomerId";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            //if there is a row to read, assign the TotalPrice value to the TotalAmountDue
           
            if (reader.Read())
            {
                if (reader["TotalPrice"] != System.DBNull.Value)
                {
                    TotalAmountDue = Convert.ToDecimal(reader["TotalPrice"]);
                }
                else
                {
                    TotalAmountDue = 0;
                }

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
        return TotalAmountDue; //return the final amount
    }

    }

