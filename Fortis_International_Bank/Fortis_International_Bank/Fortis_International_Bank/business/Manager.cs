using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Manager : Person
    {
        int password;
        public int Password
        {
            get { return password; }
            set { password = value; }
        }

        public Manager() 
            : base()
        {
            this.password = 0000;      
        }

        public Manager(int personId, String fn, String ln, Email email, Phone phone, Address address, int password)
            : base(personId, fn, ln, email, phone, address)
        { 
            this.password = password;         
        }


        public override String ToString()
        {
            String state;
            state = base.ToString() + "\n Password: " + this.password;
            return state;
        }

    }
}
