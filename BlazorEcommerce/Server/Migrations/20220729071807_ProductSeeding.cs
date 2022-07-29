﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "现代社会中，消费行为无处不在，基于信息产品的生产、分配、流通与消费的循环，人、信息、媒介之间的互动关系也是其中的有机组成部分。对于这种关系的感知、描摹与透析不仅对媒介活动本身有实践指导意义，更对整个经济体系的良性发展有益。", "http://t14.baidu.com/it/u=237061475,81843315&fm=224&app=112&f=JPEG?w=350&h=350", 9.99m, "媒介消费新论" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "本书由两部分构成，分为十二章，力图通过浅显生动的介绍和描述，把图书和图书馆的历史、图书馆的精神和文化、图书馆的历史使命、图书馆对读者的影响和成就呈现给读者；通过仔细精到的解说，把利用图书馆获取纸本刊物图书资源和各类常用数字化资源特色数据库的方法演示给读者。本书兼具学术性、知识性、可读性，既适宜作为高职院校文献信息利用课程教材使用，也适合一般读者阅读。", "http://t15.baidu.com/it/u=1623489819,611291264&fm=224&app=112&f=JPEG?w=500&h=500&s=B9285D3203536BCC7CED59D5030080A2", 7.99m, "走进图书馆殿堂" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, " 时下对纸媒来说无疑是寒冬季节，面对纸媒的一步步衰退，再言传统纸媒如何“转型”已不相宜。单亿春著的《下一个出口(纸媒的革命之路)》试图以传统纸媒的“革命”为旗帜，探索如何革掉纸媒固有的、与时代不相适宜的部分，融进时代的新鲜血液，以期实现纸媒的价值重构和涅槃重生。", "http://t15.baidu.com/it/u=1443127998,2675026579&fm=224&app=112&f=JPEG?w=322&h=500", 6.99m, "下一个出口" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}