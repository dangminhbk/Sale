using MDH.EASYPOS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MDH.EASYPOS
{
    [DependsOn(
        typeof(EASYPOSEntityFrameworkCoreTestModule)
        )]
    public class EASYPOSDomainTestModule : AbpModule
    {

    }
}