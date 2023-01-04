using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace desafgoog{


    public class Tests
    {
        private WebDriver WebDriver { get; set; } = null!;
        private string DriverPath { get; set; } = @"C:\Users\yasminmagalhaes";
        private string BaseUrl { get; set; } = "https://www.google.com.br";


        [SetUp]
        public void Setup()
        {
            WebDriver = GetChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }

        [Test]
        public void Test1()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);

            //Verificando se o Title está correto
            Assert.AreEqual("Google", WebDriver.Title);
            Thread.Sleep(1000);

            //Utilizando o buscador
            var input = WebDriver.FindElement(By.ClassName("gLFyf"));
            input.Clear();
            input.SendKeys("Bolsa");

            Thread.Sleep(1000);
            input = WebDriver.FindElement(By.ClassName("gNO89b"));
            input.Click();

            //Verificando se o title está acompanhando a palavra buscada
            Assert.AreEqual("Bolsa - Pesquisa Google", WebDriver.Title);
            Thread.Sleep(1000);

            //Utilizando o ícone de limpar o buscador
            input = WebDriver.FindElement(By.ClassName("BKRPef"));
            input.Click();
            Thread.Sleep(2000);

            //Verificando o elemento de sugestões de pesquisa clicando na primeira opção
            input = WebDriver.FindElement(By.ClassName("pcTkSc"));
            input.Click();
            Thread.Sleep(2000);

            //Utilizando a segunda opção de filtro após "Todas" 
            input = WebDriver.FindElement(By.CssSelector("#hdtb-msb > div:nth-child(1) > div > div:nth-child(2)"));
            input.Click();
            Thread.Sleep(2000);

            //Utilizando a nova segunda opção de filtro após "Todas" que foi atualizada
            input = WebDriver.FindElement(By.CssSelector("#hdtb-msb > div:nth-child(1) > div > div:nth-child(2)"));
            input.Click();
            Thread.Sleep(2000);

            //Voltando ao filtro "Todas"
            input = WebDriver.FindElement(By.CssSelector("#yDmH0d > div.T1diZc.KWE8qe > c-wiz > div.ndYZfc > div > div.tAcEof > div.O850f > div > div > a:nth-child(2)"));
            input.Click();
            Thread.Sleep(2000);

            //Testando o botão de ferramentas e suas funcionalidade
            input = WebDriver.FindElement(By.ClassName("t2vtad"));
            input.Click();
            Thread.Sleep(2000);

            //Alterando o filtro de data dos resultados para 24 horas
            input = WebDriver.FindElement(By.CssSelector("#tn_1 > span:nth-child(4)"));
            input.Click();
            Thread.Sleep(2000);

            input = WebDriver.FindElement(By.CssSelector("#lb > div > g-menu > g-menu-item:nth-child(3)"));
            input.Click();
            Thread.Sleep(2000);

            //Testando User do Login
            input = WebDriver.FindElement(By.CssSelector("#gb > div > div.gb_We > a"));
            input.Click();
            Thread.Sleep(2000);

            input = WebDriver.FindElement(By.Name("identifier"));
            input.SendKeys("docsmotion@gmail.com");
            Thread.Sleep(2000);

            input = WebDriver.FindElement(By.Id("identifierNext"));
            input.Click();
            Thread.Sleep(2000);
            


        }

        private WebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();

            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }
    }

}