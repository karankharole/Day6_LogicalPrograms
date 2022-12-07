﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograms
{
    internal class Day6Problems
    {

        public void Reverse_Number()
        {
            Console.WriteLine("\n");
            int n, reverse = 0, rem;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
