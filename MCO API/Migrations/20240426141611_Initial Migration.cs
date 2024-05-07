using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MCO_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    coachID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    coachName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coachPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coachDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coachPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coachPrice = table.Column<int>(type: "int", nullable: true),
                    coachGameID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.coachID);
                });

            migrationBuilder.CreateTable(
                name: "CoachOrders",
                columns: table => new
                {
                    orderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    sellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    orderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachOrders", x => x.orderID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    commentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    commentedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    commenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentSender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentRating = table.Column<int>(type: "int", nullable: true),
                    commentPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.commentID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    eventID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    eventWriter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eventGameID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    gameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    gameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gamePicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.gameID);
                });

            migrationBuilder.CreateTable(
                name: "UserOrders",
                columns: table => new
                {
                    orderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    sellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    orderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrders", x => x.orderID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userIsPlayer = table.Column<bool>(type: "bit", nullable: true),
                    userPrice = table.Column<int>(type: "int", nullable: true),
                    userGameID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    walletID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    walletUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    walletCoachID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    currencyOwned = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.walletID);
                });

            migrationBuilder.InsertData(
                table: "CoachOrders",
                columns: new[] { "orderID", "customerID", "orderPrice", "orderStatus", "orderType", "sellerID" },
                values: new object[,]
                {
                    { new Guid("6f83ff91-383e-4c7b-b2a3-8dfb5b47dd6d"), new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"), 200, "In Progress", "Coaching", new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7") },
                    { new Guid("7a0c9db8-b228-4db5-9dd1-1bf0f25c4995"), new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"), 200, "In Progress", "Coaching", new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7") }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "coachID", "coachDescription", "coachGameID", "coachName", "coachPassword", "coachPicture", "coachPrice" },
                values: new object[,]
                {
                    { new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"), "Valorant professional player for PaperRex", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "f0rsakeN", "123f", "https://cdn.oneesports.gg/cdn-data/2023/06/Valorant_MastersTokyo2023_PaperRex_f0rsaken_DoubleFist.jpg", 500 },
                    { new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"), "Valorant professional player for PaperRex", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "mindfreak", "123m", "https://assets.ggwp.id/2023/06/profil-mindfreak-featured-640x360.jpg", 600 },
                    { new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"), "EXP Laner for RRQ Hoshi Indonesia", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "R7", "123R", "https://static.promediateknologi.id/crop/0x0:0x0/0x0/webp/photo/indizone/2023/01/15/9DsbyOn/rrq-hoshi-kalah-lagi-di-m4-world-championship-r7-bakal-pensiun-dari-mobile-legends56.jpg", 300 },
                    { new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), "Mid Laner for RRQ Hoshi Indonesia", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "Lemon", "123L", "https://www.blibli.com/friends-backend/wp-content/uploads/2023/10/B1000704-Biodata-dan-Profil-RRQ-Lemon-1024x538.jpg", 200 },
                    { new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"), "Former CS-GO Professional Player", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), "kennyS", "123k", "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/04/20/3d960532-3d9d-481e-a45f-036fbb998d11/kennys-starladder-g2-csgo", 400 },
                    { new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"), "Currently playing for ONIC Indonesia", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "Kairi", "123K", "https://yt3.googleusercontent.com/zxzV3gMi_XpIiQkvPu1-UraWLCk4wLls7oBJ15MiEgdtRHsY1Wv99WqmnT_r9a-3VhU4kjaCD40=s900-c-k-c0x00ffffff-no-rj", 200 },
                    { new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"), "Currently playing for G2 E-Sports", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), "m0NESY", "123m", "https://yt3.googleusercontent.com/xV9eoeHWJLmFooOaB0MYw-dJJQf4q6j3fv55U6v5Qwr_eLmr4CESi_mFzkYCqnmAsldq_2_vZQ=s900-c-k-c0x00ffffff-no-rj", 500 },
                    { new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"), "Currently playing for Avalon", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "MobaZane", "123M", "https://cdn.oneesports.id/cdn-data/sites/2/2023/01/322822698_475115058029640_312986676990991925_n-450x253.jpg", 300 },
                    { new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"), "Professional CS-GO Player", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), "s1mple", "123s", "https://files.bo3.gg/uploads/news/24900/title_image/960x480-fb585de213ff273e61e8f92e4e922503.webp", 400 },
                    { new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"), "Valorant professional player for PaperRex", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "something", "123s", "https://cdn.oneesports.gg/cdn-data/2023/05/Valorant_VCTPacific2023_Week6Day3_PRX_something_GunPose.jpg", 600 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "commentID", "commentContent", "commentPicture", "commentRating", "commentSender", "commentType", "commentedUser", "commenter" },
                values: new object[,]
                {
                    { new Guid("1b29c773-2e3c-4e9b-b59f-4888c6b18738"), "The gaming coach was very patient and understanding, especially when I struggled with certain techniques.", "", 5, "Sguishs", "Coach", new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), "Coach3" },
                    { new Guid("2f1ab3c7-e0c8-4d5a-b6b2-54b3b87f20d2"), "I had high expectations when hiring the gaming coach, but unfortunately, I was left disappointed. While the coach had good intentions, their teaching style didn't resonate with me, and I didn't see much improvement in my gameplay. Additionally, there were frequent technical issues during online sessions, which disrupted the learning process.", "", 1, "Cytzr", "Coach", new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), "Coach1" },
                    { new Guid("45d29558-8fc1-4628-9d9e-0a05741be9e3"), "I enjoy gaming with him most of the time. They have a great sense of humor and make our gaming sessions enjoyable. However, there are times when they become overly focused on winning, which can take away from the casual and laid-back atmosphere I prefer during gaming", "", 5, "Sguishs", "User", new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"), "User3" },
                    { new Guid("72e8a29a-4413-4d4f-98bc-3a70218f6e39"), "Playing with him has been a blast! They're always up for a challenge and bring a lot of energy to our gaming sessions. However, there have been times when they get a bit too competitive, which can create tension and detract from the overall fun", "", 5, "Cytzr", "User", new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"), "User1" },
                    { new Guid("a13f6494-7141-4b5b-95af-21b12beafac5"), "He is incredibly skilled and has helped me improve a lot in the games we play together. They're also very reliable and always show up on time for our sessions. However, there are occasions when they're not very communicative, which can make coordinating strategies difficult.", "", 2, "Archz", "User", new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"), "User2" },
                    { new Guid("e9182aeb-465d-4d0b-ae76-19ef122d3e1b"), "The gaming coach was friendly and supportive, creating a comfortable learning environment. However, I felt that the coaching sessions were a bit rushed, and there wasn't enough time to delve deep into advanced strategies.", "", 4, "Archz", "Coach", new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), "Coach2" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "eventID", "endDate", "eventDescription", "eventGameID", "eventName", "eventPicture", "eventWriter", "startDate" },
                values: new object[,]
                {
                    { new Guid("1f5cb1a0-1e78-4f89-950d-d49e4d0e2e67"), "16-01-2024", "MLBB × The King of Fighters is the collaboration of Mobile Legends: Bang Bang and The King of Fighters franchise.", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "MLBB x The King of Fighters 2024", "https://i0.wp.com/www.gamerisme.com/wp-content/uploads/2023/12/event-kof-2024.webp?resize=860%2C484&ssl=1", null, "02-01-2024" },
                    { new Guid("7d0c8771-8878-4baf-aad7-9d5487456956"), "14-02-2024", "Three of Eldia’s greatest heroes will be in the Land of Dawn this month for the much-awaited Attack on Titan MLBB skins event.", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "MLBB x AOT", "https://cdn.oneesports.gg/cdn-data/2024/01/MLBB_AttackOnTitan_MLBB_skins_Levi_Eren_Mikasa-1024x576.jpg", null, "31-01-2024" },
                    { new Guid("ac0e72d3-8e2c-4c5b-b7c6-30e7cf01eabc"), "24-02-2024", "VCT 2024: Pacific Kickoff is an offline Korean tournament organized by Riot Games.", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "VCT 2024 - Pacific Kickoff", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWsSstTTgvyVtGvGSwQ6lpFLqsgtSt2vBmf2opOxAu3JuYeJGh0Hbid0xAAXtmEoBnpdU&usqp=CAU", null, "17-02-2024" },
                    { new Guid("e9ef8c6b-c318-41f5-a7d0-90368a37bf6c"), "24-03-2024", "VCT 2024: Masters Madrid is an offline Spanish tournament organized by Riot Games.", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "Valorant Champions Tour 2024: Masters Madrid", "https://cdn.oneesports.id/cdn-data/sites/2/2024/02/420606774_1716048858883537_467729496432484881_n-450x253.jpg", null, "14-03-2024" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "gameID", "gameName", "gamePicture" },
                values: new object[,]
                {
                    { new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), "Counter Strike", "https://cdn.akamai.steamstatic.com/steam/apps/730/capsule_616x353.jpg?t=1698860631" },
                    { new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), "Valorant", "https://www.acerid.com/wp-content/uploads/2021/05/thumbnail-1.jpg" },
                    { new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), "Mobile Legends", "https://static.wikia.nocookie.net/mobile-legends/images/e/ee/Mobile_Legends_5v5_Logo_Fair_MOBA_for_Mobile.JPG/revision/latest?cb=20200819062413" }
                });

            migrationBuilder.InsertData(
                table: "UserOrders",
                columns: new[] { "orderID", "customerID", "orderPrice", "orderStatus", "orderType", "sellerID" },
                values: new object[,]
                {
                    { new Guid("8cf4bbfe-ec32-496d-bac9-16ab8450d4d9"), new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"), 10, "In Progress", "Playing", new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb") },
                    { new Guid("9d83e380-084d-4d3a-a56e-d23cbf6b45e8"), new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"), 15, "In Progress", "Playing", new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userID", "userDescription", "userGameID", "userIsPlayer", "userName", "userPassword", "userPicture", "userPrice" },
                values: new object[,]
                {
                    { new Guid("1a0d6253-b9fd-463e-b9f1-c79c442dbd94"), "Gamer for life! Playing all the latest releases and retro classics. Let's connect and talk about our favorite games! #GamerLife #VideoGames #GameOn", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), false, "Venom", "123V", "https://www.fakepersongenerator.com/Face/female/female20171025977528839.jpg", 0 },
                    { new Guid("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7"), "Gaming enthusiast on a mission to conquer every virtual world out there! Join me as I share my gaming journey, tips, and tricks. Let's connect and level up together! #GamingEnthusiast #LevelUp #GameOn", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), true, "Spectre", "123S", "https://www.fakepersongenerator.com/Face/male/male20171084094112519.jpg", 10 },
                    { new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"), "Dive into the gaming universe with me! Let's level up together and discover new strategies to conquer every game we encounter. #GamingCommunity #LevelUp #AdventureAwaits", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), false, "Cytzr", "123C", "https://www.fakepersongenerator.com/Face/male/male20171084078698944.jpg", 0 },
                    { new Guid("4b0e25cf-d151-49d1-b4ff-520e417ea0e2"), "Obsessed with gaming! From RPGs to shooters, I love it all. Join me on my gaming adventures! #GamingObsessed #GamersUnite #GameTime", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), false, "Phoenix", "123P", "https://www.fakepersongenerator.com/Face/male/male20161086523975494.jpg", 0 },
                    { new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"), "Leveling up one game at a time! Follow me for gaming tips, reviews, and more. Let's dominate the virtual world together! #LevelUp #GamingCommunity #GameAddict", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), true, "Blaze", "123B", "https://www.fakepersongenerator.com/Face/male/male1084560160767.jpg", 5 },
                    { new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"), "Welcome to the world of gaming! Join me as we explore different game genres and embark on exciting virtual adventures. #GamerLife #GameOn #VirtualWorld", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), false, "Archz", "123A", "https://www.fakepersongenerator.com/Face/male/male1085243424652.jpg", 0 },
                    { new Guid("99a5c6fd-b832-4375-b5ac-5f78c3c895d2"), "Welcome to my gaming universe! Join me as I dive into the exciting realm of games, sharing my favorite titles, epic moments, and gaming hacks. Let's embark on this digital adventure together! #GamingUniverse #DigitalAdventure #GameOn", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), true, "Vortex", "123V", "https://www.fakepersongenerator.com/Face/female/female1022729599975.jpg", 10 },
                    { new Guid("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f"), "Level up your gaming experience with me! Join me on this virtual adventure as we explore the world of games together. #GamingAddict #GameOn #VirtualAdventures", new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"), true, "Nova", "123N", "https://www.fakepersongenerator.com/Face/male/male20151083680496277.jpg", 5 },
                    { new Guid("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db"), "Step into the realm of gaming with me! From classic favorites to the latest releases, let's journey through the diverse and thrilling world of games. #GamingJourney #ExploreGames #GameEnthusiast", new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"), false, "Sguishs", "123S", "https://www.fakepersongenerator.com/Face/male/male20161085956397827.jpg", 0 },
                    { new Guid("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6"), "Gamer for life! Playing all the latest releases and retro classics. Join me on my gaming adventures! #GamerLife #VideoGames #GamingCommunity", new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"), true, "Eclipse", "123E", "https://www.fakepersongenerator.com/Face/female/female1022091454834.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "walletID", "currencyOwned", "walletCoachID", "walletUserID" },
                values: new object[,]
                {
                    { new Guid("13f9f80b-5e2d-4b11-b1d3-364b5f674e9d"), 200, null, new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67") },
                    { new Guid("1bca0053-4d8c-4b68-9e17-f4ee7a6dd06f"), 300, new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"), null },
                    { new Guid("27b065a4-317e-47c8-97d4-c4c0d94921a4"), 400, new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"), null },
                    { new Guid("2d0c5297-6f7d-4492-8ac7-d0b35f982160"), 300, new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"), null },
                    { new Guid("3122b812-b934-4e02-8827-cd8cf41e905f"), 300, new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"), null },
                    { new Guid("5645459f-6673-4bb5-93f3-cde981dd91e1"), 200, null, new Guid("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6") },
                    { new Guid("6b024b88-ff19-4f84-9dd5-4b773a671e05"), 100, null, new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d") },
                    { new Guid("6ff8c3a7-d7f4-4ba3-bd99-13b13b3a8e7d"), 100, null, new Guid("4b0e25cf-d151-49d1-b4ff-520e417ea0e2") },
                    { new Guid("7cf950a7-3b7c-4e6e-8c97-ee6b5fc1532d"), 100, null, new Guid("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f") },
                    { new Guid("84c484bf-cf95-4b20-b6ff-1c7b776bba09"), 400, new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"), null },
                    { new Guid("8b24e288-d5df-4d6c-ba34-68dfebb8f3d8"), 400, null, new Guid("1a0d6253-b9fd-463e-b9f1-c79c442dbd94") },
                    { new Guid("8e0a3bb7-ae7a-4624-91b7-ee83ab9e5ee8"), 300, new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"), null },
                    { new Guid("9298b63e-c117-480b-8d9e-5af67b91cf0b"), 200, null, new Guid("99a5c6fd-b832-4375-b5ac-5f78c3c895d2") },
                    { new Guid("a1ae09e9-cc0e-4f38-9a24-95e3f9d6c71d"), 100, null, new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb") },
                    { new Guid("bfb75d15-0fb8-40cc-8407-47dc8a20d55b"), 100, null, new Guid("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7") },
                    { new Guid("ccf33a5b-44a6-484b-97d1-7e7b7dd230f6"), 400, new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"), null },
                    { new Guid("cfab0e4e-cff6-4c5f-bc91-d7ab5a29b800"), 300, null, new Guid("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db") },
                    { new Guid("d2d81b3d-5154-4394-ba45-2c0407f39e67"), 400, new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"), null },
                    { new Guid("d33db8f4-0c0d-4aa3-88e6-7f07d318c3eb"), 200, new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"), null },
                    { new Guid("ef16936f-7467-49fd-9269-0e4d775d2b07"), 200, new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "CoachOrders");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "UserOrders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
