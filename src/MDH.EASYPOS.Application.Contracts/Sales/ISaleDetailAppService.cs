using System;
using MDH.EASYPOS.Sales.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MDH.EASYPOS.Sales
{
    public interface ISaleDetailAppService :
        ICrudAppService< 
            SaleDetailDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateSaleDetailDto,
            UpdateSaleDetailDto>
    {

    }
}