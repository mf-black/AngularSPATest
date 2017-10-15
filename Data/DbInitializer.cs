using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularSPATest.Models;

namespace AngularSPATest.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContactContext context)
        {
            context.Database.EnsureCreated();

            //Look for contacts.
            if (context.Contacts.Any())
            {
                return; //DB has been seeded
            }

            var contacts = new Contact[]
            {
                new Contact{ Version="1", Title=Title.Mr, FirstName="John", LastName="Smith", Email="jsmith@email.com" },
                new Contact{ Version="1", Title=Title.Mrs, FirstName="Jane", LastName="Doe", Email="jdoe@email.com" },
                //new Contact{ Version="1", Title=Title.Miss, FirstName="Laura", LastName="Fredric", Email="lfred@email.com" },
                //new Contact{ Version="1", Title=Title.Mr, FirstName="Derek", LastName="Jefferson", Email="dj@email.com" },
                //new Contact{ Version="1", Title=Title.Mr, FirstName="Lyle", LastName="Taylor", Email="ltaylor@email.com" },
                //new Contact{ Version="1", Title=Title.Mr, FirstName="Murray", LastName="Black", Email="mblack@email.com" },
                //new Contact{ Version="1", Title=Title.Mr, FirstName="Stewart", LastName="Jones", Email="sjones@email.com" },
                //new Contact{ Version="1", Title=Title.Mrs, FirstName="Margaret", LastName="Lang", Email="mlang@email.com" },
                //new Contact{ Version="1", Title=Title.Miss, FirstName="Sophie", LastName="Lennon", Email="slennon@email.com" },
                //new Contact{ Version="1", Title=Title.Miss, FirstName="Lisa", LastName="Pollock", Email="lpollock@email.com" },
            };
            foreach (Contact c in contacts)
            {
                context.Contacts.Add(c);
            }
            context.SaveChanges();

            var addresses = new Address[]
            {
                new Address{ Version="1", Line1="1", Line2="Haymarket street", Line3="", City="Edinburgh", County="", PostCode="eh12 345"},
                new Address{ Version="1", Line1="2", Line2="Dalry Road", Line3="", City="", County="Edinburgh", PostCode="eh56 475"},
                new Address{ Version="1", Line1="3", Line2="Byres road", Line3="", City="", County="Glasgow", PostCode="g12 xkc"},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
                //new Address{ Version="1", Line1="", Line2="", Line3="", City="", County="", PostCode=""},
            };
            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();

            var contactAddresses = new ContactAddress[]
            {
                new ContactAddress{ ContactID=1, AddressID=1, AddressType="Home" },
                new ContactAddress{ ContactID=1, AddressID=2, AddressType="Work" },
                new ContactAddress{ ContactID=2, AddressID=3, AddressType="home"}
            };
            foreach (ContactAddress ca in contactAddresses)
            {
                context.ContactAddresses.Add(ca);
            }
            context.SaveChanges();
        }
    }
}
