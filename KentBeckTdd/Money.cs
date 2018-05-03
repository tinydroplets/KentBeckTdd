using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public abstract class Money
    {
        protected int amount;

        public Boolean Equals(object o)
        {
            var money = (Money)o;
            return amount == money.amount && GetType() == money.GetType();
        }

        public static Money dollar(int amount)
        {
            return  new Dollar(amount);
        }

        public static Money franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);
    }
}
