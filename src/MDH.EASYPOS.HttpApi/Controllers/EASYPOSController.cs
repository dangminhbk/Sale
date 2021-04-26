using MDH.EASYPOS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MDH.EASYPOS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EASYPOSController : AbpController
    {
        protected EASYPOSController()
        {
            LocalizationResource = typeof(EASYPOSResource);
        }
    }
}