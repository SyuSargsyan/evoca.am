using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am.data
{
    public class Mobile
    {
        public string VivaProvider { get; set; }
        public string UcomeProvider { get; set; }
        public string TeamsProvider { get; set; }

        public Mobile(string VivaProvider = null, string UcomeProvider = null, string TeamsProvider = null)
        {
            this.VivaProvider = VivaProvider;
            this.UcomeProvider = UcomeProvider;
            this.TeamsProvider = TeamsProvider;
        
        }
    }
}
