using System;

namespace revorder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char character1,character2,character3;
            Console.WriteLine("Enter the first character:");
            character1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the second character:");
            character2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the third character:");
            character3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}",character3,character2,character1);

                
           }
        }
    }

