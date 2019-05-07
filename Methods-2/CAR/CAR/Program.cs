using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Mitsubishi";
            car1.Model = "Evo IX";
            car1.Rego = "ABC123";
            car1.Colour = "Black";

            Console.WriteLine($"Car details: \nMake:{car1.Make}\nModel:{car1.Model}\nRego:{car1.Rego}\nColour:{car1.Colour}");
        }
    }
    class Car
    {//Attributes
        string make;
        string model;
        string rego;
        string colour;

        // getters and setters
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Rego { get { return rego; } set { rego = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
    }
}
