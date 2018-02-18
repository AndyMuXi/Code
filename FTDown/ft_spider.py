from urllib import request
from bs4 import BeautifulSoup
import re


class UrlManager(object):
    """docstring for UrlManager"""

    def __init__(self):
        self.new_urls = set()
        self.old_urls = set()

    def add_url(self, url):
        if url is None:
            return
        if url not in self.new_urls and url not in self.old_urls:
            self.new_urls.add(url)

    def add_urls(self, urls):
        if urls is None or len(urls) == 0:
            return
        for url in urls:
            self.add_url(url)

    def exists_url(self):
        return(len(self.new_urls != 0))

    def pop_url(self):
        crawl_url = self.new_urls.pop()
        self.old_urls.add(crawl_url)
        return crawl_url


class Downloader(object):
    """docstring for Downloader"""

    def download_html(self, url):
        if url is None:
            return
        response = request.urlopen(url)
        if response.getcode() != 200:
            return None
        return response.read()


class Parser(object):
    """docstring for Parser"""

    def parser_html(self, html):
        pass


class Outputer(object):
    """docstring for Outputer"""

    def __init__(self):
        pass
