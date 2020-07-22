using System;
using System.Collections.Generic;

namespace C_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Please enter you number");
            string userInput = Console.ReadLine();
            
            if (checkUserInput(userInput))
            {
              var newInt = Convert.ToInt16(userInput);
                //factorsOf(newInt);

              primeCalc(newInt);  
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



 
