// OOSD Workshop 2 - Travel Experts
//July 17, 2015
//Written by Hazem Hegazy, Bade-Adebowale Kehinde, Terry Mao

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Security.Cryptography;

    [DataObject(true)] // identify TechnicianDB class data object
    public static class CustomerDB
    {

        [DataObjectMethod(DataObjectMethodType.Select)] // identify GetCustomer as data object method for select
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT * FROM Customers order by CustFirstName, CustLastName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader contReader = selectCommand.ExecuteReader();
                while (contReader.Read())
                {
                    Customer c = new Customer();
                    c.CustomerId = (int)contReader["CustomerId"];
                    c.CustFirstName = contReader["CustFirstName"].ToString();
                    c.CustLastName = contReader["CustLastName"].ToString();
                    c.CustAddress = contReader["CustAddress"].ToString();
                    c.CustCity = contReader["CustCity"].ToString();
                    c.CustProv = contReader["CustProv"].ToString();
                    c.CustPostal = contReader["CustPostal"].ToString();
                    c.CustCountry = contReader["CustCountry"].ToString();
                    c.CustHomePhone = contReader["CustHomePhone"].ToString();
                    c.CustBusPhone = contReader["CustBusPhone"].ToString();
                   
                    c.CustEmail = contReader["CustEmail"].ToString();
                    if (contReader["AgentId"] is DBNull)
                        c.AgentId = 0;
                    else
                        c.AgentId = Convert.ToInt32(contReader["AgentId"]);
                    customers.Add(c);
                }
                contReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }

        [DataObjectMethod(DataObjectMethodType.Select)] // identify GetCustomer as data object method for select
        public static Customer GetCustomer(int CustomerId)
        {
            Customer customer = new Customer();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT * FROM Customers "
                + "Where CustomerId = @CustomerId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

            try
            {
                connection.Open();
                SqlDataReader contReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (contReader.Read())
                {
                    customer.CustomerId = (int)contReader["CustomerId"];
                    customer.CustFirstName = contReader["CustFirstName"].ToString();
                    customer.CustLastName = contReader["CustLastName"].ToString();
                    customer.CustAddress = contReader["CustAddress"].ToString();
                    customer.CustCity = contReader["CustCity"].ToString();
                    customer.CustProv = contReader["CustProv"].ToString();
                    customer.CustPostal = contReader["CustPostal"].ToString();
                    customer.CustCountry = contReader["CustCountry"].ToString();
                    customer.CustHomePhone = contReader["CustHomePhone"].ToString();
                    customer.CustBusPhone = contReader["CustBusPhone"].ToString();
                    customer.CustEmail = contReader["CustEmail"].ToString();
                    customer.CustUserName = contReader["CustUserName"].ToString();
                    if (contReader["AgentId"] is DBNull)
                        customer.AgentId = 0;
                    else
                        customer.AgentId = Convert.ToInt32(contReader["AgentId"]);
                    
                    
                }
                contReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customer;
        }

        // Terry revised customer update method; username will never get updated
        // I believe this is Keny's Method
        [DataObjectMethod(DataObjectMethodType.Update)] // identify UpdateCustomer as data object method for update
        public static bool UpdateCustomer(Customer original_Customer, Customer customer)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                                    "UPDATE Customers SET "
                                    + "CustFirstName = @newCustFirstName, "
                                    + "CustLastName = @newCustLastName, "
                                    + "CustAddress = @newCustAddress, "
                                    + "CustCity = @newCustCity, "
                                    + "CustProv = @newCustProv, "
                                    + "CustPostal = @newCustPostal, "
                                    + "CustCountry = @newCustCountry, "
                                    + "CustHomePhone = @newCustHomePhone, "
                                    + "CustBusPhone = @newCustBusPhone, "
                                    + "CustEmail = @newCustEmail "
                //+ "CustUserName = @newCustUserName "  // never should update username
                                    + "Where CustFirstName = @oldCustFirstName "
                                    + "AND CustLastName = @oldCustLastName "
                                    + "AND CustAddress = @oldCustAddress "
                                    + "AND CustCity = @oldCustCity "
                                    + "AND CustProv = @oldCustProv "
                                    + "AND CustPostal = @oldCustPostal "
                                    + "AND CustCountry = @oldCustCountry "
                                    + "AND CustHomePhone = @oldCustHomePhone "
                                    + "AND CustBusPhone = @oldCustBusPhone "
                                    + "AND CustEmail = @oldCustEmail";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@newCustFirstName", customer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@newCustLastName", customer.CustLastName);
            updateCommand.Parameters.AddWithValue("@newCustAddress", customer.CustAddress);
            updateCommand.Parameters.AddWithValue("@newCustCity", customer.CustCity);
            updateCommand.Parameters.AddWithValue("@newCustProv", customer.CustProv);
            updateCommand.Parameters.AddWithValue("@newCustPostal", customer.CustPostal);
            updateCommand.Parameters.AddWithValue("@newCustCountry", customer.CustCountry);
            updateCommand.Parameters.AddWithValue("@newCustHomePhone", customer.CustHomePhone);
            
            // checks if CustBusPHone and Email == null; if so just allow them to be empty per request
            if (customer.CustBusPhone == null)
                updateCommand.Parameters.AddWithValue("@newCustBusPhone", "");
            else
                updateCommand.Parameters.AddWithValue("@newCustBusPhone", customer.CustBusPhone);
            if (customer.CustEmail == null)
                updateCommand.Parameters.AddWithValue("@newCustEmail", "");
            else
                updateCommand.Parameters.AddWithValue("@newCustEmail", customer.CustEmail);
            
            /*NEVER GETS UPDATED atm*/
            //updateCommand.Parameters.AddWithValue("@newAgentId", customer.AgentId);
            //updateCommand.Parameters.AddWithValue("@newCustUserName", customer.CustUserName);

            updateCommand.Parameters.AddWithValue("@oldCustFirstName", original_Customer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@oldCustLastName", original_Customer.CustLastName);
            updateCommand.Parameters.AddWithValue("@oldCustAddress", original_Customer.CustAddress);
            updateCommand.Parameters.AddWithValue("@oldCustCity", original_Customer.CustCity);
            updateCommand.Parameters.AddWithValue("@oldCustProv", original_Customer.CustProv);
            updateCommand.Parameters.AddWithValue("@oldCustPostal", original_Customer.CustPostal);
            updateCommand.Parameters.AddWithValue("@oldCustCountry", original_Customer.CustCountry);
            updateCommand.Parameters.AddWithValue("@oldCustHomePhone", original_Customer.CustHomePhone);

            // checks if CustBusPHone and Email == null; if so just allow them to be empty per request
            if (original_Customer.CustBusPhone == null)
                updateCommand.Parameters.AddWithValue("@oldCustBusPhone", "");
            else
                updateCommand.Parameters.AddWithValue("@oldCustBusPhone", original_Customer.CustBusPhone);
            if (original_Customer.CustEmail == null)
                updateCommand.Parameters.AddWithValue("@oldCustEmail", "");
            else
                updateCommand.Parameters.AddWithValue("@oldCustEmail", original_Customer.CustEmail);


            /*NEVER GETS UPDATED atm*/
            //updateCommand.Parameters.AddWithValue("@oldAgentId", original_Customer.AgentId);
            //updateCommand.Parameters.AddWithValue("@oldCustUserName", original_Customer.CustUserName);


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

        public static bool deleteCustomer(Customer customer)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();

            string  deleteStatement = "DELETE * FROM Customers "
                                    //+ "CustomerId = @CustomerId, " // Commented out because i am not sure if we want to delete the customer id
                                    + "CustFirstName = @CustFirstName, "
                                    + "CustLastName = @CustLastName, "
                                    + "CustAddress = @CustAddresss, "
                                    + "CustCity = @CustCity, "
                                    + "CustProv = @CustProv, "
                                    + "CustPostal = @CustPostal, "
                                    + "CustCountry = @CustCountry, "
                                    + "CustHomePhone = @CustHomePhone, "
                                    + "CustBusPhone = @CustBusPhone, "
                                    + "CustEmail = @CustEmail, "
                                    + "AgentId = @AgentId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            //deleteCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);  //Commented out becaue i am not sure if we want to delete the customer id
            deleteCommand.Parameters.AddWithValue("@CustFirstName", customer.CustFirstName);
            deleteCommand.Parameters.AddWithValue("@CustLastName", customer.CustLastName);
            deleteCommand.Parameters.AddWithValue("@CustAddress", customer.CustAddress);
            deleteCommand.Parameters.AddWithValue("@CustCity", customer.CustCity);
            deleteCommand.Parameters.AddWithValue("@CustProv", customer.CustProv);
            deleteCommand.Parameters.AddWithValue("@CustPostal", customer.CustPostal);
            deleteCommand.Parameters.AddWithValue("@CustCountry", customer.CustCountry);
            deleteCommand.Parameters.AddWithValue("@CustHomePhone", customer.CustHomePhone);
            deleteCommand.Parameters.AddWithValue("@CustBusPhone", customer.CustBusPhone);
            deleteCommand.Parameters.AddWithValue("@CustEmail", customer.CustEmail);
            deleteCommand.Parameters.AddWithValue("AgentId", customer.AgentId);

            try
            {
                connection.Open();
                int count;
                count = deleteCommand.ExecuteNonQuery();
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

        // Terry revised CustomerDB to include method Insert/Add Customer for client registration
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int AddCustomer(Customer customer)
        {
            // establish a connection to the DB
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //insert statement
            string insertStatement =
                  "INSERT INTO Customers "
                + "(CustFirstName, CustLastName, CustAddress, "
                + "CustCity, CustProv, CustPostal, "
                + "CustCountry, CustHomePhone, CustBusPhone, "
                + "CustEmail, CustUserName, CustPassword) "
                + "VALUES (@CustFirstName, @CustLastName, @CustAddress, "
                + "@CustCity, @CustProv, @CustPostal, @CustCountry, @CustHomePhone, "
                + "@CustBusPhone, @CustEmail, @CustUserName, @CustPassword)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@CustFirstName", customer.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", customer.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustAddress", customer.CustAddress);
            insertCommand.Parameters.AddWithValue("@CustCity", customer.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", customer.CustProv);
            insertCommand.Parameters.AddWithValue("@CustPostal", customer.CustPostal);
            insertCommand.Parameters.AddWithValue("@CustCountry", customer.CustCountry);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", customer.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", customer.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", customer.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustUserName", customer.CustUserName);
            insertCommand.Parameters.AddWithValue("@CustPassword", GenerateCustPassword(customer.CustPassword));
            if (CheckCustUserName(customer.CustUserName))
            {
                return 0;
            }
            // try to catch exceptions
            try
            {
       
                // open the connection
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                  "SELECT IDENT_CURRENT('Customers') FROM Customers";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int CustomerId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return CustomerId;
      
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


        public static string GenerateCustPassword(string pw)
        {
            string hashedPW;

            hashedPW = FormsAuthentication.HashPasswordForStoringInConfigFile(pw, "MD5");
            return hashedPW;
        
        }

        public static bool CheckCustUserName(string username)
        {
          
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT * FROM Customers "
                + "Where CustUserName = @CustUserName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustUserName", username);

            try
            {
                connection.Open();
                SqlDataReader contReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (contReader.Read())
                    return true;
                else
                    return false;

                contReader.Close();
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

        public static int AuthenticateUser(string username, string password)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT CustomerId FROM Customers "
                + "Where CustUserName = @CustUserName "
                + "AND CustPassword = @CustPassword";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustUserName", username);
            selectCommand.Parameters.AddWithValue("@CustPassword", GenerateCustPassword(password));

            try
            {
                connection.Open();


                int CustomerId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return CustomerId;

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
