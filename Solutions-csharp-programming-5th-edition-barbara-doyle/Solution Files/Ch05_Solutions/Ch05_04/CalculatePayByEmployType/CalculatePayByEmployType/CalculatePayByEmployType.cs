/* CalculatePayByEmployType
 * This classes tests the Employee
 * class by instantiating objects of the class
 * and using many of the defined properties
 * and methods. It also tests for type of employee 
 * and allows users to input values based on the 
 * type of employee.
 */

using System;
using static System.Console;

namespace CalculatePayByEmployType
{
    class Program
    {
        static void Main( )
        {
            string anEmployeeFirstName,
                   anEmployeeLastName,
                   employeeID,
                   typeOfEmployee;
            double grossSalariedWages = 0,
                   rateOfPay = 0,
                   hours = 0;
            DisplayInstructions();

            anEmployeeFirstName = GetInfo("an employee first name");
            anEmployeeLastName = GetInfo("an employee last name");
            employeeID = GetInfo("the employee identification number");
            typeOfEmployee = GetTypeOfEmployee();

            if (typeOfEmployee == "Salaried")
                grossSalariedWages = GetGrossPay();
            else
            {
                hours = GetHours( );
                rateOfPay = GetRate( );
            }

            Employee oneEmployee = new Employee(employeeID, anEmployeeLastName, anEmployeeFirstName, 
                                                    typeOfEmployee);
            if (typeOfEmployee == "Salaried")
                oneEmployee.GrossSalariedAmount = grossSalariedWages;
            else
            {
                oneEmployee.HoursForHourlyEmployee = hours;
                oneEmployee.RateForHourlyEmployee = rateOfPay;
            }

            DisplayResults(oneEmployee);

            WriteLine("Press any key to see the next test...");
            ReadKey();

            Clear();
            Employee secondEmployee = new Employee("00987", "Hitower", "Alma");
            secondEmployee.TypeWage = "Salaried";
            secondEmployee.GrossSalariedAmount = 5000.00;
            WriteLine("\tSecond Test\n\n");
            WriteLine(secondEmployee);
            ReadKey();
        }

        public static void DisplayInstructions()
        {
            Write("You will be asked to enter the name of an employee" +
                "\nand the type of employee (Hourly or Salaried). " +
                "\n\nCalculations will be performed to " +
                "\ndetermine his/her deductions and take home pay.\n\n");
            WriteLine("Press any key to begin...");
            ReadKey();
            Clear();
        }

        public static string GetInfo(string info)
        {
            Write("Please enter {0}: ", info);
            return (ReadLine());
        }

		public static string GetTypeOfEmployee( )
		{
			string inputValue,
                   empType;

			Write("\nPlease enter an S for salaried employee, \n" +
				            "or an H for hourly employee: ");
			inputValue = ReadLine();
			switch(inputValue )
			{
				case "s":
                case "S":
                    empType = "Salaried";
					break;
				case "h":
                case "H":
                    empType = "Hourly";
					break;
                default:
                    empType = "unknown";
					break;
			}
            return empType;
		}

		public static double GetGrossPay( )
		{
            double gross;
			Write( "\nPlease enter weekly salary: ");
			if (double.TryParse(ReadLine( ), out gross) == false)	
                WriteLine("Invalid Data entered - 0 recorded for gross");
            return gross;
		}

        public static double GetHours( )
		{
            double hours;
			Write( "\nPlease enter hours for the week: ");
			if (double.TryParse(ReadLine( ), out hours) == false)	
                WriteLine("Invalid Data entered - 0 recorded for hours");
            return hours;
		}


        public static double GetRate( )
		{
            double rate;
			Write( "\nPlease enter hourly pay rate: ");
			if (double.TryParse(ReadLine( ), out rate) == false)	
                WriteLine("Invalid Data entered - 0 recorded for rate");
            return rate;
		}

		public static void DisplayResults(Employee person )
		{
            Clear();
            WriteLine("Weekly information for {0} {1}", person.EmployeeFirstName, person.EmployeeLastName);
            WriteLine();
            WriteLine("{0,-25} {1,12:C}",
                "Employee ID: ", person.EmployeeID);
            WriteLine("{0,-25} {1,12:C}",
                "Gross pay: ", person.CalculateGrossPay( ));
            WriteLine("{0,-25} {1,12:C}",
                "Federal tax paid: ", person.CalculateFedTaxPaid());
            WriteLine("{0,-25} {1,12:C}",
                "Social security paid: ", person.CalculateSocSecPaid());
            WriteLine("{0,-25} {1,12:C}",
                "Retirement contribution: ", person.CalculateRetirementPaid());
            WriteLine("{0,-25} {1,12:C}",
                "Total deductions: ", person.CalculateTotalDeductions());
            WriteLine();
            WriteLine("{0,-25} {1,12:C}",
                "Take home pay: ", person.CalculateTakeHomePay());
		  }
        }
    }