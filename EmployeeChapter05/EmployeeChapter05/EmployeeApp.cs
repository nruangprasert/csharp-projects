using System;
namespace EmployeeChapter05
{
    internal class EmployeeApp
    {
        static void Main(string[] args)
        {
            string firstName = ReceiveFirstName();
            string lastName = ReceiveLastName();
            int iD = ReceiveID();
            char type = ReceiveType();
            CreateObject(type, firstName, lastName, iD);
            Console.ReadKey();   
        }
        static void CreateObject(char type, string firstName, string lastName, int iD) 
        {
            if (type == 's' || type == 'S')
            {
                Console.Write("Please enter the salary: ");
                double.TryParse(Console.ReadLine(), out double salaryAmount);
                Employee employee = new Employee(firstName, lastName, iD, type, salaryAmount);
                employee.GrossPay = employee.CalculateS();
                employee.CalculateDeductions(employee.GrossPay, out double federalTax, out double socialSecurity,
            out double retirementContribution, out double totalDeductions, out double takeHomePay);
                employee.FederalTax = federalTax;
                employee.SocialSecurity = socialSecurity;
                employee.RetirementContribution = retirementContribution;
                employee.TotalDeductions = totalDeductions;
                employee.TakeHomePay = takeHomePay;

                Console.WriteLine(employee);
            }
            else if (type == 'h' || type == 'H')
            {
                Console.Write("Please enter hours for the week: ");
                double.TryParse(Console.ReadLine(), out double hoursWorked);
                Console.Write("Please enter hourly pay rate: ");
                double.TryParse(Console.ReadLine(), out double hourlyPayRate);
                Employee employee = new Employee(firstName, lastName, iD, type, hoursWorked, hourlyPayRate);
                employee.GrossPay = employee.CalculateH();
                employee.CalculateDeductions(employee.GrossPay, out double federalTax, out double socialSecurity,
            out double retirementContribution, out double totalDeductions, out double takeHomePay);
                employee.FederalTax = federalTax;
                employee.SocialSecurity = socialSecurity;
                employee.RetirementContribution = retirementContribution;
                employee.TotalDeductions = totalDeductions;
                employee.TakeHomePay = takeHomePay;

                Console.WriteLine(employee);
            }
        }
    static string ReceiveFirstName() 
        {
            Console.Write("Please enter an employee first name: ");
            return Console.ReadLine();
        }
        static string ReceiveLastName()
        {
            Console.Write("Please enter an employee last name: ");
            return Console.ReadLine();
        }
        static int ReceiveID()
        {
            Console.Write("Please enter the employee identification number: ");
            int.TryParse(Console.ReadLine(), out int empID);
            return empID;
        }
        static char ReceiveType()
        {
            Console.Write("Please enter an S for salaried employee,or an H for hourly employee: ");
            char.TryParse(Console.ReadLine(), out char empType);
            return empType;
        }

    }
}
