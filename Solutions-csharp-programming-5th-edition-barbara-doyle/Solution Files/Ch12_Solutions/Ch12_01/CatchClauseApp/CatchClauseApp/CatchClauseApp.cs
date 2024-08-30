/* CatchClauseApp.cs
 * This application throws multiple
 * exceptions - one at a timError.
 * 
 * After testing #1 try clause, comment it out
 *  and uncommment #2, #3, or #4. Repeat the
 * process to see each exception being thrown. 
 * No need to change the catch clauses.
 */
using System;
using static System.Console;

namespace CatchClauseApp
{
    class CatchClauseApp
    {
        static void Main(string[] args)
        {
            try
            {
                // #1: IndexOutOfRangeException will be thrown
                double[] weeklyWages = { 3, 4, 5 };

                WriteLine("Values being displayed from array");
                for (int i = 1; i <= 4; i++)
                {
                    WriteLine("\n\t" + weeklyWages[i]);
                }



                //// #2: FormatException will be thrown
                //int calcResult;

                //for (int i = 1; i <= 4; i++)
                //{
                //    Write("\nEnter a number\n" +
                //        "(or letter to throw an exception): ");
                //    calcResult = 3 * int.Parse(ReadLine());
                //    WriteLine(calcResult.ToString());
                //}



                //// #3: DivideByZeroException will be thrown
                //int input;

                //Write("\n\tEnter a number:\t");
                //input = int.Parse(ReadLine());
                //calcResult = (input / (input - input));
                //WriteLine(calcResult.ToString());



                //// #4: Exception will be thrown
                //short shortInput;

                //Write("\n\tEnter a number greater than 32767: ");
                //shortInput = short.Parse(ReadLine());
                //WriteLine(shortInput.ToString());
            }

            // #1
            catch (IndexOutOfRangeException e)
            {
                Error.WriteLine("\n\nError in loop termination condition.");
                Error.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }

            // #2
            catch (FormatException e)
            {
                Error.WriteLine("\nError in parameter types.");
                Error.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }

            // #3
            catch (ArithmeticException e)
            {
                Error.WriteLine("\nArithmeticException thrown.");
                Error.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }

            // #4
            catch (Exception e)
            {
                Error.WriteLine("\nValue entered exceeds the range of the\n" +
                                "data type designated to store the input.");
                Error.WriteLine("\nException type:\t" + e.Message + "\n\n\n");
            }
            ReadKey();
        }
    }
}
