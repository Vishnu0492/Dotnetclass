using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
          // driver.Navigate().GoToUrl("https://automationpractice.com/");
            driver.Navigate().GoToUrl("https://www.whatismyip.com/");
            IWebElement element = driver.FindElement(By.XPath("//div/a[@id='ipv4']"));
            string ipAddress = element.Text;
            Console.WriteLine(ipAddress);
           
            driver.Quit();
        }
    }
}