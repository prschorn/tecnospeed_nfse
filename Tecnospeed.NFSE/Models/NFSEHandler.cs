using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tecnospeed.NFSE.Models.Interfaces;

namespace Tecnospeed.NFSE.Models
{
  public class NFSEHandler : INFSE
  {
    private readonly IAuthentication authentication;
    public NFSEHandler(IAuthentication auth)
    {
      this.authentication = auth;
    }
    public async Task<HttpResponseMessage> sendData(RequestData data)
    {
      using (var client = new HttpClient())
      {
        var request = new HttpRequestMessage(HttpMethod.Post, TecnospeedData.host);

        //add body data to request
        var keyValues = new List<KeyValuePair<string, string>>
        {
          //tx2 content
          new KeyValuePair<string, string>("arquivo", TX2Handler.GenerateTx2FromData(data)),

          //CNPJ
          new KeyValuePair<string, string>("CNPJ",TecnospeedData.cnpj),

          //GRUPO
          new KeyValuePair<string, string>("Grupo",TecnospeedData.grupo)
        };
        //add data to the request body
        request.Content = new FormUrlEncodedContent(keyValues);
        //add authorization header
        request.Headers.Add("Authorization", this.authentication.ValidateUser());
        //send data
        var response = await client.SendAsync(request);

        return response;
      }
      
    }
  }
}
