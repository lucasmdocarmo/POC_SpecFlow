using Domain.Entities.Base;
using Domain.VO;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class Client : Entity
    {

        public Client(string name, EStatus status, DriverLicense dV)
        {
            Name = name;
            Status = status;
            DV = dV;

            AddNotifications(new Contract()
            .Requires()
            .IsNotEmpty(Id, Name, "Nane can't be Empty")
        );
        }

        public string Name { get; private set; }
        public EStatus Status { get; private set; }
        public DriverLicense DV { get; set; }

        public Car Car { get; set; }

        public bool CheckStatusOfClient(Client client)
        {
            bool values = Enum.IsDefined(typeof(EStatus), client.Status);

            if (!values)
            {
                AddNotifications(new Contract()
                    .IsFalse(values, "Client.Status", "Status Inexistente"));
                return false;
            }
            return true;
        }

        public void AddDriverLicence(Client client, DriverLicense licence)
        {
            client.DV = licence;
        }
        public DriverLicense GetDriverLicense(Client client)
        {
            if (client.DV != null)
                return client.DV;
            else return null;
        }

        public void ReserverAcar(Client client, Car car)
        {
            client.Car = car;
        }
    }
}
