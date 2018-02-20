using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Checking : Account, calculBalance
    {
        const int limitTransac = 4; //precisa de get and set? tem que colocar no construtor?
        public int LimitTransac
        {
            get { return limitTransac; }
        } 


        int counter;
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        double extraFees;
        public double ExtraFees
        {
            get { return extraFees; }
            set { extraFees = value; }
        }

        public Checking()
            : base()
        {
            this.counter = 0;
            this.extraFees = 0.0;
            this.counter = 0;
        }

        public Checking(int accNumber, int customerId, EnumType acctype, DateTime openDate, double balance, int counter, double extraFees)
            : base(accNumber, customerId, acctype, openDate, balance)
        {
            this.counter = counter;
            this.extraFees = extraFees;
        }

        public override String ToString()
        {
            String state;
            state = base.ToString() + "\n Extra fees: " + this.extraFees + "\n Balance: " + calculBalance();
            return state;
        }

        public double calculBalance()
        {
            return Math.Round(Balance - extraFees, 2);
        }
    }
}
