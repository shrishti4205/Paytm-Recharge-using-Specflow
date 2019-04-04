using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject14
{
    class ProprtiesClass
    {
        private string _mobilenumber = "8296865364";
        private string _amount = "448";
        public string Mobilenumber
        {
            get
            {
                return _mobilenumber;
            }
            set
            {
                _mobilenumber = value;
            }
        }
        public string amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
    }
}
