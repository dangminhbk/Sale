using System;
using Volo.Abp.Domain.Repositories;

namespace MDH.EASYPOS.Sales
{
    public interface ISaleDetailRepository : IRepository<SaleDetail, Guid>
    {
    }
}