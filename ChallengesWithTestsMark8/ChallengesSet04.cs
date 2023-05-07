using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            sum += numbers.Where(x => x % 2 == 0).Sum();
            int oddsum = numbers.Where(x => x % 2 != 0).Sum();
            return sum - oddsum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] array = new string[] { str1, str2, str3, str4 };
            int shortest = str1.Length;
            foreach(string s in array)
            {
                if(s.Length < shortest)
                {
                    shortest = s.Length;
                }
            }
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] { number1, number2, number3, number4 };
            int smallest = number1;
            foreach (int i in array)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; 
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            if(input == null || !input.Any())
            {
                return false;
            }
            return input.Replace("-","").Replace(".","").All(char.IsNumber);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(o => o == null).ToArray().Length > objs.Where(o => o != null).ToArray().Length;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int[] evens = numbers.Where(x => x % 2 == 0).ToArray();
            if(evens.Length == 0)
            {
                return 0;
            }
            double result = (1.0*evens.Sum()) / evens.Length;
            return result;
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException(number.ToString());
            }
            int fact = 1;
            while(number > 1)
            {
                fact = fact * number;
                number = number - 1;
            }
            return fact;
        }
    }
}
