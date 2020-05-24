using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Domain.Entities
{
    public class Car : Entity
    {
        public Car(string name, string year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; private set; }
        public string Year { get; private set; }
        public bool Rented { get; private set; }

        public bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;
            else return true;
        }

      
    }
}
