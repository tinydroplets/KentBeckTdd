using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public class Money
    {
        protected int amount;

        public Boolean Equals(object o)
        {
            var money = (Money)o;
            return amount == money.amount;
        }
    }
}
