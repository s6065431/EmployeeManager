using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursWorked;
            double weeklyWage;
            string empName;
            string empID;

            Console.WriteLine("Please Enter your name");
            empName = Console.ReadLine();

            Console.WriteLine("Please enter your Employee ID");
            empID = Console.ReadLine();


            Console.WriteLine("Please enter your hours worked");
            string input = Console.ReadLine();



            hoursWorked = int.Parse(input);
            if (hoursWorked > 40)
            {
                weeklyWage = 40 * 9.50;
                hoursWorked -= 40;
                weeklyWage += hoursWorked * 14.25;
            }
            else
            {
                weeklyWage = hoursWorked * 9.50;
            }
            Console.WriteLine("Your weekly wage is:  £" + weeklyWage.ToString("F"));
            Console.ReadLine();

            public boolean isValidName(empName);
            {
                if empName.Length
            }
            
        }
    }
}
