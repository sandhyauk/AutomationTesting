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
    public  class Forloop
    {
        [TestMethod]
        public void ForLoop()
        {

            /**
             * int i =1 ---- Initalization
             * i<=10 -- Condition - if condition is true -loop will continue else it will  break 
             * i++ - increment - -- i = i+1 i=i+2 i--
             * 
             */
            
            for(int i = 1; i<=20; i++) // 11  11<=10 11
            {
                Console.WriteLine(i);
            }

            // 2  4 6 8 10 12
            //1 3 5 7 

            for(int i = 1; i<=20;i=i+2)
            {
                Console.WriteLine(i);
            }
                 //     0123456
            String s = "Testingghjdgsfhdfhggfdf";

            Console.WriteLine(s.Length);

            for(int i = 0; i<s.Length; i++) // 1 1<=6 1
            {
                Console.WriteLine(s[i]); // "testing"[0]
            }
            

            //loops for numbers in reerse order 
           

           // driver.Quit();
        }
    }
}
