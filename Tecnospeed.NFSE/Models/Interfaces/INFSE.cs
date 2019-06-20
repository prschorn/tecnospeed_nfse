using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tecnospeed.NFSE.Models.Interfaces
{
  public interface INFSE
  {
    Task<HttpResponseMessage> sendData(RequestData data);
  }
}
