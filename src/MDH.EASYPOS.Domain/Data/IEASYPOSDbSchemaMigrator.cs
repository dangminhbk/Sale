using System.Threading.Tasks;

namespace MDH.EASYPOS.Data
{
    public interface IEASYPOSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
