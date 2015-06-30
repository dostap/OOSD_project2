// Author: Darya Ostapenko
// Date June 29, 2015
// Usage: Workshop 1. Package class. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2Wkp1
{
    class Package
    {

        //declare private data
        private int packageId;
        private string pkgName;
        private string pkgDesc;
        private DateTime pkgStartDate;
        private DateTime pkgEndDate;
        private decimal pkgPrice;
      

        //provide public properties for data
        
           public int PackageId
                {
                    get {return packageId;}
                    set {packageId = value;}
                }

           public string PkgName
                {
                    get {return pkgName;}
                    set {pkgName = value;}
                }

           public string PkgDesc
                {
                    get {return pkgDesc;}
                    set {pkgDesc = value;}
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

           public decimal PkgPrice
           {
               get { return pkgPrice; }
               set { pkgPrice = value; }
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
               pkgPrice = 0;
           }

        public Package(int id, string name, string desc, DateTime start, DateTime end, decimal price) //default constructor
        {
            packageId = id;
            pkgName = name;
            pkgDesc = desc;
            pkgStartDate = start;
            pkgEndDate = end;
            pkgPrice = price;
        }

        public bool addPackage()
        {
            return true;
        }

        public bool editPackage()
        {
            return true;
        }

        public bool deletePackage()
        {
            return true;
        }

        public bool addProductToPackage()
        {
            return true;
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
                "Package price: " + pkgPrice.ToString("c"); //display as currency
            return s;
        }
        
    }
}
