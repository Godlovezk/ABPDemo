using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePhoneBook.Configuration;

namespace MPACorePhoneBook.Web.Host.Startup
{
    [DependsOn(
       typeof(MPACorePhoneBookWebCoreModule))]
    public class MPACorePhoneBookWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPACorePhoneBookWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPACorePhoneBookWebHostModule).GetAssembly());
        }
    }
}
