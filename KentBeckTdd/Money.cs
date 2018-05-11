using System;

namespace KentBeckTdd
{
    public class Money : Expression
    {
        public int amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this._currency = currency;
        }

        public Boolean Equals(object o)
        {
            var money = (Money)o;
            //return amount == money.amount && GetType() == money.GetType();
            return amount == money.amount && currency().Equals(money.currency());
        }

        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Expression Times(int multiplier)
        {
            return new Money(amount * multiplier, _currency);
        }

        public string currency()
        {
            return _currency;
        }

        public string ToString()
        {
            return amount + " " + _currency;
        }

        public Expression plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            //var rate = (_currency.Equals("CHF") & to.Equals("USD")) ? 2 : 1;
            var rate = bank.Rate(_currency, to);
            return new Money(amount / rate, to);
        }
       
    }
}
