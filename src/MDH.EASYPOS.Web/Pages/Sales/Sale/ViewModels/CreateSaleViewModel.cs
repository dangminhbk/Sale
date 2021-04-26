using System;

using System.ComponentModel.DataAnnotations;

namespace MDH.EASYPOS.Web.Pages.Sales.Sale.ViewModels
{
    public class CreateSaleViewModel
    {
        [Display(Name = "SaleSubtotal")]
        public decimal Subtotal { get; set; }

    }
}