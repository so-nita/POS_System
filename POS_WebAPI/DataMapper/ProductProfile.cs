using AutoMapper;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Product;

namespace POS_WebAPI.DataMapper
{
    public class ProductProfile : Profile 
    {
        public ProductProfile()
        {
            CreateMap<ProductUpdateReq, Product>()
                .ForMember(dest => dest.Code, opt => opt.Condition(src => src.Code != null))
                .ForMember(dest => dest.Name, op => op.Condition(src => src.Name != null))
                .ForMember(dest => dest.Code, opt => opt.Condition(src => src.Code != null))
                .ForMember(dest => dest.NameKh, opt => opt.Condition(src => src.NameKh != null))
                .ForMember(dest => dest.Company, opt => opt.Condition(src => src.Company != null))
                .ForMember(dest => dest.SubCategory, opt => opt.Condition(src => src.SubCategory != null))
                .ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image != null))
                .ForMember(dest => dest.Cost, opt => opt.Condition(src => src.Cost != null))
                .ForMember(dest => dest.Price, opt => opt.Condition(src => src.Price != null))
                .ForMember(dest => dest.Description, opt => opt.Condition(src => src.Description != null))
                .ForMember(dest => dest.Status, opt => opt.Condition(src => src.Status != null))
                ;
        }
    }
}
