using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = NewProjectTestFramework.Driver.WebDriver;


namespace NewProjectTestFramework.Page
{
    public class LoginPage
    {
        private IWebDriver _driver = WebDriver.Instance;

        public IWebElement UserName => _driver.FindElement(By.Name("UserName"));
        public IWebElement Password => _driver.FindElement(By.Name("Password"));
        public IWebElement Login => _driver.FindElement(By.Name("Login"));

        public void LogginOnPage(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            Login.Submit();

        }
             
    }
}
