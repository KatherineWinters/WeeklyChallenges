using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool IsUpper = false;
            bool IsLower = false;
            bool IsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    IsUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    IsLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    IsNumber = true;
                }
            }
                    return IsUpper && IsLower && IsNumber ;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0;i < words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
