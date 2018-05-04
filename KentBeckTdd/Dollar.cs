using System;
using System.Data.SqlTypes;

namespace KentBeckTdd
{
    public class Dollar : Money
    {
        private string currency;
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }

        //public override string currency()
        //{
        //    return _currency;
        //}
    }
}
