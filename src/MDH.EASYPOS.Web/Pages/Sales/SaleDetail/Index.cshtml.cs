using System.Threading.Tasks;

namespace MDH.EASYPOS.Web.Pages.Sales.SaleDetail
{
    public class IndexModel : EASYPOSPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
