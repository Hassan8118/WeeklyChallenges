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
            int count = 0;

            for (int i = 0; i < numbers.Length;i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length;j++)
                {
                    if (numbers[i] == numbers[j])
                    { 
                        currentCount++; 
                    }
                    else 
                    { 
                        break; 
                    } 
                   
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
                
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> newList = new List<double>();
            if (elements == null || n == 0 || n < 0 || n > elements.Count)
            {
                return newList.ToArray();
            }

            for (int i = 0; i < elements.Count; i++) 
            {  
                if (elements[i] % n == 0)
                {
                    newList.Add(elements[i]);   
                }
            
            }
            return newList.ToArray();
        }
    }
}
