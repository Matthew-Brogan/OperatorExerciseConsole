using System;

namespace OperatorExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a whole number value for varible a.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select a whole number value for variable b.");
            int b = int.Parse(Console.ReadLine());
            int quotient = a/b;
            int remainder = a%b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            int addition = Add(a, b);
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            double answer = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {answer}");
            Console.WriteLine($"When added these variables equal {addition}");
            int product = Multiply(a, b);
            Console.WriteLine($"When multiplied these variables equal {product}");
            int quo = Divide(a, b);
            Console.WriteLine($"When divided these two variables equal {quo}");
        }
        public static int Add(int a , int b)
        {
           int sum = a+b;
            return sum;
        }
        public static int Multiply(int a, int b)
        {
            int res = a * b;
            return res;
        }
        public static int Divide(int a , int b)
        {
            int ans = a / b;
            return ans;
        }
        
        
        public static double AreaOfCircle(double radius)
        {
            
            double formula = Math.PI * (radius * radius);
            return formula;
            
           
            
        }



    }
}
