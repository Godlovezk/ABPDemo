using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePhoneBook.Authorization;

namespace MPACorePhoneBook
{
    [DependsOn(
        typeof(MPACorePhoneBookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MPACorePhoneBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MPACorePhoneBookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MPACorePhoneBookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
