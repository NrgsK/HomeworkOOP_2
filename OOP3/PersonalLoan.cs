﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}