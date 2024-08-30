using System;

namespace NattA1_1175_002
{
    internal class EmployeeApp
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("This application performs computations for three types of objects.");
            Console.WriteLine();
            Console.WriteLine("Three (3) tests will be performed, 1 for employee, 1 for commissioned employee and 1 for salaried employees");
            Console.WriteLine();
            Console.WriteLine("Unique characteristics of each employee will be displayed.");
            Console.WriteLine();
            Console.Write("Press any key when you are ready to begin");
            Console.ReadKey();

            //Employee information
            Console.WriteLine("\nEnter information about an employee");
            Console.WriteLine();
            string employeeName = ReceiveString("employee name : ");
            int employeeNumber = ReceiveInt("employee number : ");
            double hourlyPayRate = ReceiveDouble("hourly rate : ");
            string department = ReceiveString("department : ");
            double hoursWorked = ReceiveDouble("# of hours worked : ");

            //Create object employee from class Employee
            Employee employee = new Employee(employeeName, employeeNumber, department, hourlyPayRate, hoursWorked);

            //Display by ToString via WriteLine
            Console.WriteLine(employee);
            Console.WriteLine();

            //Prompy for the next test         
            Console.Write("Press any key to see the next test...");
            Console.ReadKey();

            //Commissioned employee information
            Console.WriteLine("\nEnter information about a commisioned employee");
            string commEmployeeName = ReceiveString("employee name : ");
            int commEmployeeNumber = ReceiveInt("employee number : ");
            double commRate = ReceiveDouble("commission rate : ");
            double commWeeklySales = ReceiveDouble("weekly sales : ");

            //Create object commEmployee from class CommissionedEmployee
            CommissionedEmployee commEmployee = new CommissionedEmployee(commEmployeeName, commEmployeeNumber, commRate, commWeeklySales);

            //Display by ToString via WriteLine
            Console.WriteLine(commEmployee);
            Console.WriteLine();

            //Prompy for the next test
            Console.Write("Press any key to see the next test...");
            Console.ReadKey();

            //Salaried employee information
            Console.WriteLine("\nEnter information about a salaried employee");
            string salEmployeeName = ReceiveString("employee name : ");
            int salEmployeeNumber = ReceiveInt("employee number : ");
            double monthlySalary = ReceiveDouble("monthly salary : ");
            double overtimeHours = ReceiveDouble("overtime hours : ");

            //Create object salEmployee from class SalariedEmployee
            SalariedEmployee salEmployee = new SalariedEmployee(salEmployeeName, salEmployeeNumber, monthlySalary, overtimeHours);

            //Display by ToString via WriteLine
            Console.WriteLine(salEmployee);
            Console.WriteLine();

            //Prompy to exit
            Console.Write("Press any key to exit...");

            //Methods for receiving input values
            string ReceiveString(string stringInfo)
            {
                Console.Write($"Enter {stringInfo}");
                return Console.ReadLine();
            }
            int ReceiveInt(string intInfo)
            {
                Console.Write($"Enter {intInfo}");
                return int.Parse(Console.ReadLine());
            }

            double ReceiveDouble(string doubleInfo)
            {
                Console.Write($"Enter {doubleInfo}");
                return double.Parse(Console.ReadLine());
            }
            //Hole the output screen
            Console.ReadKey();
        }
    }
}