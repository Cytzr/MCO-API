﻿// <auto-generated />
using System;
using MCO_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MCO_API.Migrations
{
    [DbContext(typeof(MCODbContext))]
    partial class MCODbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MCO_API.Models.Database.CoachOrdersDatabaseModel", b =>
                {
                    b.Property<Guid?>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("customerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("orderPrice")
                        .HasColumnType("int");

                    b.Property<string>("orderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("sellerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("orderID");

                    b.ToTable("CoachOrders");

                    b.HasData(
                        new
                        {
                            orderID = new Guid("6f83ff91-383e-4c7b-b2a3-8dfb5b47dd6d"),
                            customerID = new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                            orderPrice = 200,
                            orderStatus = "In Progress",
                            orderType = "Coaching",
                            sellerID = new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7")
                        },
                        new
                        {
                            orderID = new Guid("7a0c9db8-b228-4db5-9dd1-1bf0f25c4995"),
                            customerID = new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                            orderPrice = 200,
                            orderStatus = "In Progress",
                            orderType = "Coaching",
                            sellerID = new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7")
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.CoachesDatabaseModel", b =>
                {
                    b.Property<Guid?>("coachID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("coachDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("coachGameID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("coachName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coachPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coachPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("coachPrice")
                        .HasColumnType("int");

                    b.HasKey("coachID");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            coachID = new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                            coachDescription = "Currently playing for ONIC Indonesia",
                            coachGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            coachName = "Kairi",
                            coachPassword = "123K",
                            coachPicture = "https://yt3.googleusercontent.com/zxzV3gMi_XpIiQkvPu1-UraWLCk4wLls7oBJ15MiEgdtRHsY1Wv99WqmnT_r9a-3VhU4kjaCD40=s900-c-k-c0x00ffffff-no-rj",
                            coachPrice = 200
                        },
                        new
                        {
                            coachID = new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                            coachDescription = "Mid Laner for RRQ Hoshi Indonesia",
                            coachGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            coachName = "Lemon",
                            coachPassword = "123L",
                            coachPicture = "https://www.blibli.com/friends-backend/wp-content/uploads/2023/10/B1000704-Biodata-dan-Profil-RRQ-Lemon-1024x538.jpg",
                            coachPrice = 200
                        },
                        new
                        {
                            coachID = new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"),
                            coachDescription = "Currently playing for Avalon",
                            coachGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            coachName = "MobaZane",
                            coachPassword = "123M",
                            coachPicture = "https://cdn.oneesports.id/cdn-data/sites/2/2023/01/322822698_475115058029640_312986676990991925_n-450x253.jpg",
                            coachPrice = 300
                        },
                        new
                        {
                            coachID = new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f"),
                            coachDescription = "EXP Laner for RRQ Hoshi Indonesia",
                            coachGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            coachName = "R7",
                            coachPassword = "123R",
                            coachPicture = "https://static.promediateknologi.id/crop/0x0:0x0/0x0/webp/photo/indizone/2023/01/15/9DsbyOn/rrq-hoshi-kalah-lagi-di-m4-world-championship-r7-bakal-pensiun-dari-mobile-legends56.jpg",
                            coachPrice = 300
                        },
                        new
                        {
                            coachID = new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5"),
                            coachDescription = "Professional CS-GO Player",
                            coachGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            coachName = "s1mple",
                            coachPassword = "123s",
                            coachPicture = "https://files.bo3.gg/uploads/news/24900/title_image/960x480-fb585de213ff273e61e8f92e4e922503.webp",
                            coachPrice = 400
                        },
                        new
                        {
                            coachID = new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a"),
                            coachDescription = "Former CS-GO Professional Player",
                            coachGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            coachName = "kennyS",
                            coachPassword = "123k",
                            coachPicture = "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/04/20/3d960532-3d9d-481e-a45f-036fbb998d11/kennys-starladder-g2-csgo",
                            coachPrice = 400
                        },
                        new
                        {
                            coachID = new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"),
                            coachDescription = "Currently playing for G2 E-Sports",
                            coachGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            coachName = "m0NESY",
                            coachPassword = "123m",
                            coachPicture = "https://yt3.googleusercontent.com/xV9eoeHWJLmFooOaB0MYw-dJJQf4q6j3fv55U6v5Qwr_eLmr4CESi_mFzkYCqnmAsldq_2_vZQ=s900-c-k-c0x00ffffff-no-rj",
                            coachPrice = 500
                        },
                        new
                        {
                            coachID = new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"),
                            coachDescription = "Valorant professional player for PaperRex",
                            coachGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            coachName = "f0rsakeN",
                            coachPassword = "123f",
                            coachPicture = "https://cdn.oneesports.gg/cdn-data/2023/06/Valorant_MastersTokyo2023_PaperRex_f0rsaken_DoubleFist.jpg",
                            coachPrice = 500
                        },
                        new
                        {
                            coachID = new Guid("11b83625-aa92-468b-bf1b-123f2051a01f"),
                            coachDescription = "Valorant professional player for PaperRex",
                            coachGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            coachName = "mindfreak",
                            coachPassword = "123m",
                            coachPicture = "https://assets.ggwp.id/2023/06/profil-mindfreak-featured-640x360.jpg",
                            coachPrice = 600
                        },
                        new
                        {
                            coachID = new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"),
                            coachDescription = "Valorant professional player for PaperRex",
                            coachGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            coachName = "something",
                            coachPassword = "123s",
                            coachPicture = "https://cdn.oneesports.gg/cdn-data/2023/05/Valorant_VCTPacific2023_Week6Day3_PRX_something_GunPose.jpg",
                            coachPrice = 600
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.CommentsDatabaseModel", b =>
                {
                    b.Property<Guid?>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("commentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("commentRating")
                        .HasColumnType("int");

                    b.Property<string>("commentSender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("commentedUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("commentID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            commentID = new Guid("72e8a29a-4413-4d4f-98bc-3a70218f6e39"),
                            commentContent = "Playing with him has been a blast! They're always up for a challenge and bring a lot of energy to our gaming sessions. However, there have been times when they get a bit too competitive, which can create tension and detract from the overall fun",
                            commentPicture = "",
                            commentRating = 5,
                            commentSender = "Cytzr",
                            commentType = "User",
                            commentedUser = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        },
                        new
                        {
                            commentID = new Guid("a13f6494-7141-4b5b-95af-21b12beafac5"),
                            commentContent = "He is incredibly skilled and has helped me improve a lot in the games we play together. They're also very reliable and always show up on time for our sessions. However, there are occasions when they're not very communicative, which can make coordinating strategies difficult.",
                            commentPicture = "",
                            commentRating = 2,
                            commentSender = "Archz",
                            commentType = "User",
                            commentedUser = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        },
                        new
                        {
                            commentID = new Guid("45d29558-8fc1-4628-9d9e-0a05741be9e3"),
                            commentContent = "I enjoy gaming with him most of the time. They have a great sense of humor and make our gaming sessions enjoyable. However, there are times when they become overly focused on winning, which can take away from the casual and laid-back atmosphere I prefer during gaming",
                            commentPicture = "",
                            commentRating = 5,
                            commentSender = "Sguishs",
                            commentType = "User",
                            commentedUser = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        },
                        new
                        {
                            commentID = new Guid("2f1ab3c7-e0c8-4d5a-b6b2-54b3b87f20d2"),
                            commentContent = "I had high expectations when hiring the gaming coach, but unfortunately, I was left disappointed. While the coach had good intentions, their teaching style didn't resonate with me, and I didn't see much improvement in my gameplay. Additionally, there were frequent technical issues during online sessions, which disrupted the learning process.",
                            commentPicture = "",
                            commentRating = 1,
                            commentSender = "Cytzr",
                            commentType = "Coach",
                            commentedUser = new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141")
                        },
                        new
                        {
                            commentID = new Guid("e9182aeb-465d-4d0b-ae76-19ef122d3e1b"),
                            commentContent = "The gaming coach was friendly and supportive, creating a comfortable learning environment. However, I felt that the coaching sessions were a bit rushed, and there wasn't enough time to delve deep into advanced strategies.",
                            commentPicture = "",
                            commentRating = 4,
                            commentSender = "Archz",
                            commentType = "Coach",
                            commentedUser = new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141")
                        },
                        new
                        {
                            commentID = new Guid("1b29c773-2e3c-4e9b-b59f-4888c6b18738"),
                            commentContent = "The gaming coach was very patient and understanding, especially when I struggled with certain techniques.",
                            commentPicture = "",
                            commentRating = 5,
                            commentSender = "Sguishs",
                            commentType = "Coach",
                            commentedUser = new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141")
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.EventsDatabaseModel", b =>
                {
                    b.Property<Guid?>("eventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("endDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("eventGameID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("eventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eventWriter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("eventID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            eventID = new Guid("1f5cb1a0-1e78-4f89-950d-d49e4d0e2e67"),
                            endDate = "16-01-2024",
                            eventDescription = "MLBB × The King of Fighters is the collaboration of Mobile Legends: Bang Bang and The King of Fighters franchise.",
                            eventGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            eventName = "MLBB x The King of Fighters 2024",
                            eventPicture = "https://i0.wp.com/www.gamerisme.com/wp-content/uploads/2023/12/event-kof-2024.webp?resize=860%2C484&ssl=1",
                            startDate = "02-01-2024"
                        },
                        new
                        {
                            eventID = new Guid("7d0c8771-8878-4baf-aad7-9d5487456956"),
                            endDate = "14-02-2024",
                            eventDescription = "Three of Eldia’s greatest heroes will be in the Land of Dawn this month for the much-awaited Attack on Titan MLBB skins event.",
                            eventGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            eventName = "MLBB x AOT",
                            eventPicture = "https://cdn.oneesports.gg/cdn-data/2024/01/MLBB_AttackOnTitan_MLBB_skins_Levi_Eren_Mikasa-1024x576.jpg",
                            startDate = "31-01-2024"
                        },
                        new
                        {
                            eventID = new Guid("ac0e72d3-8e2c-4c5b-b7c6-30e7cf01eabc"),
                            endDate = "24-02-2024",
                            eventDescription = "VCT 2024: Pacific Kickoff is an offline Korean tournament organized by Riot Games.",
                            eventGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            eventName = "VCT 2024 - Pacific Kickoff",
                            eventPicture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWsSstTTgvyVtGvGSwQ6lpFLqsgtSt2vBmf2opOxAu3JuYeJGh0Hbid0xAAXtmEoBnpdU&usqp=CAU",
                            startDate = "17-02-2024"
                        },
                        new
                        {
                            eventID = new Guid("e9ef8c6b-c318-41f5-a7d0-90368a37bf6c"),
                            endDate = "24-03-2024",
                            eventDescription = "VCT 2024: Masters Madrid is an offline Spanish tournament organized by Riot Games.",
                            eventGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            eventName = "Valorant Champions Tour 2024: Masters Madrid",
                            eventPicture = "https://cdn.oneesports.id/cdn-data/sites/2/2024/02/420606774_1716048858883537_467729496432484881_n-450x253.jpg",
                            startDate = "14-03-2024"
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.GamesDatabaseModel", b =>
                {
                    b.Property<Guid?>("gameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("gameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gamePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            gameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            gameName = "Mobile Legends",
                            gamePicture = "https://static.wikia.nocookie.net/mobile-legends/images/e/ee/Mobile_Legends_5v5_Logo_Fair_MOBA_for_Mobile.JPG/revision/latest?cb=20200819062413"
                        },
                        new
                        {
                            gameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            gameName = "Counter Strike",
                            gamePicture = "https://cdn.akamai.steamstatic.com/steam/apps/730/capsule_616x353.jpg?t=1698860631"
                        },
                        new
                        {
                            gameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            gameName = "Valorant",
                            gamePicture = "https://www.acerid.com/wp-content/uploads/2021/05/thumbnail-1.jpg"
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.UserOrdersDatabaseModel", b =>
                {
                    b.Property<Guid?>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("customerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("orderPrice")
                        .HasColumnType("int");

                    b.Property<string>("orderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("sellerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("orderID");

                    b.ToTable("UserOrders");

                    b.HasData(
                        new
                        {
                            orderID = new Guid("8cf4bbfe-ec32-496d-bac9-16ab8450d4d9"),
                            customerID = new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                            orderPrice = 10,
                            orderStatus = "In Progress",
                            orderType = "Playing",
                            sellerID = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        },
                        new
                        {
                            orderID = new Guid("9d83e380-084d-4d3a-a56e-d23cbf6b45e8"),
                            customerID = new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                            orderPrice = 15,
                            orderStatus = "In Progress",
                            orderType = "Playing",
                            sellerID = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.UsersDatabaseModel", b =>
                {
                    b.Property<Guid?>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("userDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("userGameID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("userIsPlayer")
                        .HasColumnType("bit");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userPrice")
                        .HasColumnType("int");

                    b.HasKey("userID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userID = new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                            userDescription = "Dive into the gaming universe with me! Let's level up together and discover new strategies to conquer every game we encounter. #GamingCommunity #LevelUp #AdventureAwaits",
                            userGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            userIsPlayer = false,
                            userName = "Cytzr",
                            userPassword = "123C",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male20171084078698944.jpg",
                            userPrice = 0
                        },
                        new
                        {
                            userID = new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                            userDescription = "Welcome to the world of gaming! Join me as we explore different game genres and embark on exciting virtual adventures. #GamerLife #GameOn #VirtualWorld",
                            userGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            userIsPlayer = false,
                            userName = "Archz",
                            userPassword = "123A",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male1085243424652.jpg",
                            userPrice = 0
                        },
                        new
                        {
                            userID = new Guid("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db"),
                            userDescription = "Step into the realm of gaming with me! From classic favorites to the latest releases, let's journey through the diverse and thrilling world of games. #GamingJourney #ExploreGames #GameEnthusiast",
                            userGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            userIsPlayer = false,
                            userName = "Sguishs",
                            userPassword = "123S",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male20161085956397827.jpg",
                            userPrice = 0
                        },
                        new
                        {
                            userID = new Guid("1a0d6253-b9fd-463e-b9f1-c79c442dbd94"),
                            userDescription = "Gamer for life! Playing all the latest releases and retro classics. Let's connect and talk about our favorite games! #GamerLife #VideoGames #GameOn",
                            userGameID = new Guid("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                            userIsPlayer = false,
                            userName = "Venom",
                            userPassword = "123V",
                            userPicture = "https://www.fakepersongenerator.com/Face/female/female20171025977528839.jpg",
                            userPrice = 0
                        },
                        new
                        {
                            userID = new Guid("4b0e25cf-d151-49d1-b4ff-520e417ea0e2"),
                            userDescription = "Obsessed with gaming! From RPGs to shooters, I love it all. Join me on my gaming adventures! #GamingObsessed #GamersUnite #GameTime",
                            userGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            userIsPlayer = false,
                            userName = "Phoenix",
                            userPassword = "123P",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male20161086523975494.jpg",
                            userPrice = 0
                        },
                        new
                        {
                            userID = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                            userDescription = "Leveling up one game at a time! Follow me for gaming tips, reviews, and more. Let's dominate the virtual world together! #LevelUp #GamingCommunity #GameAddict",
                            userGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            userIsPlayer = true,
                            userName = "Blaze",
                            userPassword = "123B",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male1084560160767.jpg",
                            userPrice = 5
                        },
                        new
                        {
                            userID = new Guid("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f"),
                            userDescription = "Level up your gaming experience with me! Join me on this virtual adventure as we explore the world of games together. #GamingAddict #GameOn #VirtualAdventures",
                            userGameID = new Guid("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                            userIsPlayer = true,
                            userName = "Nova",
                            userPassword = "123N",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male20151083680496277.jpg",
                            userPrice = 5
                        },
                        new
                        {
                            userID = new Guid("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7"),
                            userDescription = "Gaming enthusiast on a mission to conquer every virtual world out there! Join me as I share my gaming journey, tips, and tricks. Let's connect and level up together! #GamingEnthusiast #LevelUp #GameOn",
                            userGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            userIsPlayer = true,
                            userName = "Spectre",
                            userPassword = "123S",
                            userPicture = "https://www.fakepersongenerator.com/Face/male/male20171084094112519.jpg",
                            userPrice = 10
                        },
                        new
                        {
                            userID = new Guid("99a5c6fd-b832-4375-b5ac-5f78c3c895d2"),
                            userDescription = "Welcome to my gaming universe! Join me as I dive into the exciting realm of games, sharing my favorite titles, epic moments, and gaming hacks. Let's embark on this digital adventure together! #GamingUniverse #DigitalAdventure #GameOn",
                            userGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            userIsPlayer = true,
                            userName = "Vortex",
                            userPassword = "123V",
                            userPicture = "https://www.fakepersongenerator.com/Face/female/female1022729599975.jpg",
                            userPrice = 10
                        },
                        new
                        {
                            userID = new Guid("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6"),
                            userDescription = "Gamer for life! Playing all the latest releases and retro classics. Join me on my gaming adventures! #GamerLife #VideoGames #GamingCommunity",
                            userGameID = new Guid("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                            userIsPlayer = true,
                            userName = "Eclipse",
                            userPassword = "123E",
                            userPicture = "https://www.fakepersongenerator.com/Face/female/female1022091454834.jpg",
                            userPrice = 10
                        });
                });

            modelBuilder.Entity("MCO_API.Models.Database.WalletsDatabaseModel", b =>
                {
                    b.Property<Guid>("walletID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("currencyOwned")
                        .HasColumnType("int");

                    b.Property<Guid?>("walletCoachID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("walletUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("walletID");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            walletID = new Guid("6b024b88-ff19-4f84-9dd5-4b773a671e05"),
                            currencyOwned = 100,
                            walletUserID = new Guid("2b536497-b4b2-4c0b-8bd3-721a62a6c53d")
                        },
                        new
                        {
                            walletID = new Guid("13f9f80b-5e2d-4b11-b1d3-364b5f674e9d"),
                            currencyOwned = 200,
                            walletUserID = new Guid("921f2f45-7360-4c9e-b7cb-af7d2b168e67")
                        },
                        new
                        {
                            walletID = new Guid("cfab0e4e-cff6-4c5f-bc91-d7ab5a29b800"),
                            currencyOwned = 300,
                            walletUserID = new Guid("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db")
                        },
                        new
                        {
                            walletID = new Guid("8b24e288-d5df-4d6c-ba34-68dfebb8f3d8"),
                            currencyOwned = 400,
                            walletUserID = new Guid("1a0d6253-b9fd-463e-b9f1-c79c442dbd94")
                        },
                        new
                        {
                            walletID = new Guid("6ff8c3a7-d7f4-4ba3-bd99-13b13b3a8e7d"),
                            currencyOwned = 100,
                            walletUserID = new Guid("4b0e25cf-d151-49d1-b4ff-520e417ea0e2")
                        },
                        new
                        {
                            walletID = new Guid("a1ae09e9-cc0e-4f38-9a24-95e3f9d6c71d"),
                            currencyOwned = 100,
                            walletUserID = new Guid("8572e71e-3561-487d-8f12-432a3e1b6dbb")
                        },
                        new
                        {
                            walletID = new Guid("7cf950a7-3b7c-4e6e-8c97-ee6b5fc1532d"),
                            currencyOwned = 100,
                            walletUserID = new Guid("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f")
                        },
                        new
                        {
                            walletID = new Guid("bfb75d15-0fb8-40cc-8407-47dc8a20d55b"),
                            currencyOwned = 100,
                            walletUserID = new Guid("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7")
                        },
                        new
                        {
                            walletID = new Guid("9298b63e-c117-480b-8d9e-5af67b91cf0b"),
                            currencyOwned = 200,
                            walletUserID = new Guid("99a5c6fd-b832-4375-b5ac-5f78c3c895d2")
                        },
                        new
                        {
                            walletID = new Guid("5645459f-6673-4bb5-93f3-cde981dd91e1"),
                            currencyOwned = 200,
                            walletUserID = new Guid("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6")
                        },
                        new
                        {
                            walletID = new Guid("d33db8f4-0c0d-4aa3-88e6-7f07d318c3eb"),
                            currencyOwned = 200,
                            walletCoachID = new Guid("72c084fb-dc7b-4825-a720-7f60702cfbb7")
                        },
                        new
                        {
                            walletID = new Guid("ef16936f-7467-49fd-9269-0e4d775d2b07"),
                            currencyOwned = 200,
                            walletCoachID = new Guid("3a45f13f-b905-4e9d-8c18-b68f6653b141")
                        },
                        new
                        {
                            walletID = new Guid("3122b812-b934-4e02-8827-cd8cf41e905f"),
                            currencyOwned = 300,
                            walletCoachID = new Guid("9f54e945-d17c-43d5-8d1b-8837ac4a86d2")
                        },
                        new
                        {
                            walletID = new Guid("1bca0053-4d8c-4b68-9e17-f4ee7a6dd06f"),
                            currencyOwned = 300,
                            walletCoachID = new Guid("13db2917-dbc9-4eb8-8f3c-926ed41d747f")
                        },
                        new
                        {
                            walletID = new Guid("2d0c5297-6f7d-4492-8ac7-d0b35f982160"),
                            currencyOwned = 300,
                            walletCoachID = new Guid("b4c87739-f2c0-4b08-a319-4fb45774b5e5")
                        },
                        new
                        {
                            walletID = new Guid("8e0a3bb7-ae7a-4624-91b7-ee83ab9e5ee8"),
                            currencyOwned = 300,
                            walletCoachID = new Guid("6a00e27e-9a9a-499b-afe4-233bf52edf5a")
                        },
                        new
                        {
                            walletID = new Guid("ccf33a5b-44a6-484b-97d1-7e7b7dd230f6"),
                            currencyOwned = 400,
                            walletCoachID = new Guid("8a5eb77e-4a36-4598-8a64-1f167b7af6cb")
                        },
                        new
                        {
                            walletID = new Guid("d2d81b3d-5154-4394-ba45-2c0407f39e67"),
                            currencyOwned = 400,
                            walletCoachID = new Guid("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059")
                        },
                        new
                        {
                            walletID = new Guid("27b065a4-317e-47c8-97d4-c4c0d94921a4"),
                            currencyOwned = 400,
                            walletCoachID = new Guid("11b83625-aa92-468b-bf1b-123f2051a01f")
                        },
                        new
                        {
                            walletID = new Guid("84c484bf-cf95-4b20-b6ff-1c7b776bba09"),
                            currencyOwned = 400,
                            walletCoachID = new Guid("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
