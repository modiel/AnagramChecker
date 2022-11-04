using System;
using System.Linq;                  // provides Linq Collection extension methods
using System.Collections.Generic;   // provides the generic list class


namespace AnagramChecker
{
    class Program
    {
        public static void Main(string[] args)
        {   
     
            //prompt user to create user name
            Console.WriteLine("Welcome to the anagram checker!\n\nPlease enter a user name: ");
            var userName = Console.ReadLine();

            //prompt user for first text input and read from keyboard
            Console.WriteLine($"Hello {userName}! Please enter your first word: ");
            var firstWord = Console.ReadLine();
            
            //prompt user for second text input and read from keyboard
            Console.WriteLine($"\n{userName}, your first word is {firstWord}. Please enter your second word: ");
            var secondWord = Console.ReadLine();

            




        



        

        }
    }
}