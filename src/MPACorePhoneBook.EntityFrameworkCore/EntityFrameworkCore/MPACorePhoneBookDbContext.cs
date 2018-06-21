using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPACorePhoneBook.Authorization.Roles;
using MPACorePhoneBook.Authorization.Users;
using MPACorePhoneBook.MultiTenancy;
using MPACorePhoneBook.PhoneBooks.Person;
using MPACorePhoneBook.PhoneBooks.PhoneNumber;

namespace MPACorePhoneBook.EntityFrameworkCore
{
    public class MPACorePhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, MPACorePhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        
       

        public MPACorePhoneBookDbContext(DbContextOptions<MPACorePhoneBookDbContext> options)
            : base(options)
        {
        }


        public DbSet<Persons> Persons { get; set; }

        public DbSet<PhoneNumbers> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persons>().ToTable("Persons", "PB");

            modelBuilder.Entity<PhoneNumbers>().ToTable("PhoneNumber","PB");

            base.OnModelCreating(modelBuilder);
        }
    }
}
