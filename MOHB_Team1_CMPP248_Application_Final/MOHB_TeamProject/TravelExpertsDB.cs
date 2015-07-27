using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            // create a connection object by using a connection string for TravelExperts database
//            string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TravelExperts.mdf;Integrated Security=True";
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
