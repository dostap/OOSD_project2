//29th June 2015
//Author: Bade-Adebowale Kehinde
//Purpose: Supplier Contacts Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    public class SupplierContact
    {
        public SupplierContact() { }

        // Variable Names As They Appear On The DB

        public int SupplierId { get; set; }

        public int SupplierContactId { get; set; }

        public string SupConFirstName { get; set; }

        public string SupConLastName { get; set; }

        public string SupConCompany { get; set; }

        public string SupConAddress { get; set; }

        public string SupConCity { get; set; }

        public string SupConProv { get; set; }

        public string SupConPostal { get; set; }

        public string SupConCountry { get; set; }

        public string SupConEmail { get; set; }

        public string SupConBusPhone { get; set; }

        public string SupConFax { get; set; }

        public string SupConURL { get; set; }

        public string AffiliationId { get; set; }

    }
}
