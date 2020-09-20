using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class MyAccount
    {
        public MyAccount(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement myAccount => Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/a[6]"));

        IWebElement realName => Driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[6]/td[2]/input"));

        IWebElement updateUser => Driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[10]/td[2]/input"));

        public void StepsMyAccount(string name)
        {

            myAccount.Click();
            realName.Clear();
            realName.SendKeys(name);
            updateUser.Click();

        }

    }
}
