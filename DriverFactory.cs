using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverManager;
using WebDriverManager.Models;

namespace Google.Drivers {
    public class DriverFactory {
        public static IWebDriver CreateDriver() {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--no-sandbox");
            IWebDriver driver = new ChromeDriver(options);
            return driver;
        }

        public static void QuitDriver(IWebDriver driver) {
            if (driver != null) {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}