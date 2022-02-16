using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the number of Employees to fill data: ");
            int numberOfRegisters = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= numberOfRegisters; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("\tIs an Outsourced Employee (y/n)?: ");
                string isOutsourcedEmployee = (Console.ReadLine().ToLower());
  
                while(true)
                {
                    if(isOutsourcedEmployee == "y" || isOutsourcedEmployee == "n")
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Wrong Choice! Try again...");
                        Console.Write("\tIs an Outsourced Employee (y/n)?: ");
                        isOutsourcedEmployee = (Console.ReadLine().ToLower());
                    }
                }

                if(isOutsourcedEmployee == "y")
                {
                    Console.Write("\tEmployee Name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("\tEmployee Worked Hours (only numbers): ");
                    int employeeWorkedHours = int.Parse(Console.ReadLine());
                    Console.Write("\tEmployee Value per Hour (without $): ");
                    double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("\tEmployee Additional Charge (without $): ");
                    double employeeAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(employeeName, employeeWorkedHours, employeeValuePerHour, employeeAdditionalCharge);

                    employees.Add(employee);
                } else if(isOutsourcedEmployee == "n")
                {
                    Console.Write("\tEmployee Name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("\tEmployee Worked Hours (only numbers): ");
                    int employeeWorkedHours = int.Parse(Console.ReadLine());
                    Console.Write("\tEmployee Value per Hour (without $): ");
                    double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(employeeName, employeeWorkedHours, employeeValuePerHour);

                    employees.Add(employee);
                }
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Resume:");

            foreach(Employee employeeRegister in employees)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee: {employeeRegister.Name} - R$ {employeeRegister.WorkerPayment().ToString("F2")}");
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you! Bye...\n\n");
        }
    }
}
