using System;
using System.Collections.Generic;


namespace AngularSPATest.Models
{
    public enum Title
    {
        Mr, Mrs, Miss
    }

    public class Contact
    {
        public int ID { get; set; }
        public string Version { get; set; }
        public Title? Title { get; set; } // the ? allows the Title property to be null
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<ContactAddress> ContactAddresses { get; set; } // Navigation property. in this case a list of the Contacts Assosciated addresses

    }
}
