/* Author: Terry Mao
 * Purpose: Cause the M.O.H.B told me Workshop Part 2
 * Date: July 6, 2015
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
    // make public class agent db
    public static class AgentDB
    {
        // make public method GetAgentId
        public static Agent GetAgentId(int agentId)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // create select statement to select from the database
            string selectStatement =
                "SELECT AgentId, AgtFirstName, " +
                "AgtMiddleInitial, AgtLastName, " +
                "AgtBusPhone, AgtEmail, " +
                "AgtPosition, AgencyId " +
                "FROM Agents " +
                "WHERE AgentId = @AgentId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@AgentId", agentId);

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
                    Agent agent = new Agent();
                    agent.AgentId = Convert.ToInt32(reader["AgentId"]);
                    agent.AgtFirstName = reader["AgtFirstName"].ToString();
                    agent.AgtMiddleInitial = reader["AgtMiddleInitial"].ToString();
                    agent.AgtLastName = reader["AgtLastName"].ToString();
                    agent.AgtBusPhone = reader["AgtBusPhone"].ToString();
                    agent.AgtEmail = reader["AgtEmail"].ToString();
                    agent.AgtPosition = reader["AgtPosition"].ToString();
                    agent.AgencyId = Convert.ToInt32(reader["AgencyId"]);
                    return agent;
                }
                else // no agent
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

        // public method AddAgent to insert into database
        public static int AddAgent(Agent agent)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            // insert statement
            string insertStatement =
                "INSERT INTO Agents " +
                "(AgtFirstName, AgtMiddleInitial, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition, AgencyId) " +
                "VALUES (@AgtFirstName, @AgtMiddleInitial, @AgtLastName, @AgtBusPhone, @AgtEmail, @AgtPosition, @AgencyId)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@AgtFirstName", agent.AgtFirstName);
            insertCommand.Parameters.AddWithValue(
                "@AgtMiddleInitial", agent.AgtMiddleInitial);
            insertCommand.Parameters.AddWithValue(
                "@AgtLastName", agent.AgtLastName);
            insertCommand.Parameters.AddWithValue(
                "@AgtBusPhone", agent.AgtBusPhone);
            insertCommand.Parameters.AddWithValue(
                "@AgtEmail", agent.AgtEmail);
            insertCommand.Parameters.AddWithValue(
                "@AgtPosition", agent.AgtPosition);
            insertCommand.Parameters.AddWithValue(
                "@AgencyId", agent.AgencyId);

            // try to catch exceptions
            try
            {
                // open the connection
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                  "SELECT IDENT_CURRENT('Agents') FROM Agents";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int agentId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return agentId;
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

        // public method EditAgent
        public static bool EditAgent(Agent oldAgent, Agent newAgent)
        {
            // establish a connection with the database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Agents SET " +
                "AgtFirstName = @NewAgtFirstName, " +
                "AgtMiddleInitial = @NewAgtMiddleInitial, " +
                "AgtLastName = @NewAgtLastName, " +
                "AgtBusPhone = @NewAgtBusPhone, " +
                "AgtEmail = @NewAgtEmail, " +
                "AgtPosition = @NewAgtPosition, " +
                "AgencyId = @NewAgencyId " +
                "WHERE AgtFirstName = @OldAgtFirstName " +
                "AND AgtMiddleInitial = @OldAgtMiddleInitial " +
                "AND AgtLastName = @OldAgtMiddleInitial " +
                "AND AgtBusPhone = @OldAgtBusPhone " +
                "AND AgtEmail = @OldAgtEmail " +
                "AND AgtPosition = @OldAgtPosition " +
                "AND AgencyId = @OldAgencyId";

            // update command for new and old product
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewAgtFirstName", newAgent.AgtFirstName);
            updateCommand.Parameters.AddWithValue(
                "@NewAgtMiddleInitial", newAgent.AgtMiddleInitial);
            updateCommand.Parameters.AddWithValue(
               "@NewAgtLastName", newAgent.AgtLastName);
            updateCommand.Parameters.AddWithValue(
               "@NewAgtBusPhone", newAgent.AgtBusPhone);
            updateCommand.Parameters.AddWithValue(
               "@NewAgtEmail", newAgent.AgtEmail);
            updateCommand.Parameters.AddWithValue(
               "@NewAgtPosition", newAgent.AgtPosition);
            updateCommand.Parameters.AddWithValue(
               "@NewAgencyId", newAgent.AgencyId);

            updateCommand.Parameters.AddWithValue(
                "@OldAgtFirstName", oldAgent.AgtFirstName);
            updateCommand.Parameters.AddWithValue(
                "@OldAgtMiddleInitial", oldAgent.AgtMiddleInitial);
            updateCommand.Parameters.AddWithValue(
               "@OldAgtLastName", oldAgent.AgtLastName);
            updateCommand.Parameters.AddWithValue(
               "@oldAgtBusPhone", oldAgent.AgtBusPhone);
            updateCommand.Parameters.AddWithValue(
               "@oldAgtEmail", oldAgent.AgtEmail);
            updateCommand.Parameters.AddWithValue(
               "@oldAgtPosition", oldAgent.AgtPosition);
            updateCommand.Parameters.AddWithValue(
               "@OldAgencyId", oldAgent.AgencyId);

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

        // public method to delete Agent
        public static bool DeleteAgent(Agent agent)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Agents " +
                "WHERE AgtFirstName = @AgtFirstName " +
                "AND AgtMiddleInitial = @AgtMiddleInitial " +
                "AND AgtLastName = @AgtLastName " +
                "AND AgtBusPhone = @AgtBusPhone " +
                "AND AgtEmail = @AgtEmail " +
                "AND AgtPosition = @AgtPosition " +
                "AND AgencyId = @AgencyId";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@AgtFirstName", agent.AgtFirstName);
            deleteCommand.Parameters.AddWithValue(
                "@AgtMiddleInitial", agent.AgtMiddleInitial);
            deleteCommand.Parameters.AddWithValue(
                "@AgtLastName", agent.AgtLastName);
            deleteCommand.Parameters.AddWithValue(
                "@AgtBusPhone", agent.AgtBusPhone);
            deleteCommand.Parameters.AddWithValue(
                "@AgtEmail", agent.AgtEmail);
            deleteCommand.Parameters.AddWithValue(
                "@AgtPosition", agent.AgtPosition);
            deleteCommand.Parameters.AddWithValue(
                "@AgencyId", agent.AgencyId);

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
