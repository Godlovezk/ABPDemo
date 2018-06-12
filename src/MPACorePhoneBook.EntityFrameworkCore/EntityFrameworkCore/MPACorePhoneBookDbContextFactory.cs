using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MPACorePhoneBook.Configuration;
using MPACorePhoneBook.Web;

namespace MPACorePhoneBook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MPACorePhoneBookDbContextFactory : IDesignTimeDbContextFactory<MPACorePhoneBookDbContext>
    {
        public MPACorePhoneBookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MPACorePhoneBookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MPACorePhoneBookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MPACorePhoneBookConsts.ConnectionStringName));

            return new MPACorePhoneBookDbContext(builder.Options);
        }
    }
}
