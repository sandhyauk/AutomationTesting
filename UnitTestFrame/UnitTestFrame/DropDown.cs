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
    public  class AdvanceDropDown
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

            IList<IWebElement> li = se.Options;

            //li.Size();

            Console.WriteLine(li.Count);

            for(int i =0; i<li.Count; i++) /// 0 0<=56
            {
                li[i].Click(); //
                Console.WriteLine(li[i].Text); // li[0]
            }
            

           

            
           

           // driver.Quit();
        }
    }
}
