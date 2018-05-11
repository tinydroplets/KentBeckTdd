using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public class Sum : Expression
    {
        public Expression augend;
        public Expression addend;

        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            //var amount = augend.amount + addend.amount;
            var amount = augend.Reduce(bank, to).amount + addend.Reduce(bank, to).amount;
            return  new Money(amount, to);
        }

        public Expression plus(Expression addend)
        {
            return null;
        }
    }
}
