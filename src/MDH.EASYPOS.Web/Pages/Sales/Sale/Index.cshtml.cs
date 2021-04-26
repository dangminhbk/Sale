using System.Threading.Tasks;

namespace MDH.EASYPOS.Web.Pages.Sales.Sale
{
    public class IndexModel : EASYPOSPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
