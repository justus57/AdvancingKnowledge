using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancingKnowledge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forloop();
            Fibonacciseries();
        }

        private static void Fibonacciseries()
        {
            int number, number1 = 0, number2 = 1, temp;
            Console.Write("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1)
            {
                Console.Write($"{number1} {number2}");
                temp = number1 + number2;
                for (; temp <= number;)
                {
                    Console.Write($" {temp}");
                    number1 = number2;
                    number2 = temp;
                    temp = number1 + number2;
                }
            }
            else
                Console.WriteLine("please enter a number greater than zero");
            Console.ReadKey();
        }

        private static void forloop()
        {
            for (int i = 1; i <= 5; i++) //Outer For Loop
            {
                Console.WriteLine($"Outer For Loop : {i}");
                for (int j = 1; j <= 10; j++) //Inner For Loop
                {
                    Console.Write($" {j}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
