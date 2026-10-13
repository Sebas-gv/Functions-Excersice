
using System;

namespace Functions_Excersice
{
    class Volume
    {
        public static double CalculateVolume(double sideLength)
        {
            return sideLength * sideLength * sideLength;
        }

        public static double CalculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }
    }

    class SurfaceArea
    {
        public static double CalculateSurfaceArea(double sideLength)
        {
            return 6 * sideLength * sideLength;
        }

        public static double CalculateSurfaceArea(double length, double width, double height)
        {
            return 2 * ((length * width) + (width * height) + (length * height));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double sideLengthCube = 5;

            double heightBox = 2;
            double widthBox = 3;
            double lengthBox = 4;

            Console.WriteLine("Surface Area");
            Console.WriteLine($"The surface area of a cube with side length {sideLengthCube} is: {SurfaceArea.CalculateSurfaceArea(sideLengthCube)}");
            Console.WriteLine($"The surface area of a box with height {heightBox}, width {widthBox} and length {lengthBox} is: {SurfaceArea.CalculateSurfaceArea(lengthBox, widthBox, heightBox)}");

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Volume");
            Console.WriteLine($"The volume of a cube with side length {sideLengthCube} is: {Volume.CalculateVolume(sideLengthCube)}");
            Console.WriteLine($"The volume of a box with height {heightBox}, width {widthBox} and length {lengthBox} is: {Volume.CalculateVolume(lengthBox, widthBox, heightBox)}");
        }
    }
}
