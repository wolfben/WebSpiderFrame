using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Utility.Helper;
using OpenQA.Selenium.Chrome;


namespace Utility.Helper
{
    /// <summary>
    /// WebDriver帮助类，详情见http://seleniumhq.github.io/selenium/docs/api/dotnet/
    /// 其中在程序exe目录下需要phantomjs.exe，chromedriver.exe等各种驱动程序
    /// </summary>
    public class WebDriverHelper
    {
        public IWebDriver Driver { get; set; }

        public  string GetChromeSpider(string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            return Driver.PageSource;
        }

        public  string GetPhantomJSSpider(string url)
        {
            Driver = new PhantomJSDriver();
            Driver.Navigate().GoToUrl(url);
            return Driver.PageSource;
        }

        /// <summary>
        /// 设置代理服务器
        /// </summary>
        /// <returns></returns>
        private  PhantomJSDriverService GetPhantomJSDriverService()
        {
            PhantomJSDriverService pds = PhantomJSDriverService.CreateDefaultService();
            //设置代理服务器地址
            //pds.Proxy = $"{ip}:{port}"; 
            //设置代理服务器认证信息
            //pds.ProxyAuthentication = GetProxyAuthorization();
            return pds;
        }
    }
}
