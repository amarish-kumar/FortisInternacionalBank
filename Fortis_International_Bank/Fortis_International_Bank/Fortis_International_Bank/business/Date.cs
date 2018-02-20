using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    [Serializable]
    public class Date
    {
        private int month;
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        
        private int day;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        
        public Date()
        {
            this.month = 00;
            this.day = 00;
            this.year = 0000;
        }
        
        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public override String ToString()
        {
            String state;
            state = this.month + "/" + this.day + "/" + this.year;
            return state;
        }
    }
}
