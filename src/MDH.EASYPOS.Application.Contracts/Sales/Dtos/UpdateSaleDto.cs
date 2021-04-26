using System;
using System.ComponentModel;

namespace MDH.EASYPOS.Sales.Dtos
{
    [Serializable]
    public class UpdateSaleDto
    {
        public decimal Subtotal { get; set; }

    }
}