using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool go = true;
            Console.WriteLine("Hello, welcome to circle reader. ");
            while (go)
            {

                
                Console.WriteLine("Please enter the radius of your circle (distance from the center of the circle to any point on its circumference.): ");
                
                try
                {
                    double userRadius = double.Parse(Console.ReadLine());

                    Circle circle = new Circle(userRadius);
                    double circumference = circle.CalculateCircumference(userRadius);
                    double area = circle.CalculateArea(userRadius);
                    Console.WriteLine("Your circumference as follows: " + circumference);
                    Console.WriteLine("Your area is: " + area);
                    num++;

                    go = KeepGoing(num);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid numberical value.");
                }
            }

        }
        public static bool KeepGoing(int num1)
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else
            {
                Console.WriteLine($"You created {num1} circles. Goodbye!");
                return false;
            }
        }
    }
}
