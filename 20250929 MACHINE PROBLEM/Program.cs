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
            RunProgram(DetermineMode(), key, characters);
            Console.ReadKey();
        }

        /// <summary>
        /// This method determines whether the user wants to encode or decode a message.
        /// </summary>
        /// <returns></returns>
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
                        return "Encode";
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

        /// <summary>
        /// This method gets the pass phrase from the user.
        /// </summary>
        /// <returns></returns>
        static string GetPassPhrase()
        {
            Console.Write("Enter your pass phrase: ");
            string passPhrase = Console.ReadLine().ToUpper();

            return passPhrase;
        }

        /// <summary>
        /// This method assigns the characters A-Z to an array.
        /// </summary>
        /// <returns></returns>
        static char[] AssignChars()
        {
            char[] arr = new char[26];
            for (int counter = 65; counter <= 90; counter++)
            {
                arr[counter - 65] = (char)counter;
                //Console.Write($"    {arr[counter - 65]}");
            }

            return arr;
        }

        /// <summary>
        /// This method assigns the pass phrase to the key array.
        /// </summary>
        /// <param name="passPhrase"></param>
        /// <param name="characters"></param>
        /// <returns></returns>
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
                    //Console.Write($"    {key[keyCounter]}");
                    keyCounter++;
                }

                //else
                //Console.WriteLine("No assignment.");
            }

            foreach (char character in characters)
            {
                if (!key.Contains(character))
                {
                    key[keyCounter] = character;
                    keyCounter++;
                }
            }

            return key;
        }

        /// <summary>
        /// This method runs the program based on the mode chosen by the user.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="key"></param>
        /// <param name="characters"></param>
        static void RunProgram(string mode, char[] key, char[] characters)
        {
            if (mode == "Encode")
                Encode(key, characters);

            else
                Decode(key, characters);

        }

        /// <summary>
        /// This method encodes the message using the key and characters arrays.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="characters"></param>
        static void Encode(char[] key, char[] characters)
        {
            string message = GetMessage();
            OutputKey(key, characters, message);

            //CheckAllArrays(characters, key);
        }

        static void OutputKey(char[] key, char[] characters, string message)
        {
            Console.Write("KEY: ");
            foreach (char letter in message)
            {
                if (characters.Contains(letter))
                {
                    for (int counter = 0; counter < characters.Length; counter++)
                    {
                        if (characters[counter] == letter)
                        {
                            Console.Write(key[counter]);
                            break;
                        }
                    }
                }
                else
                    Console.Write(letter);
            }
        }

        /// <summary>
        /// This method decodes the message using the key and characters arrays.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="characters"></param>
        static void Decode(char[] key, char[] characters)
        {
            string keyCode = GetKey();
            Console.Write("MESSAGE: ");
            OutputMessage(key, characters, keyCode);

            //CheckAllArrays(characters, key);
        }

        static void OutputMessage(char[] key, char[] characters, string keyCode)
        {
            foreach (char letter in keyCode)
            {
                if (key.Contains(letter))
                {
                    for (int counter = 0; counter < key.Length; counter++)
                    {
                        if (key[counter] == letter)
                        {
                            Console.Write(characters[counter]);
                            break;
                        }
                    }
                }
                else
                    Console.Write(letter);
            }
        }

        /// <summary>
        /// This method gets the message from the user.
        /// </summary>
        /// <returns></returns>
        static string GetMessage()
        {
            string message;
            Console.Write("Enter your message: ");
            message = Console.ReadLine();
            return message.ToUpper();
        }

        /// <summary>
        /// This method gets the key code from the user.
        /// </summary>
        /// <returns></returns>
        static string GetKey()
        {
            string keyCode;
            Console.Write("KEY: ");

            keyCode = Console.ReadLine();
            return keyCode.ToUpper();
        }

        /// <summary>
        /// This method sets the sequence of checking the arrays and groups it for easy calling.
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="key"></param>
        static void CheckAllArrays(char[] characters, char[] key)
        {
            CheckCharacters(characters);
            CheckKey(key);
        }

        /// <summary>
        /// This method is just used for debugging purposes to check the characters array.
        /// </summary>
        /// <param name="characters"></param>
        static void CheckCharacters(char[] characters)
        {
            Console.WriteLine();
            foreach (char letter in characters)
            {
                Console.Write($"    {letter}");
            }
        }

        /// <summary>
        /// This method is just used for debugging purposes to check the key array.
        /// </summary>
        /// <param name="key"></param>
        static void CheckKey(char[] key)
        {
            Console.WriteLine();
            foreach (char letter in key)
            {
                Console.Write($"    {letter}");
            }
        }
    }
}
