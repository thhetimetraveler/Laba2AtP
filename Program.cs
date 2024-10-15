using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2AtP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double a = 3.1;
            double y;

            if (x < -1)
            {
                y = -x - 1;
            }
            else if (x >= -1 && x < 1)
            {
                y = 1 - Math.Pow(x, 2) * Math.Cos(Math.PI * x);
            }
            else
            {
                y = x - 1 / Math.Sqrt(Math.Pow(a, 3));
            }

            Console.WriteLine($"The value of y: {y}");

            // task 2
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            double max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"The smallest number is: {min}");
            Console.WriteLine($"The largest number is: {max}");

            // task 3
            Console.WriteLine("Enter the element number (1 - Radius, 2 - Diameter, 3 - Circumference): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double area = 0;
            const double pi = Math.PI;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    area = pi * Math.Pow(radius, 2);
                    break;
                case 2:
                    Console.Write("Enter the diameter: ");
                    double diameter = Convert.ToDouble(Console.ReadLine());
                    radius = diameter / 2;
                    area = pi * Math.Pow(radius, 2);
                    break;
                case 3:
                    Console.Write("Enter the circumference: ");
                    double circumference = Convert.ToDouble(Console.ReadLine());
                    radius = circumference / (2 * pi);
                    area = pi * Math.Pow(radius, 2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"The area of the circle is: {area}");
        }
    }
}
