using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || !words.Any())
                return false;
            if (ignoreCase)
            {
                return words.Where(a => a!=null && a.ToLower().Equals(word.ToLower())).Count() > 0;
            }
            else
            {
                return words.Where(a => a!=null && a.Equals(word)).Count() > 0;

            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) { return false; }
            bool prime = true;
            for (int i=2;i<num;i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 0) return -1;
            Dictionary<char, int> count = new Dictionary<char, int> ();
            foreach(char c in str)
            {
                if (count.ContainsKey(c))
                {
                    count[c] = count[c] + 1;
                }
                else
                {
                    count.Add(c, 1);
                }
            }
            char lastUniqueIndex = str[0] ;
            bool present = false;
            for (int i = 0; i < count.Count(); i++) {

                if (count.ElementAt(i).Value == 1)
                {
                    lastUniqueIndex = count.ElementAt(i).Key;
                    present = true;
                                 }
            }
            Console.WriteLine(count);
            if (!present) { return -1; }
                return str.IndexOf(lastUniqueIndex);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || !numbers.Any()) return 0;
            Dictionary<int, int> count = new Dictionary<int, int>();
            for(int i=0;i<numbers.Length-1; i++)
            {
                if (!count.ContainsKey(numbers[i]))
                {
                    count.Add(numbers[i], i);
                }
                int j = i+1;
                while (j < numbers.Length && numbers[j] == numbers[i])
                {
                    count[numbers[i]] = count[numbers[i]] + 1;
                    j++;
                }
            }
            int max = 0;
            for (int i = 0; i < count.Count(); i++)
            {

                if (count.ElementAt(i).Value>max)
                {
                    max = count.ElementAt(i).Value;
                }
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
