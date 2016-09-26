using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Car
    {
        public int CarNumber { get; set; }

        public Car(int carNumber)
        {
            CarNumber = carNumber;
        }

        public override string ToString()
        {
            return CarNumber.ToString();
        }
    }
}
