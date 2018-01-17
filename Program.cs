using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace newark011618
{
	class Program
	{
		static void Main(string[] args)
		{
			// Methods obj = new Methods();
			// obj.SetupDriver();
			// obj.Login();
			// obj.Logout();
			// obj.Login();
			// obj.AdvancedJobSearch();
			// obj.Logout();
			// obj.Login();
			// obj.JSA();
			//  obj.Logout();

			IWebDriver driver;
			DesiredCapabilities capability = new DesiredCapabilities();
			capability.SetCapability("device", "iPhone 8");
			capability.SetCapability("realMobile", "true");
			capability.SetCapability("os_version", "11.0");
			capability.SetCapability("browserstack.user", "sengul2");
			capability.SetCapability("browserstack.key", "rpkJC4UKcZyRykoNUokr");

			driver = new RemoteWebDriver(
			  new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability);
			driver.Url = ("http://newarkjobs2020.com/");
			// Methods obj = new Methods();
			// obj.SetupDriver();
			// obj.Login();





		}
	}
}