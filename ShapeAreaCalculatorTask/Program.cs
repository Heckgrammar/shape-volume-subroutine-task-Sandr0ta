namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
        static void Main(string[] args)
        {
            Console.Write("Enter radius of the circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Circle: " + AreaOfCircle(radius));

            Console.Write("Enter base of the triangle: ");
            int baseLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height of the triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Triangle: " + AreaOfTriangle(baseLength, height));

            Console.Write("Enter length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Rectangle: " + AreaOfRectangle(length, width));

            Console.Write("Enter side length of the pentagon: ");
            int sideLengthPentagon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter apothem of the pentagon: ");
            int apothem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Pentagon: " + AreaOfPentagon(sideLengthPentagon, apothem));

            Console.Write("Enter side length of the octagon: ");
            int sideLengthOctagon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Octagon: " + AreaOfOctagon(sideLengthOctagon));
        }

        static int AreaOfCircle(int radius)
        {
            return (int)(Math.PI * radius * radius);
        }

        static int AreaOfTriangle(int baseLength, int height)
        {
            return (baseLength * height) / 2;
        }

        static int AreaOfRectangle(int length, int width)
        {
            return length * width;
        }

        static int AreaOfPentagon(int sideLength, int apothem)
        {
            return (5 * sideLength * apothem) / 2;
        }

        static int AreaOfOctagon(int sideLength)
        {
            return (int)(2 * (1 + Math.Sqrt(2)) * sideLength * sideLength);
        }
    }
}
