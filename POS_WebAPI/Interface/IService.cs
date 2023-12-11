using POS_WebAPI.Interface.IService;
using POS_WebAPI.Models;
using POS_WebAPI.Models.Response;

namespace POS_WebAPI.Interface
{
    public interface IService<TR, TC, TU> where TR : IResponse where TC : ICreateReq where TU : IUpdateReq
    {
        public Response<List<TR>>? ReadAll();

        public Response<TR?> Read(Key key);

        public Response<string> Create(TC req);

        public Response<string> Update(TU req);

        public Response<string> Delete(Key key);
    }
}