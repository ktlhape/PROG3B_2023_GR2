namespace VirtualFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new(4,8);
            Rectangle rec = new Rectangle(5,6);
            Shape recShape = new Rectangle(6, 4);

            Console.WriteLine(sh.PrintShape());
            Console.WriteLine($"Area: {sh.Area()}");
            Console.WriteLine("=====================");
            Console.WriteLine(recShape.PrintShape());
            Console.WriteLine($"Area: {recShape.Area()}");
            Console.WriteLine("=====================");

            Console.Read();
        }
    }

    public class Shape
    {
        protected double Length { get; set; }
        protected double Width { get; set; }
        public Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public virtual string PrintShape() =>
            "This is just a shape";

        public virtual double Area() =>
            Length * Width;
    }

    public class Rectangle : Shape
    {
        public Rectangle(double x, double y) : base(x,y)
        {
            //this.Length = x;
            //this.Width = y;
        }
        //public override double Area()
        //{
        //    return this.Length * this.Width;
        //}
        public new string PrintShape() =>
         "This is a Rectangle";
        
    }

    public class Square : Shape
    {
        public Square(double side) : base(side,0)
        {}
        public override double Area()
        {
            return Math.Pow(this.Length,2);
        }
        public override string PrintShape()
        {
            return $"This is a {this.GetType().Name}";   
        }
    }
}