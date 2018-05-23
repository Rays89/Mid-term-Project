using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Racheal
{
    class CarLot:Car
    {
         //called in a couple of methods                       
        //method, stores the new and used cars
        public static List<Car> GetCars()
        {
            List<Car> AllCars = new List<Car>();//used a list array to hold the cars

            AllCars.Add(new Car("Ford", "Escape", 2018, 23940));
            AllCars.Add(new Car("Ford", "F150", 2017, 27110));
            AllCars.Add(new Car("Ford", "EcoSport", 2018, 19995));
            AllCars.Add(new UsedCar("Kia", "Rio", 2014, 7495, 72394));
            AllCars.Add(new UsedCar("Nissan", "Sonic", 2013, 8700, 47993));
            AllCars.Add(new UsedCar("Toyota", "Camry", 2010, 8150, 126861));

            return AllCars;
        }

        public static void printInfo(List<Car> CarList)
        {
            int counter = 0;
            foreach(Car c in CarList)
              {
                  counter++;//increaments the index count by 1
                  Console.WriteLine($"{counter,-5}" + c.ToString());//-5 Formats the string
              }
        }

        public static void AddCars(List<Car> CarList )//method for adding cars
        {

            Console.WriteLine("Is the car you would like to add a (1)new car or a (2)used car");
            string UsedNew = Console.ReadLine();
            if (UsedNew == "1")
            {
                Console.WriteLine("What is the make of the car");
                string inputmake = Console.ReadLine();
                Console.WriteLine("What is the model of the car");
                string inputmodel = Console.ReadLine();
                Console.WriteLine("What is the year of the car");
                int inputyear = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the price of the car");
                double inputprice = double.Parse(Console.ReadLine());

                Car New1 = new Car(inputmake, inputmodel, inputyear, inputprice);
                CarList.Add(New1);//once a car is added, its stored to the car list
            }
            else if (UsedNew == "2")
            {
                Console.WriteLine("What is the make of the car");
                string inputmake = Console.ReadLine();
                Console.WriteLine("What is the model of the car");
                string inputmodel = Console.ReadLine();
                Console.WriteLine("What is the year of the car");
                int inputyear = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the price of the car");
                double inputprice = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the milleage of your car");
                double inputmilleage = double.Parse(Console.ReadLine());

                UsedCar Used1 = new UsedCar(inputmake, inputmodel, inputyear, inputprice, inputmilleage);
                CarList.Add(Used1);//once a car is added, its stored to the car list
            }

        }


        public static void RemoveCar(List<Car> CarList)// this method removes the car and asks the user if they want to buy it
        {

            int buycar = 0;
            bool repeat = true;
            while (repeat)
            {

                printInfo(CarList);
                Console.WriteLine("Would you like to buy a car? (1)buy (2)No i dont want to buy a car");
                bool check = int.TryParse(Console.ReadLine(), out buycar);
                if (check == true)//checking to make sure the try.parse is a number
                {
                    if (buycar == 1 || buycar == 2)
                    {
                        repeat = false;//this if statement is for the while(repeat) to keep redoing the loop once its true

                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                
               
                  
                
            }
            
            if (buycar == 1)
            {

                Console.WriteLine("Which car would you like to buy? Please pick a number from the list.");
                int Carchoice = int.Parse(Console.ReadLine());
                CarList.RemoveAt(Carchoice - 1);//the index starts counting from 0 but on the list it starts from 1
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }



            }


        public static void Lookup(List<Car>CarList)//this method looks up the car in a given position
        {
            Console.WriteLine("Please enter the number of the car to lookup a car.");
            int Carchoice = int.Parse(Console.ReadLine());
            Console.WriteLine(CarList[Carchoice - 1]);
        }

        public static void ReplaceCar(List<Car> CarList)//this method replaces the car in a given position 
        {
            Console.WriteLine("What is the make of the car");
            string inputmake = Console.ReadLine();
            Console.WriteLine("What is the model of the car");
            string inputmodel = Console.ReadLine();
            Console.WriteLine("What is the year of the car");
            int inputyear = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the price of the car");
            double inputprice = double.Parse(Console.ReadLine());

            Car New1 = new Car(inputmake, inputmodel, inputyear, inputprice);

            Console.WriteLine("Please enter the number of the car you would like to replace");
            int Replace = int.Parse(Console.ReadLine());
            CarList[Replace - 1] = New1;

        }




    }

}