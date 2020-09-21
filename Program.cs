using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lab_3
{


    class Program
    {
        static void Main(string[] args)
        {
            object[] ListOfAirplanes = new object[6]
            {
                new AirLine(1, "Minsk", 1, 32, "12:30", "Wensday"),
                   new AirLine(2, "Berlin", 2, 34, "12:23", "Sunday"),
                      new AirLine(23, "Moscow", 3, 553, "2:30", "Tuesday"),
                         new AirLine(123, "Washingtone", 4, 644, "8:30", "Wensday"),
                            new AirLine(44, "Minsk", 1, 900, "6:30", "Friday"),
                               new AirLine(132, "Minsk", 3123, 777, "7:30", "Friday")
            };
            AirLine.sizeoff();
            Console.WriteLine("__________________________________");
            Console.WriteLine("Список самолётов до Минска:");
            Console.WriteLine("__________________________________");
            foreach (AirLine Destination in ListOfAirplanes)
            {
                if(Destination.DestinationC == "Minsk")
                {
                   
                    Console.WriteLine(Destination.ID +"\t"+ Destination.DestinationC +"\t" + Destination.TimeC);
                    
                }
            }
            Console.WriteLine("__________________________________");

            Console.WriteLine("\n__________________________________");
            Console.WriteLine("Список самолётов для Понедельника:");
            Console.WriteLine("__________________________________");
            foreach (AirLine DaysOfWeek in ListOfAirplanes)
            {
                if (DaysOfWeek.DaysOfWeekC == "Wensday")
                {

                    Console.WriteLine(DaysOfWeek.ID + "\t" + DaysOfWeek.DestinationC + "\t" + DaysOfWeek.TimeC);

                }
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine(Equals(ListOfAirplanes[0], ListOfAirplanes[1]));
            Console.WriteLine(ListOfAirplanes.Equals(ListOfAirplanes));
            Console.ReadLine();
        }
    }
    
}
