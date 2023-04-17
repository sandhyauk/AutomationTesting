using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFrame
{
    [TestClass]
    public  class MouseHovering
    {
        [TestMethod]
        public void BroswerOpen()
        {
            IWebDriver driver = new ChromeDriver();//runtime polymorphism

            driver.Navigate().GoToUrl("https://www.amazon.com");

            driver.Manage().Window.Maximize(); // Maximize the window

            Console.WriteLine(driver.Title);

            IWebElement accountlist = driver.FindElement(By.XPath("//span[text()='Account & Lists']"));


            Actions act = new Actions(driver);

            act.MoveToElement(accountlist).Perform();

            driver.FindElement(By.XPath("//span[text()='Account']")).Click();
           

           // driver.Quit();
        }
    }
}
