using System;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace evoca.am
{
    public class TearDown : Methods
    {
        public TearDown(IWebDriver driver) : base(driver)
        {
        }

        [TearDown]
       public void tearDownMethod ()
        {
           driver.Close();
        }
        
    }
}
