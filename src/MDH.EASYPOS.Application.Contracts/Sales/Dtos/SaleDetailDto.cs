using System;
using Volo.Abp.Application.Dtos;

namespace MDH.EASYPOS.Sales.Dtos
{
    [Serializable]
    public class SaleDetailDto : FullAuditedEntityDto<Guid>
    {
        public Guid SaleId { get; set; }

        public decimal Total { get; set; }

        public int Count { get; set; }

        public decimal UnitPrice { get; set; }
    }
}