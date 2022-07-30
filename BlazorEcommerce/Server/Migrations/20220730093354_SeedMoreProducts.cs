using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "地球农作物因气候转变及枯萎病而经常失收，曾是美国国家航空航天局的工程师和航天飞机驾驶员的库珀（马修·麦康纳饰）被迫成为农民以协助解决粮食危机。库珀的10岁女儿墨菲（麦肯基·弗依饰）发现其房间书架上的书本无故掉到地上，认为这是幽灵现象。不久后，一场沙尘暴在墨菲房间中留下二进制坐标，二人驱车到达坐标位置后发现那是北美空防司令部（美国国家航空航天局的秘密基地）。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fuploads.xuexila.com%2Fallimg%2F1707%2F1024-1FG0144334.jpg&refer=http%3A%2F%2Fuploads.xuexila.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661764196&t=a012a15fd2231c40e47ba23f34e21284", 4.99m, "星际穿越" },
                    { 5, 2, "来自泰坦星的灭霸为了解决宇宙资源匮乏、人口暴增的问题，集齐了所有无限宝石，一个响指成功地使全宇宙生命随机减半。宇宙由于灭霸的行动而变得满目疮痍，但是五年之后，被困在量子领域的蚁人意外回到现实世界，他的出现为幸存的复仇者点燃了希望。无论前方将遭遇怎样的后果，幸存的复仇者都必须在剩余盟友的帮助下再一次集结，以逆转灭霸的所作所为，彻底恢复宇宙的秩序。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fpic4.iqiyipic.com%2Fimage%2F20200430%2F90%2F6d%2Fv_112869925_m_601_m29_480_270.jpg&refer=http%3A%2F%2Fpic4.iqiyipic.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661764329&t=4b68273644d8055a2cb246496d378e49", 39.99m, "复仇者联盟4：终局之战" },
                    { 6, 2, "被开除军籍的冷锋（吴京饰演）本是因找杀害龙小云的凶手（余男饰演）来到非洲，但是却突然被卷入一场非洲国家的叛乱。因为国家之间政治立场的关系，中国军队无法在非洲实行武装行动撤离华侨。而作为退伍老兵的冷锋无法忘记曾经为军人的使命，本来可以安全撤离的他毅然决然地回到了沦陷区，孤身一人带领身陷屠杀中的同胞和难民，展开生死逃亡。随着斗争的持续，体内的狼性逐渐复苏，最终闯入战乱区域，为同胞而战斗。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fwww.cs.com.cn%2Fssgs%2Fgsxw%2F201709%2FW020170901485303065974.jpg&refer=http%3A%2F%2Fwww.cs.com.cn&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661764465&t=0ca2d5f808107f2a43771c4cc7b452fb", 29.99m, "战狼Ⅱ" },
                    { 7, 3, "游戏以虚构的幻想世界为背景，阴阳二神互相杀伐，导致世界处于永劫之中。玩家需扮演一名英雄，在地图中收集各种资源，与其他玩家对抗，生存到最后。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimage.yxdwj.com%2Fattachment%2Fsoft%2F2021%2F0410%2F100506_51560547.png&refer=http%3A%2F%2Fimage.yxdwj.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661764842&t=6f8cadefe8db05633a371eea21629003", 97.99m, "永劫无间" },
                    { 8, 3, "玩家可以在游戏中做很多事情：制造武器战胜各种各样的敌人及群落；挖掘地下寻找器材配件、金钱和其他有用的东西；收集木材，石材，矿石等资源；用世界里的一切创造你需要的东西并守护它。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimgaes.51pgzs.com%2Fbdgame%2F202105%2F15%2F1621069307_4.jpg&refer=http%3A%2F%2Fimgaes.51pgzs.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661764895&t=3babf40fb756c86c60653214c06e05d8", 35.99m, "泰拉瑞亚" },
                    { 9, 3, "故事发生在名为“交界地”的地方，这里的人们拥戴永恒女王玛莉卡。也受到玛丽卡所祝福。所有接受祝福的人瞳孔中都有黄金一般的光芒，但也有些人因为各种原因失去了祝福，眼中的光芒消逝。这些人就被称为褪色者，并因此被逐出交界地。某天因为作为祝福核心的法环被击碎，祝福受到污染的半神们为了收集法环碎片发动了一场又一场的战争，导致世界变的满目疮痍，褪色者们因为法环破碎恢复了祝福，收集艾尔登法环碎片，挑战半神，而玩家们扮演的角色便是褪色者。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimgs.ali213.net%2Foday%2Fuploadfile%2F2021%2F06%2F11%2F2021061113653712.jpg&refer=http%3A%2F%2Fimgs.ali213.net&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661765129&t=8a2fe012e302dc8acc7c624cf80142cd", 297.99m, "艾尔登法环" },
                    { 10, 3, "在该游戏中，玩家需要在游戏地图上收集各种资源，并在不断缩小的安全区域内对抗其他玩家，让自己生存到最后。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fi-1.rar8.net%2F2022%2F1%2F30%2F1541aa1c-2db3-4db3-9ea8-a76c00435548.jpg&refer=http%3A%2F%2Fi-1.rar8.net&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661765277&t=b09b784de2f5a78c43569d070219a25e", 99.99m, "绝地求生" },
                    { 11, 3, "在这个大型闯关综艺现场，玩家将和大批参赛者共同面对一场“欲戴皇冠必趁其乱”的冲关竞技。玩家要灵活应对野蛮生长的障碍物，挤开黏人的比赛对手，跌跌撞撞地冲锋。自踏入赛场的一刻起，就请将面子和理智丢到九霄云外，在向皇冠发起挑战的过程中，尽情享受令人捧腹的娱乐场面吧。", "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fpic2.52pk.com%2Ffiles%2F200827%2F7913994_093206_1.jpg&refer=http%3A%2F%2Fpic2.52pk.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1661765420&t=7ec840cd269de905357f8d04281d4387", 57.99m, "糖豆人" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
