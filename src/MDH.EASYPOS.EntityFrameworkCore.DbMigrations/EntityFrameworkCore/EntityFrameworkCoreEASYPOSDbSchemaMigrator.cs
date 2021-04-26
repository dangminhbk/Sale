using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MDH.EASYPOS.Data;
using Volo.Abp.DependencyInjection;

namespace MDH.EASYPOS.EntityFrameworkCore
{
    public class EntityFrameworkCoreEASYPOSDbSchemaMigrator
        : IEASYPOSDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEASYPOSDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EASYPOSMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EASYPOSMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}