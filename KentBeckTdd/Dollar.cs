using System;

namespace KentBeckTdd
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public Boolean Equals(object o)
        {
            var dollar = (Dollar) o;
            return amount == dollar.amount;
        }
    }
}
