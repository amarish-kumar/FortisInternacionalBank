using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortis_International_Bank.business
{
    public class NumGenerator
    {
        int code;
        public int Code
        {
          get { return code; }
          set { code = value; }
        }

        public NumGenerator(int initValue)
        {
            this.code = initValue; 
        }

        public int NextValue()
        {
            int temp = Code;
            Code++;
            return temp;
        }

        public int NextValue(int code)
        {
            this.Code = code;
            code++;
            return code;
        }
    }
}
