using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPACorePhoneBook.EntityFrameworkCore
{
    public static class MPACorePhoneBookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MPACorePhoneBookDbContext> builder, string connectionString)
        {
            // builder.UseSqlServer(connectionString,b=>b.UseRowNumberForPaging());
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MPACorePhoneBookDbContext> builder, DbConnection connection)
        {
           // builder.UseSqlServer(connection,b=>b.UseRowNumberForPaging());
            builder.UseSqlServer(connection);
        }
    }
}
