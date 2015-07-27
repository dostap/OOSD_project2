// OOSD Workshop 2 - Travel Experts
//July 17, 2015
//Written by Darya Ostapenko

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Database connection
/// </summary>

    public class TravelExpertsDB
    {

        public static SqlConnection GetConnection()
        {
            string connectionString = 
                "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TravelExperts.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }

