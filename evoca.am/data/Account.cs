using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am.data
{
    public class Account
    {
        public string Number { get; set; }

        public Account(string Number)
        {
            this.Number = Number;

        }
        public static Account testAccount;
        public static Account SyuAccount = new Account("1660005971370200");
    }
}
