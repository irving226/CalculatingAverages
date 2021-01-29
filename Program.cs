using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatingAverages
{
    class Program
    {





        static void Main(string[] args)
        {

            //Sum of numbers 

            int[] numBank = new int[10];

            int x = 0;
            int sum = 0;
            Console.WriteLine("Welcome to the sum of numbers calculator!");

            while (numBank.Length > x)
            {
                numBank[x] = x;
                Console.WriteLine("Please type a number between 1-100");
                int newValue = int.Parse(Console.ReadLine());
                if (newValue >= 0 && newValue <= 100)
                {
                    numBank[x] = newValue;
                    sum += numBank[x];
                    x++;

                    Console.WriteLine($"{x} out of 10");
                }
                else
                {
                    Console.WriteLine("That is not a valid number, please try again.");
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", numBank));
            Console.WriteLine($"The sum of these numbers is {sum}");

            //Average ten scores

            Console.WriteLine("Let's make a test bank.");
            int[] testBank = new int[10];
            int testSum = 0;

            for (int i = 0; i < testBank.Length; i++)
            {
                Console.WriteLine("Enter a grade");
                int newValue = int.Parse(Console.ReadLine());

                if (newValue >= 0 && newValue <= 100)
                {
                    testBank[i] = newValue;
                    testSum += testBank[i];

                    Console.WriteLine($"{i + 1} out of 10");

                }
                else Console.WriteLine("That is an incorrect number, please try again");

            }


            int average = testSum / testBank.Length;

            Console.WriteLine("[{0}]", string.Join(",", testBank));
            Console.WriteLine($"The average of these grades is {average}");

            if (average >= 0 && average <= 59)
            {
                Console.WriteLine($"Average GPA: F");

            }
            else if (average >= 60 && average < 69)
            {
                Console.WriteLine("Average GPA: D");
            }
            else if (average >= 70 && average < 79)
            {
                Console.WriteLine("Average GPA: C");
            }
            else if (average >= 80 && average < 89)
            {
                Console.WriteLine("Average GPA: B");
            }
            else Console.WriteLine("Average GPA: A");

            testBank.Sum();


            //av. a specific number of scores
            Console.WriteLine("How many numbers would you like to add to a new test bank?");
            int userDefinedNum = int.Parse(Console.ReadLine());
            int a = 0;
            int total = 0;
            int[] userBank = new int[userDefinedNum];
            if (userDefinedNum > 0)
            {

                while (userBank.Length > a)
                {
                    userBank[a] = a;
                    Console.WriteLine("Please add a number between 1-100");
                    int userValue = int.Parse(Console.ReadLine());
                    if (userValue >= 0 && userValue <= 100)
                    {
                        userBank[a] = userValue;
                        total += userBank[a];
                        a++;

                        Console.WriteLine($"{a} out of {userDefinedNum}");
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number, please try again.");
                    }

                }
                int userDefinedAverage = total / userBank.Length;
                Console.WriteLine("[{0}]", string.Join(",", userBank));
                Console.WriteLine($"The average of these grades is {userDefinedAverage}");

                if (userDefinedAverage >= 0 && userDefinedAverage <= 59)
                {
                    Console.WriteLine($"Average GPA: F");

                }
                else if (userDefinedAverage >= 60 && userDefinedAverage < 69)
                {
                    Console.WriteLine("Average GPA: D");
                }
                else if (userDefinedAverage >= 70 && userDefinedAverage < 79)
                {
                    Console.WriteLine("Average GPA: C");
                }
                else if (userDefinedAverage >= 80 && userDefinedAverage < 89)
                {
                    Console.WriteLine("Average GPA: B");
                }
                else Console.WriteLine("Average GPA: A");

            }
            else Console.WriteLine("Invalid Number");

           

          
                 Console.WriteLine("Enter a number:");
                 int firstInput = int.Parse(Console.ReadLine());
                 List<int> listBank = new List<int>();
                 listBank.Add(firstInput);
                 Console.WriteLine("Would you like to Enter another? (Y/N)");
                 string answer = Console.ReadLine();
                 if (answer == "Y" || answer == "y" || answer == "N" || answer == "n")
                 {
                     while (answer != "N" || answer != "n")
                     {
                         if (answer == "Y" || answer == "y")
                         {
                             Console.WriteLine("Enter a number:");
                             int collector = int.Parse(Console.ReadLine());
                             if (collector >= 0 && collector <= 100)
                             {
                                 listBank.Add(collector);
                             }
                             Console.WriteLine("Would you like to enter another? (Y/N)");
                             answer = Console.ReadLine();
                         }
                         else if (answer == "N" || answer =="n")
                         {
                             int tally = listBank.Sum();
                             int totalNums = listBank.Count;
                             int totalAverage = tally / totalNums;
                             Console.WriteLine($"You've entered {totalNums} numbers. Their average is { totalAverage}");
                             return;
                         }
                         else

                             Console.WriteLine("Invalid reponse, please try again.");
                             
                            continue;



                     }
                 }
                 else
                 {

                     Console.WriteLine("Invalid reponse, please try again.");

               
                 }
                

            }
        }

    }

