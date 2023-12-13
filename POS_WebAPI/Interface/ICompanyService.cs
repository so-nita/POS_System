using POS_WebAPI.Models.RequestModel.Company;

namespace POS_WebAPI.Interface;
public interface ICompanyService : IService<CompanyResponse,CompanyCreateReq,CompanyUpdateReq>
{

}
