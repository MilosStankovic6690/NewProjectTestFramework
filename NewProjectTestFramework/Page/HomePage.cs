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

        public void SelectOptionTittle(string option)
        {
            SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
            drop.SelectByText(option);
        }

        public IWebElement Initials => _driver.FindElement(By.Id("Initial"));
        public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName => _driver.FindElement(By.Id("MiddleName"));
        public IWebElement Gender => _driver.FindElement(By.Name("Male"));
        public IWebElement LanguagesKnown => _driver.FindElement(By.Name("english"));
        public IWebElement ButtonSave => _driver.FindElement(By.Name("Save"));
        public IWebElement JavaScriptAlert => _driver.FindElement(By.Name("generate"));

        public void InputData(string MM, string Milos, string Misa)
        {
            Initials.SendKeys("MM");
            FirstName.SendKeys("Milos");
            MiddleName.SendKeys("Misa");
            Gender.Click();
            LanguagesKnown.Click();
            ButtonSave.Click();
            JavaScriptAlert.Click();

        }
       

      
    }
}
