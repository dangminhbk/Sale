using System;
using System.Threading.Tasks;
using MDH.EASYPOS.Sales.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MDH.EASYPOS.Sales
{
    public interface ISaleAppService :
        ICrudAppService< 
            SaleDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateSaleDto,
            UpdateSaleDto>
    {
    }
}