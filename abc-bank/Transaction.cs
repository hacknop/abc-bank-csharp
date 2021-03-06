﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc_bank
{
    public class Transaction
    {
        public readonly double amount;

        private DateTime transactionDate;
        public DateTime TransactionDate { get { return transactionDate; }  }

        public readonly TransactionType tType;

        public string transactionType()
        {
            return (this.amount < 0 ? "withdrawal" : "deposit");
        }
        public Transaction(double amount)
        {
            this.amount = amount;
            tType = amount < 0 ? TransactionType.Withdrawal : TransactionType.Deposit;
            this.transactionDate = DateProvider.getInstance().Now();
        }
    }
}
