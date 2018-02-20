using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Transaction
    {
        public enum EnumType
        {
            Deposit, Withdraw, Unknown
        }

        int transNumber;
        public int TransNumber
        {
            get { return transNumber; }
            set { transNumber = value; }
        }

        int accNumber;
        public int AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }

        Account.EnumType accType;
        public Account.EnumType AccType
        {
            get { return accType; }
            set { accType = value; }
        }

        String description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        EnumType transType;
        public EnumType TransType
        {
            get { return transType; }
            set { transType = value; }
        }

        public Transaction()
        {
            this.transNumber = 0;
            this.description = "Unknown";
            this.date = new DateTime();
            this.amount = 0.0;
            this.transType = EnumType.Unknown;
            this.AccNumber = 0000;
            this.AccType = Account.EnumType.Undefined;
        }

        public Transaction(int transNumber, String description, DateTime date, double amount, String transType, int accNumber, Account.EnumType accType)
        {
            this.transNumber = transNumber;
            this.description = description;
            this.date = date;
            this.amount = amount;
            this.transType = EnumType.Unknown;
            this.accNumber = accNumber;
            this.AccType = accType;
        }

        public override String ToString()
        {
            String state;
            state = "\n Transaction number: " + this.transNumber + "\n Description: " + this.description + "\n Date: " + this.date + "\n Amount: " + this.amount + "\n Transaction type: " + this.transType;
            return state;
        }

    }
}
