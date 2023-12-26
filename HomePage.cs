using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

class HomePage
{
    static void Main()
    {
        // initialize the webdriver
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        // navigate to the homepage
        driver.Navigate().GoToUrl("https://crescentpearls.educare.school/login");
        var usernameField = driver.FindElement(By.Id("email"));
        var passwordField = driver.FindElement(By.Id("password"));
        var loginButton = driver.FindElement(By.XPath("//*[@id=\"loginfrm\"]/div[5]/button"));
        usernameField.SendKeys("nurudeendanjuma@crescentpearls.sch.ng");
        passwordField.SendKeys("password");
        loginButton.Click();

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        var eclassroom = driver.FindElement(By.XPath(
            "//*[@id=\"mbodz\"]/div[2]/div[3]/div[3]/div/div/div[3]/div/div/div/div/div/div[1]/div[2]"));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        eclassroom.Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        driver.Navigate().Back();
        //driver.Quit();

    }
}