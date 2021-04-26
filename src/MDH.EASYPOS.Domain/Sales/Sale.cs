using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace MDH.EASYPOS.Sales
{
    public class Sale : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public decimal Subtotal { get; set; }
        public Guid? TenantId { get; set; }

        protected Sale()
        {
        }

        public Sale(
            Guid id,
            decimal subtotal,
            Guid? tenantId
        ) : base(id)
        {
            Subtotal = subtotal;
            TenantId = tenantId;
        }
    }
}
