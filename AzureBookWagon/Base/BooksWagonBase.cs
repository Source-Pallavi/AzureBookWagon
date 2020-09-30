using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AzureBookWagon.Base
{
    public class BooksWagonBase
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.bookswagon.com/login";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
