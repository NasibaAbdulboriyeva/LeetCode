using System;

namespace leetcodeEasy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hundredHandler = new HundredsHandler();
            var fiftyHandler = new FiftyHandler();
            var tenHandler = new TenHandler();
            var fiveHandler = new FiveHandler();
            var oneHandler = new OneHandler();
           

            hundredHandler.SetNext(fiftyHandler);
            fiftyHandler.SetNext(tenHandler);
            tenHandler.SetNext(fiveHandler);
            fiveHandler.SetNext(oneHandler);
       

            var result = hundredHandler.Handle(7521);
            //Console.WriteLine(result); 

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



    //public class Solution
    //{
    //    public IList<IList<int>> Combine(int n, int k)
    //    {
    //        IList<IList<int>> result = new List<IList<int>>();
    //        int position = 0;
    //        int[] current = new int[k];
    //        while (0 <= position)
    //        {
    //            current[position]++;
    //            if (n < current[position])
    //            {
    //                position--;
    //            }
    //            else if (position == k - 1)
    //            {
    //                result.Add(current.ToArray());
    //            }
    //            else
    //            {
    //                current[++position] = current[position - 1];
    //            }
    //        }
    //        return result;
    //    }
    //}


    //public class TreeNode
    //  {
    //    public int val;
    //    public TreeNode left;
    //    public TreeNode right;
    //  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    //      {
    //          this.val = val;
    //          this.left = left;
    //          this.right = right;
    //             }
    //}

    //public class Solution
    //{
    //    public string LongestPalindrome(string s)
    //    {
    //        var result = string.Empty;
    //        for (var i = s.Length; i > 0; i--)
    //        {
    //            for (var j = 0; j < s.Length - i; j++)
    //            {
    //                result = s.Substring(j, i);
    //                if (IsPalindrome(result))
    //                {
    //                    return result;
    //                }

    //            }
    //        }
    //        return result;
    //    }
    //    private  bool IsPalindrome(string s)
    //    {
    //        var left = 0;
    //        var right = s.Length - 1;

    //        while (left < right)
    //        {
    //            if (s[left] != s[right])
    //            {
    //                return false;
    //            }
    //            left++;
    //            right--;
    //        }
    //        return true;
    //    }
    //}
    //public class Solution
    //{
    //    public bool IsNumber(string s)
    //    {
    //        s = s.Trim();
    //        bool hasNum = false, hasE = false, hasDot = false;

    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            char c = s[i];

    //            if (char.IsDigit(c))
    //            {
    //                hasNum = true;
    //            }
    //            else if (c == '.')
    //            {
    //                if (hasDot || hasE) return false; // Only one dot, no dot after e
    //                hasDot = true;
    //            }
    //            else if (c == 'e' || c == 'E')
    //            {
    //                if (hasE || !hasNum) return false; // Only one e, must have number before e
    //                hasE = true;
    //                hasNum = false; // Reset for number after e
    //            }
    //            else if (c == '+' || c == '-')
    //            {
    //                if (i != 0 && s[i - 1] != 'e' && s[i - 1] != 'E') return false; // Only at start or after e
    //            }
    //            else
    //            {
    //                return false; // Invalid character
    //            }
    //        }

    //        return hasNum;
    //    }
    //}
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {

            if (n <= 0) return false;
            var i = 1;
            while (true)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    if(n == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
