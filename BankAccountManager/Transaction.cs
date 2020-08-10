using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountManager
{
    class Transaction
    {
        public Decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
