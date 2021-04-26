using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.Sale.ViewModels;
using MDH.EASYPOS.Sales.Dtos;
using MDH.EASYPOS.Web.Pages.Sales.SaleDetail.ViewModels;
using AutoMapper;

namespace MDH.EASYPOS.Web
{
    public class EASYPOSWebAutoMapperProfile : Profile
    {
        public EASYPOSWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<SaleDto, EditSaleViewModel>();
            CreateMap<CreateSaleViewModel, CreateSaleDto>();
            CreateMap<EditSaleViewModel, UpdateSaleDto>();
            CreateMap<SaleDetailDto, EditSaleDetailViewModel>();
            CreateMap<CreateSaleDetailViewModel, CreateSaleDetailDto>();
            CreateMap<EditSaleDetailViewModel, UpdateSaleDetailDto>();
        }
    }
}
