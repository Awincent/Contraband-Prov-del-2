using System;

namespace Contraband
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passangers = generator.Next(1, 4);
            contrabandAmount = 0;
        }
    }
}