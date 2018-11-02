using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Application
{
    
    public class UnitTest1

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
                IWebElement alertbox = driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.clearfix.post-119.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-special-elements > div.mh-loop-content.clearfix > header > h3 > a"));
                alertbox.click();
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
