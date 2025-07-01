namespace leetcodeEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string s)///hello world
        {
            var count = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                    
                }
               else if (count != 0 && s[i] == ' ')
                {
                    return count;
                }
            }
            return count;
        }
    }
}
