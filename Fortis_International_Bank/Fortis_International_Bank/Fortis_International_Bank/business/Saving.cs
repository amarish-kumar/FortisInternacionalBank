using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Saving : Account, calculBalance
    {
        double interestRate;
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        double annualGain;
        public double AnnualGain
        {
            get { return annualGain; }
            set { annualGain = value; }
        }

        double extraFees;
        public double ExtraFees
        {
            get { return extraFees; }
            set { extraFees = value; }
        }

        public Saving()
            : base()
        {
            this.interestRate = 0.0;
            this.annualGain = 0.0;
            this.extraFees = 0.0;    
        }

        public Saving(int accNumber, int customerId, EnumType acctype, DateTime openDate, double balance, double interestRate, double annualGain, double extraFees)
            : base(accNumber, customerId, acctype, openDate, balance)
        {
            this.interestRate = interestRate;
            this.annualGain = annualGain;
            this.extraFees = extraFees;
        }

        public override string ToString()
        {
            String state;
            state = base.ToString() + "\n Interest rate: " + this.interestRate + "\n Extra fees: " + this.extraFees + "\n Annual gain: " + calculAnnualGain() + "\n Balance: " + calculBalance();
            return state ;
        }

        public double calculBalance()
        {
            return Math.Round( ( (1 + interestRate) * Balance) - extraFees, 2); 
        }

        public double calculAnnualGain()
        {
            return Math.Round(calculBalance() - Balance, 2);
        }
    }
}
