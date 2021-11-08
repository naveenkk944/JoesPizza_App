using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Seleniumautomation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            driver = new ChromeDriver(@"c:\DoverCorp");
            Thread.Sleep(200);
            string url = "http://localhost:60623/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(100);

            IWebElement element = driver.FindElement(By.Name("pizza+1"));
            element.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            IWebElement element1 = driver.FindElement(By.Name("checkout"));
            element1.SendKeys(Keys.Enter);
            
            Thread.Sleep(1000);



            driver.Close();
        }
    }
}
