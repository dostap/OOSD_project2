// OOSD Workshop 2 - Travel Experts
//July 20, 2015
//Written by Darya Ostapenko

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Invoice
/// </summary>
public class Invoice
{
		//default constructor
         public Invoice() { }

         //declare publc properties (auto-implement)
         public DateTime BookingDate { get; set; }
         public string bookingNo { get; set; }
         public int PackageId { get; set; }
         public string PkgName { get; set; }
         public decimal PkgBasePrice { get; set; }
         public string FeeName { get; set; }
         public decimal FeeAmt { get; set; }
         public string ProdName { get; set; }
         public decimal BasePrice { get; set; }
         public decimal TotalPrice { get; set; }

}