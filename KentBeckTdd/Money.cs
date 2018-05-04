using System;

namespace KentBeckTdd
{
    public abstract class Money
    {
        protected int amount;
        protected string _currency;

        protected Money(int amount, string currency)
        {
            this.amount = amount;
            this._currency = currency;
        }

        public Boolean Equals(object o)
        {
            var money = (Money)o;
            return amount == money.amount && GetType() == money.GetType();
        }

        public static Money dollar(int amount)
        {
            return  new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        public string currency()
        {
            return _currency;
        }
    }
}
