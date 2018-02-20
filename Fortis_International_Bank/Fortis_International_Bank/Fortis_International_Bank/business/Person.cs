using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Person
    {
        int personId;
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        
        String fn;
        public String Fn
        {
            get { return fn; }
            set { fn = value; }
        }

        String ln;
        public String Ln
        {
            get { return ln; }
            set { ln = value; }
        }

        Email email;
        public Email Email
        {
            get { return email; }
            set { email = value; }
        }

        Phone phone;
        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        Address address;
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person()
        {
            this.personId = 000000;
            this.fn = "Unknown";
            this.ln = "Unknown";
            this.email = new Email();
            this.phone = new Phone();
            this.address = new Address();          
        }

        public Person(int personId, String fn, String ln, Email email, Phone phone, Address address)
        {
            this.personId = personId;
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public override String ToString()
        {
            String state;
            state = "\n Person Id: " + this.personId + "\n First name: " + this.fn + "\n Last name: " + this.ln + "\n Email: " + this.email + "\n Phone number: " + this.phone + "\n Address: " + this.address;
            return state;
        }

    }
}
