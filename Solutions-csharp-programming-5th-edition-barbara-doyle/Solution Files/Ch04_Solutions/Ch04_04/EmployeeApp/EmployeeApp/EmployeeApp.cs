/* EmployeeApp.cs
 * This class tests the Employee class,
 * calling constructor methods to instantiate
 * objects, using properties to set values and
 * displaying object's data through invoking the
 * ToString( ) method. 
 */

using System;
using static System.Console;

namespace EmployeeApp
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            Employee firstEmployeeObject = new Employee();
            firstEmployeeObject.EmployeeFirstName = AskForEmployeeName("First");
            firstEmployeeObject.EmployeeLastName = AskForEmployeeName("Last");
            firstEmployeeObject.EmployeeNumber = AskForEmployeeNumber();
            firstEmployeeObject.DateOfHire =
                AskForDateOfHire(firstEmployeeObject.ReturnFullName( ));
            firstEmployeeObject.Salary = AskForSalary();
            firstEmployeeObject.JobDescription = AskForJobDescription();
            firstEmployeeObject.Department = AskForDepartment();
            
            Clear();
            WriteLine("\tFirst Test");
            WriteLine(firstEmployeeObject.ToString());


            Employee secondEmployeeObject = new Employee("C-2345");
            secondEmployeeObject.Salary = 95000;
            
            WriteLine("\n\n\tSecond Test");
            WriteLine("Employee Number: " + secondEmployeeObject.EmployeeNumber +
                               "\nSalary: {0:c}", secondEmployeeObject.Salary);
            
            

            Employee thirdEmployeeObject = new Employee("C-2234", "Timothy Walnut", "01/01/2009");
            thirdEmployeeObject.Salary = 75000;
            thirdEmployeeObject.Department = "Information Technology";
            thirdEmployeeObject.JobDescription = "C# Programmer Analyst";
            WriteLine("\n\n\tThird Test");
            WriteLine(thirdEmployeeObject);


            Employee lastEmployeeObject = new Employee("A-2334", "Maria", "Smith", "01/01/2008", 60000);
            WriteLine("\n\n\tAnother Test");
            WriteLine("Employee Name: " + lastEmployeeObject.EmployeeFirstName + " " + lastEmployeeObject.EmployeeLastName  +
                              "\nEmployee Number: " + lastEmployeeObject.EmployeeNumber +
                              "\nDateOfHire: " + lastEmployeeObject.DateOfHire +
                              "\nSalary: " + lastEmployeeObject.Salary.ToString("C"));

            WriteLine("\n\n\tLast Test");
            WriteLine("Last Employee, shown in Sort order");
            WriteLine("Name: {0}", lastEmployeeObject.ReturnFullNameForSortingPurposes());

            ReadKey();
        }

       static double AskForSalary()
        {
            string inValue;
            double theSalary;
            Write("Enter salary amount: ");
            inValue = ReadLine();
            theSalary = double.Parse(inValue);
            return theSalary;
        }

        static string AskForEmployeeName(string whichPartOfName)
        {
            string inValue;
            Write("Enter Employee {0} Name: ", whichPartOfName);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForDateOfHire(string name)
        {
            string inValue;
            Write("When was {0} Hired? ", name);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForEmployeeNumber()
        {
            string inValue;
            Write("Enter Employee Number: ");
            inValue = ReadLine();
            return(inValue);
        }

        static string AskForDepartment()
        {
            string inValue;
            Write("Enter Employee Department: ");
            inValue = ReadLine();
            return (inValue);
        }

        static string AskForJobDescription()
        {
            string inValue;
            Write("Enter Job Description: ");
            inValue = ReadLine();
            return (inValue);
        }
    }
}
