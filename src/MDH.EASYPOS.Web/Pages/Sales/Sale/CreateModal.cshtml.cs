using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDH.EASYPOS.Sales;
using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.Sale.ViewModels;

namespace MDH.EASYPOS.Web.Pages.Sales.Sale
{
    public class CreateModalModel : EASYPOSPageModel
    {
        [BindProperty]
        public CreateSaleViewModel ViewModel { get; set; }

        private readonly ISaleAppService _service;

        public CreateModalModel(ISaleAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateSaleViewModel, CreateSaleDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}