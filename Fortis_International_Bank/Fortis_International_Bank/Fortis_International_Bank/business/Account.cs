using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Account
    {
        //FALTA list of transactions
        public Dictionary<int, Transaction> accTransactionDict;

        public enum EnumType
        {
            Undefined, Checkings, Savings, Credit
        }

        int accNumber;
        public int AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }

        int customerId;  //e agora?
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        EnumType acctype;
        public EnumType Acctype
        {
            get { return acctype; }
            set { acctype = value; }
        }

        DateTime openDate;
        public DateTime OpenDate
        {
            get { return openDate; }
            set { openDate = value; }
        }

        double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account()
        {
            this.accNumber = 0;
            this.customerId = 0;
            this.acctype = EnumType.Undefined;
            this.openDate = DateTime.Now;
            this.balance = 0.0;
            this.accTransactionDict = new Dictionary<int, Transaction>();
        }

        public Account(int accNumber, int customerId, EnumType acctype, DateTime openDate, double balance)
        {
            this.accNumber = accNumber;
            this.customerId = customerId;
            this.acctype = acctype;
            this.openDate = openDate;
            this.balance = balance;
            this.accTransactionDict = new Dictionary<int, Transaction>();
        }

        public override String ToString()
        {
            String state;
            state = "\n Account number: " + "\n Customer ID: " + this.customerId + "\n Account type: " + this.acctype + "\n Opened date: " + this.openDate + "\n Balance: " + this.balance;
            return state;
        }

    }
}
