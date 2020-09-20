using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class AddForMonitoring
    {
        public AddForMonitoring(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement selectingItem => Driver.FindElement(By.XPath("/html/body/div[3]/table[1]/tbody/tr[1]/td[1]/table/tbody/tr[2]/td[1]/span/a"));

        IWebElement monitor => Driver.FindElement(By.XPath("/html/body/table[3]/tbody/tr[19]/td/table/tbody/tr/td[4]/form/input[3]"));

        IWebElement myView => Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/a[1]"));

        public void StepsToAddMonitoring()
        {
            selectingItem.Click();
            monitor.Click();
            myView.Click();

        }



    }
}
