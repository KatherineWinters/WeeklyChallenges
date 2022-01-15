using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(num => num % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> list = new List<int> { number1, number2, number3, number4 };

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
          biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
            && sideLength1 + sideLength3 > sideLength2
            && sideLength2 + sideLength3 > sideLength1)
            {
            return true;
            }
            else
            {
              return false;
            }
        }

        public bool IsStringANumber(string input)

        {
            return double.TryParse(input, out double i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = objs.Where(x=> x== null).Count();
            var notNullCount = objs.Where(x => x != null).Count();

            if (nullCount > notNullCount)
            { 
                return true;
            }
            else 
            {
              return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double sumOfEvens = 0;
            double countOfEvens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                    countOfEvens++;
                }
            }
            return countOfEvens == 0 ? 0 : sumOfEvens / countOfEvens;
        }

        public int Factorial(int number)
        {
            var answer = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
            //4! = 4 * 3 * 2 * 1
        }

    }
}

