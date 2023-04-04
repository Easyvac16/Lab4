using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class cs2
    {
        public static void task_2()
        {
            Console.Write("Введiть рядок з 0 i 1: ");
            string input = Console.ReadLine();

            try
            {
                int result = Convert.ToInt32(input, 2);
                Console.WriteLine($"Введене число в десятковому поданнi: {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введене число не може бути представлене у форматi int.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введений рядок мiстить некоректний формат числа.");
            }
        }
    }
}
