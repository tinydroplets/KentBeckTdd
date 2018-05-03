using System;

namespace KentBeckTdd
{
    public class Dollar : Money
    {
        //private int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        //public Boolean Equals(object o)
        //{
        //    var money = (Money) o;
        //    return amount == money.amount;
        //}
    }
}
