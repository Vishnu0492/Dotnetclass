using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Saucedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");
            IWebElement Password = driver.FindElement(By.Id("password"));
           
            Password.SendKeys("secret_sauce");
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();
            IWebElement Addtocart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));

            Addtocart.Click();
            IWebElement CartICon = driver.FindElement(By.Id("shopping-cart-link"));
            CartICon.Click();
           // driver.Quit();
        }
    }
}