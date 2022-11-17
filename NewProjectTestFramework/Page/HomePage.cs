using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Cast;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = NewProjectTestFramework.Driver.WebDriver;

namespace NewProjectTestFramework.Page
{
    public class HomePage
    {
        private IWebDriver _driver = WebDriver.Instance;

        public void Tittle(string option)
        {
            SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
            drop.SelectByText(option);
        }

        public IWebElement Initials => _driver.FindElement(By.Id("Initial"));
        public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName => _driver.FindElement(By.Id("MiddleName"));
        public IWebElement Female => _driver.FindElement(By.Name("Female"));
        public IWebElement Hindi => _driver.FindElement(By.Name("Hindi"));
        public IWebElement SaveButton => _driver.FindElement(By.Name("Save"));
        public IWebElement HtmlPopup => _driver.FindElement(By.CssSelector(".detail_box a"));
        public IWebElement Generate => _driver.FindElement(By.Name("generate"));

        public void Alert()
        {
            Generate.Click();
            _driver.SwitchTo().Alert().Accept();
            _driver.SwitchTo().Alert().Accept();
        }

        
       

      
    }
}
