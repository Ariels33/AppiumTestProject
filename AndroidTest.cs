using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;

namespace VillageAppiumAutomation
{
    public class AndroidTest
    {
        private AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {

            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");

            AppiumServiceBuilder builder = new AppiumServiceBuilder();
            AppiumLocalService service = builder.Build();
            service.Start();

            driver = new AndroidDriver<AndroidElement>(service, capabilities);
            // driver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }

        [Test]
        public void ConnectionTest()
        {

            driver.PressKeyCode(AndroidKeyCode.Home);

            driver.Quit();
        }
    }
}