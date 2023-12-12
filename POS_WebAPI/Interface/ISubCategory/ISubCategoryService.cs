using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.SubCategory;

namespace POS_WebAPI.Interface.ISubCategory
{
    public interface ISubCategoryService : IService<SubCategoryResponse, SubCategoryCreateReq, SubCategoryUpdateReq>
    {
    }
}
