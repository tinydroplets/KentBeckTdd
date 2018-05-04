using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public class Franc : Money
    {
        //private string currency;
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }

        //public override string currency()
        //{
        //    return _currency;
        //}
    }
}
