using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MDH.EASYPOS.Sales
{
    public static class SaleEfCoreQueryableExtensions
    {
        public static IQueryable<Sale> IncludeDetails(this IQueryable<Sale> queryable, bool include = true)
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