using System;
using MDH.EASYPOS.Permissions;
using MDH.EASYPOS.Sales.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MDH.EASYPOS.Sales
{
    public class SaleAppService : CrudAppService<Sale, SaleDto, Guid, PagedAndSortedResultRequestDto, CreateSaleDto, UpdateSaleDto>,
        ISaleAppService
    {
        protected override string GetPolicyName { get; set; } = EASYPOSPermissions.Sale.Default;
        protected override string GetListPolicyName { get; set; } = EASYPOSPermissions.Sale.Default;
        protected override string CreatePolicyName { get; set; } = EASYPOSPermissions.Sale.Create;
        protected override string UpdatePolicyName { get; set; } = EASYPOSPermissions.Sale.Update;
        protected override string DeletePolicyName { get; set; } = EASYPOSPermissions.Sale.Delete;

        private readonly ISaleRepository _repository;
        
        public SaleAppService(ISaleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
