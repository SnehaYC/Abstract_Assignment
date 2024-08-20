using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment_1
{
    public class UnitTest1
    {
        IWebDriver driver;
        
        public UnitTest1()
        {
            driver = new ChromeDriver(@"C:\Users\sumee\Downloads\chromedriver-win64\chromedriver-win64");

            driver.Navigate().GoToUrl("http://www.facebook.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }
        [Fact]
        public void Test2()
        {
            IWebElement element1 = driver.FindElement(By.Id("email"));
            element1.SendKeys("nikitavy@gmail.com");
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Name("pass"));
            ele1.SendKeys("Pass@123");
            Thread.Sleep(1000);
            IWebElement ele2 = driver.FindElement(By.Name("login"));
            ele2.Click();
            Thread.Sleep(1000);
            driver.Close();
        }
    }
}