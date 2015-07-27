// OOSD Workshop 2 - Travel Experts
//July 17, 2015
//Written by Darya Ostapenko

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Booking_Package
/// This contains all info we would want to show the customer
/// </summary>
/// 

	public class Booking_Package
	{
		 //default constructor
         public Booking_Package() { }

        //declare publc properties (auto-implement)
        public DateTime BookingDate { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public string PkgDesc { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public decimal PkgBasePrice { get; set; }
        public string BookingNo { get; set; }
        public double TravelerCount { get; set; }

	}
