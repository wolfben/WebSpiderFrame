# WebSpiderFrame简介（基于游览器模式的爬虫抓取框架）
  WebSpiderFrame不同于普通的爬虫开发框架，该框架主要是用于一些特殊反爬虫网站的数据抓取，基于本地游览器或PhantomJs的渲染模式；基本能够解决所有正常游览器看到的数据，从而能够很好的抓取反爬虫手段比较高的数据。
# 框架特性
### 1、基于PhantomJs进行渲染获取源码，该模式不会弹出窗口，而且加载效率比游览器加载会高
### 2、基于Chrome模式进行渲染获取源码，该模式会调用本地Chrome游览器进行渲染，但可以控制弹出窗关闭，该模式能够最大程度保留游览器渲染的结构，数据全面但速度会比较慢，主要看运行时的网速
### 3、相比WebBrowser，Web.kit模式，该模式是直接基于本地运行环境下的游览器，所以能够避免各种小问题的出现
