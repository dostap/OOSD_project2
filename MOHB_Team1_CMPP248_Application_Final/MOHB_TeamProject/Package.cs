// OOSD Workshop 2 - Travel Experts
// July 6, 2015
//Written by Darya Ostapenko
//Purpose: creation of Package class with properties and ToString method


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
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
        public double PkgBasePrice { get; set; }
        public double PkgAgencyCommission { get; set; }
      
    }
    
}
