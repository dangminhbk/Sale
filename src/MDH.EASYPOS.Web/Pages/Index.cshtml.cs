using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MDH.EASYPOS.Web.Pages
{
    public class IndexModel : EASYPOSPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}