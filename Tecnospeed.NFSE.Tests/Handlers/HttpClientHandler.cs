using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tecnospeed.NFSE.Tests.Handlers
{
  public class HttpClientHandler : HttpMessageHandler
  {
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      Task<HttpResponseMessage> result = new Task<HttpResponseMessage>(() => { return new HttpResponseMessage(); });
      return result;
    }
  }
}
