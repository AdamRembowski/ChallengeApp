using System;
using System.Globalization;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
char[] digits = { '0' ,'1', '2', '3', '4', '5', '6', '7', '8', '9' };
foreach (var digit in digits)
{
    int finder = 0;
    foreach (var letter in letters)
    {
        if (letter == digit)
        {
            ++finder;
        }
    }
    Console.WriteLine(digit + " => " + finder);
}