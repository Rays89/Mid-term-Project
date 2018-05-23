using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Racheal
{
    class UsedCar: Car
    {
        //data members
        private double milleage;

        //properties
        public double Milleage
        {
            set { milleage = value; }
            get { return milleage; }
        }

        //overloaded constructor

        public UsedCar(string make, string model, int year, double price,  double milleage):base(make,model,year,price)
        {
            Milleage = milleage;
        }

        //method
        public override string ToString()//overrides the cars Tostring to include usedcar and the milleage
        {
            string result = base.ToString() + $" UsedCar {Milleage, -10}";
            return result;

        }

    }
}
