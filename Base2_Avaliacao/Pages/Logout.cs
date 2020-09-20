using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class Logout
    {
        public Logout(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement logout => Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/a[7]"));

        public void StepsLogout()
        {

            logout.Click();

        }

    }
}
