using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.NFSE.Controllers;
using Tecnospeed.NFSE.Models;
using Tecnospeed.NFSE.Models.Interfaces;
using Xunit;


namespace Tecnospeed.NFSE.Tests
{
  public class NFSETests
  {
    private readonly Mock<INFSE> mockNfseHandler;
    private readonly NFSEController controller;

    public NFSETests()
    {
      this.mockNfseHandler = new Mock<INFSE>();
      this.controller = new NFSEController(this.mockNfseHandler.Object);
    }


    [Fact]
    public async Task PostNfse_ReturnsOK_GivenRequestData_IsValid()
    {
      //Arrange
      this.mockNfseHandler.Setup(x => x.sendData(It.IsAny<RequestData>()))
        .Returns(Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent("000,00,00,Autorizado",Encoding.UTF8) }));

      //Act
      var action = await this.controller.Post(new Models.RequestData());

      //Assert
      var result = action as OkObjectResult;
      result.Should().BeOfType<OkObjectResult>();
      result.Value.Should().NotBeNull();
      result.Value.ToString().Should()
        .NotContain("EXCEPTION");
    }

    [Fact]
    public async Task PostNfse_ReturnsBadRequest_WhenRequestData_IsNull()
    {
      //Arrange

      //Act
      var action = await this.controller.Post(null);

      //Assert
      action.Should().BeOfType<BadRequestObjectResult>("Dados inválidos para geração de nota fiscal.");
    }

    [Fact]
    public async Task PostNfse_ReturnsBadGateway_WhenRequestData_IsInvalid()
    {
      //Arrange
      this.mockNfseHandler.Setup(x => x.sendData(It.IsAny<RequestData>()))
        .Returns(Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.BadGateway) { Content = new StringContent("EXCEPTION", Encoding.UTF8) }));

      //Act
      var action = await this.controller.Post(new RequestData());

      //Assert
      var result = action as ObjectResult;
      Assert.Equal(502, result.StatusCode);
      result.Value.ToString().Should().Contain("EXCEPTION");

    }
    
  }
}
