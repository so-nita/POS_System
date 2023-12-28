using POS_UI.Models.Responses;
using POS_UI.Models.SubCategory;

namespace POS_UI.Service;

public class SubCategoryService : BaseService
{
    public async Task<List<SubCategoryResponse>> GetAllAsync()
    {
        var url = "http://sonitab-001-site1.atempurl.com/api/category";
        var data = await GetAsync<Response<SubCategoryResponse>>(url);
        return data?.Result ?? new List<SubCategoryResponse>();
    }


}
