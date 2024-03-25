using Microsoft.VisualStudio.TestPlatform.TestExecutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am.data
{
    public class Client
    {
        public string Loan {get; set;}
        public string Account { get; set;}
        public string Card { get; set;}
        public Mobile Mobile {get; set;}

        public Client(
            string Loan,
            string Account,
            string Card,
            string viva = null,
            string ucom = null,
            string team = null)
        {
            this.Loan = Loan;
            this.Account = Account; 
            this.Card = Card;
            this.Mobile = new Mobile
            {
                VivaProvider = viva,
                UcomeProvider = ucom,
                TeamsProvider = team
            };
            
        }
        public static Client testClinet;
        public static Client SyuneSargsyan = new Client("TV275480", "1660005971370200", "5263920001035153", viva:"094595767");

    }
}
