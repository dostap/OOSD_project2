// OOSD Workshop 2 - Travel Experts
// July 6, 2015
//Written by Darya Ostapenko
//Purpose: creation of Package class with properties and ToString method


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{

  public class Package
    {
        //default constructor
         public Package() { }


        //declare publc properties (auto-implement)
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public string PkgDesc { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
      
    }

/*
    public class Package
    {

        //declare private data
        private int packageId;
        private string pkgName;
        private string pkgDesc;
        private DateTime pkgStartDate;
        private DateTime pkgEndDate;
        private decimal pkgBasePrice;
        private decimal pkgAgencyCommission;


        //provide public properties for data

        public int PackageId
        {
            get { return packageId; }
            set { packageId = value; }
        }

        public string PkgName
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public string PkgDesc
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public DateTime PkgStartDate
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public DateTime PkgEndDate
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public decimal PkgBasePrice
        {
            get { return pkgBasePrice; }
            set { pkgBasePrice = value; }
        }

        public decimal PkgAgencyCommission
        {
            get { return pkgAgencyCommission; }
            set { pkgAgencyCommission = value; }
        }

        //constructors
        public Package() //default constructor
        {
            //declare variables
            DateTime today;
            today = DateTime.Now;
            packageId = 0;
            pkgName = "";
            pkgDesc = "";
            pkgStartDate = today;
            pkgEndDate = today;
            pkgBasePrice = 0;
            pkgAgencyCommission = 0;
        }

        public Package(int id, string name, string desc, DateTime start, DateTime end,
                        decimal price, decimal commission) //default constructor
        {
            packageId = id;
            pkgName = name;
            pkgDesc = desc;
            pkgStartDate = start;
            pkgEndDate = end;
            pkgBasePrice = price;
            pkgAgencyCommission = commission;
        }


        public override string ToString()
        // overrides method from the Object class
        //returns string displaying package information
        {
            string s = "PackageId: " + packageId.ToString() + "\n" +
                "Package name:: " + pkgName + "\n" +
                "Package description: " + pkgDesc + "\n" +
                "Package start date: " + pkgStartDate.ToString("d MMM yyyy") + "\n" +
                "Package end date: " + pkgEndDate.ToString("d MMM yyyy") + "\n" +
                "Package price: " + pkgBasePrice.ToString("c") + "]n" + //display as currency
                "Package agency commission: " + pkgAgencyCommission.ToString("c");
            return s;
        }

    } */
}
