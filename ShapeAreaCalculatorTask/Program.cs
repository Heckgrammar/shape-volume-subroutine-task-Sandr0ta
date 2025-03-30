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
        }
         static double AreaOfCircle(int radius)
        {
            return Math.PI * radius * radius;
        }

        static double AreaOfTriangle(int baseLength, int height)
        {
            return 0.5 * baseLength * height;
        }

        static int AreaOfRectangle(int length, int width)
        {
            return length * width;
        }

        static double AreaOfPentagon(int sideLength, int apothem)
        {
            return (5 * sideLength * apothem) / 2.0;
        }

        static double AreaOfOctagon(int sideLength)
        {
            return 2 * (1 + Math.Sqrt(2)) * sideLength * sideLength;
        }
    }
}
