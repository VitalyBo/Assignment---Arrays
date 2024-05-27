using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/*This assignment solidifies your understanding of arrays in C#. You'll create a program that:

Takes user input to determine the size of an integer array.
Populates the array with random numbers within a specified range.
Calculates the sum, average, largest element, smallest element, and counts even and odd numbers.
Displays the array neatly on a single line.
Displays the calculated results to the user.*/

namespace Сonsole
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] assignmentArray;
            bool condition = true;
            Console.WriteLine("\nVitalii Bobyr - 05/27/24");
            Console.WriteLine("Programming 120 - Assignment - Arrays");
            start:
            while (condition) 
            { 
             Console.OutputEncoding = Encoding.Unicode;
             Console.Write("Lets create some array! \nPut some number which will be array size: ");
             int arraySize = int.Parse(Console.ReadLine());
             assignmentArray = new int[arraySize];

                Console.WriteLine("Right now using Random we will fill out and print that array!\n");
                       
                Random random = new Random();

               for (int i = 0; i<arraySize; i++)
               {
                assignmentArray[i] = random.Next(50, 208);// Random numbers between 1 and 100
                Console.Write($" {assignmentArray[i]}");
               }
            menu:
                Console.WriteLine("\n");
                Console.WriteLine("Choose next action: \n1.Sum\n2.Average\n3.Largest Element\n4.Smallest Element\n5.Even/Odd Count\n6.Exit");
                string choice;
                choice = Console.ReadLine().ToLower();

                try
                {

                
                    
                  switch (choice)
                  {
                    case "1":
                            Console.WriteLine("Sum");
                            int sum = 0;
                            for (int i = 0; i < arraySize; i++)
                            { sum += assignmentArray[i];}
                            Console.WriteLine($"Sum of that array: {sum}");
                            goto menu;

                        case "2":
                            Console.WriteLine("Average");
                            double sum_1 = 0;
                            int count = 0;
                            for (int i = 0; i < arraySize; i++)
                            { 
                                sum_1 += assignmentArray[i]; 
                                count++;
                            }
                            double aver = sum_1/count;
                            Console.WriteLine($"Average of that array: {aver}");
                            goto menu;

                        case "3":
                            Console.WriteLine("Largest Element");
                            int larg = 0;
                            for (int i = 0; i < arraySize; i++)
                            {
                                if (assignmentArray[i] > larg) { larg = assignmentArray[i]; }
                            }
                            Console.WriteLine($"Largest Element of that array: {larg}");
                            goto menu;

                        case "4":
                            Console.WriteLine("Smallest Element");
                            int small = assignmentArray[0];
                            for (int i = 0; i < arraySize; i++)
                            {
                                if (assignmentArray[i] < small) { small = assignmentArray[i]; }
                            }
                            Console.WriteLine($"Smallest Element of that array: {small}");
                            goto menu;

                        case "5":
                            Console.WriteLine("Even/Odd Count");
                            for (int i = 0; i < arraySize; i++)
                            {
                                if (assignmentArray[i]%2 == 0) 
                                { Console.WriteLine($"{assignmentArray[i]} is EVEN "); }
                                else { Console.WriteLine($"{assignmentArray[i]} is ODD"); }
                            }
                            goto menu;

                        case "6":
                            Console.WriteLine("Exit from progarm");
                            condition = false;
                            break;
                  }
                }
                catch 
                {
                    Console.WriteLine("Something going wrong! Please try again!");
                    goto start;
                };





            }
        }
    }
}

