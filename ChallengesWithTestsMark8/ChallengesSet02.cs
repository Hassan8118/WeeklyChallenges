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

        public bool CountOfElementsIsEven(string[] vals)
        {
          return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
           return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
           return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;

            }
            double Min = numbers.ElementAt(0);
            double Max = numbers.ElementAt(0);
            foreach (double number in numbers) { if (number < Min) Min = number; if (number > Max) Max = number; } return Min + Max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           return str1.Length > str2.Length? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;

            }
            return numbers.Sum(x => x);
        }

        public int SumEvens(int[] numbers)
        {

            if (numbers == null || !numbers.Any())
            {
                return 0;

            }
            
            return numbers.Sum(x => x % 2 == 0 ? x: 0);
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null || !numbers.Any())
            {
                return false;

            }

            return numbers.Sum(x => x)% 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            int count = 0;
            long x = 1;
            while (true)
            {
                if (x < number)
                {
                   if(x%2 == 1) count++;

                }
                else
                {
                    break;
                }
                x++;

            }
            return count;
        }
    }
}
