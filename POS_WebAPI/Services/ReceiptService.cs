using Microsoft.EntityFrameworkCore;
using POS_WebAPI.Interface;
using POS_WebAPI.Models;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Receipt;
using POS_WebAPI.Models.Response;
using System.Net;

namespace POS_WebAPI.Services
{
    public class ReceiptService : IReceitpService
    {
        private readonly IRepository<Receipt> _repo;

        public ReceiptService(IRepository<Receipt> repo)
        {
            _repo = repo;
        }

        public Response<string> Create(ReceiptCreateReq req)
        {
            try
            {
                return Response<string>.Success();
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        private List<ReceiptResponse> GetAll()
        {
            try
            {
                var data = _repo.GetQueryable().Include(e=>e.Order).Include(e=>e.User)
                .Select(e=>new ReceiptResponse()
                {
                    Id = e.Id,
                    Company_Id = e.User.Company_Id,
                    Discount = e.Order.Total_Discount,
                    Tax = e.Order.Tax,
                    Order_Id = e.Order_Id,
                    Reference_Id = e.User.Id,
                    Reference_Name = e.User.Name,
                    Sub_Total = e.Order.Sub_Total,
                    Grand_Total = e.Order.Grand_Total,
                    Order_Date = e.Order.Order_Date,
                    Transaction_Date = e.Order.Order_Date
                }).OrderBy(e=>e.Order_Date).ToList();
                return data;
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        public Response<ReceiptResponse?> Read(Key key)
        {
            try
            {
                var data = GetAll().FirstOrDefault(e=> e.Id==key.Id);

                return Response<ReceiptResponse?>.Success(data);

            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<List<ReceiptResponse>>? ReadAll()
        {
            try
            {
                var data = GetAll();    

                return Response<List<ReceiptResponse>>.Success(data,data.Count());   

            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        public Response<string> Update(ReceiptUpdateReq req)
        {
            try
            {
                return Response<string>.Success();
            }catch (Exception ex)
            {
                throw ex.InnerException!;
            }
        }
        public Response<string> Delete(Key key)
        {
            try
            {
                return Response<string>.Success();
            }catch(Exception ex)
            {
                throw ex.InnerException!;
            }
        }

        
    }
}
