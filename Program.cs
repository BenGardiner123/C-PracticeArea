using System;
<<<<<<< HEAD

namespace C_PracticeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program p1 = new Program();
            System.Console.WriteLine(p1.FibonacciRec(1, 1, 3));
            
        }

         /// <summary>
        /// Returns the nth Fibonacci number
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="numFibs"></param>
        /// <returns></returns>
        public int FibonacciRec(int num1, int num2, int numFibs) {
            if (numFibs > 0) {
                numFibs--;
                num2 = num1 + num2;
                return FibonacciRec(num2, num2 + num1, numFibs);
            }   
            return num2 + num1;
        }
    }
}
=======
using System.Collections.Generic;
using System.Linq;

namespace C_Practice
{
    partial class Program
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
            int counter = 0;
            
            var goOn = false;
            while(!goOn)
            {
                counter++;
                int goOne = rand.Next(1000, 9999);
                string guess = goOne.ToString();
                char[] guessCharArray = guess.ToCharArray(); 
                
                int multipler = rand.Next(2, 8);

                int answer =  goOne * multipler;

                string x = answer.ToString();
                char[] myAnswerArray = x.ToCharArray();
                
                if (myAnswerArray.Length != 4)
                {
                    continue;   
                }
                if (myAnswerArray.Length == 4)
                {
                    
                    Array.Reverse(myAnswerArray);
    
                    if (guessCharArray.SequenceEqual(myAnswerArray))
                    {
                        foreach (var numbers in guessCharArray)
                        {
                            System.Console.Write(numbers);
                        }
                        System.Console.WriteLine(" * " + multipler + " is equal to ");
                        Array.Reverse(myAnswerArray);
                        foreach (var numbers in myAnswerArray)
                        {
                            
                            System.Console.Write(numbers);
                        }
                        goOn = true;
                    }
                
                }
                else
                {
                        foreach (var numbers in guessCharArray)
                        {
                            System.Console.Write(numbers);
                            System.Console.WriteLine("is not equal to");
                        }
                        foreach (var numbers in myAnswerArray)
                        {
                            System.Console.Write(numbers);
                        }
                    Console.WriteLine("  Wrong guess .. trying again...! " + " " + counter);
                    Array.Clear(guessCharArray, 0, guessCharArray.Length);
                    Array.Clear(myAnswerArray, 0, myAnswerArray.Length);
                
                    continue;
                }

               
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



 
>>>>>>> 190b0290b5783da58f7ccd6363944fea1c0f687c
