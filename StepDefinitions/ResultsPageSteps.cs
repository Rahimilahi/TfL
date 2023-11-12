using NUnit.Framework;
using TfL.Pages;

namespace TfL.StepDefinitions
{
    [Binding]
    public sealed class ResultsPageSteps
    {
        private DriverHelper _driverHelper;
        ResultsPage resultsPage;

        public ResultsPageSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            resultsPage = new ResultsPage(_driverHelper.Driver);
        }

        [Then(@"the map is diplayed")]
        public void ThenTheMapIsDiplayed()
        {

            Assert.That(resultsPage.IsMapDisplayed(), Is.True);
        }

        [Then(@"I should see ""([^""]*)"" error message on journey results")]
        public void ThenIShouldSeeErrorMessageOnJourneyResults(string expectedMessage)
        {
            string actualMessage = resultsPage.GetReultsErrorMesage();
            Assert.AreEqual(expectedMessage, actualMessage, $"Actual message was {actualMessage} but was expecting {expectedMessage}");
        }

        [When(@"I click on edit journey")]
        public void GivenIClickOnEditJourney()
        {
            resultsPage.ClickOnEditJourneyLink();
        }
      
        [Then(@"The results page with ""([^""]*)"" is displayed")]
        public void ThenTheResultsPageWithIsDisplayed(string expectedMessage)
        {
            string actualMessage = resultsPage.GetPageHeaderTitle();
            Assert.AreEqual(expectedMessage, actualMessage, $"Actual message was {actualMessage} but was expecting {expectedMessage}");
        }
    }
}
