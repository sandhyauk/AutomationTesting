using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFrame
{
    [TestClass]
    public  class OpenBrowser
    {
        [TestMethod]
        public void BroswerOpen()
        {
            IWebDriver driver = new ChromeDriver();//runtime polymorphism

            driver.Navigate().GoToUrl("https://www.facebook.com");

            driver.Manage().Window.Maximize(); // Maximize the window

            Console.WriteLine(driver.Title);

            //driver.FindElement(By.Name("q")).SendKeys("Testing");

            driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");

            driver.FindElement(By.Name("pass")).SendKeys("1234555");


            driver.FindElement(By.Name("login")).Click();



            Thread.Sleep(6000);

            driver.Quit();
        }
    }
}
