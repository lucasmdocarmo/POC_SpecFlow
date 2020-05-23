using Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Unit.Tests.Factory;
using Xunit;

namespace Integreation.Tests.Steps
{
    [TechTalk.SpecFlow.Binding]
    [Trait("Integration Test","Rent Feature")]
    public class RentalSteps : ClientFactory
    {

        [Given(@"Existing Client")]
        public void GivenExistingClient()
        {
            NUnit.Framework.Assert.True(base.Client_1.Valid);
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
            NUnit.Framework.Assert.True(base.Client_1.Valid);
        }

    }
}
