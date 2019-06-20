using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.NFSE.Models;
using Xunit;

namespace Tecnospeed.NFSE.Tests
{
  public class TX2Tests
  {
    public TX2Tests()
    {
    }

    [Fact]
    public void GenerateTx2FromData_ReturnsEncodedString_When_DataIsValid()
    {
      //Arrange
      var requestData = new RequestData();

      //act
      var encodedData = TX2Handler.GenerateTx2FromData(requestData);

      //Assert
      encodedData.Should().NotBeNull();
      encodedData.Should().BeOfType<string>();

    }

    [Fact]
    public void GenerateTx2FromData_ThrowsException_When_DataIsInvalid()
    {
      //Act
      Func<string> encodedData = () => { return TX2Handler.GenerateTx2FromData(null); };

      //Assert
      encodedData.Should().Throw<Exception>("Dados inválidos para gerar nota, verifique sua requisição.");
    }

  }
}
