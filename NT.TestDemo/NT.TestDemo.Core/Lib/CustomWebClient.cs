using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Lib
{
    public class CustomWebClient :WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request= base.GetWebRequest(address);
            request.Timeout = request.Timeout*3;
            return request;
        }
    }
}
