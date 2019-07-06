using System;
using System.Text;
using System.Linq;
using System.IO;

namespace ExtensionMethHomeWork
{
    public class Program
    {
        public static void Main()

        {

            Console.WriteLine("---------------------------------------StartsUpperCase-----------------------------------");
            Console.WriteLine("Enter a sentence: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Starts with capital letter : {0} !!!", myString.StartsUpperCase());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", myString.StartsUpperCase().ToString());

            Console.WriteLine("---------------------------------------Pluralize-----------------------------------");
            Console.WriteLine("Enter a word: ");
            string myString1 = Console.ReadLine();
            Console.WriteLine("Pluralize:  {0}", myString1.Pluralize());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", myString1.Pluralize());

            Console.WriteLine("---------------------------------------Capitalize-----------------------------------");
            Console.WriteLine("Enter a word: ");
            string myString2 = Console.ReadLine();
            Console.WriteLine("Capitalize: {0}", myString2.Capitalize());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", myString2.Capitalize());

            Console.WriteLine("---------------------------------------CapitalizeAndPluralize-----------------------------------");
            Console.WriteLine("Enter a word: ");
            string myString3 = Console.ReadLine();
            Console.WriteLine("Capitalize and Pluralize: {0}", myString3.CapitalizeAndPluralize());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", myString3.CapitalizeAndPluralize());

            Console.WriteLine("---------------------------------------CharacterCount-----------------------------------");
            Console.WriteLine("Enter a sentence: ");
            string myString4 = Console.ReadLine();
            Console.WriteLine("Number of characters: {0}", myString4.CharacterCount());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", myString4.CharacterCount().ToString());

            Console.WriteLine("---------------------------------------VAT24-----------------------------------");
            decimal price = 11.15M;
            Console.WriteLine("VAT for the price {1} is {0}", price.VAT24(), price);
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", price.VAT24().ToString());

            int priceInput = 120;
            Console.WriteLine("VAT for the price {0} is {1}", priceInput, priceInput.VAT24());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", priceInput.VAT24().ToString());

            double priceInput2 = 12.15;
            Console.WriteLine("VAT for the price {0} is {1}", priceInput2, priceInput2.VAT24());
            File.AppendAllText(@"D:\Curs NET C#\MyProjecs\HomeWork\Homework\ExtensionMeth\ExtensionMethHomeWork\ExtensionMethHomeWork\Results.txt", priceInput2.VAT24().ToString());
        }
    }

    static class ExtensionsMethods
    {
        //Capital letter
        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool StartsUpperCase(this string str)
        {
            if (str != string.Empty)
            {
                if (str[0] == char.ToUpper(str[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Pluralize
        //Write an extension method that appends an ‘s’ to a string.
        //Ex:
        //input : method
        //output:methods
        public static string Pluralize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append('s');
            return sb.ToString();
        }

        //Capitalize word
        //Write an extension method that will capitalize a word.
        //Input: mom
        //Output: Mom
        public static string Capitalize(this string str)
        {
            if (str != string.Empty)
            {
                char firstChar = str[0];
                firstChar = char.ToUpper(firstChar);
                StringBuilder sb = new StringBuilder();
                sb.Append(firstChar);
                sb.Append(str.Substring(1));
                return sb.ToString();
            }
            else
            {
                return str;
            }
        }

        //Capitalize and pluralize
        //Write a program that will capitalize a string , and pluralize the same string.
        //You cand write a new extension method or use what you already have.
        public static string CapitalizeAndPluralize(this string str)
        {
            return str.Capitalize().Pluralize();
        }

        //Character count
        //Write an extension method what will count the number of characters in a string.
        public static int CharacterCount(this string str)
        {
            return str.Length;
        }

        //Apply VAT
        //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
        public static decimal VAT24(this decimal value)
        {
            return (0.24m * value)+value;
        }
        public static double VAT24(this int value)
        {
            return (0.24 * value) + value;
        }
        public static double VAT24(this double value)
        {
            return (0.24 * value) + value;
        }
    }

}
