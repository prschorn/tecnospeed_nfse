using System;
using System.Threading.Tasks;
using Xunit;
using Tecnospeed.NFSE.Extensions;
using FluentAssertions;

namespace Tecnospeed.NFSE.Tests
{
  public class DateTimeTests
  {

    [Fact]
    public void DateTimeExtension_ReturnsConvertedDatetime()
    {
      //Arrange
      var date = new DateTime(2000, 1, 1, 1, 10, 10, 10);

      //Act
      var convertedDate = date.DatabaseTime();

      //Assert
      convertedDate.Should().NotBeNullOrEmpty();
      convertedDate.Should().BeOfType<string>();
      convertedDate.Should().Be("2000-1-1T01:10:10");
    }
  }
}
