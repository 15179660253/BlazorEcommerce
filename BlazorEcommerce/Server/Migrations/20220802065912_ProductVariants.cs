using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "Paperback" },
                    { 3, "E-Book" },
                    { 4, "Audiobook" },
                    { 5, "Stream" },
                    { 6, "Blu-ray" },
                    { 7, "VHS" },
                    { 8, "PC" },
                    { 9, "PlayStation" },
                    { 10, "Xbox" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "Ready Player One" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "Back to the Future" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "Toy Story" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "Half-Life 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "Diablo II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "Day of the Tentacle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "Xbox" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "Super Nintendo Entertainment System" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 2, 19.99m, 9.99m },
                    { 1, 3, 0m, 7.99m },
                    { 1, 4, 29.99m, 19.99m },
                    { 2, 2, 14.99m, 7.99m },
                    { 3, 2, 0m, 6.99m },
                    { 4, 5, 0m, 3.99m },
                    { 4, 6, 0m, 9.99m },
                    { 4, 7, 0m, 19.99m },
                    { 5, 5, 0m, 3.99m },
                    { 6, 5, 0m, 2.99m },
                    { 7, 8, 29.99m, 19.99m },
                    { 7, 9, 0m, 69.99m },
                    { 7, 10, 59.99m, 49.99m },
                    { 8, 8, 24.99m, 9.99m },
                    { 9, 8, 0m, 14.99m },
                    { 10, 1, 299m, 159.99m },
                    { 11, 1, 399m, 79.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "现代社会中，消费行为无处不在，基于信息产品的生产、分配、流通与消费的循环，人、信息、媒介之间的互动关系也是其中的有机组成部分。对于这种关系的感知、描摹与透析不仅对媒介活动本身有实践指导意义，更对整个经济体系的良性发展有益。", 9.99m, "媒介消费新论" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "本书由两部分构成，分为十二章，力图通过浅显生动的介绍和描述，把图书和图书馆的历史、图书馆的精神和文化、图书馆的历史使命、图书馆对读者的影响和成就呈现给读者；通过仔细精到的解说，把利用图书馆获取纸本刊物图书资源和各类常用数字化资源特色数据库的方法演示给读者。本书兼具学术性、知识性、可读性，既适宜作为高职院校文献信息利用课程教材使用，也适合一般读者阅读。", 7.99m, "走进图书馆殿堂" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { " 时下对纸媒来说无疑是寒冬季节，面对纸媒的一步步衰退，再言传统纸媒如何“转型”已不相宜。单亿春著的《下一个出口(纸媒的革命之路)》试图以传统纸媒的“革命”为旗帜，探索如何革掉纸媒固有的、与时代不相适宜的部分，融进时代的新鲜血液，以期实现纸媒的价值重构和涅槃重生。", 6.99m, "下一个出口" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "地球农作物因气候转变及枯萎病而经常失收，曾是美国国家航空航天局的工程师和航天飞机驾驶员的库珀（马修·麦康纳饰）被迫成为农民以协助解决粮食危机。库珀的10岁女儿墨菲（麦肯基·弗依饰）发现其房间书架上的书本无故掉到地上，认为这是幽灵现象。不久后，一场沙尘暴在墨菲房间中留下二进制坐标，二人驱车到达坐标位置后发现那是北美空防司令部（美国国家航空航天局的秘密基地）。", 4.99m, "星际穿越" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "来自泰坦星的灭霸为了解决宇宙资源匮乏、人口暴增的问题，集齐了所有无限宝石，一个响指成功地使全宇宙生命随机减半。宇宙由于灭霸的行动而变得满目疮痍，但是五年之后，被困在量子领域的蚁人意外回到现实世界，他的出现为幸存的复仇者点燃了希望。无论前方将遭遇怎样的后果，幸存的复仇者都必须在剩余盟友的帮助下再一次集结，以逆转灭霸的所作所为，彻底恢复宇宙的秩序。", 39.99m, "复仇者联盟4：终局之战" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "被开除军籍的冷锋（吴京饰演）本是因找杀害龙小云的凶手（余男饰演）来到非洲，但是却突然被卷入一场非洲国家的叛乱。因为国家之间政治立场的关系，中国军队无法在非洲实行武装行动撤离华侨。而作为退伍老兵的冷锋无法忘记曾经为军人的使命，本来可以安全撤离的他毅然决然地回到了沦陷区，孤身一人带领身陷屠杀中的同胞和难民，展开生死逃亡。随着斗争的持续，体内的狼性逐渐复苏，最终闯入战乱区域，为同胞而战斗。", 29.99m, "战狼Ⅱ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "游戏以虚构的幻想世界为背景，阴阳二神互相杀伐，导致世界处于永劫之中。玩家需扮演一名英雄，在地图中收集各种资源，与其他玩家对抗，生存到最后。", 97.99m, "永劫无间" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "玩家可以在游戏中做很多事情：制造武器战胜各种各样的敌人及群落；挖掘地下寻找器材配件、金钱和其他有用的东西；收集木材，石材，矿石等资源；用世界里的一切创造你需要的东西并守护它。", 35.99m, "泰拉瑞亚" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "故事发生在名为“交界地”的地方，这里的人们拥戴永恒女王玛莉卡。也受到玛丽卡所祝福。所有接受祝福的人瞳孔中都有黄金一般的光芒，但也有些人因为各种原因失去了祝福，眼中的光芒消逝。这些人就被称为褪色者，并因此被逐出交界地。某天因为作为祝福核心的法环被击碎，祝福受到污染的半神们为了收集法环碎片发动了一场又一场的战争，导致世界变的满目疮痍，褪色者们因为法环破碎恢复了祝福，收集艾尔登法环碎片，挑战半神，而玩家们扮演的角色便是褪色者。", 297.99m, "艾尔登法环" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "在该游戏中，玩家需要在游戏地图上收集各种资源，并在不断缩小的安全区域内对抗其他玩家，让自己生存到最后。", 99.99m, "绝地求生" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Price", "Title" },
                values: new object[] { "在这个大型闯关综艺现场，玩家将和大批参赛者共同面对一场“欲戴皇冠必趁其乱”的冲关竞技。玩家要灵活应对野蛮生长的障碍物，挤开黏人的比赛对手，跌跌撞撞地冲锋。自踏入赛场的一刻起，就请将面子和理智丢到九霄云外，在向皇冠发起挑战的过程中，尽情享受令人捧腹的娱乐场面吧。", 57.99m, "糖豆人" });
        }
    }
}
