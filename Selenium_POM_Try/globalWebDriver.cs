using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_POM_Try
{
    enum element
    {
        id,
        name,
        link,
        css,
        classname,
        xp
    }
    class globalWebDriver
    {
        public static IWebDriver driver;
    }
}
