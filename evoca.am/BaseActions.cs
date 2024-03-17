using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evoca.am.data;
using OpenQA.Selenium;

namespace evoca.am
{
    //public interface IGenericMethods     
    //{
    //    void SendKey(By by, string text);
    //    void Click(By by);
    //}

    //public class Actions : IGenericMethods
    //{
    //    readonly IWebDriver driver;
    //    public Actions(IWebDriver driver)
    //    {
    //        this.driver = driver;
    //    }

    //    public void Click(By by)
    //    {
    //        driver.FindElement(by).Click();
    //    }

    //    public void SendKey(By by, string text )
    //    {
    //        Click(by);
    //        driver.FindElement(by).SendKeys(text);
    //    }
    //}

    public abstract class BaseActions : Fields
    {
        protected BaseActions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public virtual void Click(By by)
        {
            driver.FindElement(by).Click();

        }

        public virtual void SendKey(By by, string text)
        {
            Click(by);
            driver.FindElement(by).SendKeys(text);
        }

        //public virtual void ClickElement (IWebElement element)
        //{
        //    driver.FindElement(element).Click();
        //}
    }

    //public class Actions : BaseActions
    //{
    //    public override void SendKey(By by, string text)
    //    {
    //        Click(by);
    //        base.SendKey(by, text);
    //    }

    //    public Actions(IWebDriver driver) : base(driver)
    //    {
    //    }
    //}

}