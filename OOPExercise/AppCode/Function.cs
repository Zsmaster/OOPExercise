using OOPExercise_Console.Models;
using System.Collections.Generic;
using System.Linq;

namespace OOPExercise_Console.AppCode
{
    class Function
    {
        public static IShape FirstShapeInList<T>(List<IShape> shapes)
        {
            return shapes
                    .Where(x => x is T)
                    .FirstOrDefault();
        }
    }
}
