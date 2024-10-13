using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjectModelDemo.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        protected IWebElement FindElement(By by)
        {
            return Driver.FindElement(by);
        }
        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Driver.FindElements(by);
        }
    }
}