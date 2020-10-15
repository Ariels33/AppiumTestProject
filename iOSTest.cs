using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;

namespace VillageAppiumAutomation
{
    public class iOSTest
    {
        private IOSDriver<IOSElement> driver;

        [SetUp]
        public void Setup()
        {

            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            capabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 11");

            AppiumServiceBuilder builder = new AppiumServiceBuilder();
            AppiumLocalService service = builder.Build();
            service.Start();

            driver = new IOSDriver<IOSElement>(service, capabilities);
            // driver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }

        [Test]
        public void ConnectionTest()
        {

            driver.FindElementByAccessibilityId("Photos").Click();

            //TouchAction action = new TouchAction(driver);
            //action.Tap(140, 457);
            //action.Perform();

            driver.Quit();
        }
    }
}