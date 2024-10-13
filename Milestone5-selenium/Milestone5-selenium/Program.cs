using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLoginDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {
                // Navigate to the login page
                //string url = "https://www.example.com/login";
                string url = "https://www.saucedemo.com";
                driver.Navigate().GoToUrl(url);

                // Input credentials
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();

                // Wait for the page to load
                System.Threading.Thread.Sleep(2000);

                // Verify successful login
                string currentUrl = driver.Url;
                if (currentUrl == "https://www.saucedemo.com/inventory.html")
                {
                    Console.WriteLine("Login successful.");
                    Console.WriteLine($"Current URL: {currentUrl}");
                }
                else
                {
                    Console.WriteLine("Login failed.");
                }
            }
        }
    }
}
namespace Milestone5_selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}