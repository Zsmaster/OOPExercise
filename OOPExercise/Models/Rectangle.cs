namespace OOPExercise_Console.Models
{
    public class Rectangle : IShape
    {
        static public int RectangleCounter { get; set; } = 0;
        public ShapeSize Size { get; private set; }

        public Rectangle(ShapeSize size)
        {
            Size = size;
            ++Rectangle.RectangleCounter;
        }
        ~Rectangle()
        {
            --Rectangle.RectangleCounter;
        }

        public double Area()
        {
            return (int)Size * (int)Size;
        }

        public override string ToString()
        {
            return $"This is an {Size} ({(int)Size}*{(int)Size}) {GetType().Name}.";
        }
    }
}
