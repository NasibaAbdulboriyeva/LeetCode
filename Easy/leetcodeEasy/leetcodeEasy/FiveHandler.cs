using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public class FiveHandler : Handler
    {
        public override Dictionary<int, int> Handle(int number)
        {
            var res = new Dictionary<int, int>();
            int temp = number / 5;
            number = number % 5;
            Console.WriteLine(temp);
            res.Add(5, temp);
            return Next?.Handle(number) ?? res;
        }
    }
}
