using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    internal class ProductPage : BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver)
        {

        }
        private By addToCartButton = By.Id("add-to-cart");
        public void AddProductToCart()
        {
            FindElement(addToCartButton).Click();
        }
    }
}