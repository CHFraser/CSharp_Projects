//ciara Fraser
// December 18, 2023
//Creating an array and displaying the average.
using System;
using static System.Console;

namespace CountAboveAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            int[] randomArray = new int[20];
            Random rnd = new Random();
            float higherThanAverage = 0;

            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                randomArray[i] = rnd.Next(1, 11); //between 1 and 10
            }

            //Displaying the array of nubmers
            Write("The numbers are: ");
            for (int i = 0; i < randomArray.Length; i++)
            {
                Write("{0} ", randomArray[i]);
                total += randomArray[i];

                // check if the array element is higher than the average
                
             
            }

            float avgOfArray = total / 20;


            for (int i = 0; i<randomArray.Length; i++) 
            {
                if (randomArray[i] > avgOfArray)
                {
                    higherThanAverage++;
                }
            }
            WriteLine();
            WriteLine("The average is {0:f2}", avgOfArray);
            WriteLine("There are {0} numbers higher than the average", higherThanAverage);
        }
    }
}
