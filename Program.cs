using System;
using System.IO;
using System.Linq;                  

namespace AnagramChecker
{
    class Anagram
    {
        public bool charsOnly(string firstString, string secondString ){

            //check inputs are letters only
            if (firstString.All(Char.IsLetter) && secondString.All(Char.IsLetter)){
                return true;
            };

            return false;
            
        }
            public bool isAnagram(string firstString, string secondString) {  
                
                //check strings are same length
                if (firstString.Length != secondString.Length) {  
                    return false;  
                } 

                //Convert strings to character arrays  
                char[] firstCharsArray = firstString.ToLower().ToCharArray();  
                char[] secondCharsArray = secondString.ToLower().ToCharArray();  

                //Sort arrays
                Array.Sort(firstCharsArray);  
                Array.Sort(secondCharsArray);  

                //Check each character and position to confirm if an anagram.  
                for (int i = 0; i < firstCharsArray.Length; i++) {  
                    if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString()) {  
                        return false;  
                    }  
                }  
                return true;  
            }  

        public static void outputFile(string firstString, string secondString){

        // Create a string with a line of text.
        string text = firstString + " "+ secondString + Environment.NewLine;

        // Set a variable to the Documents path.
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

        // Write the text to a new file named "Anagram.txt".
        File.WriteAllText(Path.Combine(docPath, "Anagram.txt"), text);
        // Create a string array with the additional lines of text
        string[] lines = { firstString, secondString };

        //Ensure unique values are added to array
        var distinctLines = lines.Distinct().ToArray(); 
        
        //create file if it does not exist, append distinct values if it does
        if (!File.Exists(docPath)){
            
            File.Create(docPath).Close();

            // Append new lines of text to the file
            File.AppendAllLines(Path.Combine(docPath, "Anagram.txt"), distinctLines);

            if (File.Exists(docPath)){
                // Append new lines of text to the file
                File.AppendAllLines(Path.Combine(docPath, "Anagram.txt"), distinctLines);

            }
        }

    }

        public static void Main(string[] args)
        {   

                //initialise variables
                string? firstWord;
                string? secondWord;
    

                //prompt user to create user name
                Console.WriteLine("Welcome to the anagram checker!\n\nPlease enter a user name: ");
                string? userName = Console.ReadLine();

                //prompt user for first text input and read from keyboard
                Console.WriteLine($"Hello {userName}! Please enter your first word: ");
                firstWord = Console.ReadLine();
                
                //prompt user for second text input and read from keyboard
                Console.WriteLine($"\n{userName}, your first word is {firstWord}. Please enter your second word: ");
                secondWord = Console.ReadLine();

                //instantiate anagram object
                Anagram anagram = new Anagram();

                //validate input and iterate until input is letters only
                while (anagram.charsOnly(firstWord, secondWord) == false){
                
                Console.WriteLine("Please enter words without spaces or numbers.");
                Console.WriteLine("Please enter your first word: ");
                firstWord= Console.ReadLine();
                Console.WriteLine("Please enter your second word: ");
                secondWord = Console.ReadLine();

                }

                //Check if words are anagrams and validate letter input
                if (anagram.isAnagram(firstWord, secondWord) && anagram.charsOnly(firstWord,secondWord) == true) {  
                Console.WriteLine($"Yes! {firstWord} and {secondWord} are anagrams.");  
                } 
                    
                else {  
                    Console.WriteLine($"No; {firstWord} and {secondWord} are not anagrams.");  

               
                }  
             //write and append anagrams to file
                outputFile(firstWord, secondWord);      
            
        }
    }
}