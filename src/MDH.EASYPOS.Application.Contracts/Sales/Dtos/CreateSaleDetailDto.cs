using System;
using System.ComponentModel;
namespace MDH.EASYPOS.Sales.Dtos
{
    [Serializable]
    public class CreateSaleDetailDto
    {
        public Guid SaleId { get; set; }

        public decimal Total { get; set; }

        public int Count { get; set; }

        public decimal UnitPrice { get; set; }
    }
}