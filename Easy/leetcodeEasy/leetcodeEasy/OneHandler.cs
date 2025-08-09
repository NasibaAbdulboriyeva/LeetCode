using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public class OneHandler : Handler
    {
        public override Dictionary<int, int> Handle(int number)
        {
            var res = new Dictionary<int, int>();
            int temp = number / 1;
            number = number % 1;
            Console.WriteLine(temp);
            res.Add(1, temp);
            return Next?.Handle(number) ?? res;
        }
    }
}
