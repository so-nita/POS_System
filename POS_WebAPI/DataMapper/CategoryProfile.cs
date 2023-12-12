using AutoMapper;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Category;
using POS_WebAPI.Models.RequestModel.Product;

namespace POS_WebAPI.DataMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryUpdateReq, Category>()
                .ForMember(dest => dest.Name, op => op.Condition(src => src.Name != null))
                .ForMember(dest => dest.Image, opt => opt.Condition(src => src.Image != null))
                .ForMember(dest => dest.Description, opt => opt.Condition(src => src.Description != null))
                .ForMember(dest => dest.Status, opt => opt.Condition(src => src.Status != null))
                ;
        }
    }
}
