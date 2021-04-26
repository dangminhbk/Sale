using MDH.EASYPOS.Sales;
using MDH.EASYPOS.Sales.Dtos;
using AutoMapper;

namespace MDH.EASYPOS
{
    public class EASYPOSApplicationAutoMapperProfile : Profile
    {
        public EASYPOSApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Sale, SaleDto>();
            CreateMap<CreateSaleDto, Sale>(MemberList.Source);
            CreateMap<UpdateSaleDto, Sale>(MemberList.Source);
            CreateMap<SaleDetail, SaleDetailDto>();
            CreateMap<CreateSaleDetailDto, SaleDetail>(MemberList.Source);
            CreateMap<UpdateSaleDetailDto, SaleDetail>(MemberList.Source);
        }
    }
}
