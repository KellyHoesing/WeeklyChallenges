using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }
        public bool CharacterIsNotALetter(char c)
        {
            if(Char.IsLetter(c))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num%2!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)    //good
            {                       //good
                return 0;           //good
            }                       //good

            int length = numbers.Count();
            if ( length == 0)
            {
                return 0;
            }

            double? numbersMin = numbers.Min(); //good
            double? numbersMax = numbers.Max(); //good
            double min = (double)numbersMin; //good
            double max = (double)numbersMax; //good
            double total = 0; //good
            total += min; //good
            total += max; //good
            return total; //good
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1= str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int total = 0;
                foreach (var item in numbers)
                {
                    total += item;
                }
                return total;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            List<int> evensList = new List<int>();
            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    evensList.Add(item);
                }
            }
            int sum1=evensList.Sum();
            return sum1;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            {
                if (numbers == null)
                {
                    return false;
                }
                int numberSum = numbers.Sum();
                if(numberSum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddChecker = number / 2;
            if(oddChecker<=0)
            {
                return 0;
            }
            else
            {
                return oddChecker;
            }
        }
    }
}
