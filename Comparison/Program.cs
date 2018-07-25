using System;

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 details:
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            string Rate1 = Console.ReadLine();
            decimal HourlyRate1 = Convert.ToDecimal(Rate1);
            Console.WriteLine("How many hours do you work each week?");
            string Hour1 = Console.ReadLine();
            decimal WorkHours1 = Convert.ToDecimal(Hour1);
            decimal Annual1 = HourlyRate1 * WorkHours1 * 52;
            int AnnualSalary1 = Convert.ToInt32(Annual1);

            //Person 2 details:
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            string Rate2 = Console.ReadLine();
            decimal HourlyRate2 = Convert.ToDecimal(Rate2);
            Console.WriteLine("How many hours do you work each week?");
            string Hour2 = Console.ReadLine();
            decimal WorkHours2 = Convert.ToDecimal(Hour2);
            decimal Annual2 = HourlyRate2 * WorkHours2 * 52;
            int AnnualSalary2 = Convert.ToInt32(Annual2);

            //Comparison:
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(AnnualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(AnnualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (AnnualSalary1 > AnnualSalary2)
                Console.WriteLine("True");
            else
                if (AnnualSalary2 > AnnualSalary1)
                Console.WriteLine("False");
            else
                Console.WriteLine("The salaries are the same.");
            Console.ReadLine();
        }
    }
}
