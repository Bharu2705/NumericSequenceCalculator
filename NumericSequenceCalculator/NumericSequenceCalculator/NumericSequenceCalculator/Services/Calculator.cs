using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Services
{
    //S3.1 The following numeric sequences shall be displayed
    public class Calculator
    {

        //S3.1.1 All numbers up to and including the number entered,
        public IEnumerable<int> Sequence(int number)
        {
            return GetNumbers(number);
        }

        //S3.1.2 All odd numbers up to and including the number entered
        public IEnumerable<int> OddSequence(int number)
        {
            return GetNumbers(number).Where(i => i % 2 > 0);
        }

        //S3.1.3 All even numbers up to and including the number entered,
        public IEnumerable<int> EvenSequence(int number)
        {
            return GetNumbers(number).Where(i => i % 2 == 0);
        }

        //S3.1.4 All numbers up to and including the number entered, except when
        public string ConditionalSequence(int number)
        {
            string result = null;

            //S3.1.4.1 A number is a multiple of 3 output C, and when,
            if (number % 3 == 0)
            {
                result = "C";
            }

            //S3.1.4.2 A number is a multiple of 5 output E, and when,
            if (number % 5 == 0)
            {
                result = "E";
            }

            //S3.1.4.3 A number is a multiple of both 3 and 5 output Z,
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                result = "Z";
            }

            //if result is null then return all numbers from first method
            return result;
        }

        //S3.1.5 All fibonacci number up to and including the number entered.
        public IEnumerable<int> FibonacciSequence(int number)
        {
            return Fibonacci().TakeWhile(x => x <= number);
        }


        #region Helpers

        //Fibonacci number generator
        private static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int temp = next;
                next = current + next;
                current = temp;
            }
        }

        //Get all numbers upto and including input
        private List<int> GetNumbers(int number)
        {
            var list = new List<int>();
            for (int i = 0; i <= number; i++)
            {
                list.Add(i);
            }
            return list;
        }

        #endregion
    }
}



//var evenSum = Fibonacci().TakeWhile( x => x < 4000000L )
//            .Where( x => x % 2L == 0L )
//            .Sum();