using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodSacdevFramework.Base
{
    class BasePage
    {

        static void Main()
        {
            SpecialElements();
        }
        static void SpecialElements()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com/";

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            try
            {
                IWebElement csselement = driver.FindElement(By.Id("menu-item-35"));
                csselement.Click();

                //Thread.Sleep(5000);
                //clicking on alert
                IWebElement alertbox = driver.FindElement(By.XPath("//h3//a[contains(text(),'Alert Box')]"));
                alertbox.Click();
                Thread.Sleep(5000);

                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();//clicks on okay

                Thread.Sleep(5000);
                driver.Navigate().Back();//goes back to special elements page

                driver.Quit();
            }

            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }



    }
}
