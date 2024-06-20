using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] digits = new int[30];
        Random random = new Random();
        int minValueInDigits = 0;
        int maxValueInDigits = 10;
        int positionPerOneDigit = 2;
        int rowForPrintDigits = 0;
        int rowForPrintLokalMax = 1;

        for (int i = 0; i < digits.Length; i++)
            digits[i] = random.Next(minValueInDigits, maxValueInDigits);

        for (int i = 0; i < digits.Length; i++)
        {
            Console.SetCursorPosition(i * positionPerOneDigit, rowForPrintDigits);
            Console.Write(digits[i]);
        }

        if (digits[0] > digits[1])
        {
            Console.SetCursorPosition(0, rowForPrintLokalMax);
            Console.Write(digits[0]);
        }

        for (int i = 1; i < digits.Length - 1; i++)
        {
            if (digits[i] > digits[i + 1] && digits[i] > digits[i - 1])
            {
                Console.SetCursorPosition(i * positionPerOneDigit, rowForPrintLokalMax);
                Console.Write(digits[i]);
            }
        }

        if (digits[digits.Length - 1] > digits[(digits.Length - 1) - 1])
        {
            Console.SetCursorPosition((digits.Length - 1) * positionPerOneDigit, rowForPrintLokalMax);
            Console.Write(digits[(digits.Length - 1)]);
        }

        Console.WriteLine();
    }
}