using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Racheal
{
    class Car
    {
        //Data members
        private string make;
        private string model;
        private int year;
        private double price;
        

        //properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
       
       
        //default constructor. takes in no-arguments
        public Car ()
        {

        }

        //overloaded constructor. takes in 4 arguments
        public Car (string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
           
        
        }

        //method
        public override string ToString()//override the Tostring method returning a formatted string with the car details
        {
            string result = $"{Make,-10}{Model, -10}{Year, -10}{Price, -10}";
            return result;
        }
    }
}
