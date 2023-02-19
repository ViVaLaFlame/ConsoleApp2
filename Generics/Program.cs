﻿namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1; 
            double b = 5.3;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");


            Console.WriteLine("\n");

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref str1 , ref str2);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");

            int result = Foo<int>();

        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>()
        {
            return default(T);
           

        } 
    }
}