// OOSD Workshop 2 - Travel Experts
//July 17, 2015
//Written by Hazem Hegazy

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
    public class Customer
    {
        public Customer() { }

        public int CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostal { get; set; }
        public string CustCountry { get; set; }
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }

        // Terry revised class Customer to include CustUserName and CustPassword
        public string CustUserName { get; set; }
        public string CustPassword { get; set; }

        public int AgentId { get; set; }

    }

