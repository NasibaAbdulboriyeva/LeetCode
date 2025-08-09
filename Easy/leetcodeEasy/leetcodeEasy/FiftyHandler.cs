using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public class FiftyHandler : Handler
    {
        public override Dictionary<int, int> Handle(int number)
        {
            var res = new Dictionary<int, int>();
            int temp = number / 50;
            number = number % 50;
            Console.WriteLine(temp);
            res.Add(50, temp);
            return Next?.Handle(number) ?? res;
        }
    }
}
