using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame
{
    class program
    {
        public static void mm()
        {
            int minNumber = 1;
            int maxNumber = 100;
            int secretNumber;

            Random random = new Random();
            secretNumber = random.Next(minNumber, maxNumber + 1);

            Console.WriteLine($"Вгадайте число в дiапазонi вiд {minNumber} до {maxNumber}.");

            int guess;
            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.Write("Введiть число: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Ви вгадали число!");
                    isGuessed = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загадане число бiльше.");
                }
                else
                {
                    Console.WriteLine("Загадане число менше.");
                }
            }

            
        }

    }
    internal class cs3
    {
        public static void Start()
        {
            program.mm();
        }

    }

}
