using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePhoneBook.Configuration;

namespace MPACorePhoneBook.Web.Startup
{
    [DependsOn(typeof(MPACorePhoneBookWebCoreModule))]
    public class MPACorePhoneBookWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPACorePhoneBookWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MPACorePhoneBookNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPACorePhoneBookWebMvcModule).GetAssembly());
        }
    }
}
