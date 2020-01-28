using System;
using System.Collections.Generic;

namespace Contraband
{
    class Program
    {
        public int howManyCars = 0;
        public List<Car> cars;
        public Random generator = new Random();
        

        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello Car-Inspector!");
            Console.WriteLine("How many card do you want o inspect?");
            string _temp = Console.ReadLine();

            if (howManyCars > 0)
            {
                if (int.TryParse(_temp, out howManyCars))
                {
                    if (howManyCars == 0)
                    {
                        Console.WriteLine("So no cars today Inspector?");
                        Console.ReadKey();
                        Environment.Exit(); // Quit because of no cars
                    }
                    else
                    {
                        while(howManyCars > 0) //Creates all cars
                        {
                            int _tempCar = generator.Next(1,3);
                            if (_tempCar == 1) //cerates clean car
                            {
                                string _tempName = howManyCars.ToString();
                                Car _tempName = new CleanCar();
                                cars.Add(_tempName);
                            } 
                            else if (_tempCar == 2) //creates dirty car
                            {
                                string _tempName = howManyCars.ToString();
                                string _tempName = howManyCars.ToString();
                                Car _tempName = new ContrabandCar();
                                cars.Add(_tempName);
                            }
                            howManyCars--;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please imput a number");
                }
            }
            

            //nomoretime







            Console.ReadKey();
        }
    }
}
