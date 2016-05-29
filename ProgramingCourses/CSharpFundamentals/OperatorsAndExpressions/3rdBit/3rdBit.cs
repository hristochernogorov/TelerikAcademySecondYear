﻿/*Using bitwise operators, write a program that uses an expression to find the value of the bit 
at index 3 of an unsigned integer read from the console.
The bits are counted from right to left, starting from bit 0.
The result of the expression should be either 1 or 0. Print it on the console.
Input
On the only input line, you will receive a single positive integer - 
the number whose 3rd bit you must print.
Output
Output a single number - 1 or 0 - the value of the 3rd bit, counted from 0 and 
from right to left.
*/
using System;

class Program
{
    static void Main()
    {
        int userNum = int.Parse(Console.ReadLine());
        int threeBit = 3;
        int mask = 1 << threeBit;
        int nandMask = userNum & mask;
        int bit = nandMask >> (threeBit);
        Console.WriteLine("{0}",bit);
    }
}

