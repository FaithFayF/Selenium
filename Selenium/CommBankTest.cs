using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class CommBankTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("/usr/local/bin");
            driver.Url = "https://www.commbank.com.au";
        }

        [Test]
        public void TravelOverseas() //The actual page doesn't exist, reference name/id is being used
        {
            //Navigate to the page 
            driver.FindElement(By.Name("Travel money overseas")).Click();
            driver.FindElement(By.Name("Tell me more")).Click();

            //Get text for the sub topic 
            var exchangeRate = driver.FindElement(By.Id("exchangeRate")).Text;
            var checkFees = driver.FindElement(By.Id("checkFees")).Text;

            Assert.AreEqual("Exchange Rate", exchangeRate);
            Assert.AreEqual("Check Fees", checkFees);
        }

        [Test]
        public void NetbankLogin()
        {
            //Navigate to login  
            driver.FindElement(By.ClassName("log-on-text")).Click();
         
            //Check client username and password field display
            var clientNumber = driver.FindElement(By.Id("txtMyClientNumber_field")).Displayed;
            var password = driver.FindElement(By.Id("txtMyPassword_field")).Displayed;

            Assert.IsTrue(clientNumber);
            Assert.IsTrue(password);
        }
        
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
