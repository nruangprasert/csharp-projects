// AccessFileWithRandomNumbers.cs
// This program retrieves 10 lines of 5 numbers per line.
// The largest and smallest value per row are displayed. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccessFileWithRandomNumbers
{
    class AccessFileWithRandomNumbers
    {
        static void Main(string[] args)
        {
            StreamReader numFile;
            int[,] numbers = new int [10,5];

            try
            {
                numFile = new StreamReader("numbers.txt"); //numbers.txt is stored in the bin\debug directory
                RetriveData(numFile, numbers);
                DisplayResults(numbers);
                CloseInFile(numFile);
            }
            catch (Exception exc)
            {
                Console.Write(exc.Message);
            }
            Console.ReadKey();
        }
 
        public static void RetriveData(StreamReader numFile, int[,] numbers)
        {
            string inData;
            int i = 0;
			string[] t = new string[5];
			try
			{
				while((inData = numFile.ReadLine()) != null)
				{
					t = inData.Split(' ');   
					for(int c = 0; c < 5; c++)
					{
						numbers[i,c] = int.Parse(t[c]);  
					}
					i++;       // i represents record 
				}
            }
            catch (Exception exc)
            {
               Console.WriteLine(exc.Message);
            }
        }

        public static void DisplayResults(int[,] numbers)
        {
            string result;
            int max = 0,
                min = 0;
            try
            {
                result = string.Format("{0}{1,13}{2,11}\n{3}{4,12}{4,10}\n{5}\n\n", 
                                        "Row", "Largest", "Smallest", "No.", "Value",
                                        "".PadLeft(30, '-'));
                for (int r = 0; r < numbers.GetLength(0); r++)
                {
                    for (int c = 0; c < numbers.GetLength(1); c++)
                    {
                        if (c == 0)
                        {
                            max = numbers[r, 0];
                            min = numbers[r, 0];
                        }
                        else
                        {
                            if (max < numbers[r, c])
                                max = numbers[r, c];
                            if (min > numbers[r, c])
                                min = numbers[r, c];
                        }
                    }
                    result += string.Format("{0, 3}", (r + 1))
                                   + string.Format("{0, 11}", max.ToString())
                                   + string.Format("{0, 10}", min.ToString())
                                   + "\n";
                }
                Console.WriteLine(result);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Problem - " + exc.Message);
            }
        }

        public static void CloseInFile(StreamReader numFile)
        {
            try
            {
                numFile.Close();
            }
            catch
            {
               Console.WriteLine("Could not close files");
            }
        }
    }
}
