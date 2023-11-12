using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace TfL.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            var options = new ChromeOptions { };
            options.AddUserProfilePreference("profile.cookie_controls_mode", 0);
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            
            _driverHelper.Driver = new ChromeDriver(options);
            _driverHelper.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _driverHelper.Driver.Manage().Window.Maximize();
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}