using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20250929_MACHINE_PROBLEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] characters = AssignChars();
            char[] key = AssignPassPhrase(GetPassPhrase(), characters);
            RunProgram(DetermineMode(), key);
            Console.WriteLine();
            Console.ReadKey();
        }

        static string DetermineMode()
        {
            Console.Write("Enter mode (E)ncode or (D)ecode: ");

            while (true)
            {
                string input = Console.ReadLine().ToUpper();

                if (input == "E" || input == "D")
                {
                    if (input == "E")
                    {
                        Console.WriteLine("You chose to Encode.");
                        return "Enode";
                    }
                    
                    else
                    {
                        Console.WriteLine("You chose to Decode.");
                        return "Decode";
                    }
                }

                else
                {
                    Console.Write("Invalid input. Please enter (E)ncode or (D)ecode: ");
                }      
            }
        }

        static string GetPassPhrase()
        {
            Console.Write("Enter your pass phrase: ");
            string passPhrase = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return passPhrase;
        }

        static char[] AssignChars()
        {
            char[] arr = new char[26];
            for (int counter = 65; counter <= 90; counter++)
            {
                arr[counter-65] = (char)counter;
                Console.Write($"    {arr[counter - 65]}");
            }

            Console.WriteLine();

            return arr;
        }

        static char[] AssignPassPhrase(string passPhrase, char[] characters)
        {
            int keyCounter = 0;
            char[] key = new char[26];

            for (int passPhraseCounter = 0; passPhraseCounter < passPhrase.Length; passPhraseCounter++)
            {
                if (!key.Contains(passPhrase[passPhraseCounter]) && passPhrase[passPhraseCounter] != ' ' && characters.Contains(passPhrase[passPhraseCounter]))
                {
                    //Console.WriteLine($"Assigning {passPhrase[passPhraseCounter]} to key[{keyCounter}]");
                    key[keyCounter] = passPhrase[passPhraseCounter];
                    Console.Write($"    {key[keyCounter]}");
                    keyCounter++;
                }

                else
                    Console.WriteLine("No assignment.");
            }

            Console.WriteLine();

            return key;
        }

        static void RunProgram(string mode, char[] key)
        {
            if (mode == "Encode")
            Encode(key);

            else 
            Decode(key);

        }

        static void Encode(char[] key)
        {
            string message = GetMessage();
            char[] characters = AssignChars();
            Console.Write("KEY: ");
            foreach (char letter in message)
            {
                if (characters.Contains(letter))
                {
                  for (int counter = 0, counter < characters.Length, counter++)
                  {
                     if (characters[counter] == letter)
                     {
                        Console.Write(key[counter]);
                        break;
                     }
                  }
                }
            }
        }

        static void Decode(char[] key)
        {
            string message = GetMessage();
        }

        static string GetMessage()
        {
            string message;
            Console.Write("Enter your message: ");
            message = Console.ReadLine();
            return message.ToUpper();
        }

        
    }
}
