using MDH.EASYPOS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MDH.EASYPOS.Web.Pages
{
    public abstract class EASYPOSPageModel : AbpPageModel
    {
        protected EASYPOSPageModel()
        {
            LocalizationResourceType = typeof(EASYPOSResource);
        }
    }
}