using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class ReportIssue
    {
        public ReportIssue(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement reportIssue => Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/a[3]"));

        IWebElement chooseProject => Driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[2]/td[2]/select/option[5]"));

        IWebElement selectProject => Driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[4]/td/input"));

        IWebElement selectCategory => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[2]/td[2]"));

        IWebElement selecionar => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[2]/td[2]/select/option[2]"));

        IWebElement selectReproducibility => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[3]/td[2]/select/option[1]"));

        IWebElement selectSeverity => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[4]/td[2]/select/option[8]"));

        IWebElement selectPriority => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[5]/td[2]/select/option[6]"));

        IWebElement selectProfile => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[6]/td[2]/select/option[4]"));

        IWebElement txtSummary => Driver.FindElement(By.Name("summary"));

        IWebElement txtDescription => Driver.FindElement(By.Name("description"));

        IWebElement txtStepsToReproduce => Driver.FindElement(By.Name("steps_to_reproduce"));

        IWebElement txtAdditionalInformation => Driver.FindElement(By.Name("additional_info"));

        IWebElement viewStatus => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[13]/td[2]/label[1]/input"));

        IWebElement reportStay => Driver.FindElement(By.Id("report_stay"));

        IWebElement btnSubmitReport => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[15]/td[2]/input"));

        public void StepsReportIssue(string summary, string description, string steps, string additionalInfo)
        {
            reportIssue.Click();
            chooseProject.Click();
            selectProject.Click();
            selectCategory.Click();
            selecionar.Click();
            selectReproducibility.Click();
            selectSeverity.Click();
            selectPriority.Click();
            selectProfile.Click();
            txtSummary.SendKeys(summary);
            txtDescription.SendKeys(description);
            txtStepsToReproduce.SendKeys(steps);
            txtAdditionalInformation.SendKeys(additionalInfo);
            viewStatus.Click();
            reportStay.Click();
            btnSubmitReport.Click();

        }

    }
}
