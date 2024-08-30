using System;
using static System.Console;

namespace CalcAveWithTryCatch
{
    class CalcAveWithTryCatch
    {
        static void Main(string[] args)
        {

            bool moreData = true;
            double average = 0;
            int[] numArray = new int[100]; ;
            int numScores = 0;
            char grade;
            try
            {
                DisplayInfo();
                moreData = AsKIfWantToInputDataSet(); 
                while (moreData)
                {
                    numScores = InputNumbers(numArray);
                    Write("NumScore = " + numScores);
                    average = CalculateAverage(numArray, numScores);
                    grade = DetermineLetterGrade(average);
                    DisplayResults(numScores, average, grade);
                    moreData = AsKIfWantToInputDataSet();
                }
                WriteLine("\n\n\nTerminated Normally");
            }

            catch (FormatException ex)
            {
                Error.WriteLine("\n\tError in parameter types.");
                Error.WriteLine("\n\tException type:\t" + ex.Message + "\n\n\n");
                Error.WriteLine("\n\tException type:\t" + ex.StackTrace + "\n\n\n");
            }

            catch (DivideByZeroException ex)
            {
                Error.WriteLine("\n\tDenominator within a calculation read as zero.");
                Error.WriteLine("\n\tException type:\t" + ex.Message + "\n\n\n");
            }

            catch (ArrayTypeMismatchException ex)
            {
                Error.WriteLine("\n\tWrong type of data in the scores array.");
                Error.WriteLine("\n\tException type:\t" + ex.Message + "\n\n\n");
            }

            catch (IndexOutOfRangeException ex)
            {
                Error.WriteLine("\n\tIndex out of range.");
                Error.WriteLine("\n\tException type:\t" + ex.Message + "\n\n\n");
            }
            catch (Exception ex)
            {
                Error.WriteLine("\n\tValue entered exceeds the range of the\n" +
                                "\tdata type designated to store the input.");
                Error.WriteLine("\n\tException type:\t" + ex.Message + "\n");
            }
            ReadKey();
        }

        static void DisplayInfo()
        {
            WriteLine("\n***   You can be prompted to input scores 0 - 100.        ***" +
                      "\n***   The scores entered will be averaged and a letter    ***" +
                      "\n***   grade assigned. The results will then be displayed. ***" +
                      "\n***   Enter as many sets of scores as you would like.     ***" +
                      "\n\n\n***************   Press any key to begin....    *************");
            ReadKey();
            Clear();
        }

        static bool AsKIfWantToInputDataSet()
        {
            char input;
            bool choice;

            Write("Would you like to enter a set of scores? " +
                  "\nPlease enter 'y' for yes or any other letter for no: ");
            input = char.Parse(ReadLine());
             
            switch (input)
            {
                case 'y':
                case 'Y': choice = true;
                    break;
                default: choice = false;
                    break;
            }

            return choice;
        }

        public static int InputNumbers(int[] numArray)
        {
            int numScores = 0,
                valueEntered;

            valueEntered = GetSingleValue();

            while (valueEntered != -99)
            {
                if (valueEntered > -1)
                {
                    if (valueEntered < 101)
                    {
                        numArray[numScores] = valueEntered;
                        numScores++;
                    }
                    else
                        WriteLine("\nPlease re-enter the score. Value must be less than 100!");
                }
                else
                    WriteLine("\nPlease re-enter the score. Value must be a positive value!");
            valueEntered = GetSingleValue();
            }
            return numScores;
        }

        public static int GetSingleValue()
        {
            string input;
            int valueEntered;

            //Clear();
            Write("\nPlease enter score (0 - 100)" +
                  "\nTO STOP entering scores, enter -99: ");
            input = ReadLine();
            while (int.TryParse(input, out valueEntered) == false)
            {
                WriteLine("Value must be numeric!");
                Write("\nPlease re-enter a score 0 - 100" +
                  "\nEnter -99 to STOP entering scores.");
                input = ReadLine();
            }
            return valueEntered;
        }

        public static double CalculateAverage(int[] numArray, int numScores)
        {
            int total = 0;

            for (int i = 0; i < numScores; i++)
            {
                total += numArray[i];
            }
            return (double)total / numScores;
        }

        public static char DetermineLetterGrade(double average)
        {
            char letter;
            if (average > 89.495)
            {
                letter = 'A';
            }
            else
                if (average > 79.495)
                {
                    letter = 'B';
                }
                else
                    if (average > 69.495)
                    {
                        letter = 'C';
                    }
                    else
                        if (average > 59.495)
                        {
                            letter = 'D';
                        }
                        else
                        {
                            letter = 'F';
                        }

            return letter;
        }

        static void DisplayResults(int numScores, double average, char grade)
        {
            Clear();
            if (numScores > 0)
            {
                WriteLine("Average of the {0} scores entered: {1:F1}" +
                      "\nLetter grade: {2}\n\n\n\n",
                      numScores, average, grade);
            }
            else
                WriteLine("No scores entered.");
        }
    }
}
