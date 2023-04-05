using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoTextGenerator
{
    class Program
    {
        public static void Gol()
        {
            
            Console.Write("Enter number of vowels: ");
            int vowelsCount = int.Parse(Console.ReadLine());

            Console.Write("Enter number of consonants: ");
            int consonantsCount = int.Parse(Console.ReadLine());

            Console.Write("Enter maximum word length: ");
            int maxWordLength = int.Parse(Console.ReadLine());

            
            PseudoTextGenerator generator = new PseudoTextGenerator();

            
            string pseudoText = generator.Generate(vowelsCount, consonantsCount, maxWordLength);
            Console.WriteLine(pseudoText);

            
        }
    }

    class PseudoTextGenerator
    {
        private const string VOWELS = "aeiouy";
        private const string CONSONANTS = "bcdfghjklmnpqrstvwxz";

        private Random random = new Random();

        public string Generate(int vowelsCount, int consonantsCount, int maxWordLength)
        {
            string pseudoText = "";
            int wordLength;

            for (int i = 0; i < vowelsCount; i++)
            {
                wordLength = random.Next(1, maxWordLength + 1);
                pseudoText += GenerateWord(VOWELS, wordLength) + " ";
            }

            for (int i = 0; i < consonantsCount; i++)
            {
                wordLength = random.Next(1, maxWordLength + 1);
                pseudoText += GenerateWord(CONSONANTS, wordLength) + " ";
            }

            return pseudoText;
        }

        private string GenerateWord(string alphabet, int length)
        {
            string word = "";
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, alphabet.Length);
                word += alphabet[index];
            }
            return word;
        }
    }
    internal class c4
    {
        public static void PsevdoText()
        {
            Program.Gol();
        }
    }
}