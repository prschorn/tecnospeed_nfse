using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;

namespace Tecnospeed.NFSE.Models.Interfaces
{
  public interface INFSE
  {
    Task<HttpResponseMessage> sendData(RequestData data);

    Task<NFSEDto> GetNfse(string lote, string nfse);

    Task<string> PrintNfseUrl(string numNfse);

    Task<byte[]> PrintNfseFile(string NumNfse);
  }
}
