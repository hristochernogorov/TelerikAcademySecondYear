﻿//Description
//Write a method that reverses the digits of a given decimal number.
//Input
//On the first line you will receive a number
//Output
//Print the given number with reversed digits
//Constraints
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//256	652
//123.45	54.321

using System;

class ReverseNumber
{
    static string Reverse(string number)
    {
        string reversedNumberAsString = null;
        for (int i = number.Length -1; i > -1; i--)
        {
            reversedNumberAsString += number[i];
        }
        return reversedNumberAsString;
    }

    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(Reverse(number));
    }
}

