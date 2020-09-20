using Base2_Avaliacao.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Base2_Avaliacao.Tests
{
    class LogoutTest
    {

        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://mantis-prova.base2.com.br");
        }

        [Test]
        public void Logout()
        {
            Login pageLogin = new Login(webDriver);
            pageLogin.StepsLogin("romeu.junior", "150691");

            var logged = webDriver.FindElement(By.ClassName("form-title"));
            Assert.That(logged.Displayed, Is.True);

            Thread.Sleep(5000);

            Logout logout = new Logout(webDriver);
            logout.StepsLogout();

            var home = webDriver.FindElement(By.XPath("/html/body/div[3]"));
            Assert.That(home.Displayed, Is.True);

            Thread.Sleep(5000);

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
