using System;

namespace studioclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter the radius");
            string radius = Console.ReadLine();
            int r = int.Parse(radius); // MPG


            double areaOfCircle = pi * r * r;
            Console.WriteLine("The area of the circle is " + areaOfCircle);

            double circumference = 2 * pi * r;
            double diameter = 2 * r; // MILES
            double gallonsPerRound = diameter / r;
            Console.WriteLine("Gallons of gas they will use to go around this circle is " + gallonsPerRound);
            Console.WriteLine("The circumference is " + circumference);
            Console.WriteLine("The diameter is " + diameter);
        }
    }
}
