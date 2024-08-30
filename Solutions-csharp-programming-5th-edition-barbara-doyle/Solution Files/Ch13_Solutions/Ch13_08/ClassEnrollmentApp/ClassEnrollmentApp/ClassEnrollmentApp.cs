/* ClassEnrollmentApp.cs
 * This program determines the number of students who can still 
 * enroll in a given class. A custom exception class is defined. This 
 * exception is thrown if the current enrollment has more than 
 * three over the maximum enrollment. When this unexpected condition occurs, 
 * the report is halted and a message is displayed indicating which course has the 
 * problem.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  // Added for ArrayList
using System.IO;  // Added for file access

namespace ClassEnrollmentApp
{
    class ClassEnrollmentApp
    {
        static void Main(string[] args)
        {
            StreamReader classEnrollmentData;
            ArrayList className = new ArrayList();
            ArrayList currentEnrollment = new ArrayList();
            ArrayList maxEnrollment = new ArrayList();
            string templine = "";
            int i = 0;

            try
            {
                classEnrollmentData = 
                    new StreamReader("class.txt"); // File stored in bin\debug directory
                do
                {
                    templine = classEnrollmentData.ReadLine();  // Retrieves one class record
                    className.Add(GetData(templine, ref i)); 
                    i++;
                    currentEnrollment.Add(GetData(templine, ref i));
                    i++;
                    maxEnrollment.Add(GetData(templine, ref i));
                    i = 0;
                }while(classEnrollmentData.EndOfStream !=true);

               classEnrollmentData.Close();
               DisplayResults(className, currentEnrollment, maxEnrollment);
            }

            catch (ClassFilledException e)
            {
                Console.WriteLine("\n\nProblem with Course: " + e.CourseName);
                Console.WriteLine("Students Enrolled: " + e.CurrentEnrollment);
                Console.WriteLine("Maximum Allowed: " + e.OverMax);
            }

            catch (Exception e)
            {
                Console.WriteLine("\n\nProblem - " + e.Message);
            }

            finally
            {
                System.Console.WriteLine("\nReport halted!" );
                Console.ReadKey();
            }
		}

        public static string GetData(string templine, ref int i)
        {
            string temporary = "";
            do
            {
                temporary += templine[i];  //Adds one characater at a time to temp
                i++;

            } while (templine[i] != ' ');

            return temporary;
        }

		public static void DisplayResults(ArrayList className, ArrayList current, ArrayList max)
		{
            
                for(int x = 0; x < className.Count; x++)
                {
                    if ( int.Parse(current[x].ToString()) - int.Parse(max[x].ToString()) > 3)
                    {
                        ClassFilledException e = new ClassFilledException
                            ("Class Filled", className[x].ToString(), 
                            int.Parse(current[x].ToString()),
                            int.Parse(max[x].ToString()));
                        throw e;

                    }
                    else
                    {
                        Console.WriteLine("{0} has {1} spots left", className[x], 
                            int.Parse(max[x].ToString()) - int.Parse(current[x].ToString()));
                    }
                }
            }
		}
	}
