/* 
 * This is a Company class which is a parent for the Supplier and Agency(later) sub classes
 * Author: Hazem Hegazy
 * Date: Jul-2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public abstract class Company
    {
           
        // declare the variables as protected so as to be accessible to the child classes
        protected int id;
        protected string name;
       
        // class constructor
        public Company() { }

        public Company(int cid, string cname)
        {
            id = cid;
            name = cname;
        }

    }
}
