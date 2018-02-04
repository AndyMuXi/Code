# -*- coding: utf-8 -*-
import scrapy


class DemoOneSpider(scrapy.Spider):
    name = 'demo_one'
    # allowed_domains = ['python123.io']
    start_urls = ['http://python123.io/ws/demo.html']

    def parse(self, response):
        fname = response.url.split('/')[-1]
        with open(fname, 'wb') as f:
            f.write(response.body)
        self.log('Saved files %s.' % fname)
