using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public class Franc : Money
    {
        //private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        //public Boolean Equals(object o)
        //{
        //    var Franc = (Money)o;
        //    return amount == money.amount;
        //}
    }
}
