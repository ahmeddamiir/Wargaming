using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace TaskB
{
    /* --TASK DESCRIPTION--
     given sequence of numbers 1...n and a number x = 3.
     Every round you will remove from the sequence numbers that fulfils following two conditions:
     1. number is divisible by x
     2. number contains digit sum of x

    To get digit sum of number x you keep summing single digits until you get single digit number.
    For example: digit_sum(56) => 5+6 = 11 => 1+1 = 2, Initial value of x = 3.
    Amount of removed numbers will be your x for next round. Game ends when you remove 0 numbers (x==0).
    */
    internal class Program
    {
        public static void Main(string[] args)
        {
            var x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(Test(x, 3));
        }

        public static int[] Test(int[] n, int x)
        {
            var number = new int[n.Length];
            for (int i = 0, j = 0; i < n.Length; i++)
            {
                if (DigitSum(n[i]) != x)
                {
                    number[j] = n[i];
                    j++;
                }
            }

            return number;
        }
        public static int Play(int n, int x)
        {
            // var counter = Math.Floor(Math.Log10(n) + 1); // Number of digits in n
            int number = 0, tmp = 0;
            while (n > 0)
            {
                if (n % 10 == x) n /= 10; // take-off last number of n if matches with x
                else
                {
                    number = number * 10 + n%10; // put the non-matching number
                    n /= 10; // take-off last number of n
                }

            }
            while (number > 0) // Return it in the correct order again
            {
                tmp = tmp * 10 + number%10;
                number /= 10;
            }
            return tmp;
        }

        public static int Divisible(int n, int divider)
        {
            int number = 0, tmp1 = 0;
            while (n > 0)
            {
                var tmp0 = n % 10;
                if (tmp0 % divider == 0) n /= 10; // take-off the number divisible by x
                else
                {
                    tmp1 = tmp1 * 10 + n % 10;
                    n /= 10;
                }
            }

            while (tmp1 > 0)
            {
                number = number * 10 + tmp1 % 10;
                tmp1 /= 10;
            }

            return number;
        }

        public static int DigitSum(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var tmp = n % 10;
                sum += tmp;
                n /= 10;
            }
            
            return sum;
        }

        // NOTICE -> I though that this function would be useful xD
        public static int DigitsCounter(int number)
        {
            if (number == 0) return 1; // number = 1 edge case
        
            int tmp = 0, result = 0;
            while(number > 0)
            {
                result++;
                number /= 10;
            }
            return result;
        } 
        /* !NOTICE -> I can traverse through the sequence using Modulus operator and division for getting each number
         * from the end of the sequence but that would take too much algorithms, so I decided to transform the sequence
         * to a string (array of characters) to make it easier traversing over it but, that may cost slightly more time.
         * --EDIT-- I didn't use function because I found that traversing without changing (int) to (str) saves more time 
         */
        public static int PlayString(int n, int x)
        {
            var number = n.ToString();
            
            for (var i = 0; i < number.Length; i++)
            {
                // Remove the number from the string
                /*
                if (number[i] == Convert.ToChar(x))
                    number = number.Remove(i, 1);
                */
                if (number[i].ToString() == x.ToString())
                {
                    number = number.Replace(n.ToString(), string.Empty);
                }
            }

            return Convert.ToInt32(number);
        }
    }
}