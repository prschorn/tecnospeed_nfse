using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.NFSE.Models;
using Tecnospeed.NFSE.Models.Interfaces;
using Xunit;
using FluentAssertions;

namespace Tecnospeed.NFSE.Tests
{
  public class AuthenticationTests
  {
    private readonly IAuthentication authentication;

    public AuthenticationTests()
    {
      this.authentication = new Authentication();
    }


    [Fact]
    public void ValidateUser_ReturnsEncodedToken_When_UserAndPassword_AreValid()
    {
      //Arrange
      TecnospeedData.user = "user";
      TecnospeedData.password = "password";
      //act
      var encodedToken = this.authentication.ValidateUser();

      //Assert
      encodedToken.Should().NotBeNull();
      encodedToken.Should().BeOfType<string>();
      encodedToken.Should().Be("Basic dXNlcjpwYXNzd29yZA==");
    }

    [Fact]
    public void ValidateUser_ThrowsException_When_UserOrPassword_AreInvalid()
    {
      //Arrange
      TecnospeedData.user = null;
      TecnospeedData.password = null;

      //Act
      Func<string> result = () => { return this.authentication.ValidateUser(); };

      //Assert
      result.Should().Throw<Exception>("Usuário e senha de administradores não encontrado. Fale com a equipe responsável pelo sistema.");
    }
  }
}
