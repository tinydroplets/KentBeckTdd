﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentBeckTdd
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);

        Expression plus(Expression addend);
    }
}
