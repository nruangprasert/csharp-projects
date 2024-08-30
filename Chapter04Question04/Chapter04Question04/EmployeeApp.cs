using System;

namespace Chapter04Question04
{
    internal class EmployeeApp
    {
        static void Main(string[] args)
        {
        int employeeNumber = ReceiveInt();
        string firstName = ReceiveString("first name");
        string lastName = ReceiveString("last name");
        string dateOfHire = ReceiveString("date of hire");
        string jobDescription = ReceiveString("job description");
        string department = ReceiveString("department");
        double monthlySalary = ReceiveDouble();

        Employee employee = new Employee(employeeNumber, firstName, lastName, dateOfHire, jobDescription, department, monthlySalary);

        Console.WriteLine(employee.FullName());
        Console.WriteLine(employee.FormattedName());
        Console.WriteLine(employee.ToString());      

            Console.ReadKey();
        }
        static int ReceiveInt()
        {
            Console.Write($"Enter employee number : ");
            return int.Parse( Console.ReadLine() );
        }
        static string ReceiveString(string value) 
        {
            Console.Write($"Enter {value} : ");
            return Console.ReadLine();
        }
        static double ReceiveDouble()
        {
            Console.Write("Enter montly salary : ");
            return double.Parse( Console.ReadLine());
        }
    }
}
