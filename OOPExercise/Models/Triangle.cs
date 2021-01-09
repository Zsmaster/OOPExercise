namespace OOPExercise_Console.Models
{
    public class Triangle : IShape
    {
        static public int TriangleCounter { get; set; } = 0;
        public ShapeSize Size { get; private set; }
        public Triangle(ShapeSize size)
        {
            Size = size;
            ++Triangle.TriangleCounter;
        }

        ~Triangle()
        {
            --Triangle.TriangleCounter;
        }

        public double Area()
        {
            return (int)Size * (int)Size / 2;
        }

        public override string ToString()
        {
            return $"This is an {Size} ({(int)Size}*{(int)Size}) {GetType().Name}.";
        }
    }
}
