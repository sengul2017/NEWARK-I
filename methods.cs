using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;


namespace newark011618
{
	class Methods
	{

		IWebDriver driver = new ChromeDriver();
		//ChromeOptions controloptions = new ChromeOptions();
		// DesiredCapabilities capability = new DesiredCapabilities();
		//  capability



		public void SetupDriver()
		{
			driver.Url = ("http://newarkjobs2020.com/");
		}


		public void Login()
		{
			Thread.Sleep(2000);
			var login = driver.FindElement(By.Id(CtrlIds.id_login));
			login.Click();
			Thread.Sleep(2000);
			var username = driver.FindElement(By.Id(CtrlIds.id_username));
			username.SendKeys(Inputs.input_username);
			var password = driver.FindElement(By.Id(CtrlIds.id_password));
			password.SendKeys(Inputs.input_password);
			var login_button = driver.FindElement(By.XPath(CtrlIds.xpath_loginbtn));
			login_button.Click();
		}


		public void Logout()
		{
			Thread.Sleep(3000);
			var logout = driver.FindElement(By.LinkText(CtrlIds.linktxt_logout));
			logout.Click();
		}


		public void AdvancedJobSearch()
		{
			Thread.Sleep(2000);
			var aJS = driver.FindElement(By.LinkText(CtrlIds.linktxt_Ajs));
			aJS.Click();
			Thread.Sleep(2000);
			var searchfor = driver.FindElement(By.Id(CtrlIds.id_searchfor));
			searchfor.SendKeys(Inputs.input_searchfor);
			var findjobs = driver.FindElement(By.XPath(CtrlIds.xpath_findjobs));
			findjobs.Click();
		}


		public void JSA()
		{
			Thread.Sleep(3000);
			var jsa = driver.FindElement(By.LinkText(CtrlIds.linktxt_jsa));
			jsa.Click();
			Thread.Sleep(3000);
			var create_new = driver.FindElement(By.XPath(CtrlIds.xpath_createNew));
			create_new.Click();
			Thread.Sleep(3000);
			var email_address = driver.FindElement(By.Id(CtrlIds.id_emailadd));
			email_address.SendKeys(Inputs.input_emailadd);
			var keywords = driver.FindElement(By.Id(CtrlIds.id_keywords));
			keywords.SendKeys(Inputs.input_keywords);
			var keyword_opt = driver.FindElement(By.Name(CtrlIds.name_kwOption));
			var kw_select = new SelectElement(keyword_opt);
			kw_select.SelectByValue("1");
			var zipcode = driver.FindElement(By.Name(CtrlIds.name_zip));
			zipcode.SendKeys(Inputs.input_zipcode);
			var radius = driver.FindElement(By.Name(CtrlIds.name_radius));
			var radius_opt = new SelectElement(radius);
			radius_opt.SelectByValue("10");
			var active = driver.FindElement(By.XPath(CtrlIds.xpath_active));
			active.Click();
			var create_button = driver.FindElement(By.XPath(CtrlIds.xpath_createBtn));
			create_button.Click();
			var delete = driver.FindElement(By.XPath(CtrlIds.xpath_delete));                         // delete the jsa row created
			delete.Click();
			Thread.Sleep(3000);
			var del_yes = driver.FindElement(By.XPath(CtrlIds.xpath_deleteYes));
			del_yes.Click();
		}








	}
}