using Volo.Abp.Modularity;

namespace MDH.EASYPOS
{
    [DependsOn(
        typeof(EASYPOSApplicationModule),
        typeof(EASYPOSDomainTestModule)
        )]
    public class EASYPOSApplicationTestModule : AbpModule
    {

    }
}