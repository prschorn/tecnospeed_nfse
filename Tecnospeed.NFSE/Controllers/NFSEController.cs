using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
    public NFSEController(INFSE nfse)
    {
      this.nfseHandler = nfse;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> Post([FromBody]RequestData data)
    {
      if (data == null)
        return this.BadRequest("Dados inválidos para geração de nota fiscal.");

      //send data to tecnospeed api
      var response = await this.nfseHandler.sendData(data);

      //read response body to get the data the server sent back
      var responseBody = await response.Content.ReadAsStringAsync();

      if (response.StatusCode == System.Net.HttpStatusCode.OK)
      {
        return this.Ok(responseBody);
      }

      return this.StatusCode((int)response.StatusCode, responseBody);
    }
  }
}
