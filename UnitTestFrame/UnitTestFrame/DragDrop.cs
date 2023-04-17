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
    public  class DragDrop
    {
        [TestMethod]
        public void BroswerOpen()
        {
            IWebDriver driver = new ChromeDriver();//runtime polymorphism

            driver.Navigate().GoToUrl("https://demo.guru99.com/test/drag_drop.html");

            driver.Manage().Window.Maximize(); // Maximize the window

            Console.WriteLine(driver.Title);

            IWebElement startingpoint = driver.FindElement(By.XPath("//a[text()=' BANK ']"));

           IWebElement target =  driver.FindElement(By.Id("bank"));

            Actions act = new Actions(driver);

            act.DragAndDrop(startingpoint, target).Perform();

            
        }
    }
}
