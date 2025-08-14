using System;
using System.ComponentModel.Design;

namespace leetcodeEasy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    var hundredHandler = new HundredsHandler();
            //    var fiftyHandler = new FiftyHandler();
            //    var tenHandler = new TenHandler();
            //    var fiveHandler = new FiveHandler();
            //    var oneHandler = new OneHandler();


            //    hundredHandler.SetNext(fiftyHandler);
            //    fiftyHandler.SetNext(tenHandler);
            //    tenHandler.SetNext(fiveHandler);
            //    fiveHandler.SetNext(oneHandler);


            //    var result = hundredHandler.Handle(7521);
            //var solution = new Solution();
            //solution.Generate(5);
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
    //public class Solution
    //{
    //    public bool IsPowerOfTwo(int n)
    //    {

    //        if (n <= 0) return false;
    //        var i = 1;
    //        while (true)
    //        {
    //            if (n % 2 == 0)
    //            {
    //                n /= 2;
    //            }
    //            else
    //            {
    //                if(n == 1)
    //                {
    //                    return true;
    //                }
    //                else
    //                {
    //                    return false;
    //                }
    //            }
    //        }
    //    }
    //}
    //public class Solution
    //{
    //    public bool ReorderedPowerOf2(int n)
    //    {
    //        int[] nums = new int[n.ToString().Length];
    //        int i = 0;
    //        while (true)
    //        {
    //            nums[i++] = n % 10;
    //            n /= 10;
    //            if (n == 0) break;
    //        }

    //        IList<IList<int>> current = PermuteUnique(nums);
    //        i = 0;

    //        foreach (var num in current)
    //        {
    //            string temp = "";
    //            foreach (var numb in num)
    //            {
    //                temp += numb.ToString();
    //            }
    //            if (temp[0] == '0')
    //            {
    //                continue;
    //            }
    //            bool solu = IsPowerOfTwo(int.Parse(temp));
    //            if (solu) return true;

    //        }
    //        return false;
    //    }
    //    public bool IsPowerOfTwo(int n)
    //    {
    //        if (n < 0) return false;
    //        if (n % 2 != 0 && n != 1) return false;

    //        while (n > 0)
    //        {
    //            if (n == 1) return true;
    //            if (n % 2 != 0) return false;
    //            n /= 2;
    //        }
    //        return false;
    //    }
    //    public IList<IList<int>> PermuteUnique(int[] nums)
    //    {
    //        Array.Sort(nums);
    //        IList<IList<int>> result = new List<IList<int>>();

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates
    //            List<int> current = new List<int>();
    //            current.Add(nums[i]);
    //            bool[] used = new bool[nums.Length];
    //            used[i] = true;
    //            Backtrack(nums, used, current, result);
    //        }

    //        return result;
    //    }

    //    public void Backtrack(int[] nums, bool[] used, List<int> current, IList<IList<int>> result)
    //    {
    //        if (current.Count == nums.Length)
    //        {
    //            result.Add(new List<int>(current));
    //            return;
    //        }
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (used[i]) continue; // Skip used numbers
    //            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue; // Skip duplicates
    //            used[i] = true;
    //            current.Add(nums[i]);
    //            Backtrack(nums, used, current, result);
    //            used[i] = false;
    //            current.RemoveAt(current.Count - 1);
    //        }
    //    }
    //}

    public class Solution
    {
        public string LargestGoodInteger(string num)
        {
            
            if (num.Contains("999")) return "999";
            if (num.Contains("888")) return "888";
            if (num.Contains("777")) return "777";
            if (num.Contains("666")) return "666";
            if (num.Contains("555")) return "555";
            if (num.Contains("444")) return "444";
            if (num.Contains("333")) return "333";
            if (num.Contains("222")) return "222";
            if (num.Contains("111")) return "111";
            if (num.Contains("000")) return "000";
            else return "";
        }
    }
}
