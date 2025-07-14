using System.Text;

namespace leetcodeEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    //    public class Solution
    //    {
    //        public int LengthOfLastWord(string s)///hello world
    //        {
    //            var count = 0;
    //            for (var i = s.Length - 1; i >= 0; i--)
    //            {
    //                if (s[i] != ' ')
    //                {
    //                    count++;

    //                }
    //               else if (count != 0 && s[i] == ' ')
    //                {
    //                    return count;
    //                }
    //            }
    //            return count;
    //        }
    //    }
    //}

    //    public class Solution
    //    {
    //        public void ReverseString(char[] s)
    //        {
    //            int left = 0;
    //            int right = s.Length - 1;

    //            while (left < right)
    //            {

    //                (s[left], s[right]) = (s[right], s[left]);

    //                left++;
    //                right--;
    //            }
    //        }
    //    }

    //public class Solution
    //{
    //    public bool IsPalindrome(string s)
    //    {
    //        var newS = new StringBuilder();
    //        var newS1 = new StringBuilder();
    //        if (s == " ")
    //        {
    //            return true;
    //        }
    //        for (var i = 0; i < s.Length; i++)
    //        {
    //            if (char.IsLetterOrDigit(s[i]))
    //            {
    //                newS.Append(char.ToLower(s[i]));
    //            }
    //        }
    //        for (var i = newS.Length - 1; i >= 0; i--)
    //        {

    //            newS1.Append(newS[i]);

    //        }
    //        if (newS.ToString() == newS1.ToString())
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}


    //public class Solution
    //{
    //    public bool IsPowerOfTwo(int n)
    //    {
    //        int newI = 1;
    //        if (n ==1)
    //        {
    //            return true;
    //        }
    //        for (var i = 0; i < n; i++)
    //        {
    //            newI *= 2;
    //            if (newI == n)
    //            {
    //                return true;
    //            }
    //        }

    //            return false;

    //    }
    //}


}