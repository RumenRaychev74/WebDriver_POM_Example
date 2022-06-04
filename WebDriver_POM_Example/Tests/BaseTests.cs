

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriver_POM_Example.Tests
{
    public class BaseTests
    {
       protected IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()
        {
            this.driver = new FirefoxDriver();
        }
        [OneTimeTearDown]

        public void ShutDownBrowser()
        {
            driver.Quit();
        }
    }
}
