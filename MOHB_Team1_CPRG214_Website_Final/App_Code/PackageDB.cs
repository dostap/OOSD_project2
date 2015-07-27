// OOSD Workshop 2 - Travel Experts
// July 6, 2015
//Written by Darya Ostapenko
//Purpose: creation of PackageDB class with methods connecting to the database and validating user inputs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[DataObject(true)]
    public static class PackageDB
    {

    //get package info based on packageId
    [DataObjectMethod(DataObjectMethodType.Select)]
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

  
    
    }

