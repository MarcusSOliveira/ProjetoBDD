using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox; 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;
//using OpenQA.Selenium.IE;

using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.Web.Tests.Steps
{
    [Binding] //Classe ser reconhecida pelo spec-flow
    public class ManterDepartamentos
    {
        //Atributo para o selenium
        private IWebDriver driver;

        [Given(@"Acessar a pagina de cadastro de departamento")]
        public void DadoAcessarAPaginaDeCadastroDeDepartamento()
        {
            //driver = new ChromeDriver();
            //driver = new InternetExplorerDriver();
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:33310/departamento/cadastro");


        }

        [Given(@"Informar o nome ""(.*)""")]
        public void DadoInformarONome(string param)
        {// O nome vem do id da página
            driver.FindElement(By.Id("nome")).SendKeys(param);
        }

        [When(@"Solicitar o cadastro")]
        public void QuandoSolicitarOCadastro()
        {
            driver.FindElement(By.Id("btncadastro")).Click();
        }

        [Then(@"Sistema exibe mensagem ""(.*)""")]
        public void EntaoSistemaExibeMensagem(string mensagem)
        {
            //capturar o conteudo da <div id='mensagem'>
            Assert.AreEqual(mensagem, driver.FindElement(By.Id("mensagem")).Text);
        }

        [Given(@"Nao preencher o nome do departamento")]
        public void DadoNaoPreencherONomeDoDepartamento()
        {
            driver.FindElement(By.Id("nome")).Clear();
        }

        [Then(@"Sistema exibe mensagem de erro ""(.*)""")]
        public void EntaoSistemaExibeMensagemDeErro(string mensagem)
        {
            Assert.AreEqual(mensagem, driver.FindElement(By.Id("erronome")).Text);
        }
        
    }
}
