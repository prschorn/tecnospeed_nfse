using FluentAssertions;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;
using Tecnospeed.NFSE.Models;
using Tecnospeed.NFSE.Models.Interfaces;
using Xunit;

namespace Tecnospeed.NFSE.Tests
{
  public class NFSEHandlerTests
  {
    private readonly Mock<HttpClientHandler> mockClient;
    private INFSE nfseHandler;
    private readonly Mock<IAuthentication> mockAuth;
    private string ExpectedUri = "https://managersaas.tecnospeed.com.br:7071//ManagerAPIWeb/nfse/";
    public NFSEHandlerTests()
    {
      this.mockClient = new Mock<HttpClientHandler>();
      this.mockAuth = new Mock<IAuthentication>();
      this.nfseHandler = new NFSEHandler(this.mockAuth.Object);
    }

    [Fact]
    public async Task GetNfse_ReturnsDto_When_DataIsValid()
    {
      //Arrange
      this.mockAuth.Setup(x => x.ValidateUser())
        .Returns("Basic header");
      this.mockClient.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(new HttpResponseMessage() {
          StatusCode = System.Net.HttpStatusCode.OK,
          Content = new StringContent("ok")
        }).Verifiable();

      var httpClient = new HttpClient(this.mockClient.Object)
      {
        BaseAddress = new Uri(ExpectedUri)
      };

      this.nfseHandler = new NFSEHandler(this.mockAuth.Object);
      

      //Act
      var result = await this.nfseHandler.GetNfse("lote", "nfse");


      //assert
      result.Should().NotBeNull();
      result.Should().BeOfType<NFSEDto>();

      this.mockClient.Protected().Verify(
         "SendAsync",
         Times.Exactly(1),
         ItExpr.IsAny<CancellationToken>()
        );
    }

    [Fact]
    public void GetNfse_ReturnsErrorNotFound_When_DataIsInvalid()
    {
      //Arrange
      this.mockClient.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(new HttpResponseMessage()
        {
          StatusCode = System.Net.HttpStatusCode.NotFound
        });

      //Act
      Func<Task<NFSEDto>> result = async () => { return await this.nfseHandler.GetNfse(null, null); };

      //Assert
      result.Should().Throw<Exception>("Nota não encontrada");
    }


    [Fact]
    public async Task PrintNfseUrl_ReturnUrl_When_NfseNumberIsValid()
    {
      //Arrange
      this.mockClient.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(new HttpResponseMessage()
        {
          StatusCode = System.Net.HttpStatusCode.OK
        });

      //Act
      var result = await this.nfseHandler.PrintNfseUrl("NUMERO NFSE");

      //Assert
      result.Should().NotBeNull();
    }
    [Fact]
    public void PrintNfseUrl_ThrowsException_When_NfseNumberIsInvalid()
    {
      //Arrange
      this.mockClient.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(new HttpResponseMessage()
        {
          StatusCode = System.Net.HttpStatusCode.NotFound
        });

      //Act
      Func<Task<string>> result = async () => { return await this.nfseHandler.PrintNfseUrl("numero invalido"); };
      //Assert
      result.Should().Throw<Exception>("Nota não encontrada");
    }

  }
}
