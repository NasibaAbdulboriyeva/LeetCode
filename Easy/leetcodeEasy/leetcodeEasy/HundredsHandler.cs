using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public class HundredsHandler : Handler
    {
        public override Dictionary<int, int> Handle(int number)
        {
            var res = new Dictionary<int, int>();
            int temp = number / 100;
            number = number % 100;
            Console.WriteLine(temp);
            res.Add(100, temp);
            return Next?.Handle(number) ?? res;
        }
    }
}
