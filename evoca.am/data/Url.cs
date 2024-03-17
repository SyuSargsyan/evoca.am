using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am.data
{
    public class Url
    {
        public string urlValue { get; set; }

        public Url(string urlValue)
        {

            this.urlValue = urlValue;

        }
        public static Url currentUrl;
        public static Url liveUrl = new Url("https://www.evoca.am/hy/");

    }
}
