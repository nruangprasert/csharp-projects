/*InputPercentageApp.cs
 * This application accepts any number 
 * monthly sales figures.It totals the values and
 * displays a report showing the original value input 
 * and the percentage it contributes to the total.
 */
using System;
using System.Console;

namespace InputPercentageApp
{
    class InputPercentageApp
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int arraySize;
           
            DisplayInformationAboutApp();
            arraySize = PromptForArraySize();
            double[] inputValues = new double[arraySize];

            GetTheData(inputValues);
            sum = CalculateSum(inputValues);
            DisplayResults(inputValues, sum); 
            ReadKey();
        }



        public static void DisplayInformationAboutApp()
        {
            WriteLine("\t Sales Percentage App" +
                "\n\n***  You will be prompted to enter  monthly sales figures.   ***" +
                "\n***  The values entered will be displayed, along with the    ***" +
                "\n***  percentage of the total contributed by that value.      ***");
            WriteLine("\n\n\nPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        public static int PromptForArraySize()
        {
            string input;
            int size;

            Write("\nEnter how many months of data would you like to input:  ");
            input = ReadLine();
            while (int.TryParse(input, out size) == false)
            {
                WriteLine("Invalid data");
                Write("The count must be numeric -  please re-enter the number: ");
                input = ReadLine();
            }
            return (size);
        }

        public static void GetTheData(double[] inputValues)
        {
            double numInput;

            Clear();
            for (int i = 0; i < inputValues.Length; i++)
            {
                numInput = PromptForNums(i + 1);
                inputValues[i] = numInput;
            }
        }

        public static double PromptForNums(int j)
        {
            string input;
            double numInput;

            Write("Please enter sales figure #{0}:  ", j);
            input = ReadLine();
            while (double.TryParse(input, out numInput) == false)
            {
                WriteLine("Invalid data entered");
                Write("Please re-enter the sales figure#{0}:  ", j);
                input = ReadLine();
            }

            return numInput;
        }

        public static double CalculateSum(double [ ] inputValues)
        {
            double sum = 0;
            foreach (double val in inputValues)
                sum += val;
            return sum;
        }

        public static double GetPercentage(double num, double total)
        {
            return (num * 100.0) / total;
        }

        public static void DisplayResults(double[] array, double total)
        {
            Clear();
            if (total > 0)
            {
                WriteLine("\tIon Realty Sales App\n");
                WriteLine("Total Sales: {0:C}\n\n", total);
                WriteLine("{0,9} {1,16}", "Monthly","% Contributed");
                WriteLine("{0,9} {1,16}\n", "Sales", " to Total");
                foreach (int i in array)
                {
                    WriteLine("{0,9:C} {1,12:F1}%",
                        i, GetPercentage(i, total));
                }
            }
            else
                WriteLine("\nNo values were received.\n\n");
        }
    }
}
