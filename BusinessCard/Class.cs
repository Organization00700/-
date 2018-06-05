using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCard
{
    public class Class
    {
        private int money;
        public int Money
        {
            get {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public Class(int money)
        {
            this.money = money;
        }

        public void Add(int money)
        {
            this.money += money;
        }
        public void Subtract(int money)
        {
            this.money -= money;
        }
    }
}
