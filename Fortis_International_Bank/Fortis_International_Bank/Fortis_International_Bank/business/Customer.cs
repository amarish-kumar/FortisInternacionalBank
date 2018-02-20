using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Customer : Person
    {
        //FALTA list of accounts
        public Dictionary<int, Account> customerAccount;
        

        int pin;
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public Customer() 
            : base()
        {
            this.pin = 0000;
            this.customerAccount  = new Dictionary<int,Account>();
        }

        public Customer(int personId, String fn, String ln, Email email, Phone phone, Address address, int pin)
            : base(personId, fn, ln, email, phone, address)
        {
            this.pin = pin;
            this.customerAccount  = new Dictionary<int,Account>();
        }

        public override String ToString()
        {
            String state;
            state = base.ToString() + "\n Pin: " + this.pin;
            return state;
        }
    }
}
