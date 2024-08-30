/* PigLatinApp.cs	 
 * This program asks for a string of input.
 * The string is converted into a pseudo Pig Latin format.
 * The results are displayed.
 */
using System;
using static System.Console;

namespace PigLatinApp
{
    class PigLatinApp
    {
        static void Main(string[] args)
        {
            string inputPhrase = "";
            string[] phraseOut;

            DisplayInfo();
            inputPhrase = GetPhrase();
            while (inputPhrase != "")
            {
                WriteLine(" ");
                phraseOut = GetTranslation(inputPhrase);
                DisplayResults(inputPhrase, phraseOut);
                inputPhrase = GetPhrase();
            }
            ReadKey();
        }

        public static void DisplayInfo()
        {
            WriteLine("********************************************************" +
                "\n***    You will be prompted to enter a string of     ***" +
                "\n***    words. The phrase will be converted into a    ***" +
                "\n***    pseudo Pig Latin with results displayed.      ***" +
                "\n\n***    Enter as many strings as you would like.      ***" +
                "\n********************************************************\n\n");
            Write("\n\n\n   Press any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        public static string GetPhrase()
        {
            string inputPhrase;
            WriteLine("Enter a phrase or group of words  " +
                "\nTo Exit, press the Enter key");
            inputPhrase = ReadLine();
            return inputPhrase;
        }

        public static string[] GetTranslation(string phraseIn)
        {
            string first = "";
            string[] phraseOut;
            int numLength = 0;
            phraseOut = phraseIn.Split(' ');
            for (int i = 0; i < phraseOut.Length; i++)
            {
                numLength = phraseOut[i].Length;
                first = phraseOut[i].Remove(1, numLength - 1);
                phraseOut[i] = phraseOut[i].Remove(0, 1);
                phraseOut[i] = phraseOut[i].Insert(numLength - 1, first + "ay");
            }
            return phraseOut;
        }

        public static void DisplayResults(string input, string[] output)
        {
            Clear();
            WriteLine("Original Phrase: " + input + "\n");
            Write("\nNew Phrase: ");
            foreach (string i in output)
            {
                Write(i + " ");
            }
            WriteLine("\n");
        }
    }
}
