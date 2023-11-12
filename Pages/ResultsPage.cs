using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Data;

namespace TfL.Pages
{
    public class ResultsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        private IWebElement Map => driver.FindElement(By.XPath("//div[contains(@aria-label, 'Map')]"));
        private IWebElement ResultsError => driver.FindElement(By.CssSelector("li.field-validation-error"));
        private IWebElement EditJourneyLink => driver.FindElement(By.ClassName("edit-journey"));
        private IWebElement FromField => driver.FindElement(By.Id("InputFrom"));
        private IWebElement ToField => driver.FindElement(By.Id("InputTo"));
        private IWebElement ResultsPageHeaderTitle => driver.FindElement(By.CssSelector("h1 span"));

        public void ClickOnEditJourneyLink()
        {
            EditJourneyLink.Click();
        }

        public bool IsMapDisplayed()
        {
            wait.Until(driver => Map);
            return Map.Displayed;
        }

        public string GetReultsErrorMesage()
        {
            wait.Until(driver => ResultsError);
            return ResultsError.Text;
        }
        public void ClearFromField()
        {
            FromField.SendKeys(Keys.Clear);
        }

        public void ClearToField()
        {
            ToField.SendKeys(Keys.Clear);
        }

        public string GetPageHeaderTitle()
        {
            return ResultsPageHeaderTitle.Text;
        }
    }
}
