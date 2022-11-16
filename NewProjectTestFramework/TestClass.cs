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
            Login("execute", "automation");
        }

        [Test]
        public void TC02_OpenPopUp_ShouldDisplayed()
        {
            Login("execute", "automation");


        }


        [Test]
        public void TC03_OpenAlert_ShouldDisplayed()
        {
            Login("execute", "automation");


        }


        public void Login(string Milos, string Milosss)
        {
            _loginPage.LogginOnPage(Milos, Milosss);
        }


    }
}