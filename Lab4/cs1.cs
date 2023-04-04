using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class cs1
    {
        public static void task_1()
        {
            Console.Write("Введiть рядок чисел: ");
            string input = Console.ReadLine();

            try
            {
                int result = int.Parse(input);
                Console.WriteLine($"Введене число: {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введене число не може бути представлене у форматi int.");
            }
            
        }
    }
}
