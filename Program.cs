using System;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        double ComputeArea();
        string DisplayArea();
        string Name();
    }

    class Circle : IShape
    {
        double area;
        int radius;

        public string Name()
        {
            return "Circle";
        }

        double IShape.ComputeArea()
        {
            Console.Write("Enter radius of Circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = Math.PI * radius * radius;
            return area;
        }

        string IShape.DisplayArea()
        {
            return "Area: " + area;
        }
    }
    class Square : IShape
    {
        double area;
        int length;

        public string Name()
        {
            return "Square";
        }
        double IShape.ComputeArea()
        {
            Console.Write("Enter side length of square: ");
            length = Convert.ToInt32(Console.ReadLine());
            area = length * length;
            return area;
        }

        string IShape.DisplayArea()
        {
            return "Area: " + area;
        }
    }

    class Rectangle : IShape
    {
        double area;
        int length;
        int width;

        public string Name()
        {
            return "Rectangle";
        }
        double IShape.ComputeArea()
        {
            Console.Write("Enter length of rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            return area;
        }

        string IShape.DisplayArea()
        {
            return "Area: " + area;
        }
    }


    class ShapeCalculator
    {
        public void CalculateShape(IShape shapeName) 
        {
            shapeName.ComputeArea();
            Console.WriteLine($"{shapeName.Name()} {shapeName.DisplayArea()}");
        }
    }

    interface ICalculator
    {
        public void Calculate(int FirstValue, int SecondValue);
        public void RenderValue();
    }

    abstract class NumberValues
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
    }

    class Add: ICalculator
    {
        int sum;

        public void Calculate(int FirstValue, int SecondValue)
        {
            sum = FirstValue + SecondValue;
        }

        public void RenderValue()
        {
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }

    class Subtract : ICalculator
    {
        int difference;

        public void Calculate(int FirstValue, int SecondValue)
        {
            difference = FirstValue - SecondValue;
        }

        public void RenderValue()
        {
            Console.WriteLine($"Difference of numbers: {difference}");
        }
    }

    class Multiply : ICalculator
    {
        int product;

        public void Calculate(int FirstValue, int SecondValue)
        {
            product = FirstValue * SecondValue;
        }

        public void RenderValue()
        {
            Console.WriteLine($"Product of numbers: {product}");
        }
    }
    class Divide : ICalculator
    {
        double quotient;
        public void Calculate(int FirstValue, int SecondValue)
        {
            quotient = (double)FirstValue / (double)SecondValue;
        }

        public void RenderValue()
        {
            Console.WriteLine($"Quotient of numbers: {quotient}");
        }
    }
    class Program
    {
        static void Number1()
        {
            ShapeCalculator circle = new ShapeCalculator();
            IShape Circle = new Circle();
            circle.CalculateShape(Circle);

            ShapeCalculator square = new ShapeCalculator();
            IShape Square = new Square();
            square.CalculateShape(Square);

            ShapeCalculator rectangle = new ShapeCalculator();
            IShape Rectangle = new Rectangle();
            rectangle.CalculateShape(Rectangle);
        }
        static void Number2()
        {
            Console.Write("Enter first number: ");
            int FirstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Add addition = new Add();
            addition.Calculate(FirstValue, secondNumber);
            addition.RenderValue();

            Subtract subtraction = new Subtract();
            subtraction.Calculate(FirstValue, secondNumber);
            subtraction.RenderValue();

            Multiply multiply = new Multiply();
            multiply.Calculate(FirstValue, secondNumber);
            multiply.RenderValue();

            Divide divide = new Divide();
            divide.Calculate(FirstValue, secondNumber);
            divide.RenderValue();
        }
        static void Main(string[] args)
        {
            Number1();
            //Number2();
        }
    }
}
