using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelDemo.Pages;

namespace PageObjectModelDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            var loginPage = new LoginPage(driver);
            var homePage = new HomePage(driver);
            var productPage = new ProductPage(driver);
            var cartPage = new CartPage(driver);
            var checkoutPage = new CheckoutPage(driver);

            //login
            loginPage.Login("standard_user", "secret_sauce");
            homePage.OpenProduct("Sauce Labs Backpack");
            productPage.AddProductToCart();
            cartPage.ProceedToCheckout();
            string Success = checkoutPage.Checkout("Gayathri", "Mohan", "33434");
            driver.Quit();
            Console.WriteLine(Success);

        }
    }
}