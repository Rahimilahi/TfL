using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TfL.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
           this.driver = driver;
        }

        private IWebElement AcceptAllCookies => driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));
        private IWebElement FromField => driver.FindElement(By.Id("InputFrom"));
        private IWebElement ToField => driver.FindElement(By.Id("InputTo"));
        private IWebElement PlanMyJourneyButton => driver.FindElement(By.Id("plan-journey-button"));
        private IWebElement FromFieldErrorMessage => driver.FindElement(By.Id("InputFrom-error"));
        private IWebElement ToFieldErrorMessage => driver.FindElement(By.Id("InputTo-error"));
        private IWebElement ChangeDepartureTimeLink => driver.FindElement(By.ClassName("change-departure-time"));
        private IWebElement ArrivingOption => driver.FindElement(By.Id("arriving"));
        private IWebElement LeavingOption => driver.FindElement(By.Id("departing"));
        private IWebElement DateOption => driver.FindElement(By.Id("Date"));
        private IWebElement TimeOption => driver.FindElement(By.Id("Time"));
        private IWebElement NewTabLink => driver.FindElement(By.Id("jp-new-tab-home"));
        private IWebElement MyJourneysTabLink => driver.FindElement(By.Id("jp-fav-tab-home"));
        private IWebElement RecentsTabLink => driver.FindElement(By.Id("jp-recent-tab-home"));
        private IWebElement TurnOnRecentJourneyFeature => driver.FindElement(By.CssSelector("#jp-recent-content-home- .turn-on-recent-journeys"));
        private IWebElement TflLogo => driver.FindElement(By.ClassName("logo"));
        private IWebElement RecentJourneyList => driver.FindElement(By.XPath("//div[@id= 'recent-journeys']//div[@id= 'jp-recent-content-home-']/a[1]"));

        public void ClickOnAcceptAllCookies( )
        {
            AcceptAllCookies.Click();
        }

       public void EnterFromFieldText(string text) 
        {
            FromField.SendKeys(text + Keys.Tab);
        }

        public void EnterToFieldText(string text) 
        {
            ToField.SendKeys(text + Keys.Tab);
        }

        public void ClickOnPlanMyJourneyButton()
        {
            PlanMyJourneyButton.Click();
        }


        public void ClickOnChangeDeprtureTimeLink()
        { 
            ChangeDepartureTimeLink.Click();
        }

        public void ClickOnArrivingOption()
        {
            ArrivingOption.Click();
        }

        public void ClickOnLeavingOption()
        {
            LeavingOption.Click();
        }


        public string GetFromFieldErrorMessage()
        {
            return FromFieldErrorMessage.Text;
        }
        public string GetToFieldErrorMessage()
        {
            return ToFieldErrorMessage.Text;
        }


        public void SelectDateOption(string date)
        {
            SelectElement select = new SelectElement(DateOption);
            select.SelectByText(date);
        }

        public void SelectTimeOption(string time)
        {
            SelectElement select = new SelectElement(TimeOption);
            select.SelectByText(time);
        }

        public void ClickOnNewTabLink()
        {
            NewTabLink.Click();
        }

        public void ClickOnMyJourneysTabLink()
        {
            MyJourneysTabLink.Click();
        }

        public void ClickOnRecentsTabLink()
        {
            RecentsTabLink.Click();
        }
        public void ClickOnTurnOnRecentJourneyFeature()
        {
            TurnOnRecentJourneyFeature.Click();
        }

        public void ClickOnTflLogo()
        {
            TflLogo.Click();
        }

        public void ClcikOnRecentJourneyList()
        {
            RecentJourneyList.Click();
        }
    }
}
