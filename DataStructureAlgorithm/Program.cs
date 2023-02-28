﻿using System;

namespace DataStructureAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure algorithum");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Permutation of string\n2:Binary search");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Hello, World!");
                    String s = "ABC";
                    String answer = "";
                    Console.Write("\nAll possible strings are : ");
                    PermutationOfString.Permute(s, answer);
                    break;
                case 2:
                    string[] arr = new string[] { "abc", "def", "ghi", "jkl" };
                    Array.Sort(arr);
                    Console.WriteLine("The elements of Sorted Array");
                    BinarySearch.display(arr);
                    object s1 = "mno";
                    BinarySearch.result(arr, s1);
                    object s2 = "def";
                    BinarySearch.result(arr, s2);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}