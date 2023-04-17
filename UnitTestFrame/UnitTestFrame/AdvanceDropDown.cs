using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFrame
{
    [TestClass]
    public  class DropDown
    {
        [TestMethod]
        public void BroswerOpen()
        {
            IWebDriver driver = new ChromeDriver();//runtime polymorphism

            driver.Navigate().GoToUrl("https://www.amazon.com");

            driver.Manage().Window.Maximize(); // Maximize the window

            Console.WriteLine(driver.Title);

            IWebElement dropdownbox = driver.FindElement(By.Id("searchDropdownBox"));

            SelectElement se = new SelectElement(dropdownbox);

            se.SelectByIndex(3); //low priority
            se.SelectByValue("search-alias=baby-products"); //medium priority
            se.SelectByText("Arts, Crafts & Sewing"); //High

            
           

           // driver.Quit();
        }
    }
}
