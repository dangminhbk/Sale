using System;

using System.ComponentModel.DataAnnotations;

namespace MDH.EASYPOS.Web.Pages.Sales.Sale.ViewModels
{
    public class EditSaleViewModel
    {
        [Display(Name = "SaleSubtotal")]
        public decimal Subtotal { get; set; }

    }
}