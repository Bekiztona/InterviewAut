using OpenQA.Selenium;

namespace Framework
{
    public class AdminPage
    {
        IWebDriver driver;
        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PimPage GoToPim()
        {
            driver.FindElement(By.XPath("//a[@id='menu_pim_viewPimModule']/b")).Click();
            driver.FindElement(By.Id("menu_pim_addEmployee")).Click();
            return new PimPage(driver);
        }
    }
}
