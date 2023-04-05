using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Numbers
{
    public class EvenNumbers
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = i * 2;
            }
            return numbers;
        }
    }

    public class OddNumbers
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = i * 2 + 1;
            }
            return numbers;
        }
    }

    public class PrimeNumbers
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            int number = 2;
            int i = 0;
            while (i < count)
            {
                if (IsPrime(number))
                {
                    numbers[i] = number;
                    i++;
                }
                number++;
            }
            return numbers;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }
    }

    public class FibonacciNumbers
    {
        public static int[] Generate(int count)
        {
            int[] numbers = new int[count];
            int previous = 0;
            int current = 1;
            for (int i = 0; i < count; i++)
            {
                numbers[i] = previous;
                int next = previous + current;
                previous = current;
                current = next;
            }
            return numbers;
        }
    }
    internal class cs1
    {
       
            public static void Info()
            {
                int[] primes = PrimeNumbers.Generate(10);
                foreach (int prime in primes)
                {
                    Console.Write(prime + " ");

                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                int[] evenNumbers = EvenNumbers.Generate(10);
                foreach(int even in evenNumbers)
                {
                    Console.Write(even + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                int[] oddNumbers = OddNumbers.Generate(10);
                foreach(int odd in oddNumbers)
                {
                    Console.Write(odd + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                int[] fibonacciNumbers = FibonacciNumbers.Generate(10);
                foreach(int fib in fibonacciNumbers)
                {
                    Console.Write(fib + " ");
                }
                Console.WriteLine(" ");
            }
        

    }

}