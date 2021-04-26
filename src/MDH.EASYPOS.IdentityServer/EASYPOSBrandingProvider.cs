using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MDH.EASYPOS
{
    [Dependency(ReplaceServices = true)]
    public class EASYPOSBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EASYPOS";
    }
}
