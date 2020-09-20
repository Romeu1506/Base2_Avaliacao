using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class ViewIssues
    {
        public ViewIssues(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement viewIssues => Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/a[2]"));

        IWebElement txtSearch => Driver.FindElement(By.Name("search"));

        IWebElement applyFilter => Driver.FindElement(By.Name("filter"));

        public void StepsViewIssues(string search)
        {
            viewIssues.Click();
            txtSearch.SendKeys(search);
            applyFilter.Click();
        }

    }
}
