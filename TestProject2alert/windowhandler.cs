using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject2alert
{
   public class Windowhandler
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser1()
        {

            // new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // driver = new EdgeDriver();
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }
        [Test]
        public void WindowHandlermethod()
        {

            driver.FindElement(By.CssSelector("body > header > a.blinkingText")).Click();
            Assert.That(driver.WindowHandles.Count, Is.EqualTo(2));
            string childWindowName = driver.WindowHandles[1];

            driver.SwitchTo().Window(childWindowName);
            TestContext.Progress.WriteLine(driver.FindElement(By.CssSelector("#interview-material-container > div > div.col-md-8 > p.im-para.red")).Text);

        }
        //ok

    }
}