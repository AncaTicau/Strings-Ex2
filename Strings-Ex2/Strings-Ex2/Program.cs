using System;

namespace Strings_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverToUppercaseIfAtLeast2UpperChars("USA is a country comprising 50 states, a federal district, five major self-governing territories, and various possessions.");
            ConverToUppercaseIfAtLeast2UpperChars("U");
            ConverToUppercaseIfAtLeast2UpperChars("aaa");
        }

        //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.

        public static void ConverToUppercaseIfAtLeast2UpperChars(string givenString)
        {
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                if (i >= givenString.Length)
                {
                    break;
                }

                if (givenString[i].ToString() == givenString[i].ToString().ToUpper())
                {
                    count += 1;
                }
            }

            if (count >= 2)
            {
                Console.WriteLine(givenString.ToUpper());
            }
            else
            {
                Console.WriteLine(givenString);
            }
        }

    }

}

