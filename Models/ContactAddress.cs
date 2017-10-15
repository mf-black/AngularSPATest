using System;
using System.Collections.Generic;


namespace AngularSPATest.Models
{
    public class ContactAddress
    {
        public int ID { get; set; }
        public int ContactID { get; set; } // Foreign Key  to corresponding Contact
        public int AddressID { get; set; } // Foreign Key  to corresponding Address. Entity Framework interprets  this from the naming conventions used
        public string AddressType { get; set; }

        public Contact Contact { get; set; } 
        public Address Address { get; set; }
    }
}
