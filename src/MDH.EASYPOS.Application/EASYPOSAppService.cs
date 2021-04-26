using System;
using System.Collections.Generic;
using System.Text;
using MDH.EASYPOS.Localization;
using Volo.Abp.Application.Services;

namespace MDH.EASYPOS
{
    /* Inherit your application services from this class.
     */
    public abstract class EASYPOSAppService : ApplicationService
    {
        protected EASYPOSAppService()
        {
            LocalizationResource = typeof(EASYPOSResource);
        }
    }
}
