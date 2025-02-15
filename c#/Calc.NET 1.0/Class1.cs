﻿using System;
using System.IO;
using System.Diagnostics;
using System.Runtime;

namespace CalcLIib
{

    public class CalcLIib
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "p":
                    result = Math.Pow(num1, num2);
                    break;
                case "si":
                    result = Math.Sin(num1);
                    break;
                case "c":
                    result = Math.Cos(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
}
