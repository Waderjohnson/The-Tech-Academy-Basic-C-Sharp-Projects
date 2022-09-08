using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A one-dimensional array of strings
            string[] stringList = { "hello ", "i see you, ", "do you want to play, " };

            //A WriteLine method that prints to the console with a question asking for some input from the user.
            Console.WriteLine("Please write your name.");

            //Variable that saves the input from the console to memory
            string indexString = Console.ReadLine();

            //a for loop by a counter of i as long as i is less then the count of the list.  
            for (int i = 0; i < stringList.Length; i++)
            {
                stringList[i] = "\n" + stringList[i] + indexString + ".";
            }
            //a foreach loop that iterates through the newly saved array values to print out the strings from the array from each index of the array.
            foreach (string all in stringList)
            {
                Console.WriteLine(all);
            }
            //-------Create an infinite loop------------
            //string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            //for( ; ; )
            //{
            //    Console.WriteLine("Infinite.");
            //}

            //-------Fix an infinite loop----------------
            string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            for (int j = 0; j < infinite.Length; j++)
            {
                Console.WriteLine(infinite[j]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.
            int[] myLoop = { 1, 2, 3, 4, 5 };
            for (int k = 0; k < myLoop.Length; k++)
            {
                Console.WriteLine(myLoop[k]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine(myLoop[l]);
            }
            Console.ReadLine();


            //Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List. 
            //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.


            List<string> mySong = new List<string>();
            List<int> repeatLyrics = new List<int>();

            mySong.Add("Never");
            mySong.Add("gonna");
            mySong.Add("turn");
            mySong.Add("around");
            mySong.Add("and");
            mySong.Add("hurt");
            mySong.Add("you");
            

            Console.WriteLine("Type a word from this sentence to find what index that word is contained at. \"Never gonna turn around and hurt you\"");
            string userWord = Console.ReadLine();

            //----Loop that will look for a word typed by the user in the List------------------------------------------
            foreach (string word in mySong)
            {
                if (word == userWord)
                {
                    Console.WriteLine("The index of " + "\"" + userWord + "\"" + " is: " + mySong.IndexOf(word));
                    break;
                }
            }

            //catches if the user entered a word that is not in the sentence.
            if (mySong.Contains(userWord) == false)
            {
                Console.WriteLine("You did not enter a word from the sentence.");
            }
            Console.ReadLine();


            //Create a List of strings that has at least two identical strings in the List.
            //Ask the user to select text to search for in the List. Create a loop that iterates through the loop and then
            //displays the indices of the array that contain matching text on the screen.

            
            List<string> myWords = new List<string>();
            myWords.Add("Never");
            myWords.Add("Gonna");
            myWords.Add("give");
            myWords.Add("you");
            myWords.Add("up");
            myWords.Add("never");
            myWords.Add("gonna");
            myWords.Add("let");
            myWords.Add("you");
            myWords.Add("down");

            Console.WriteLine("Please input a word from the below lyrics: ");
            Console.WriteLine("Never Gonna give you up never gonna let you down");
            string userWordLyric = Console.ReadLine();

            //search List mySong to match the users word with a word(s) in the lyrics then print the index of those words.
            for (int i = 0; i < myWords.Count; i++)
            {
                bool songFound = false;
                if (userWordLyric == myWords[i])
                {
                    songFound = true;
                    Console.WriteLine("The index of the lyric is: " + i);
                }
            }

            //if user word is not in the List display error            
            if (myWords.Contains(userWordLyric) == false)
            {
                Console.WriteLine("The word you typed is not in the lyrics.");
            }
            Console.ReadLine();

            //11. Create a list of strings that has at least two identical strings in the List. Create a foreach loop that evaluates
            //each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> nameList = new List<string>();
            List<string> nameRepeat = new List<string>();

            nameList.Add("Sophia");
            nameList.Add("Patrick");
            nameList.Add("Hazel");
            nameList.Add("Alice");
            nameList.Add("Wyatt");
            nameList.Add("Sophia");

            // loop adds a name to the nameRepeat List and then checks to see if the name is already in the list
            foreach (string name in nameList)
            {
                if (nameRepeat.Contains(name))
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("The name " + name + " has already appeared in the list!");
                }
                else
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("This name " + name + " has not appeared in the list yet!");

                }
            }
            Console.ReadLine();
        }
    }
}
