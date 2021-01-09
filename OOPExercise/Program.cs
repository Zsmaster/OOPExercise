using OOPExercise_Console.Models;
using System;
using System.Collections.Generic;

namespace OOPExercise
{
    class Program
    {
        private static List<IShape> shapes = new List<IShape>();
        private static List<Type> types = new List<Type>() { typeof(Rectangle), typeof(Triangle) };
        private static string menuItem = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
