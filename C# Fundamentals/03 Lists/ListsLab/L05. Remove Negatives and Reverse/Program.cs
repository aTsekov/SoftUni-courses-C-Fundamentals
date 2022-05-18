﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace L05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers.RemoveAll(numbers => numbers < 0);
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));

            }



        }
    }
}