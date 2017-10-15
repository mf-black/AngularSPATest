using AngularSPATest.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularSPATest.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<ContactAddress>().ToTable("ContactAddresses");// Stop EF from pluralising ContactAddress
            //modelBuilder.Entity<Address>().ToTable("Address");
        }
    }
}
