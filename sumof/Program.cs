using System;

namespace sumof
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,sum;
            Console.WriteLine("Enter the first number:");
            num1 = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the second number:"); 
            num2 = int.Parse(Console.ReadLine());
            sum = num1+num2;
            Console.WriteLine(sum);

        }
    }
}
