using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandParametersAssign11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculation System!");

            // Choose employee type
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            int employeeType = int.Parse(Console.ReadLine());
            // Input values based on employee type
            int workingHours, numWorkingDays, projectHandles, extras;
            Console.Write("Enter Working Hours: ");
            workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Working Days: ");
            numWorkingDays = int.Parse(Console.ReadLine());
            switch (employeeType)
            {
                case 1: // HR
                    projectHandles = 1;
                    extras = 0;
                    break;
                case 2: // Admin
                    Console.Write("Enter Project Handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    extras = 0;
                    break;
                case 3: // Software Developer
                    Console.Write("Enter Project Handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.Write("Enter Extras: ");
                    extras = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid employee type. Exiting...");
                    return;
            }           
            double monthlySalary = CalculateSalary(workingHours, numWorkingDays, projectHandles, extras); // Calculate and display the monthly salary
            Console.WriteLine($"Monthly Salary: ${monthlySalary:F2}");
        }
        // Method to handle salary calculation for all types of employees
        static double CalculateSalary(int workingHours, int numWorkingDays, int projectHandles, int extras)
        {      
            double hourlyRate = 100;// Assuming hourly rate is $100, projectHandles rate is $3000, and extras rate is $2000
            double projectHandlesRate = 3000;
            double extrasRate = 2000;
            double salary = workingHours * numWorkingDays * hourlyRate + projectHandles * projectHandlesRate + extras * extrasRate;
            return salary;
        }
    }
}
