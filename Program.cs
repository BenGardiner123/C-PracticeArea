﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ///prime numbers and factors homework
           /*  System.Console.WriteLine("Please enter you number");
            string userInput = Console.ReadLine();
            
            if (checkUserInput(userInput))
            {
              var newInt = Convert.ToInt16(userInput);
                //factorsOf(newInt);

              primeCalc(newInt);  
            } */
            
           ///.!---.!---.!---.!---.!---.!---.!---.!---.!---.!---.!---.!---.!---
            //SECOND HOMEWORK TASK - Problem 3 - ABCD * E == DCBA
            /* A, B, C, D, E represent digits.
            Write a program to find the values for A, B, C, D, E that makes the statement "ABCD * E = DCBA" true.
            Each digit must be unique. Each digit must be a value from 0 - 9. There is one valid solution.
            */

           equationcheck();




        }

        public static void equationcheck()
        {
            var rand = new Random();
            var guesChecker = new List<string>();
            var answerChecker = new List<string>();
            
            int goOne = rand.Next(1000, 9999);
            string guess = goOne.ToString();
            guesChecker.Add(guess);
            
            int multipler = rand.Next(1, 9);

            int answer =  goOne * multipler;

            string x = answer.ToString();
            answerChecker.Add(x);
            
            if (x.Length == 4)
            {
                string [] reversedAnswer = answerChecker.ToArray();
                
            }


        }


        public static void primeCalc(int userInput)
        {
            Console.WriteLine("2");

            for (int i = 3; i <= userInput + 1; i++)
            {
                if(isPrime(i))
                {
                    Console.WriteLine(i);
                }
                    
            }

        }
    
   
        public static bool isPrime(int number)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        

        static void factorsOf(int target)
        {
            var factors = new List<int>();
            double limit = Math.Sqrt(target);
            
            
            for (int i = 2; i <= target; i++)
            {
                var result = target % i == 0;

                if (result)
                {
                    factors.Add(i);
                }
                else
                {
                    continue;
                }
                
            }
            
            foreach (var nums in factors)
            {   

                Console.WriteLine(nums);
            }
        }

            

        static bool checkUserInput(string userInput)
        {
            bool goOn = false; // exit value for my while loop
            int validInput = 0;
            

                while (!goOn)
                {
                    

                    if (int.TryParse(userInput, out validInput))
                    {
                        if (validInput >= 0) 
                        {
                            goOn = true;
                        }    
                        else 
                        {
                            Console.WriteLine (  " Only numbers please " + " Please choose a number from the menu.. try again");
                        }

                    }
                    else
                    {
                        Console.WriteLine(" .... really? " + " Please enter just a number.. no words .. try again"); /// again thsi catches the non - numercial input.
                    }
                    

                }

            return true;
        }  
    }
    
}



 
