using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace MethodOverloading
{
    class Program
    {
        private static object sum;

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add (decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            return Add(num1, num2, isTrue, sum);
        }

        public static string Add(int num1, int num2, bool isTrue, object sum)
        {
            var sum = 0;
            var response = "";

            if(isTrue)
            {
                
                sum = num1 + num2;

                if (sum == 1)
                {
                    response = $"{sum} dollars.";
                }
                else
                {
                    response = $"{sum} dollar.";
                }
            }

            return response;
        }   
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine();

            Console.WriteLine(Add(-6, 3, true));

            Add(6, -3, true);
        }
    }
}