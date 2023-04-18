using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    internal class cs2
    {
        static Dictionary<char, string> MorseAlphabet = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"}
        };
        static Dictionary<string, char> ReverseMorseAlphabet = new Dictionary<string, char>();
        static void TranslateToMorseCode()
        {
            Console.Write("Enter a message: ");
            string input = Console.ReadLine().ToLower();
            string output = "";

            foreach (char c in input)
            {
                if (MorseAlphabet.ContainsKey(c))
                {
                    output += MorseAlphabet[c] + " ";
                }
            }

            Console.WriteLine(output);
        }

        static void TranslateFromMorseCode()
        {
            Console.Write("Enter a Morse code message: ");
            string input = Console.ReadLine();
            string output = "";

            string[] words = input.Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string[] letters = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string letter in letters)
                {
                    if (ReverseMorseAlphabet.ContainsKey(letter))
                    {
                        output += ReverseMorseAlphabet[letter];
                    }
                }

                output += " ";
            }

            Console.WriteLine(output);
        }

        public static void Morze()
        {
            foreach (KeyValuePair<char, string> entry in MorseAlphabet)
            {
                ReverseMorseAlphabet[entry.Value] = entry.Key;
            }

            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Translate text to Morse code");
            Console.WriteLine("2. Translate Morse code to text");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TranslateToMorseCode();
                    break;
                case "2":
                    TranslateFromMorseCode();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
