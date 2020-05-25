using Domain.Entities;
using Domain.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Unit.Tests.Factory;
using Unit.Tests.Features.Domain;
using Xunit;

namespace Integreation.Tests.Steps
{
    [TechTalk.SpecFlow.Binding]
    [Trait("Integration Test","Rent Feature")]
    public class RentalSteps : ClientFactory
    {
        ClientUnitTest clientUni = new ClientUnitTest();

        [Given(@"Existing Client")]
        public void GivenExistingClient()
        {
            var result = clientUni.CanIInsertNewClient_ShouldReturnTrue("lucas");
            NUnit.Framework.Assert.True(result);
        }

        [Given(@"Client has Driver Licence")]
        public void GivenClientHasDriverLicence()
        {
            var driver = base.Client_1.GetDriverLicense(base.Client_1);
            NUnit.Framework.Assert.True(driver.isValid);
        }

        [When(@"Client Rents the Car")]
        public void WhenClientRentsTheCar()
        {
            base.Client_1.ReserverAcar(Client_1, base.Car_1);
            NUnit.Framework.Assert.True(base.Car_1.Valid);
        }

        [Then(@"the result should be True")]
        public void ThenTheResultShouldBeTrue()
        {
            var cli = base.Client_1;

            Mock<IClientService> mock = new Mock<IClientService>();

            mock.Setup(m => m.ReserveCar()).Returns(true);

            var mockResult = mock.Object.ReserveCar();
            NUnit.Framework.Assert.True(mockResult);
        }

    }
}
