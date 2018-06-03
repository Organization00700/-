using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class Class1
    {
        private int money;
        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value > 0 ? value : 0;
            }
        }

        public Class1(int mn)
        {
            Money = mn;
        }

        public void AddMoney(int mn)
        {
            Money += mn;
        }

        public void SubtractMoney(int mn)
        {
            Money -= mn;
        }
    }
}
