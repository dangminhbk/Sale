using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MDH.EASYPOS.Data
{
    /* This is used if database provider does't define
     * IEASYPOSDbSchemaMigrator implementation.
     */
    public class NullEASYPOSDbSchemaMigrator : IEASYPOSDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}