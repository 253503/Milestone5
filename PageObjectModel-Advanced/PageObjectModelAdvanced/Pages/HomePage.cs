using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelDemo.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        private By productSelector = By.CssSelector(".inventory_item_name");
        public void OpenProduct(string productName)
        {
            var products = FindElements(productSelector);
            foreach (var product in products)
            {
                if (product.Text.Contains(productName))
                {
                    product.Click();
                    break;
                }
            }
        }
    }
}