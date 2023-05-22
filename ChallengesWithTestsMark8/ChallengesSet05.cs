using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber;
            if (startNumber == 0) { return n; }
            if (startNumber % n == 0) { nextNumber++; }
            while(nextNumber % n != 0) 
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if(b.TotalRevenue <= 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers==null || !numbers.Any())
                return false;
            bool isGreater = true;
            for (int i=0;i<numbers.Length-1;i++)
            {
                if (numbers[i + 1] - numbers[i] < 0)
                {
                    isGreater = false;
                    break;
                }
            }
            return isGreater;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] %2==0)
                {
                    sum = sum + numbers[i+1];
                                    }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || !words.Any()) return "";
            List<string> processed = new List<string>();
            foreach(string s in words){
                processed.Add(s.Trim());
            }
            return string.Join(" ", processed.Where(a=>!a.Trim().Equals(""))) + (words.Where(a => a.Trim() != "").Count() > 0 ? "." : "");
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> ans = new List<double>();
            if (elements == null || !elements.Any()) { return ans.ToArray(); };
            int index = 0;
            
            foreach(double i in elements)
            {
                index++;
                if (index % 4 == 0)
                {
                    ans.Add(i);
                }
            }
            return ans.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool present = false;
            if (nums == null || !nums.Any()) { return false; };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j=0;j<nums.Length;j++)
                {
                    if (i!=j && nums[i] + nums[j] == targetNumber)
                    {
                        present = true;
                        break;
                    }
        }
                        if (present) break;
            }
            return present;
        }

    }
}
