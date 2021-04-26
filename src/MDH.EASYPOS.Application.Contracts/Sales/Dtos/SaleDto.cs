using System;
using Volo.Abp.Application.Dtos;

namespace MDH.EASYPOS.Sales.Dtos
{
    [Serializable]
    public class SaleDto : FullAuditedEntityDto<Guid>
    {
        public decimal Subtotal { get; set; }

    }
}