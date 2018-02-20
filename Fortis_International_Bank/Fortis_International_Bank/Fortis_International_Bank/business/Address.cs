using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Address
    {
        int streetNo;
        public int StreetNo
        {
            get { return streetNo; }
            set { streetNo = value; }
        }

        String streetName;
        public String StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        int aptNo;
        public int AptNo
        {
            get { return aptNo; }
            set { aptNo = value; }
        }

        String city;
        public String City
        {
            get { return city; }
            set { city = value; }
        }

        String province;
        public String Province
        {
            get { return province; }
            set { province = value; }
        }

        String country;
        public String Country
        {
            get { return country; }
            set { country = value; }
        }

        String postalCode;
        public String PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }     

        public Address()
        {
            this.streetNo = 0;
            this.streetName = "Unknown";
            this.aptNo = 0;
            this.city = "Unknown";
            this.province = "Unknown";
            this.country = "Unknown";
            this.postalCode = "Unknown";
        }

        public Address(int streetNo, String streetName, int aptNo, String city, String province, String country, String postalCode)
        {
            this.streetNo = streetNo;
            this.streetName = streetName;
            this.aptNo = aptNo;
            this.city = city;
            this.province = province;
            this.country = country;
            this.postalCode = postalCode;
        }

        public override String ToString()
        {
            String state;
            state = this.streetNo + " - " + this.streetName + " - " + this.aptNo + " - " + this.city + " - " + this.province + " - " + this.country + " - " + this.postalCode;
            return state;
        }

    }
}
