using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using Tecnospeed.NFSE.Models.Interfaces;

namespace Tecnospeed.NFSE.Models
{

  public class Authentication : IAuthentication
  {
    public string ValidateUser()
    {
      if (TecnospeedData.user == null || TecnospeedData.user.Length == 0
          || TecnospeedData.password == null || TecnospeedData.password.Length == 0)
      {
        throw new Exception("Usuário e senha de administradores não encontrado. Fale com a equipe responsável pelo sistema.");
      }

      //encode to base64
      var encodedData = this.EncodeUserDataTo64(TecnospeedData.user, TecnospeedData.password);

      //return authorization header
      return $"Basic {encodedData}";
    }


    private string EncodeUserDataTo64(string user, string password)
    {
      var toEncodeBytes = System.Text.Encoding.ASCII.GetBytes($"{user}:{password}");

      var returnValue = Convert.ToBase64String(toEncodeBytes);

      return returnValue;
    }
  }
}
