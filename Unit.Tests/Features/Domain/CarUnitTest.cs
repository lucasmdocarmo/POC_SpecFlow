using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Tests.Factory;
using Xunit;

namespace Unit.Tests.Features.Domain
{
    public class CarUnitTest : ClientFactory
    {
        [Theory]
        [Trait("Car", "Insert Car")]
        [InlineData("Fiat","1992")]
        [InlineData("Ferrari", "1992")]
        [InlineData("Tesla", "2019")]
        public void CanIInsertNewCar_ShouldReturnTrue(string name,string year)
        {
            //AAA
            var client = new Car(name, year);

            var result = client.CheckName(name);

            Assert.True(result);

        }
    }
}
