using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Phone
    {
        int countryCode;
        public int CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        int areaCode;
        public int AreaCode
        {
            get { return areaCode; }
            set { areaCode = value; }
        }

        int phone1;
        public int Phone1
        {
            get { return phone1; }
            set { phone1 = value; }
        }

        public Phone()
        {
            this.countryCode = 0;
            this.areaCode = 000;
            this.phone1 = 0000000;
        }

        public Phone(int countryCode, int areaCode, int phone1)
        {
            this.countryCode = countryCode;
            this.areaCode = areaCode;
            this.phone1 = phone1;
        }

        public Phone(String phone)
        {
            this.CountryCode = Int32.Parse(phone.Substring(0, 1));
            this.AreaCode = Int32.Parse(phone.Substring(3, 3));
            this.phone1 = Int32.Parse(phone.Substring(8, 3) + phone.Substring(12, 4));
        }

        public override String ToString()
        {
            String state;
            state = countryCode.ToString() + areaCode.ToString() + phone1.ToString();
            return state;
        }
    }
}
