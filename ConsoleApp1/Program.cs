using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1+2+3
            string name;
            string location;


            Console.WriteLine("please Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Where are you coming from: ");
            location = Console.ReadLine();

            Console.WriteLine("Hi " + name);
            Console.WriteLine("I am from " + location + " too.");

            //4
            DateTime localDate = DateTime.Now;
            Console.WriteLine("The time now is " + localDate.ToString());

            //5
            string christmasDay = "12-25-2020";
            DateTime endDate = DateTime.Parse(christmasDay);
            TimeSpan days = endDate.Subtract(localDate);
            Console.WriteLine("Today {0} to the Christmas {1} is only {2} left!",
                                localDate.ToString("MM-dd-yyyy"),
                                christmasDay,
                                days);

            //6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("please Enter the wood width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("please Enter the wood height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


        }
    }
}
