﻿namespace leetcodeEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

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
}