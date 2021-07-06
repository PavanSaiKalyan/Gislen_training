using System;

namespace comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            double num1,num2;
            Console.WriteLine("Enter first string:");
            str1 = Console.ReadLine();
            Console.WriteLine("enter second string:");
            str2 = Console.ReadLine();
            if(str1 == str2){
                Console.WriteLine("Those are same things");

            }
            else {
                Console.WriteLine("They are not the same");

            } 
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            if(num1==num2){
                Console.WriteLine("num1 and num2 are equal");
            }
            else {
                Console.WriteLine("num1 and num2 are no equal");

            }
            if ((num1 == num2) && (str1==str2)){
                Console.WriteLine("Both numbers are equal and both the strings are equal");
            }
            else if ((num1!=num2) && (str1==str2))
            {
                Console.WriteLine("Numbers and strings given are not the same ");
            
            }
            else if ((num1==num2) && (str1!=str2)){
                Console.WriteLine("Numbers are equal strings are not");
            }
            else 
                Console.WriteLine("Numbers are not equal but strings are equal");
            
            

                
           

            
        
              
        }
    }
}
