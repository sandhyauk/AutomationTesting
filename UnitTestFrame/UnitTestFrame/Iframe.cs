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
    public  class Iframe
    {
        [TestMethod]
        public void BroswerOpen()
        {
            IWebDriver driver = new ChromeDriver();//runtime polymorphism

            driver.Navigate().GoToUrl("https://yatra.com");

            driver.Manage().Window.Maximize(); // Maximize the window

            Console.WriteLine(driver.Title);

            IWebElement support = driver.FindElement(By.XPath("//a[text()='Support ']"));


            Actions act = new Actions(driver);

            act.MoveToElement(support).Perform();

            driver.FindElement(By.XPath("//a[text()='Talk To Us']")).Click();

            driver.SwitchTo().Frame("iframeChatBot"); //user enter into the frame

            driver.FindElement(By.XPath("//button[text()='Cancellation']")).Click();

            driver.SwitchTo().DefaultContent(); //user come out from the frame

            driver.FindElement(By.Id("chatbot_close_button")).Click();



        }
    }
}
