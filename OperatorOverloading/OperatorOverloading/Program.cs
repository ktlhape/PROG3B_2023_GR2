using System.ComponentModel;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box boxA = new Box(4, 6);
            Box boxB = new Box(3, 8);
            //Box boxC = new Box(boxA.Length + boxB.Length, boxA.Width + boxB.Width);
            Box boxC = boxA + boxB;

            boxA++;
            bool results = boxA > boxB;

            /*overload the operator such that the
             * length and width of a box increases 
             * by a percentage*/

            Console.WriteLine(boxC.ToString());






        }
    }

    public class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Box(double theLength, double theWidth) => 
            (Length, Width) = (theLength, theWidth);

        public override string? ToString()
        {
            return $"Length: {Length}\nWidth: {Width}\n" +
                $"==================";
        }

        //modifier static return type operator + (operands)
        public static Box operator +(Box b1, Box b2) =>
         new Box(b1.Length + b2.Length, b1.Width + b2.Width);

        public static Box operator ++(Box b)
        {
            return new Box(b.Length + 1, b.Width + 1);
        }
        //public static int operator +(Box b1, Box b2)
        //{
        //    return 0;
        //}
        public static bool operator >(Box b1, Box b2) =>
            b1.Length > b2.Length && b1.Width > b2.Width;
        public static bool operator <(Box b1, Box b2) =>
            b1.Length < b2.Length && b1.Width < b2.Width;

    }
}