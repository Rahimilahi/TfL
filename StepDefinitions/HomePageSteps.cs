using NUnit.Framework;
using TfL.Pages;


namespace TfL.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
  
        public HomePageSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [Given(@"the user navigates to the tfl home page")]
        public void GivenTheUserNavigatesToTheTflHomePage()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://www.tfl.gov.uk");
        }

        [When(@"click on accept all the cookie button")]
        public void GivenClickOnAcceptAllTheCookieButton()
        {
            homePage.ClickOnAcceptAllCookies();
        }

        [When(@"I enter ""([^""]*)"" in the from field")]
        public void GivenIEneterInTheFromField(string fromFieldText)
        {
            homePage.EnterFromFieldText(fromFieldText);
        }

        [When(@"I enter ""([^""]*)"" in the to field")]
        public void GivenIEneterInTheToField(string toFieldText)
        {
            homePage.EnterToFieldText(toFieldText);
        }

        [When(@"I click plan my journey button")]
        public void GivenIClickPlanMyJourneyButton()
        {
            homePage.ClickOnPlanMyJourneyButton();
        }

        [Then(@"I should see error message ""([^""]*)"" on the from field")]
        public void ThenIShouldSeeErrorMessageOnTheFromField(string expectedMessage)
        {
            string actualMessage = homePage.GetFromFieldErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage, $"Actual message was {actualMessage} but was expecting {expectedMessage}");
        }
        [Then(@"I should see error message ""([^""]*)"" on the to field")]
        public void ThenIShouldSeeErrorMessageOnTheToField(string expectedMessage)
        {
            string actualMessage = homePage.GetToFieldErrorMessage();
            Assert.AreEqual(expectedMessage, actualMessage, $"Actual message was {actualMessage} but was expecting {expectedMessage}");
        }

        [When(@"I click on change time")]
        public void GivenIClickOnChangeTime()
        {
            homePage.ClickOnChangeDeprtureTimeLink();
        }

        [When(@"I click on the ""([^""]*)"" option")]
        public void GivenIClickOnTheOption(string option)
        {
            switch (option)
            {
                case "Arriving":
                    homePage.ClickOnArrivingOption();
                    break;
                case "Leaving":
                    homePage.ClickOnLeavingOption();
                    break;
            }
        }

        [When(@"I select ""([^""]*)"" as a date")]
        public void GivenISelectAsADate(string date)
        {
            homePage.SelectDateOption(date);
        }

        [When(@"I Select ""([^""]*)"" as a time")]
        public void GivenISelectAsATime(string time)
        {
            homePage.SelectTimeOption(time);
        }

        [When(@"I click on ""([^""]*)"" tab")]
        public void WhenIClickOnTab(string tab)
        {
            switch (tab)
            {
                case "New":
                    homePage.ClickOnNewTabLink();
                    break;
                case "My journeys":
                    homePage.ClickOnMyJourneysTabLink();
                    break;
                case "Recents":
                    homePage.ClickOnRecentsTabLink();
                    break;
            }
        }

        [When(@"I turn on recent journey feature")]
        public void WhenITurnOnRecentJourneyFeature()
        {
            homePage.ClickOnTurnOnRecentJourneyFeature();
        }

        [When(@"I click on the tfl logo")]
        public void ThenIClickOnTheTflLogo()
        {
            homePage.ClickOnTflLogo();
        }

        [Then(@"I click on journey number (.*)")]
        public void ThenIClickOnJourneyNumber(int position)
        {
            homePage.ClcikOnRecentJourneyList();
        }


    }
}