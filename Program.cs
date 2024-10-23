using Static_class__Extensions_methods;
using System;

namespace ExtensionMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"{num} tek: {num.IsOdd()}");
            Console.WriteLine($"{num} cut: {num.IsEven()}");


            string str = "menmektebem97";
            Console.WriteLine($"'{str}' reqem var: {str.HasDigit()}");

            string password = "Parol1";
            Console.WriteLine($"Password: '{password}' is correct: {password.CheckPassword()}");

        }
    }
}
