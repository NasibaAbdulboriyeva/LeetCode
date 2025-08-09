using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeEasy
{
    public abstract class Handler
    {
        protected Handler Next;

        public void SetNext(Handler next)
        {
            Next = next;
        }

        public abstract Dictionary<int,int> Handle(int number);

    }

}
