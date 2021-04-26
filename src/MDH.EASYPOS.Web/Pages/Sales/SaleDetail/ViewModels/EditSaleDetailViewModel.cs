using System;

using System.ComponentModel.DataAnnotations;

namespace MDH.EASYPOS.Web.Pages.Sales.SaleDetail.ViewModels
{
    public class EditSaleDetailViewModel
    {
        [Display(Name = "SaleDetailSaleId")]
        public Guid SaleId { get; set; }

        [Display(Name = "SaleDetailTotal")]
        public decimal Total { get; set; }

        [Display(Name = "SaleDetailCount")]
        public int Count { get; set; }

        [Display(Name = "SaleDetailUnitPrice")]
        public decimal UnitPrice { get; set; }
    }
}