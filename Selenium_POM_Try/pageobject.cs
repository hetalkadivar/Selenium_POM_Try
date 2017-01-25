using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Selenium_POM_Try
{
    public class pageobject
    {
        public pageobject()
        {
            PageFactory.InitElements(globalWebDriver.driver, this);
        }
        
        [FindsBy(How= How.Id, Using ="Email")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[3]/input")]
        public IWebElement loginbutton { get; set; }




    }
    

}
