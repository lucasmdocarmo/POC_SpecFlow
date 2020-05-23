using Domain.Entities;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Domain.Entities
{
    public class DriverLicense : Entity
    {
        public DriverLicense(int number, string type)
        {
            Number = number;
            Type = type;
        }

        public Client Client { get; private set; }
        public int Number { get; private set; }
        public string Type { get; private set; }
        public bool isValid { get; set; } = true;

        public void AddLicenceToClient(DriverLicense license)
        {
            if (isValid)
                Client.DV = license;
        }
        public bool CheckLicence(int Number)
        {
            if (Client.DV.Number == Number)
                return isValid;
            return false;
        }
    }
}
