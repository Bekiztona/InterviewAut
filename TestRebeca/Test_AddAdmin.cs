using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestRebeca
{
    [TestClass]
    public class Test_AddAdmin
    {
        IWebDriver driver;
        [TestInitialize]
        public void testInitialize()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void AddAdmin()
        {
            LoginPage loginPage = new LoginPage(driver);
            bool userAdded = 
                loginPage.loginSuccessfull("Admin", "admin").
                GoToPim().
                clickAddEmployee().
                setFirstName("Purple").
                setMiddleName("Hrm").
                setLastName("Automation").
                clickSaveBtn().
                clickEmployeeList().
                setEmployeeList("Purple Hrm Automation").
                isEmployeeInTable("Purple Hrm");
            Assert.IsTrue(userAdded, "The user not found");                  
        }

        [TestCleanup]
        public void testCleanUp()
        {
            driver.Close();
        }
    }
}
