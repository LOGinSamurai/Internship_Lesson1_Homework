using System;

namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
        * using "if" write a programm that checks whether an integer is greater then zero and even or odd
        * Example:
        * -------------------------------------------------
        * |input   | result                               |
        * |--------|--------------------------------------|
        * |  1     | even                                 |
        * |--------|--------------------------------------|
        * |  2     | odd                                  |
        * |--------|--------------------------------------|
        * | -1     | the value should be greater then zero|
        * -------------------------------------------------
        * 
        */
            //your code here

            if (number >= 0)
            { 
                if (number % 2 == 0)
                { 
                    Console.WriteLine("even"); 
                }
                else 
                {
                    Console.WriteLine("odd"); 
                } 
            } 
            else 
            { 
                Console.WriteLine("the value should be greater then zero"); 
            }
          
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
       * using a ternary operator write a program that print if number divide to 4
       * Example: 
       * --------------------------------------------
       * |input   | result                          |
       * |--------|---------------------------------|
       * |  -4    | The number divide to 4          |
       * |--------|---------------------------------|
       * |   2    | The number doesn't divide to 4  |
       * --------------------------------------------
       */
            //your code here

            Console.WriteLine(string.Concat("The number ", (number % 4 == 0) ? "divide to 4" : "doesn't divide to 4"));
        
        }
        public void DayOfWeek(string day)
        {
                        /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */
                        /* 
                         switch (day)
                         {
                             //your code here
                         }*/

            switch (day.ToLower())
            {
                case "monday" :
                    Console.WriteLine(1);
                    break;
                case "tuesday":
                    Console.WriteLine(2);
                    break;
                case "wednesday":
                    Console.WriteLine(3);
                    break;
                case "thursday":
                    Console.WriteLine(4);
                    break;
                case "friday":
                    Console.WriteLine(5);
                    break;
                case "saturday":
                    Console.WriteLine(6);
                    break;
                case "sunday":
                    Console.WriteLine(7);
                    break;
                default: Console.WriteLine("Srong value! Please give a day of a week");
                    break;
            }

        }
        public void CheckLetterIfVowel(char character)
        {

            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //your code here
            if (Char.IsLetter(character)) //пришлось добавить иф потому что 20 кейсов для согласны писать было бы очень не хорошо :)
            {
                switch (character.ToString().ToLower())
                {
                    case "a":
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case "e":
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case "i":
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case "o":
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case "u":
                        Console.WriteLine(character + " is a vowel");
                        break;
                    default:
                        Console.WriteLine(character + " is a consonant");
                        break;
                }
            }
            else
            { Console.WriteLine(character + " is not a latter"); }

        }

        //перегрузил что бы показать второй вариант
        public void CheckLetterIfVowel(ref char character)
        {

            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            //your code here
            if (Char.IsLetter(character)) 
            {
                if ("aeiou".Contains(character))
                { Console.WriteLine(character + " is a vowel"); }
                else {Console.WriteLine(character + " is consonant"); }
            }
            else
            { Console.WriteLine(character + " is not a latter"); }

        }
        public static void Main(String[] args)
        {
         Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');

        }
    }
}
