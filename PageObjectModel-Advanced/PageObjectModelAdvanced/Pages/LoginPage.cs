using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");

        public void Login(string username, string password)
        {
            FindElement(usernameField).SendKeys(username);
            FindElement(passwordField).SendKeys(password);
            FindElement(loginButton).Click();
        }
    }
}