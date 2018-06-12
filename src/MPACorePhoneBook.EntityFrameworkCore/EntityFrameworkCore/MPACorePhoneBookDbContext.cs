using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPACorePhoneBook.Authorization.Roles;
using MPACorePhoneBook.Authorization.Users;
using MPACorePhoneBook.MultiTenancy;

namespace MPACorePhoneBook.EntityFrameworkCore
{
    public class MPACorePhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, MPACorePhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MPACorePhoneBookDbContext(DbContextOptions<MPACorePhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
