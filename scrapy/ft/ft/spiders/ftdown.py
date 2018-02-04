# -*- coding: utf-8 -*-
import scrapy
from bs4 import BeautifulSoup
import re


class FtdownSpider(scrapy.Spider):
    name = 'ftdown'
    #allowed_domains = ['http://www.ftchinese.com/rss/feed']
    start_urls = ['http://www.ftchinese.com/channel/ce.html']

    def parse(self, response):
        soup = BeautifulSoup(response.body, "lxml")
        sites = soup.find_all('a', class_="item-headline-link")
        for site in sites:
            try:
                url = "http://www.ftchinese.com" + site.get("href")
                yield scrapy.Request(url, callback=self.parse_url)
            except:
                continue

    def parse_url(self, response):
        articledict = {}

        soup = BeautifulSoup(response.body, 'lxml')

        title = soup.find('title').get_text()

        en_s = soup.find_all('div', class_="leftp")
        en_totle = ""
        for en in en_s:
            en_totle = en_totle + en.get_text()

        zh_s = soup.find_all('div', class_="rightp")
        zh_totle = ""
        for zh in zh_s:
            zh_totle = zh_totle + zh.get_text()

        articledict['title'] = title
        articledict['en'] = en_totle
        articledict['zh'] = zh_totle

        return articledict
