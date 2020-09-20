using Base2_Avaliacao.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Base2_Avaliacao.Tests
{
    class RemoveFromMonitoringTest
    {

        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://mantis-prova.base2.com.br");
        }

        [Test]
        public void RemoveFromMonitoring()
        {
            Login pageLogin = new Login(webDriver);
            pageLogin.StepsLogin("romeu.junior", "150691");

            var logged = webDriver.FindElement(By.ClassName("form-title"));
            Assert.That(logged.Displayed, Is.True);

            Thread.Sleep(5000);

            AddForMonitoring addForMonitoring = new AddForMonitoring(webDriver);
            addForMonitoring.StepsToAddMonitoring();

            var monitoring = webDriver.FindElement(By.XPath("/html/body/div[3]/table[1]/tbody/tr[3]/td[1]/table/tbody/tr[2]/td[2]"));
            Assert.That(monitoring.Displayed, Is.True);

            Thread.Sleep(5000);

            RemoveFromMonitoring removeFromMonitoring = new RemoveFromMonitoring(webDriver);
            removeFromMonitoring.StepsToRomoveMonitoring();

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
