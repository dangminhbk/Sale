using System;
using MDH.EASYPOS.Permissions;
using MDH.EASYPOS.Sales.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MDH.EASYPOS.Sales
{
    public class SaleDetailAppService : CrudAppService<SaleDetail, SaleDetailDto, Guid, PagedAndSortedResultRequestDto, CreateSaleDetailDto, UpdateSaleDetailDto>,
        ISaleDetailAppService
    {
        protected override string GetPolicyName { get; set; } = EASYPOSPermissions.SaleDetail.Default;
        protected override string GetListPolicyName { get; set; } = EASYPOSPermissions.SaleDetail.Default;
        protected override string CreatePolicyName { get; set; } = EASYPOSPermissions.SaleDetail.Create;
        protected override string UpdatePolicyName { get; set; } = EASYPOSPermissions.SaleDetail.Update;
        protected override string DeletePolicyName { get; set; } = EASYPOSPermissions.SaleDetail.Delete;

        private readonly ISaleDetailRepository _repository;
        
        public SaleDetailAppService(ISaleDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
