using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MDH.EASYPOS.EntityFrameworkCore
{
    [DependsOn(
        typeof(EASYPOSEntityFrameworkCoreModule)
        )]
    public class EASYPOSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<EASYPOSMigrationsDbContext>();
        }
    }
}
