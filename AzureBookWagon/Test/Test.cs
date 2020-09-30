

using AzureBookWagon.Base;
using AzureBookWagon.pages;
using AzureBookWagon.Pages;
using NUnit.Framework;

namespace AzureBookWagon.Test
{
   public class Test : BooksWagonBase
    {
        [Test, Order(1)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.BookwagonLogin();
            Assert.AreEqual(driver.Title, title);
        }
        [Test, Order(2)]
        public void HomePageTest()
        {
            HomePage home = new HomePage(driver);
            home.SearchItem("cobain");
            Assert.IsTrue(home.Validate().Displayed);
        }

    }
}
