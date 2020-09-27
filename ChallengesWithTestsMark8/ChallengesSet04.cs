using System;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                int shortString1 = str1.Length;
                return shortString1;
            }
            else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                int shortString2 = str2.Length;
                return shortString2;
            }
            else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                int shortString3 = str3.Length;
                return shortString3;
            }
            else
            {
                int shortString4 = str4.Length;
                return shortString4;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if(number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <=0)
            {
                return false;
            }
            else if (sideLength1  + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
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
            double i = 0;
            bool result = double.TryParse(input, out i);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;
            int filled = 0;
            foreach(var obj in objs)
            {
                if(obj == null)
                {
                    counter++;
                }
                else
                {
                    filled++;
                }
            }
            bool majority = false;
            if(counter>filled)
            {
                majority = true;
            }
            else
            {
                majority = false;
            }
            return majority;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            double sum = 0;
            double count = 0;
            foreach(var num in numbers)
            {
                if(num % 2 ==0)
                {
                    sum += num;
                    count++;
                }
            }
            if(count>0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number <= -1)
            {
                throw new ArgumentOutOfRangeException();
            }
            int res = 1;
            while (number != 1)
            {
                res = res * number;
                number = number - 1;
            }
            return res;
        }
    }
}
