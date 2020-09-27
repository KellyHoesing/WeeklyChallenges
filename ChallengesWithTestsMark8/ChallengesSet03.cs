using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool answer = false ;
            foreach(var item in vals)
            {
                if(item==false)
                {
                    answer = true;
                }
            }
            return answer;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            List<int> odds = new List<int>();
            int sum = 0;
            var answer = true;
            foreach(var number in numbers)
            {
                if(number % 2 !=0)
                {
                    odds.Add(number);
                }
            }
            foreach(var odd in odds)
            {
                sum += odd;
            }
            if(sum % 2 ==0)
            {
                answer = false;
            }
            return answer;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper=password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsNumber = password.Any(char.IsDigit);
            if(containsUpper == true && containsLower == true && containsNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] characters = val.ToCharArray();
            return characters[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] characters = val.ToCharArray();
            var end = characters.Length - 1;
            return characters[end];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var end = nums.Length - 1;
            var first = nums[0];
            var last = nums[end];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsList.Add(i);
                }
            }
            int[] odds = oddsList.ToArray();
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i=0; i<words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
