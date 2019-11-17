using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class MainClass
    {

        public static void Main(string[] args)
        {
      
            IWebDriver driver = new ChromeDriver("/usr/local/bin");
            driver.Url = "https://www.commbank.com.au";

          
        }

    }
}
