using Domain.Entities;
using Domain.VO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.Tests.Factory
{
    public abstract class ClientFactory
    {
        public ClientFactory()
        {
           
            Client_1 = new Client("test", EStatus.Gold, DV_1);
            Car_1 = new Car("Fiat", "1989");
        }
        
        public virtual DriverLicense DV_1 { get; set; } = new DriverLicense(123456, "B");
        public virtual Client Client_1 { get; set; }
        public virtual Car Car_1 { get; set; }
    }
}
