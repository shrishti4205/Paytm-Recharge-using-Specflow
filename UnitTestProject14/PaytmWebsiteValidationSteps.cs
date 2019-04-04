using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Test.Pages;

namespace UnitTestProject14
{
    [Binding]
    public class PaytmWebsiteValidationSteps
    {
        private bool _noelementfound;
        private PaytmMobilePage _paytmmobil;
        private PaytmHomePage _paytmhome;
        IWebDriver driver = new ChromeDriver();
        [Given]
        public void GivenThatPaytmIsOpenedInTheWebBrowser()
        {
            _paytmhome = new PaytmHomePage(driver);
            _paytmhome.goToPage();
        }

        [Given]
        public void GivenINavigateToMobileTab()
        {
            _paytmmobil = _paytmhome.goToPaytmMobilePage();
        }

        [Given]
        public void GivenThenEnterTheMobileNumberAmount()
        {
            _paytmmobil.EnterNumber("8296865364");
            _paytmmobil.EnterTheAmount(new ProprtiesClass().amount);
        }

        [When]
        public void WhenInsideThePaytmWebsite()
        {
            _paytmhome.seeIfPresent();
        }

        [When]
        public void WhenClickedOnProceedToRecharge()
        {
            _paytmmobil.ProceedToRecharge();
        }

        [Then]
        public void ThenThereShouldBeMobileElectricityDTHMetro()
        {
            Assert.IsFalse(_noelementfound);
        }

        [Then]
        public void ThenItShouldRedirectTo_P0(string p0)
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[2]")));
        }
        [AfterScenario]
        public void Dispose()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
