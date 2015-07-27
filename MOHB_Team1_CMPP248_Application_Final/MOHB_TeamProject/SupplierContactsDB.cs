//29th June 2015
//Author: Bade-Adebowale Kehinde
//Purpose: Supplier Contacts Database Class for the Maintenance Of The Supplier Contact's database

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public static class SupplierContactDB
    {
        // Get Supplier Contacts
        public static List<SupplierContact> GetContactofSupplier(int SupplierId)
        {
            List<SupplierContact> supplierContact = new List<SupplierContact>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                // Database Select Statement
               = "SELECT  SupplierId, SupplierContactId, SupConFirstName, SupConLastName, "
               + "SupConCompany, SupConAddress, SupConCity, SupConProv, "
               + "SupConPostal, SupConCountry, SupConBusPhone, SupConFax, "
               + "SupConEmail, SupConURL, AffiliationId "
               + "FROM SupplierContacts "
               + "WHERE SupplierId = @SupplierId ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", SupplierId);

            try
            {
                // Open Connection
                connection.Open();
                SqlDataReader supReader = selectCommand.ExecuteReader();
                while (supReader.Read())
                {
                    SupplierContact s = new SupplierContact();
                    s.SupplierId = (int)supReader["SupplierId"];
                    s.SupplierContactId = (int)supReader["SupplierContactId"];
                    s.SupConFirstName = supReader["SupConFirstName"].ToString();
                    s.SupConLastName = supReader["SupConLastName"].ToString();
                    s.SupConCompany = supReader["SupConCompany"].ToString();
                    s.SupConAddress = supReader["SupConAddress"].ToString();
                    s.SupConCity = supReader["SupConCity"].ToString();
                    s.SupConProv = supReader["SupConProv"].ToString();
                    s.SupConPostal = supReader["SupConPostal"].ToString();
                    s.SupConCountry = supReader["SupConCountry"].ToString();
                    s.SupConBusPhone = supReader["SupConBusPhone"].ToString();
                    s.SupConFax = supReader["SupConFax"].ToString();
                    s.SupConEmail = supReader["SupConEmail"].ToString();
                    s.SupConURL = supReader["SupConURL"].ToString();
                    s.AffiliationId = supReader["AffiliationId"].ToString();
                    supplierContact.Add(s);
                }
                supReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;          
            }
            finally
            {
                connection.Close();
            }
            return supplierContact;                       
        }

        // Two instances for Concurrency Optimization
        public static bool UpdateContactOfSupplier(SupplierContact oldSupplierContact,
            SupplierContact newSupplierContact)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                // Update Statement To Update The Supplier Contacts
                                    "UPDATE SupplierContacts SET "  
                                   + "SupplierId = @newSupplierId, "
                                   + "SupplierContactId = @newSupplierContactId, "
                                   + "SupConFirstName = @newSupConFirstName, "
                                   + "SupConLastName = @newSupConLastName, "
                                   + "SupConCompany = @newSupConCompany, "
                                   + "SupConAddress = @newSupConAddress, "
                                   + "SupConCity = @newSupConCIty, "
                                   + "SupConProv = @newSupConProv, "
                                   + "SupConPostal = @newSupConPostal, "
                                   + "SupConCountry = @newSupContry, "
                                   + "SupConBusPhone = @newSupConBusPhone, "
                                   + "SupConFax = @newSupConFax, "
                                   + "SupConEmail = @newSupConEmail, "
                                   + "SupConURL = @newSupConURL, "
                                   + "AffiliationId = @newAffiliationId "
                                   + "AND SupplierId = @oldSupplierId, "
                                   + "AND SupplierContactId = @oldSupplierContactId, "
                                   + "AND SupConFirstName = @oldSupConFirstName, "
                                   + "AND SupConLastName = @oldSupConLastName, "
                                   + "AND SupConCompany = @oldSupConCompany, "
                                   + "AND SupConAddress = @oldSupConAddress, "
                                   + "AND SupConCity = @oldSupConCIty, "
                                   + "SupConProv = @newSupConProv, "
                                   + "SupConPostal = @newSupConPostal, "
                                   + "SupConCountry = @newSupContry, "
                                   + "SupConBusPhone = @newSupConBusPhone, "
                                   + "SupConFax = @newSupConFax, "
                                   + "SupConEmail = @newSupConEmail, "
                                   + "SupConURL = @newSupConURL, "
                                   + "AffiliationId = @newAffiliationId ";

            // Update Command
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@newSupplierId", newSupplierContact.SupplierId);
            updateCommand.Parameters.AddWithValue("@newSupplierContactId", newSupplierContact.SupplierContactId);
            updateCommand.Parameters.AddWithValue("@newSupConFirstName", newSupplierContact.SupConFirstName);
            updateCommand.Parameters.AddWithValue("@newSupConLastName", newSupplierContact.SupConLastName);
            updateCommand.Parameters.AddWithValue("@newConCompany", newSupplierContact.SupConCompany);
            updateCommand.Parameters.AddWithValue("@newSupConAddress", newSupplierContact.SupConAddress);
            updateCommand.Parameters.AddWithValue("@newSupConCity", newSupplierContact.SupConCity);
            updateCommand.Parameters.AddWithValue("@newConProv", newSupplierContact.SupConProv);
            updateCommand.Parameters.AddWithValue("@newSupConPostal", newSupplierContact.SupConPostal);
            updateCommand.Parameters.AddWithValue("@newSupConContry", newSupplierContact.SupConCountry);
            updateCommand.Parameters.AddWithValue("@newSupConBusPhone", newSupplierContact.SupConBusPhone);
            updateCommand.Parameters.AddWithValue("@newSupConFax", newSupplierContact.SupConFax);
            updateCommand.Parameters.AddWithValue("@newSupConURL", newSupplierContact.SupConURL);
            updateCommand.Parameters.AddWithValue("@newAffiliationId", newSupplierContact.AffiliationId);
            updateCommand.Parameters.AddWithValue("@oldSupplierId", oldSupplierContact.SupplierId);
            updateCommand.Parameters.AddWithValue("@oldSupplierContactId", oldSupplierContact.SupplierContactId);
            updateCommand.Parameters.AddWithValue("@oldSupConFirstName", oldSupplierContact.SupConFirstName);
            updateCommand.Parameters.AddWithValue("@oldSupConLastName", oldSupplierContact.SupConLastName);
            updateCommand.Parameters.AddWithValue("@oldConCompany", oldSupplierContact.SupConCompany);
            updateCommand.Parameters.AddWithValue("@oldSupConAddress", oldSupplierContact.SupConAddress);
            updateCommand.Parameters.AddWithValue("@oldSupConCity", oldSupplierContact.SupConCity);
            updateCommand.Parameters.AddWithValue("@oldConProv", oldSupplierContact.SupConProv);
            updateCommand.Parameters.AddWithValue("@oldSupConPostal", oldSupplierContact.SupConPostal);
            updateCommand.Parameters.AddWithValue("@oldSupConContry", oldSupplierContact.SupConCountry);
            updateCommand.Parameters.AddWithValue("@oldSupConBusPhone", oldSupplierContact.SupConBusPhone);
            updateCommand.Parameters.AddWithValue("@oldSupConFax", oldSupplierContact.SupConFax);
            updateCommand.Parameters.AddWithValue("@oldSupConURL", oldSupplierContact.SupConURL);
            updateCommand.Parameters.AddWithValue("@oldAffiliationId", oldSupplierContact.AffiliationId);

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

        public static bool DeleteSupplier(SupplierContact supplier)
        {
            // Deleting the SupplierContact 
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE * FROM SupplierContacts "
                                   + "WHERE SupplierId = @SupplierId "
                                   + "SupplierContactId = @SupplierContactId "
                                   + "SupConFirstName = @SupConFirstName "
                                   + "SupConLastName = @SupConLastName "
                                   + "SupConCompany = @SupConCompany "
                                   + "SupConAddress = @SupConAddress "
                                   + "SupConCity = @SupConCIty "
                                   + "SupConProv = @SupConProv "
                                   + "SupConPostal = @SupConPostal "
                                   + "SupConCountry = @SupConContry "
                                   + "SupConBusPhone = @SupConBusPhone "
                                   + "SupConFax = @SupConFax "
                                   + "SupConEmail = @SupConEmail "
                                   + "SupConURL = @SupConURL "
                                   + "AffiliationId = @AffiliationId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            deleteCommand.Parameters.AddWithValue("@SupplierContactId", supplier.SupplierContactId);
            deleteCommand.Parameters.AddWithValue("@SupConFirstName", supplier.SupConFirstName);
            deleteCommand.Parameters.AddWithValue("@SupConLastName", supplier.SupConLastName);
            deleteCommand.Parameters.AddWithValue("@SupConCompany", supplier.SupConCompany);
            deleteCommand.Parameters.AddWithValue("@SupConAddress", supplier.SupConAddress);
            deleteCommand.Parameters.AddWithValue("@SupConCity", supplier.SupConCity);
            deleteCommand.Parameters.AddWithValue("@SupConProv", supplier.SupConProv);
            deleteCommand.Parameters.AddWithValue("@SupConPostal", supplier.SupConPostal);
            deleteCommand.Parameters.AddWithValue("@SupConCountry", supplier.SupConCountry);
            deleteCommand.Parameters.AddWithValue("@SupConBusPhone", supplier.SupConBusPhone);
            deleteCommand.Parameters.AddWithValue("@SupConFax", supplier.SupConFax);
            deleteCommand.Parameters.AddWithValue("@SupConEmail", supplier.SupConEmail);
            deleteCommand.Parameters.AddWithValue("@SupConURL", supplier.SupConURL);
            deleteCommand.Parameters.AddWithValue("@Affiliation", supplier.AffiliationId);

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
    }
}
