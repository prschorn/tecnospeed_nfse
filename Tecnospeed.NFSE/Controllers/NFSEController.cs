using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Tecnospeed.Database.Repositories.Interfaces;
using Tecnospeed.NFSE.Models;
using Tecnospeed.NFSE.Models.Interfaces;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]
namespace Tecnospeed.NFSE.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NFSEController : ControllerBase
  {
    private readonly INFSE nfseHandler;
    private readonly INfseRepository nfseRepository;
    public NFSEController(INFSE nfse, INfseRepository repository)
    {
      this.nfseHandler = nfse;
      this.nfseRepository = repository;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Post([FromBody]RequestData data)
    {
      if (data == null)
        return this.BadRequest("Dados inválidos para geração de nota fiscal.");

      //send data to tecnospeed api
      var response = await this.nfseHandler.sendData(data);

      //read response body to get the data the server sent back
      var responseBody = await response.Content.ReadAsStringAsync();

      //get nota on tecnospeed endpoint and save information
      //handle responsebody
      if (response.StatusCode != System.Net.HttpStatusCode.OK)
      {
        return this.StatusCode(400, responseBody);
      }

      var responseBodyArray = responseBody.Split(',');

      //TODO - CHECAR CAMPOS
      var lote = responseBodyArray[0];
      var numero = responseBodyArray[1];
      try
      {
        var nfse = await this.nfseHandler.GetNfse(lote, numero);

        //save information on database
        await this.nfseRepository.SaveInformationAsync(nfse);
        return this.Created(this.Url.ToString(), responseBody);
      }
      catch (System.Exception ex)
      {
        return this.StatusCode(400, ex.Message);
      }


    }

    [HttpGet]
    [Route("ImprimirNota/{numero}/0")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetImprimirNotaUrl(string numero)
    {
      if (numero == null || numero == "")
        return this.BadRequest("Número da nota inválido.");
      try
      {
        return this.Ok(await this.nfseHandler.PrintNfseUrl(numero));
      }
      catch (System.Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [Route("ImprimirNota/{numero}/1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> GetImprimirNotaArquivo( string numero)
    {
      if (numero == null || numero == "")
        return this.BadRequest("Número da nota inválido.");
      try
      {
        var filebytes = await this.nfseHandler.PrintNfseFile(numero);
        return new FileStreamResult(new MemoryStream(filebytes),"application/pdf");
      }
      catch (System.Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }
  }
}
