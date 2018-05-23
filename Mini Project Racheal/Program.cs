using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Racheal
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool repeat = true;

                                 
            List<Car> AllCar = CarLot.GetCars();//instantiating 

            Console.WriteLine("Welcome to the Grand Circus Motors admin console! \n");
         
            while (repeat)
            {

            Console.WriteLine("Motors Menu. Please choose a list of your choice under the menu.\n 1. List all cars \n 2. Add a car \n 3. Remove a car \n 4. Look up a car \n 5. Replace a car \n 6.Quit");
            string userinput = (Console.ReadLine());
            Console.WriteLine();

            

                if (userinput == "1")
                {
                    CarLot.printInfo(AllCar);
                    Console.WriteLine("List all cars");
                }
                else if (userinput == "2")
                {
                    CarLot.AddCars(AllCar);
                    CarLot.printInfo(AllCar);
                }
                else if (userinput == "3")
                {
                    CarLot.RemoveCar(AllCar);
                    CarLot.printInfo(AllCar);
                }
                else if (userinput == "4")
                {
                    CarLot.Lookup(AllCar);
                }
                else if (userinput == "5")
                {
                    CarLot.ReplaceCar(AllCar);
                    CarLot.printInfo(AllCar);
                }

                Console.WriteLine("Would you like to quit? (1) for quit, (2) for continue");
                int AskQuit = int.Parse(Console.ReadLine());
                if (AskQuit == 2)
                {
                    Console.WriteLine("continue");
                    repeat = true;
                }
                else if (AskQuit == 1)
                {
                    Console.WriteLine("Goodbye");
                    repeat = false;
                }

                
            }
            
                  






          

           

          

            


           





          
        }
    }
}
