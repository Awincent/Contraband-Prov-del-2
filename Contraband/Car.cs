using System;

namespace Contraband
{     
    class Car
    {
        
        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        private int missable; //temp for if the car can be missjudged

        public void Examine()
        {
            missable = generator.Next(0, contrabandAmount); //int will be higher if contraband is more

            if (alreadyChecked != true) //is checked? otherwise do
            {
                alreadyChecked = true;

                if (contrabandAmount <= 0 || missable <= 1) // if clean or missjudged this passes
                {
                    Console.WriteLine("The car is clean.");
                }
                else if (contrabandAmount > 0)
                {
                    Console.WriteLine("The car is dirty, nice."); //haha nice
                }
                
            }
            else
            {
                Console.WriteLine("This car has been inspected, inspector.");
            }



        }

    }
}