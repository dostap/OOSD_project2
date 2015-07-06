//29th June 2015
//Author: Bade-Adebowale Kehinde
//Purpose: Supplier Class for the Maintenance Of The Supplier's database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public class Supplier: Company
    {
        public Supplier() { }

        public int SupplierId { get; set; }

        public string SupName { get; set; }
           
    }

}
