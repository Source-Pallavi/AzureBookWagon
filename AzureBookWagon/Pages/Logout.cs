using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace AzureBookWagon.Pages
{
    public class Logout
    {
        public IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class
        /// </summary>
        /// <param name="driver">to control browser</param>
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        public IWebElement logout;

        [FindsBy(How = How.XPath, Using = "//span[@class='login-bg sprite usermenu-bg']")]
        public IWebElement menu;

        [FindsBy(How = How.XPath, Using = "//div[@class='ac-container']//li[1]//a[1]")]
        public IWebElement validation;

        [FindsBy(How = How.XPath, Using = "//img[@id='ctl00_imglogo']")]
        public IWebElement home;

        /// <summary>
        /// To logout from Bookwagon application
        /// </summary>
        public void LogOut()
        {
            home.Click();
            menu.Click();
            Thread.Sleep(2000);
            logout.Click();
        }
    }
}
