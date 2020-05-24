using Domain.Entities;
using Domain.Services;
using Domain.VO;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Tests.Factory;
using Xunit;

namespace Unit.Tests.Features.Domain
{
    public class ClientUnitTest : ClientFactory
    {
        [Theory]
        [Trait("Client", "Insert Client")]
        [InlineData("Lucas")]
        [InlineData("Clauber")]
        [InlineData("Monalisa")]
        public void CanIInsertNewClient(string name)
        {
            //AAA
            var result = base.Client_1.CheckStatusOfClient(base.Client_1);
            Assert.True(result);

        }
        [Theory]
        [Trait("Client", "Insert Client")]
        [InlineData("Lucas")]
        [InlineData("Clauber")]
        [InlineData("Gioconda")]
        public void CanIInsertNewClient_ShouldReturnTrue(string name)
        {
            //Arrange
            var cli = new Client(name, EStatus.Gold, base.DV_1);

            Mock<IClientService> mock = new Mock<IClientService>();
            mock.Setup(m => m.AddClient(cli)).Returns(true);
            // act
            var mockResult = mock.Object.AddClient(cli);
            
            // assert
            Assert.True(mockResult);
        }
    }
}
