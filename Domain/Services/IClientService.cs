﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public interface IClientService
    {
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        bool DelteClient(Client client);
        bool ReserveCar();
    }
}
