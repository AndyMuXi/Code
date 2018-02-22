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
import pymysql


class FtPipeline(object):

    #    def open_spider(self, spider):
    #        self.db = pymysql.connect(
    #            host="localhost", user="root", password="Mac199707", db="article", port=3306)

    def process_item(self, item, spider):
        '''
        fname = item['title'].replace('/', '').replace('\n', '')

        f = open("FT中文网" + fname + ".txt", "w", encoding='utf-8')
        try:
            aritcle = item['title'] + "\n" + \
                item['en'] + item['zh'] + "\n\n"
            f.write(aritcle)
        except:
            pass

        f.close()
        '''
        db = pymysql.connect(host="localhost", user="root",
                             password="Mac199707", db="article", port=3306)

        cur = db.cursor()
        sql_insert = "insert into ft(title,content_en,content_zh) values(% s, % s,% s)"
        try:
            cur.execute(sql_insert, (item['title'], item['en'], item['zh']))
            db.commit()
        except:
            pass

    # self.db = pymysql.connect(host="localhost", user="root",
    #                          password="Mac199707", db="article", port=3306)
    #cur = self.db.cursor()
    #sql_insert = "insert into ft(title,content_en,content_zh) values(% s, % s,% s)"
    # try:
    #    cur.execute(sql_insert, (item['title'], item['en'], item['zh']))
    #    self.db.commit()
    # except:
    #    pass

#    def close_spider(self, spider):
#        self.db.close()
