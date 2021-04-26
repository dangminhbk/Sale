using System;
using MDH.EASYPOS.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MDH.EASYPOS.Sales
{
    public class SaleRepository : EfCoreRepository<EASYPOSDbContext, Sale, Guid>, ISaleRepository
    {
        public SaleRepository(IDbContextProvider<EASYPOSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}