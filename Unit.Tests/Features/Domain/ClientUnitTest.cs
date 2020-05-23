using Domain.Entities;
using Domain.VO;
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
    }
}
