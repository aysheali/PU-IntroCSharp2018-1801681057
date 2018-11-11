using System;
using System.IO;
using System.Text;

namespace StudentsWithSmiley
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Read each line of the file into a string array. Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ayse\Desktop\PUhomework\PU-IntroCSharp2018-1801681057\STD2b-AysheAli-1801681057\StudentsNumberSmiley\std-students-2018.txt");
            System.Console.WriteLine("Contents of std-students-2018.txt");
            int StudentsWithSmiley = 0;
            
            foreach(string line in lines)
                {
                string[] elements = line.Split(' ');
                string FirstName = elements[1];
                string SecondName = elements[2];
                string ThirdName = elements[3];
                string name = $"{FirstName} {SecondName} {ThirdName}";
                int sum1 = 0;
                int sum2 = 0;
                int sum3 = 0;
                int sum = 0;

                for (int i = 0; i < FirstName.Length; i++) 
                {
                    sum1 += (int)FirstName[i];
                }
                for (int i = 0; i < SecondName.Length; i++) 
                {                   
                    sum2 += (int)SecondName[i];
                }
                for (int i = 0; i < ThirdName.Length; i++) 
                {                   
                    sum3 += (int) ThirdName[i];
                }
                sum = sum1 + sum2 + sum3;
                
                if (sum>1500)
                {
                    Console.WriteLine($"{FirstName} {SecondName} {ThirdName} {(char)9786}");

                    StudentsWithSmiley += 1;
                }
            }
        }
    }
}
