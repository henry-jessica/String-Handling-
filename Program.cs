using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
/*******************************************************************************************************
Author  : Jessica Henry                                                                              *  
Lecturer: Kinsella,V.                                                                                *
String Handling                                                                                      *
Date 25/02/2021                                                                                      *
*******************************************************************************************************/

namespace String_Questions
{

    class Program
    {
        static void Main(string[] args)
        {
            string str = " ";

            string choice = " ";
            const string EXIT = "10";

            while (choice != EXIT)
            {
                Console.Clear();
                choice = Menu();
                Console.WriteLine("Enter the string you would like to print the result ");
                str = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "1":
                        PrintChar(str);
                        break;
                    case "2":
                        PrintEveryThirdCharacter(str);
                        break;
                    case "3":
                        MethodCountXandY(str);
                        break;
                    case "4":
                        PrintOutThirdBock(str);
                        break;
                    case "5":
                        Console.WriteLine(CheckStartString(str));
                        break;
                    case "6":
                        StringQuizTesteV2(str);
                        break;
                    case "7":
                        RemoveSpecialChar(str);
                        break;
                    case "8":
                        CheckEnds(str);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, only numbers between 1-10 ");
                        break;
                }

                Thread.Sleep(1500);
            }

        }


        static string Menu()
        {
            string userChoice;

            Console.WriteLine("\n\n ----------|  Menu  |---------");
            Console.WriteLine("1. Display Every Character ");
            Console.WriteLine("2. Display out Every Third Character");
            Console.WriteLine("3. Display numbers of X and Y in the String");
            Console.WriteLine("4. Display a new string made up of every alternate 3");
            Console.WriteLine("5. Display if the String Start with a numeric characters.");
            Console.WriteLine("6. Display a new string with a ‘-‘ as third char");
            Console.WriteLine("7. Display a new string without special characters");
            Console.WriteLine("8. Display if the string ends with .com");
            Console.WriteLine("10. Exit ");

            Console.Write("Please Enter a option: ");
            userChoice = Console.ReadLine();

            return userChoice;
        }
        static private void PrintChar(string word)
        {
            char[] charWord = word.ToCharArray();

            for (int i = 0; i < charWord.Length; i++)
            {
                Console.WriteLine(" {0}", charWord[i]);
            }

            Console.WriteLine("*******using foreach");

            foreach (char c in charWord)
            {
                Console.WriteLine(" {0}", c);
            }

        } //Question 1
        static private void PrintEveryThirdCharacter(string word)
        {

            // var word = "abcdefghijklmnopqrs";

            for (var i = 1; i <= word.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(word[i - 1]);

                }

            }

        } //Question 2
        static private void MethodCountXandY_V2(string word)
        {
            int count = 0;

            char[] charWord = word.ToCharArray();  //double memory useless

            for (int i = 0; i < charWord.Length; i++)
            {
                if (charWord[i] == 'y' || charWord[i] == 'x')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        } //Question 3-V2
        static private void MethodCountXandY(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'y' || word[i] == 'x')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        } //Question 3
        static private void StringQuizTeste(string word) //Question 6
        {
            // Write a method  called InsertDashes that accepts a string variable as an argument and 
            // returns a new string with a ‘-‘ inserted after every third character (e.g. “ 97755512312” will return “977-555-123-12”)

            //  string word = "97755512312";

            StringBuilder x = new StringBuilder(word);

            for (int i = 3; i <= word.Length; i += 4)
            {
                x.Insert(i, '-');
            }

            Console.WriteLine(x);

        }
        static private void StringQuizTesteV2(string word)
        {
            // Write a method  called InsertDashes that accepts a string variable as an argument and 
            // returns a new string with a ‘-‘ inserted after every third character (e.g. “ 97755512312” will return “977-555-123-12”)


            // string word = "97755512312";

            for (int i = 3; i <= word.Length; i += 4)
            {
                word = word.Insert(i, "-");
            }

            Console.WriteLine(word);

        } //Question 6-V2
        static private void RemoveSpecialChar(string input) //Using RegEx
        {
            //string input = "abc$$kh%  gg";
            string pattern = @"(?i)[$%&((¨%$\s]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("String Original: {0}", input);
            Console.WriteLine("String tratada : {0}", result);

        } //Question 7
        static private bool CheckEnds(string word)
        {

            bool checkEndOftheString = word.EndsWith(".com");

            return checkEndOftheString;
        } //Question 8
        static private void CodeMessage(string message)
        {


        } //Question 9
        static private bool CheckStartString(string word)
        {

            return new Regex(@"^[0-9]+").IsMatch(word);

        } //Using RegEx //Question 5
        static private string PrintOutThirdBock(string word) 
        {
            string newString = " ";
            for (int i = 3; i < word.Length; i += 3)
            {
                word = word.Remove(i, 3);
            }

            return newString;
        }  //Quesion 4

    }
}




