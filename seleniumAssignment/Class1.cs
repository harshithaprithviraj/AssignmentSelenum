using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class BlankSellerNameTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/test/new_form.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheBlankSellerNameTest()
        {
            driver.Navigate().GoToUrl("http://localhost/test/new_form.php");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("ALBERT STREET");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("WATERLOO");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=email | ]]
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("mich@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2268456231");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2004");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Please enter seller name !", CloseAlertAndGetItsText());
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Displayed);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
    [TestFixture]
    public class BlankAddressTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/test/new_form.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheBlankAddressTest()
        {
            driver.Navigate().GoToUrl("http://localhost/test/new_form.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("jeffery");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("jeff@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2269785214");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("lexus");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("gsf");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2007");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Please enter address !", CloseAlertAndGetItsText());
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Displayed);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
    [TestFixture]
    public class InvalidEmailTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/test/new_form.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheInvalidEmailTest()
        {
            driver.Navigate().GoToUrl("http://localhost/test/new_form.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Dolly");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("waterloo");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys(".com");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Assignment'])[1]/following::table[1]")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2265415203");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("swift");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2007");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Invalid email address format!", CloseAlertAndGetItsText());
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Displayed);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
    [TestFixture]
    public class InvalidPhoneNumberTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/test/new_form.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheInvalidPhoneNumberTest()
        {
            driver.Navigate().GoToUrl("http://localhost/test/new_form.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("yuvi");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("westmount");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("yuv@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("5621");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("foed");
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.Id("model")).Clear();
            driver.FindElement(By.Id("model")).SendKeys("Mustang");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=year | ]]
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2010");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Invalid Phone format!", CloseAlertAndGetItsText());
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Displayed);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
    [TestFixture]
    public class BlankModelTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/test/new_form.php";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheBlankModelTest()
        {
            driver.Navigate().GoToUrl("http://localhost/test/new_form.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Rammy");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("east road");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("cambridge");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("ramm@gmail.com");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2136547586");
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.Id("make")).Clear();
            driver.FindElement(By.Id("make")).SendKeys("Ford");
            driver.FindElement(By.Id("year")).Click();
            driver.FindElement(By.Id("year")).Clear();
            driver.FindElement(By.Id("year")).SendKeys("2010");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Click();
            Assert.AreEqual("Please enter model!", CloseAlertAndGetItsText());
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year *'])[1]/following::input[2]")).Displayed);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
