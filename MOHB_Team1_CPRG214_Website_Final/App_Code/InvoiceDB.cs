// OOSD Workshop 2 - Travel Experts
//July 20, 2015
//Written by Darya Ostapenko

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InvoiceDB
/// </summary>
/// 

[DataObject(true)]
public static class InvoiceDB
{

    [DataObjectMethod(DataObjectMethodType.Select)] // identify GetCustomer as data object method for select
    public static List<Invoice> GetInvoiceForProducts(int CustomerId)
    {
        List<Invoice> invoices = new List<Invoice>();

        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement
         = "SELECT b.BookingDate, b.bookingNo, f.FeeName, "
           + " f.FeeAmt, pr.ProdName, bd.BasePrice "
           + " FROM Customers c inner join Bookings b on c.CustomerId =  b.CustomerId "
                                                    + "inner join BookingDetails bd on b.BookingId = bd.BookingId "
                                                    + "inner join Fees f on bd.FeeId = f.FeeId "
                                                    + "inner join Products_Suppliers ps on bd.ProductSupplierId=ps.ProductSupplierId "
                                                    + "inner join Products pr on ps.ProductId=pr.ProductId "
         + " WHERE c.CustomerId = @CustomerId "
         + " order by  b.BookingDate desc ";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        try
        {
            connection.Open();
            SqlDataReader reader =
               selectCommand.ExecuteReader(); // retrieve multiple rows
            while (reader.Read())
            //method returns true as long as there is a row to read
            {
                //create a new instance of an invoice
                Invoice invoice = new Invoice();
                //write all the object's properties
                invoice.BookingDate = (DateTime)reader["BookingDate"];
                invoice.bookingNo = reader["bookingNo"].ToString();
                invoice.FeeName = reader["FeeName"].ToString();
                invoice.FeeAmt = (decimal)reader["FeeAmt"];
                invoice.ProdName = reader["ProdName"].ToString();
                invoice.BasePrice = (decimal)reader["BasePrice"];

                //add object to the list
                invoices.Add(invoice);
            }
            return invoices; //return populated list to the calling method
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


    [DataObjectMethod(DataObjectMethodType.Select)] // identify GetInvoice as data object method for select
    public static decimal GetTotalAmountDueForProducts(int CustomerId)
    {
        //declare a new variable to hold the final total amount due
        decimal TotalAmountDue=0;

        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement
         = "SELECT sum(bd.BasePrice) as TotalPrice "
            +"FROM Customers c inner join Bookings b on c.CustomerId =  b.CustomerId "
													+"inner join BookingDetails bd on b.BookingId = bd.BookingId "
													+"inner join Fees f on bd.FeeId = f.FeeId "
													+"inner join Products_Suppliers ps on bd.ProductSupplierId=ps.ProductSupplierId "
													+"inner join Products pr on ps.ProductId=pr.ProductId "
           + "WHERE c.CustomerId = @CustomerId "
            + "group by GROUPING SETS((c.CustomerId))";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
            //if htere is a row to read, assign the TotalPrice value to the TotalAmountDue
            if (reader.Read())
            {
                TotalAmountDue = (decimal)reader["TotalPrice"];
            }
            reader.Close();
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