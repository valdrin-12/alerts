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
    internal class Alertmessage22
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {

            // new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // driver = new EdgeDriver();
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }
        [Test]
        public void TestAlert()
        {

            string name = "Rahul";
             driver.FindElement(By.CssSelector("#name")).SendKeys(name);
            driver.FindElement(By.CssSelector("#confirmbtn")).Click();
            Thread.Sleep(3000);
            string alertText = driver.SwitchTo().Alert().Text;
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();
            // driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            StringAssert.Contains(name, alertText);

        }
        //ok

    }
}
