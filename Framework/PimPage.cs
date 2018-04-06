using OpenQA.Selenium;

namespace Framework
{
    public class PimPage
    {
        IWebDriver driver;
        public PimPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public PimPage setFirstName(string name)
        {
            driver.FindElement(By.Id("firstName")).SendKeys("Purple");
            return this;
        }

        public PimPage setMiddleName(string name)
        {
            driver.FindElement(By.Id("middleName")).SendKeys("Hrm");
            return this;
        }

        public PimPage clickAddEmployee()
        {
            driver.FindElement(By.Id("menu_pim_addEmployee")).Click();
            return this;
        }

        public PimPage setLastName(string name)
        {
            driver.FindElement(By.Id("lastName")).SendKeys("Automation");
            return this;
        }

        public PimPage clickSaveBtn()
        {
            driver.FindElement(By.Id("btnSave")).Click();
            return this;
        }

        public PimPage clickEmployeeList()
        {
            driver.FindElement(By.Id("menu_pim_viewEmployeeList")).Click();
            return this;
        }

        public PimPage setEmployeeList(string name)
        {
            driver.FindElement(By.Id("empsearch_employee_name_empName")).SendKeys("Purple Hrm Automation");
            return this;
        }

        public bool isEmployeeInTable(string employeeName)
        {
            var table = driver.FindElement(By.XPath("//table[@id='resultTable']/tbody"));
            var rows = table.FindElements(By.TagName("tr"));
            bool isPresentInTable = false;
            foreach (var row in rows)
            {
                if (row.Text.Contains("Purple Hrm"))
                {
                    isPresentInTable = true;
                    break;
               }
            
            }
            return isPresentInTable;
        }
        

    }
}