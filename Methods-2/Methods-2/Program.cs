using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {  //4 question
            Console.WriteLine("enter a no. from 1 to 7");
            Console.WriteLine("The day is :" + Day(int.Parse(Console.ReadLine())));
            


            //task 1
            Console.WriteLine("Enter your body weight in kilograms: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in centimetres: ");
            double h = double.Parse(Console.ReadLine());
            double bmi = Bmi(w, h);
            Console.WriteLine($"Your BMI is : {bmi}");
            Console.ReadLine();

            //task 2
            Console.WriteLine("Your BMI category is : ");

        }

        static string Day(int num)
        { string[] days = { "monday", "tuesday", "wednesday", "Thursday", "friday", "saturday", "sunday" };
            return days[num-1]; }

        static double Bmi(double w, double h)
        { return Math.Round( w / (h * h) ,1); }

      

    }
}
