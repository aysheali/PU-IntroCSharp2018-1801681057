using System;

namespace STD_2B_AysheAli_1801681057_H2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7-digit number:");
            int number = int.Parse(Console.ReadLine());

            //Chek if the input number has 7 digits
            if (number < 1000000 || number > 9999999)
            {
                //if it hasn't, display a suitable massage
                Console.WriteLine("The number you entered is not a 7-digit number!");
            }
            else
            {
                /* If it has, find the fourth digit. you can search the Internet for another and better algorithm for finding the 4th digit. */
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The 4th digit of {number} is {fourthDigit}");


            }
        }  
    }
}
