using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace AzureBookWagon.Base
{
    public class BooksWagonBase
    {
        public IWebDriver driver;
        public static string title = ConfigurationManager.AppSettings["title"];
        public static string placeOrder = ConfigurationManager.AppSettings["placeOrder"];
        public static string logOut = ConfigurationManager.AppSettings["logout"];
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
