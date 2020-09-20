using Base2_Avaliacao.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Base2_Avaliacao.Tests
{
    class ReportIssueTest
    {

        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://mantis-prova.base2.com.br");
        }

        [Test]
        public void ReportIssue()
        {
            Login pageLogin = new Login(webDriver);
            pageLogin.StepsLogin("romeu.junior", "150691");

            var logged = webDriver.FindElement(By.ClassName("form-title"));
            Assert.That(logged.Displayed, Is.True);

            ReportIssue reportIssue = new ReportIssue(webDriver);
            reportIssue.StepsReportIssue("Bug 1",
                                         "Este problema ocorre quando o usuário tenta iniciar uma nova busca",
                                         "Usuário seleciona o botão 'buscar' na tela de perfil",
                                         "Este bug está acontencendo em todas as tentativas, se tornando algo impeditivo!");

            var operationSuccessful = webDriver.FindElement(By.XPath("/html/body/div[2]"));
            Assert.That(operationSuccessful.Displayed, Is.True);

            Thread.Sleep(5000);

        }

        [TearDown]
        public void TearDown() => webDriver.Quit();

    }
}
