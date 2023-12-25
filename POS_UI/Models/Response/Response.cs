using POS_UI.Constant;

namespace POS_UI.Models.Response;

public class Response<T>
{
    public StatusResponse Status { get; set; }
    public int Total { get; set; }
    public List<T>? Result { get; set; }
}
