using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePhoneBook.Configuration;
using MPACorePhoneBook.EntityFrameworkCore;
using MPACorePhoneBook.Migrator.DependencyInjection;

namespace MPACorePhoneBook.Migrator
{
    [DependsOn(typeof(MPACorePhoneBookEntityFrameworkModule))]
    public class MPACorePhoneBookMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MPACorePhoneBookMigratorModule(MPACorePhoneBookEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MPACorePhoneBookMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MPACorePhoneBookConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPACorePhoneBookMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
