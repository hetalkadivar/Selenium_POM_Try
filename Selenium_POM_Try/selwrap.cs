using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_POM_Try
{
    class selwrap
    {

        public static void openURL(string url)
        {
            globalWebDriver.driver.Navigate().GoToUrl(url);
        }

        public static void input(element elem,string target,string value)
        {
            if(elem ==  element.id)
            {
                globalWebDriver.driver.FindElement(By.Id(target)).Clear();
                globalWebDriver.driver.FindElement(By.Id(target)).SendKeys(value);
            }
            if(elem == element.name)
            {
                globalWebDriver.driver.FindElement(By.Name(target)).Clear();
                globalWebDriver.driver.FindElement(By.Name(target)).SendKeys(value);
            }
            if(elem ==  element.xp)
            {

            }
        }
        public static void wait(element elem, string target)
        {
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (elem == element.name)
                    {
                        if (globalWebDriver.driver.FindElement(By.Name(target)).Displayed) break;
                    }
                    if (elem == element.id)
                    {
                        if (globalWebDriver.driver.FindElement(By.Id(target)).Displayed) break;
                    }
                    if (elem == element.css)
                    {
                        if (globalWebDriver.driver.FindElement(By.CssSelector(target)).Displayed) break;
                    }
                    if (elem == element.link)
                    {
                        if (globalWebDriver.driver.FindElement(By.LinkText(target)).Displayed) break;
                    }
                    if (elem == element.xp)
                    {
                        if (globalWebDriver.driver.FindElement(By.XPath(target)).Displayed) break;
                    }
                }
                catch (Exception)
                { }
                Thread.Sleep(2000);
            }
        }
    }
}
