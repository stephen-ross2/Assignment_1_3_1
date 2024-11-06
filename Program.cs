using System;

namespace Assignment_1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1_3_1
            //Write a program in C# to calculate area of triangle, square and rectangle.
            //Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.;

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("This program will calculate the area of a square, rectangle, or circle. Please select an option below:");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit Calculator");
                string userInput = Console.ReadLine();

                switch (userInput)

                {

                    case "1":
                        Console.WriteLine("Input the base measurment of the square");
                        double squareBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the height measurement of the square");
                        double sqaureHeight = Convert.ToDouble(Console.ReadLine());
                        double areaSquare = squareBase * sqaureHeight;
                        Console.WriteLine();
                        Console.WriteLine("The area of the square is " + areaSquare);
                        Console.WriteLine();    
                        break;

                    case "2":
                        Console.WriteLine("Input the base measurment of the rectangle");
                        double rectangleBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the height measurement of the rectangle");
                        double rectangleHeight = Convert.ToDouble(Console.ReadLine());
                        double areaRectangle = rectangleBase * rectangleHeight;
                        Console.WriteLine();
                        Console.WriteLine("The area of the rectangle is " + areaRectangle);
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Input the base measurment of the triangle");
                        double triangleBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the height measurement of the triangle");
                        double triangleHeight = Convert.ToDouble(Console.ReadLine());
                        double areaTriangle = 0.5 * triangleBase * triangleHeight;
                        Console.WriteLine();
                        Console.WriteLine("The area of the triangle is " + areaTriangle);
                        Console.WriteLine();

                        break;

                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Goodbye");
                        break;

                }



            }
        }
    }
}