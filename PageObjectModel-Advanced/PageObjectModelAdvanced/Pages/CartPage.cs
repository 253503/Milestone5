
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {

        }
        private By cartButton = By.CssSelector(".shopping_cart_link");
        private By checkoutButton = By.CssSelector(".checkout_button");
        public void ProceedToCheckout()
        {
            FindElement(cartButton).Click();
            FindElement(checkoutButton).Click();
        }
    }
}
