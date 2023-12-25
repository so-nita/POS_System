using POS_UI.Models.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_UI.Models;

public class Response<T>
{
    public StatusResponse Status { get; set; }
    public int Total { get; set; }
    public List<T>? Result { get; set; }
}
