using OOPExercise_Console.Models;
using OOPExercise_Console.AppCode;
using System;
using System.Collections.Generic;

namespace OOPExercise
{
    class Program
    {
        private static List<IShape> shapes = new List<IShape>();
        private static string menuItem = "";

        static void Main(string[] args)
        {
            while (!menuItem.Equals("9"))
            {
                WriteMenu();
                ToDo(menuItem);
            }
        }

        public static void WriteMenu()
        {
            ClearConsole();
            Console.WriteLine("Please, select a number from the list below.");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Number of items");
            Console.WriteLine("4. List of items");
            Console.WriteLine("5. Amount of area");
            Console.WriteLine("6. Number of items by type");
            Console.WriteLine("7. First item by type");
            Console.WriteLine("8. Save to text file");
            Console.WriteLine("9. Exit");

            menuItem = Console.ReadLine();
        }

        public static void ClearConsole()
        {
            if (menuItem == "1" || menuItem == "2")
            {
                Console.Clear();
            }
            Console.ResetColor();
        }

        public static void ToDo(string item)
        {
            ShapeSize shapeSize;
            switch (item)
            {
                case "1":
                    shapeSize = ReadSize();
                    Rectangle rectanlge = new Rectangle(shapeSize);
                    shapes.Add(rectanlge);
                    break;
                case "2":
                    shapeSize = ReadSize();
                    Triangle triangle = new Triangle(shapeSize);
                    shapes.Add(triangle);
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Number of items: {shapes.Count}");
                    Console.WriteLine();
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (IShape shapeItem in shapes)
                    {
                        Console.WriteLine(shapeItem.ToString());
                    }
                    Console.WriteLine();
                    break;
                case "5":
                    double area = 0.0;
                    foreach (IShape shapeItem in shapes)
                    {
                        area += shapeItem.Area();
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Amount of area: {area}.");
                    Console.WriteLine();
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Number of rectangles: {Rectangle.RectangleCounter}");
                    Console.WriteLine($"Number of triangles: {Triangle.TriangleCounter}");
                    Console.WriteLine();
                    break;
                case "7":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"First rectangle: {Function.FirstShapeInList<Rectangle>(shapes)}");
                    Console.WriteLine($"First triangle: {Function.FirstShapeInList<Triangle>(shapes)}");
                    Console.WriteLine();
                    break;
                case "8":
                    Function.SaveToTextFile(shapes);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The list has been successfully saved.");                    
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }

        public static ShapeSize ReadSize()
        {
            Console.WriteLine("Please, select a size from the list below.");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large");
            string item = Console.ReadLine();

            switch (item)
            {
                case "1":
                    return ShapeSize.Small;
                case "2":
                    return ShapeSize.Medium;
                case "3":
                    return ShapeSize.Large;
                default:
                    Console.WriteLine("Incorrect number");
                    return ReadSize();
            }
        }
    }
}
