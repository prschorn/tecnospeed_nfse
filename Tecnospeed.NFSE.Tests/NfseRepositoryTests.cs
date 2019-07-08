using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;
using Tecnospeed.Database.Repositories.Interfaces;
using LiterateElephant.Common.Model;
using Xunit;
using Moq;
using Tecnospeed.Database.Models;
using Tecnospeed.Database.Models.Interfaces;

namespace Tecnospeed.NFSE.Tests
{
  public class NfseRepositoryTests
  {
    private readonly Mock<ITecnospeedDbContext> mockDbcontext;
    private readonly INfseRepository repository;
    public NfseRepositoryTests()
    {
      this.mockDbcontext = new Mock<ITecnospeedDbContext>();
    }


    [Fact]
    public void SaveInformationAsync_ReturnsEntity_When_DataIsValid()
    {
      //arrange
      this.mockDbcontext.Setup(x => x.Invoices.Add(It.IsAny<Invoice>())).Returns(new Invoice());
      this.mockDbcontext.Setup(x => x.SaveChangesAsync()).Returns(new Task<int>(() => { return 1; }));

      //act
      Func<Task> result = async () => { await this.repository.SaveInformationAsync(new NFSEDto()); };

      //Assert
      result.Should().NotThrow<Exception>();
    }

    [Fact]
    public void SaveInformationAsync_ThrowsException_When_DataIsInvalid()
    {
      //Arrange
      this.mockDbcontext.Setup(x => x.Invoices.Add(It.IsAny<Invoice>())).Returns(new Invoice());
      this.mockDbcontext.Setup(x => x.SaveChangesAsync()).Returns(new Task<int>(() => { return -1; }));

      //Act
      Func<Task> result =  async () => { await this.repository.SaveInformationAsync(null); };

      //Assert
      result.Should().Throw<Exception>("Erro ao salvar nota.");
    }
  }
}
