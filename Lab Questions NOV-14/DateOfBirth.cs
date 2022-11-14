using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Questions_NOV_14
{
    internal class DateOfBirth
    {

        public string Date { get; set; }
        public DateTime Dob { get; set; }
        private int age;
        private string d;
        private int hours;
        private int days;
        private int weeks;
        private int months;
   


        public void Evaluate()
        {
            int temp1,temp2,temp3,temp4;
            Console.WriteLine("Enter your Date of birth(DD/MM/YYYY)");
            Date = Console.ReadLine();
            Dob = Convert.ToDateTime(Date);

            DateTime now = DateTime.Now;


            age = now.Year - Dob.Year;
            Console.WriteLine($"Years : {age}");
            months = now.Month - Dob.Month;
            temp1 = age * 12 + months;
            Console.WriteLine($"Months : {temp1}");
            weeks = now.DayOfWeek - Dob.DayOfWeek;
            temp2 = (temp1*4) + weeks;
            Console.WriteLine($"Weeks : {temp2}");
            days = now.Day - Dob.Day;
            temp3 = (temp2*7) + days;
            Console.WriteLine($"Days : {temp3}");
            hours = now.Hour - Dob.Hour;
            temp4 = (temp3*24) + hours;
            Console.WriteLine($"Hours : {temp4}");

            if (Dob.Year % 4 == 0)
            {
                Console.WriteLine("The Year of DOB is a Leap year");
            }
            else
            {
                Console.WriteLine("The Year of DOB is not a Leap year");
            }
                 







        }
    }
}
