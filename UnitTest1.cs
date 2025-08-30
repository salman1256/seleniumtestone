using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests;

public class GoogleSearchTests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");   // Headless mode for Jenkins
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");

        driver = new ChromeDriver(options);
    }

    [Test]
    public void GoogleSearch_ShouldShowResults()
    {
        driver.Navigate().GoToUrl("https://www.google.com");
        var searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Jenkins Selenium .NET");
        searchBox.Submit();

        Assert.IsTrue(driver.Title.Contains("Jenkins"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

}