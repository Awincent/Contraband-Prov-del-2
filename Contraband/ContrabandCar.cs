using System;

namespace Contraband
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passangers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
        }
    }
}