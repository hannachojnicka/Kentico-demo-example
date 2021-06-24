using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataSynchroModule.Interfaces
{
    public interface IHttpClientService : IService
    {
        bool Send(HttpRequestMessage request);
    }
}
