using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace MDH.EASYPOS.Sales
{
    public class SaleDetail : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        [ForeignKey(nameof(Sale))]
        public Guid SaleId { get; set; }
        public decimal Total { get; set; }
        public Guid? TenantId { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }

        protected SaleDetail()
        {
        }

        public SaleDetail(
            Guid id,
            Guid saleId,
            decimal total,
            Guid? tenantId,
            int count,
            decimal unitPrice
        ) : base(id)
        {
            SaleId = saleId;
            Total = total;
            TenantId = tenantId;
            Count = count;
            UnitPrice = unitPrice;
        }
    }
}
