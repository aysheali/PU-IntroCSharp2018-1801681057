using System;

namespace STD_2B_AysheAli_1801681057_H2_task2
{
    class Program
    {
        static void Main(string[] args) 
        {
            /* The values of the constants in this task are not important. The algorith is what matters. */
            const double speedOfSound = 1225.004; // in km/h
            const long distToSun = 149600000; // in km
            double timeNeeded = Math.Round(distToSun / speedOfSound); // in hours
            // Search in the Internet how to transform hours into years and days.
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double leftoverDays = Math.Floor(((timeNeeded / 8760) - timeNeededInYears) * 365);

            Console.WriteLine($"The time needed to travel form the Earth to the Sin is {timeNeeded} hours, or " + $"{timeNeededInYears} years and {leftoverDays} days.");
           
        }
    }
}
