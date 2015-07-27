// Group        MOHB
// Author:      Bade-Adebowale Kehinde
// Description: Agent's DB Class
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AgentsDB
/// </summary>

[DataObject(true)]
public class AgentsDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
	public static List<Agent> GetAgentsinAgency_1()
	{
        SqlConnection connection = TravelExpertsDB.GetConnection();
        List<Agent> Agent_List = new List<Agent>();
        string selectStatement =
                                "SELECT * FROM Agents "
                               + "WHERE AgencyId = 1 "
                               + "ORDER BY AgentId";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

        try
        {
            connection.Open();
            SqlDataReader agentReader =
                selectCommand.ExecuteReader();
            while (agentReader.Read())
            {
                Agent agent = new Agent();
                agent.AgentId = (int)agentReader["AgentId"];
                agent.AgtFirstName = agentReader["AgtFirstName"].ToString();
                agent.AgtMiddleInitial = agentReader["AgtMiddleInitial"].ToString();
                agent.AgtBusPhone = agentReader["AgtBusPhone"].ToString();
                agent.AgtEmail = agentReader["AgtEmail"].ToString();
                agent.AgtPosition = agentReader["AgtPosition"].ToString();
                agent.AgencyId = (int)agentReader["AgencyId"];
                Agent_List.Add(agent);

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
        return Agent_List;
	}


    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<Agent> GetAgentsinAgency_2()
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        List<Agent> Agent_List = new List<Agent>();
        string selectStatement =
                                "SELECT * FROM Agents "
                               + "WHERE AgencyId = 2 "
                               + "ORDER BY AgentId";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

        try
        {
            connection.Open();
            SqlDataReader agentReader =
                selectCommand.ExecuteReader();
            while (agentReader.Read())
            {
                Agent agent = new Agent();
                agent.AgentId = (int)agentReader["AgentId"];
                agent.AgtFirstName = agentReader["AgtFirstName"].ToString();
                agent.AgtMiddleInitial = agentReader["AgtMiddleInitial"].ToString();
                agent.AgtBusPhone = agentReader["AgtBusPhone"].ToString();
                agent.AgtEmail = agentReader["AgtEmail"].ToString();
                agent.AgtPosition = agentReader["AgtPosition"].ToString();
                agent.AgencyId = (int)agentReader["AgencyId"];
                Agent_List.Add(agent);

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
        return Agent_List;
    }


}