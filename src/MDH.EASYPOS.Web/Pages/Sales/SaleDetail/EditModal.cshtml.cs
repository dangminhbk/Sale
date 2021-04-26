using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDH.EASYPOS.Sales;
using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.SaleDetail.ViewModels;

namespace MDH.EASYPOS.Web.Pages.Sales.SaleDetail
{
    public class EditModalModel : EASYPOSPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditSaleDetailViewModel ViewModel { get; set; }

        private readonly ISaleDetailAppService _service;

        public EditModalModel(ISaleDetailAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SaleDetailDto, EditSaleDetailViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditSaleDetailViewModel, UpdateSaleDetailDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}