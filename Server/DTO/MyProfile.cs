using AutoMapper;
using DAL.models;
using DTO.repository;

namespace DTO
{
    public class MyProfile : Profile
    {
        public MyProfile() { 

            // category table
            CreateMap<CategoryDTO, CategoryTbl>();
            CreateMap<CategoryTbl, CategoryDTO>();

            // cp table
            CreateMap<CategoryProductDTO, CategoryProductTbl>();
            CreateMap<CategoryProductTbl, CategoryProductDTO>()
                .ForMember(k => k.CatName, j => j.MapFrom(h => h.CpCat.CatName))
                .ForMember(k => k.GenProdName, j => j.MapFrom(h => h.CpGenProd.GenProdName));

            // City table
            CreateMap<CityDTO, CityTbl>();
            CreateMap<CityTbl, CityDTO>();


            // color table
            CreateMap<ColorDTO, ColorTbl>();
            CreateMap<ColorTbl, ColorDTO>();

            //generalProduct
            CreateMap<GeneralProductDTO, GeneralProductTbl>();
            CreateMap<GeneralProductTbl, GeneralProductDTO>();
    
            // orders table
            CreateMap<OrdersDTO, OrdersTbl>();
            CreateMap<OrdersTbl, OrdersDTO>();
            
            // picture table
            CreateMap<PictureDTO, PictureTbl>();
            CreateMap<PictureTbl, PictureDTO>()
                //.ForMember(c => c.ColorName, j => j.MapFrom(h => h.PicColor.ColorName))
                .ForMember(p => p.ProdGeneralId, j => j.MapFrom(h => h.PicProd.ProdGeneralId))
                .ForMember(p => p.ProdName, j => j.MapFrom(h => h.PicProd.ProdName))
                .ForMember(p => p.ProdDesc, j => j.MapFrom(h => h.PicProd.ProdDesc))
                .ForMember(p => p.ProdPrice, j => j.MapFrom(h => h.PicProd.ProdPrice))
                .ForMember(p => p.ProdQty, j => j.MapFrom(h => h.PicProd.ProdQty))
                .ForMember(p => p.ProdInStack, j => j.MapFrom(h => h.PicProd.ProdInStack))
                .ForMember(p => p.ProdStatus, j => j.MapFrom(h => h.PicProd.ProdStatus))
                .ForMember(p => p.ProdInSale, j => j.MapFrom(h => h.PicProd.ProdInSale))
                .ForMember(p => p.ProdPic, j => j.MapFrom(h => h.PicProd.ProdPic))
                .ForMember(p => p.ProdSalePrice, j => j.MapFrom(h => h.PicProd.ProdSalePrice));

            // Product table
            CreateMap<ProductDTO, ProductTbl>();
            CreateMap<ProductTbl, ProductDTO>();


            // po table
            CreateMap<ProductOrderDTO, ProductOrderTbl>();
            CreateMap<ProductOrderTbl, ProductOrderDTO>()
                //order
                .ForMember(po => po.OrdUserId, j => j.MapFrom(h => h.PoOrd.OrdUserId))
                .ForMember(po => po.OrdDate, j => j.MapFrom(h => h.PoOrd.OrdDate))
                .ForMember(po => po.OrdStatus, j => j.MapFrom(h => h.PoOrd.OrdStatus))
                .ForMember(po => po.OrdDateSend, j => j.MapFrom(h => h.PoOrd.OrdDateSend))
                .ForMember(po => po.OrdTotalPayment, j => j.MapFrom(h => h.PoOrd.OrdTotalPayment))

                //product
                .ForMember(po => po.ProdGeneralId, j => j.MapFrom(h => h.PoProd.ProdGeneralId))
                .ForMember(po => po.ProdColorId, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdName, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdDesc, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdPrice, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdQty, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdInStack, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdStatus, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdPic, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdInSale, j => j.MapFrom(h => h.PoProd.ProdColorId))
                .ForMember(po => po.ProdSalePrice, j => j.MapFrom(h => h.PoProd.ProdColorId))
                //city
                .ForMember(po => po.CityName, j => j.MapFrom(h => h.PoCity.CityName))
                .ForMember(po => po.CityShippPrice, j => j.MapFrom(h => h.PoCity.CityShippPrice))
                //user
                .ForMember(po => po.UserName, j => j.MapFrom(h => h.PoUser.UserName))
                .ForMember(po => po.UserPhone, j => j.MapFrom(h => h.PoUser.UserPhone))
                .ForMember(po => po.UserEmail, j => j.MapFrom(h => h.PoUser.UserEmail))
                .ForMember(po => po.UserPass, j => j.MapFrom(h => h.PoUser.UserPass))
                .ForMember(po => po.UserCityId, j => j.MapFrom(h => h.PoUser.UserCityId))
                .ForMember(po => po.UserPhone, j => j.MapFrom(h => h.PoUser.UserPhone));




            // User table
            CreateMap<UserDTO, UserTbl>();
            CreateMap<UserTbl, UserDTO>()
                .ForMember(u => u.CityName, j => j.MapFrom(h => h.UserCity.CityName))
                .ForMember(u => u.CityShippPrice, j => j.MapFrom(h => h.UserCity.CityShippPrice));

        }
    }
}