using Base2_Avaliacao.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Base2_Avaliacao.Tests
{
    class MyAccountTest
    {

        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://mantis-prova.base2.com.br");

        }

        [Test]
        public void MyAccount()
        {

            Login pageLogin = new Login(webDriver);
            pageLogin.StepsLogin("romeu.junior", "150691");

            var logged = webDriver.FindElement(By.ClassName("form-title"));
            Assert.That(logged.Displayed, Is.True);

            Thread.Sleep(5000);

            MyAccount myAccount = new MyAccount(webDriver);
            myAccount.StepsMyAccount("Romeu da Fonseca Junior");

            Thread.Sleep(5000);

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
