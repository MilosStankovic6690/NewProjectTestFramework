using NewProjectTestFramework.Driver;
using NewProjectTestFramework.Page;

namespace NewProjectTestFramework
{
    public class Tests
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }
        [Test]
        public void TC01_FillInutWithValidData_ShouldAllDataDisplayedInInput()
        {
            Login("Milos", "milosss");
            _homePage.Initials.SendKeys("MM");
            _homePage.Tittle("Mr.");
            _homePage.FirstName.SendKeys("Milos");
            _homePage.MiddleName.SendKeys("Stankovic");
            _homePage.Female.Click();
            _homePage.Hindi.Click();
            _homePage.SaveButton.Click();
            
        }

        [Test]
        public void TC02_OpenPopUp_ShouldDisplayed()
        {
            Login("name", "pass");
            _homePage.HtmlPopup.Click();


        }


        [Test]
        public void TC03_OpenAlert_ShouldDisplayed()
        {
            Login("name", "password");
            _homePage.Alert();


        }


        public void Login(string name, string password)
        {
            _loginPage.LogginOnPage(name, password);
        }


    }
}