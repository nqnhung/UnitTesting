using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.TestsMain.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            var pingService = new NetworkService();

            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();//setting fluent
            result.Should().Be("Success PingSent!");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2,2,4)]
        public void NetworkService_SendPing_ReturnInt(int a, int b, int expected)
        {
            var pingService = new NetworkService();

            //Act
            var result = pingService.PingTimeOut(a, b);

            //Assert
            result.Should().Be(expected);
        }
    }
}
