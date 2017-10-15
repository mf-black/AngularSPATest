using System;
using System.Collections.Generic;


namespace AngularSPATest.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Version { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }

        public ICollection<ContactAddress> ContactAddress { get; set; }
    }
}
