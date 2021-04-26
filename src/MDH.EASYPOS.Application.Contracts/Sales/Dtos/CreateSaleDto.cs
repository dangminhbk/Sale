using System;
using System.ComponentModel;
namespace MDH.EASYPOS.Sales.Dtos
{
    [Serializable]
    public class CreateSaleDto
    {
        public decimal Subtotal { get; set; }

    }
}