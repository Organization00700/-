using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Class1
    {
        public int money;

        public Class1(int m = 0)
        {
            money = m;
        }

        public void Add(int m)
        {
            money += m;
        }

        public void Remove(int m)
        {
            money -= m;
        }
    }
}
