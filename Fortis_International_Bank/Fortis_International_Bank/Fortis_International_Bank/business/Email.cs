using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Email
    {
        private String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private String domainName;
        public String DomainName
        {
            get { return domainName; }
            set { domainName = value; }
        }
       
        public Email()
        {
            this.userName = "Unknown";
            this.domainName = "Unknown";
        }

        public Email(String userName, String domainName)
        {
            this.userName = userName;
            this.domainName = domainName;
        }

        public Email(String email)
        {
            int at = email.IndexOf('@');
            int lenght = email.Length;
            this.userName = email.Substring(0, (at));
            this.domainName = email.Substring((at + 1), lenght - userName.Length - 1);        
        }

        public override String ToString()
        {
            String state;
            state = this.userName + "@" + this.domainName;
            return state;
        }

        
    }
}
