using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {

        }
        private By firstnameField = By.Id("first-name");
        private By lastnameField = By.Id("last-name");
        private By codeField = By.Id("postal-code");
        private By continueButton = By.Id("continue");
        private By finishButton = By.Id("finish");
        private By successMessage = By.CssSelector(".complete-header");
        public string Checkout(string firstname, string lastname, string postalcode)
        {
            FindElement(firstnameField).SendKeys(firstname);
            FindElement(lastnameField).SendKeys(lastname);
            FindElement(codeField).SendKeys(postalcode);
            FindElement(continueButton).Click();
            FindElement(finishButton).Click();
            return FindElement(successMessage).Text;
        }
    }
}