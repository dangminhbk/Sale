using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MDH.EASYPOS.Sales
{
    public static class SaleDetailEfCoreQueryableExtensions
    {
        public static IQueryable<SaleDetail> IncludeDetails(this IQueryable<SaleDetail> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}