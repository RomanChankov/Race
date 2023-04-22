using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class MotorCar : Car
    {
        public string Name = "Lincoln Town Car";

        public void Drive()
        {
            Race(Name, CarSpeed(new Random(), 80, 100));
        }
    }
}
