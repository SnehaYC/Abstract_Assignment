using Assignment_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Tests
{
    public class LoginText
    {
        IWebDriver driver;
        public LoginText()
        {
           driver = new ChromeDriver(@"C:\Users\sumee\Downloads\chromedriver-win64\chromedriver-win64");

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Console.WriteLine("exe first");
        }

        [Fact]
        public void TestCase()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "password");
            Assert.True(homePage.IsEmployeeDetailsExists());
            Console.WriteLine("exec later");
        }
    }
}
