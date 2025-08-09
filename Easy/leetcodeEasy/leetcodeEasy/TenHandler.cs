using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public class TenHandler : Handler
    {
        public override Dictionary<int, int> Handle(int number)
        {
            var res = new Dictionary<int, int>();
            int temp = number / 10;
            number = number % 10;
            Console.WriteLine(temp);
            res.Add(10, temp);
            return Next?.Handle(number) ?? res;
        }
    }
}
