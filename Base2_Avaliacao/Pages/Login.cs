using OpenQA.Selenium;

namespace Base2_Avaliacao.Pages
{
    class Login
    {

        public Login(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public IWebElement txtUserName => Driver.FindElement(By.Name("username"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/div[3]/form/table/tbody/tr[6]/td/input"));

        public void StepsLogin(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();

        }

    }
}
