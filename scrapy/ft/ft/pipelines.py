# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html


# class FtPipeline(object):
#    def open_spider(self, spider):
#        self.f = open(item['title'] + ".txt", "w")

#    def function():
#        pass

# def process_item(self, item, spider):
#    aritcle = item['title']+item['en'] + item['zh']
#    self.f.write(aritcle)
#   return item
class FtPipeline(object):
    # def open_spider(self, spider):
    #    self.f = open("FT中文网双语新闻 - FT中文网.txt", "w")

    def process_item(self, item, spider):

        fname = item['title'].replace('/', '').replace('\n', '')

        f = open("FT中文网" + fname + ".txt", "w", encoding='utf-8')
        try:
            aritcle = item['title'] + "\n" + item['en'] + item['zh'] + "\n\n"
            f.write(aritcle)
        except:
            pass

   # def close_spider(self, spider):
   #     f.close()
