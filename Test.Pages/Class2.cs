using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Pages
{

    public class PaytmHomePage
    {
        private bool NoelementFound;
        private readonly IWebDriver _driver;
        public PaytmHomePage(IWebDriver driver)
        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='http://www.paytm.com/recharge']")]
        private IWebElement Mobile;
        public bool seeIfPresent()
        {
            try
            {
                _driver.FindElement(By.XPath(ElementsPath._mobile));//Mobile 
                _driver.FindElement(By.XPath(ElementsPath._electricity));//electricity
                _driver.FindElement(By.XPath(ElementsPath._dth));//DTH
                _driver.FindElement(By.XPath(ElementsPath._metro));//Metro

            }
            catch (Exception e)
            {
                return NoelementFound = true;
            }
            return NoelementFound = false;
        }

        public void goToPage()
        {
            _driver.Navigate().GoToUrl(ElementsPath._url);
        }

        public PaytmMobilePage goToPaytmMobilePage()
        {
            _driver.Navigate().GoToUrl(ElementsPath._mobileurl);
            return new PaytmMobilePage(_driver);
        }
    }
}
