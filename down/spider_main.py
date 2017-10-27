import url_manager,html_downloader,html_parser,html_outputer



class spider_main(object):
    def __init__(self):
        self.urls = url_manager.url_manager()
        self.downloader =html_downloader.html_downloader()
        self.parser = html_parser.html_parser()
        self.output = html_outputer.html_outputer()

    def craw(self,root_url):
        self.urls.add_new_url(root_url)
        while self.urls.has_new_url():
            new_url = self.urls.get_new_url()
            html_cont = self.downloader.download(new_url)
            new_urls, new_data = self.parser.parse(new_url,html_cont)
            self.urls.add_new_urls(new_urls)
            self.outputer.collect_data(new_data)

        self.outputer.output_html()

if __name__=="__main__":
    root_url = "http://www.baidu.com"
    obj_spdier = spider_main()
    obj_spdier.craw(root_url)
