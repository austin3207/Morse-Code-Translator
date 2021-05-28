/*
 * Austin Rogers
 * ITCS - 3112 - 051
 * Assignment 5: Morse Code
 * 5/5/2021
 */
using System;

namespace MorseCodeProject
{
    class Morse
    {
        static void Main(string[] args)
        {
            string[,] morse = new string[36,2];
            //Reads the specified file, might need to change file location
            System.IO.StreamReader file =                   
                new System.IO.StreamReader(@"C:\Users\Austin\source\repos\MorseCodeProject\Morse.txt");
            string temp;
            string letter;  //Stores a character that will be translated
            string code;    //Stores the equivalent in morse code

            //Inserts letter and assigned code to a 2D String array
            //for easy access
            //Based on structure of data in Morse.txt
            for (int i = 0; i < 36; i++)
            {
                temp = file.ReadLine();
                letter = temp.Substring(0, 1);
                code = temp.Substring(2);
                morse[i, 0] = letter;
                morse[i, 1] = code;
            }

            file.Close();

            string sentence;
            string morseSentence;
            while (true) //Loops until Sentinel value of only a 0 is entered.
            {
                Console.WriteLine("Please enter a sentence to be tranlated into Morse code.");
                sentence = Console.ReadLine();
                Console.Clear();          //Cleans up the console
                                          //Can be removed if you want all outputs on the same screen

                //Check for Sentinel Value
                if (sentence.Equals("0"))
                {
                    Console.WriteLine("Thank you for participating.");
                    Console.WriteLine("The translation has now ended.");
                    break;
                }
                else   //Otherwise, attempts to translate the sentence
                {
                    morseSentence = Code.sentToMorse(morse, sentence.ToUpper()); //Converts to Uppercase since there is no differentiation in Morse
                    Console.WriteLine("\nOriginal Sentence: ");
                    Console.ForegroundColor = ConsoleColor.Green;   //Makes the original sentence more visible, can be removed without issue
                    Console.WriteLine(sentence);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nHere is the translated Sentence: ");
                    Console.ForegroundColor = ConsoleColor.Red;     // Emphasizes translated output, can be removed without issue
                    Console.WriteLine(morseSentence);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
