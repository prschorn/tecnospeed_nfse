using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;
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

    public async Task<NFSEDto> GetNfse(string lote, string nfse)
    {
      NFSEDto dtoResponse;
      using (var httpclient = new HttpClient())
      {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{TecnospeedData.host}/{Constants.ConsultarNotaEndpoint}?grupo={TecnospeedData.grupo}&CNPJ={TecnospeedData.cnpj}&nlote={lote}&nnfse={nfse}");
        request.Headers.Add("Authorization", this.authentication.ValidateUser());
        var response = await httpclient.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();
        if(response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          dtoResponse = new NFSEDto
          {
            //TODO - CONVERT DATA
          };
        }
        else
        {
          throw new Exception($"Erro ao consultar nota: {body}");
        }
      }


      return dtoResponse;
    }

    public async Task<byte[]> PrintNfseFile(string NumNfse)
    {
      using (var httpClient = new HttpClient())
      {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{TecnospeedData.host}/{Constants.ImprimirNotaEndpoint}?Grupo={TecnospeedData.grupo}&CNPJ={TecnospeedData.cnpj}&NomeCidade={TecnospeedData.nomeCidade}&NumNFSe={numNfse}&url=1");
        request.Headers.Add("Authorization", this.authentication.ValidateUser());
        var response = await httpClient.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          return System.Text.Encoding.UTF8.GetBytes(body);
        }
        throw new Exception("Nota não encontrada");
      }
    }

    public async Task<string> PrintNfseUrl(string numNfse)
    {
      using (var httpClient = new HttpClient())
      {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{TecnospeedData.host}/{Constants.ImprimirNotaEndpoint}?Grupo={TecnospeedData.grupo}&CNPJ={TecnospeedData.cnpj}&NomeCidade={TecnospeedData.nomeCidade}&NumNFSe={numNfse}&url=1");
        request.Headers.Add("Authorization", this.authentication.ValidateUser());
        var response = await httpClient.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          return body;
        }
        throw new Exception("Nota não encontrada");
      }
    }

    public async Task<HttpResponseMessage> sendData(RequestData data)
    {
      using (var client = new HttpClient())
      {
        var request = new HttpRequestMessage(HttpMethod.Post, $"{TecnospeedData.host}/{Constants.EnviarNotaEndpoint}");

        //add body data to request
        var keyValues = new List<KeyValuePair<string, string>>
        {
          //tx2 content
          new KeyValuePair<string, string>("Arquivo", TX2Handler.GenerateTx2FromData(data)),

          //CNPJ
          new KeyValuePair<string, string>("CNPJ",TecnospeedData.cnpj),

          //GRUPO
          new KeyValuePair<string, string>("Grupo",TecnospeedData.grupo),

          //NOME CIDADE
          new KeyValuePair<string, string>("NomeCidade",TecnospeedData.nomeCidade)
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
