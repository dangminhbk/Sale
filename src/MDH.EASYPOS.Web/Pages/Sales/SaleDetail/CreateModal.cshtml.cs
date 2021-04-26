using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDH.EASYPOS.Sales;
using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.SaleDetail.ViewModels;

namespace MDH.EASYPOS.Web.Pages.Sales.SaleDetail
{
    public class CreateModalModel : EASYPOSPageModel
    {
        [BindProperty]
        public CreateSaleDetailViewModel ViewModel { get; set; }

        private readonly ISaleDetailAppService _service;

        public CreateModalModel(ISaleDetailAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateSaleDetailViewModel, CreateSaleDetailDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}