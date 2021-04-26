using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MDH.EASYPOS.Sales;
using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.Sale.ViewModels;

namespace MDH.EASYPOS.Web.Pages.Sales.Sale
{
    public class EditModalModel : EASYPOSPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditSaleViewModel ViewModel { get; set; }

        private readonly ISaleAppService _service;

        public EditModalModel(ISaleAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SaleDto, EditSaleViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditSaleViewModel, UpdateSaleDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}