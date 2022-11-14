using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Questions_NOV_14
{
    internal class Flight
    {

        public int FlightFare { get; set; }
        public int Hour { get; set; }
        public int Min { get; set; }
        public string amPm { get; set; }

        private int Time;

        private int FareInc;
        private int Inc;

        public void Enter()
        {
            Console.WriteLine("Enter the Flight Fare :");
            FlightFare = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hour :");
            Hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minutes :");
            Min = int.Parse(Console.ReadLine());
            Console.WriteLine("AM or PM :");
            amPm = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Flight Fare : {FlightFare}");
            Console.WriteLine($"Time : {Hour}:{Min} {amPm}");

            Time = (Hour * 100) + (Min);

            var t = amPm.ToLower();

            if (t.Equals("pm"))
            {
                Time = Time + 1200;
            }
            else if (t.Equals("am"))
            {
                Time = Time + 0;
            }

        }

        public void Check()
        {
            //Console.WriteLine("Hello");

            
            if (Time > 600 && Time < 900)
            { 
                Inc = 10; 
                FareInc = FlightFare + (FlightFare/Inc);
                Console.WriteLine($"Flight Fare increased to {Inc}% : {FareInc}");
            }
            else if (Time > 900 && Time < 1700)
            {
                Inc = 20;
                FareInc = FlightFare + (FlightFare / Inc);
                Console.WriteLine($"Flight Fare increased to {Inc}% : {FareInc}");
            }
            else if (Time > 1700 && Time < 2300)
            {
                Inc = 7;
                FareInc = FlightFare + (FlightFare / Inc);
                Console.WriteLine($"Flight Fare increased to {Inc}% : {FareInc}");
            }
            else if (Time > 2300 || Time < 600)
            {
                Inc = 5;
                FareInc = FlightFare + (FlightFare / Inc);
                Console.WriteLine($"Flight Fare increased to {Inc}% : {FareInc}");
            }


        }





    }
}
