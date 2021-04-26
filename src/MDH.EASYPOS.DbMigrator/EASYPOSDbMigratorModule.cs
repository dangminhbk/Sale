using MDH.EASYPOS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MDH.EASYPOS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EASYPOSEntityFrameworkCoreDbMigrationsModule),
        typeof(EASYPOSApplicationContractsModule)
        )]
    public class EASYPOSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
