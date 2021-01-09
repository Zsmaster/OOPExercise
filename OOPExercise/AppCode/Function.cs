using OOPExercise_Console.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOPExercise_Console.AppCode
{
    public class Function
    {
        public static IShape FirstShapeInList<T>(List<IShape> shapes)
        {
            return shapes
                    .Where(x => x is T)
                    .FirstOrDefault();
        }

        public static void SaveToTextFile(List<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                WriteToFie(shape);
            }
        }

        private static void WriteToFie<T>(T shape)
        {
            File.AppendAllText($@"{Directory.GetCurrentDirectory()}\Shapes.txt", shape.ToString() + Environment.NewLine, Encoding.UTF8);
        }
    }
}
