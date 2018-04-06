using OpenQA.Selenium;

namespace Framework
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public AdminPage loginSuccessfull(string user, string password)
        {
            driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com/index.php/auth/login");
            driver.Manage().Window.Maximize();
            IWebElement inputUser = driver.FindElement(By.Id("txtUsername"));
            inputUser.SendKeys("Admin");
            IWebElement inputPass = driver.FindElement(By.Id("txtPassword"));
            inputPass.SendKeys("admin");
            IWebElement btnlogin = driver.FindElement(By.Id("btnLogin"));
            btnlogin.Click();

            return new AdminPage(driver);
        }
    }
}
