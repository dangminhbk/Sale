using MDH.EASYPOS.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MDH.EASYPOS.Blazor.Server
{
    public abstract class EASYPOSComponentBase : AbpComponentBase
    {
        protected EASYPOSComponentBase()
        {
            LocalizationResource = typeof(EASYPOSResource);
        }
    }
}
