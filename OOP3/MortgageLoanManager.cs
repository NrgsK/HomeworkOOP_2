﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class MortgageLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}