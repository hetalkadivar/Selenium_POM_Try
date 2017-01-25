using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_POM_Try
{
    [TestFixture]
    class testscript
    {
        private string baseURL;

        [SetUp]
        public void setup()
        {            
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Saurabh\Documents\Selenium_driver\", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files(x86)\Mozilla Firefox\firefox.exe";
            //service.Port = 6444;
            globalWebDriver.driver = new FirefoxDriver(service);
            System.Threading.Thread.Sleep(10000);
            globalWebDriver.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [Test]
        public void mytest()
        {
            pageobject page = new pageobject();
            globalWebDriver.driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            selwrap.openURL("http://admin-demo.nopcommerce.com/login?ReturnUrl=%2fadmin%2f");

            selwrap.input(element.id, "Email","admin@yourstore.com");
            selwrap.input(element.id,"Password","admin");
            

          //  page.username.SendKeys("admin@yourstore.com");           
          //  page.password.SendKeys("admin");
            page.loginbutton.Click();            
        }

        [TearDown]
        public void destroy()
        {
          globalWebDriver.driver.Quit();
        }
    }

}
