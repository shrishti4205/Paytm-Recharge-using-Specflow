using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Pages
{
    public class PaytmMobilePage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public PaytmMobilePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        public void EnterNumber(String number)
        {
            _driver.FindElement(By.XPath(ElementsPath._mobilenoinput)).SendKeys(number);
        }
        public void EnterTheAmount(String amount)
        {
            _driver.FindElement(By.XPath(ElementsPath._amountinput)).SendKeys(amount);

        }
        public void ProceedToRecharge()
        {
            _driver.FindElement(By.XPath(ElementsPath._rechargebutton)).SendKeys(Keys.Return);

        }
    }
}
