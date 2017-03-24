using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Utility.Helper;

namespace WebSpiderFrame
{
    class Program
    {
        /// <summary>
        /// Demo示例，抓取天眼查网站的数据（wwww.tianyancha.com），这个网站反爬虫比较厉害，一般的方法获取重要数据基本没用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WebDriverHelper driver = new WebDriverHelper();

            var html = driver.GetPhantomJSSpider("http://bj.tianyancha.com/search");//通过PhantomJs来渲染列表页

            if (!string.IsNullOrEmpty(html))
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                HtmlNode node = doc.DocumentNode;

                var nodeList = node.SelectNodes("//div[@class='search_right_item']//a[contains(@class,'query_name')]");

                if (nodeList == null)
                {
                    return;
                }

                foreach (var item in nodeList)
                {
                    var link = item.Attributes["href"].Value;
                    Console.WriteLine("{0}的url：{1}", item.InnerText, link);

                    var html2 = driver.GetChromeSpider(link);//通过Chrome游览器来渲染详细页（详细页用PhantomJs有些元素渲染不出来）
                    driver.Driver.Quit();
                    if(!string.IsNullOrEmpty(html2))
                    {

                    }
                }
            }

            
            driver.Driver.Dispose();
        }
    }
}
