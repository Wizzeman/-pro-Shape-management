using System;

namespace Pro_Shape_management
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();

    }

    class Triangle : Shape
    {
        double a, b, c, h;


        public Triangle(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;

        }
        
        public override double Area()
        {
            return (h * b) / 2;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
    }

    class Square : Shape
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }

        public override double Perimeter()
        {
            return a*4;
        }
    }

    class Circle : Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return Math.PI*r*r;
        }

        public override double Perimeter()
        {
            return Math.PI*r*2;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Mr.Wizzeman's pro shape management";
            System.Console.WriteLine("What is your shape ? (circle , triangle , square)");
            string choice = Console.ReadLine().ToLower();
            Shape shape = null;

            switch (choice)
            {

                case "circle":
                    System.Console.WriteLine("please insert radios ");
                    System.Console.WriteLine("r= ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle(r);
                    break;

                case "triangle":

                    System.Console.WriteLine("please insert sides and height ");
                    System.Console.WriteLine("a= ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    System.Console.WriteLine("b= ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    System.Console.WriteLine("c= ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    System.Console.WriteLine("hight= ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    shape = new Triangle(a, b, c, h);
                    break;
                case "square":
                    Console.Write("please insert side ");
                    System.Console.WriteLine("s= ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    shape = new Square(s);
                    break;

                default:
                    System.Console.WriteLine("Non defined");
                    break;
            }

            if (shape!=null)
            {
                Console.WriteLine($"Area = {shape.Area()}");
                Console.WriteLine($"Perimeter = {shape.Primeter()}");
            }


            Console.ReadKey();
        }
    }

}
