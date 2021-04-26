using System;
using MDH.EASYPOS.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MDH.EASYPOS.Sales
{
    public class SaleDetailRepository : EfCoreRepository<EASYPOSDbContext, SaleDetail, Guid>, ISaleDetailRepository
    {
        public SaleDetailRepository(IDbContextProvider<EASYPOSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}