using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MDH.EASYPOS.Blazor.Server.Tiered
{
    [Dependency(ReplaceServices = true)]
    public class EASYPOSBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EASYPOS";
    }
}
