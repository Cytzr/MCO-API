using MCO_API.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace MCO_API.Data
{
    public class MCODbContext : DbContext
    {
        public DbSet<CoachesDatabaseModel> Coaches { get; set; }
        public DbSet<UsersDatabaseModel> Users { get; set; }
        public DbSet<EventsDatabaseModel> Events { get; set; }
        public DbSet<GamesDatabaseModel> Games { get; set; }
        public DbSet<WalletsDatabaseModel> Wallets { get; set; }
        public DbSet<CommentsDatabaseModel> Comments { get; set; }
        public DbSet<UserOrdersDatabaseModel> UserOrders { get; set; }
        public DbSet<CoachOrdersDatabaseModel> CoachOrders { get; set; }

        public MCODbContext(DbContextOptions<MCODbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CoachesDatabaseModel>().HasKey(c => c.coachID);
            modelBuilder.Entity<UsersDatabaseModel>().HasKey(c => c.userID);
            modelBuilder.Entity<EventsDatabaseModel>().HasKey(c => c.eventID);
            modelBuilder.Entity<GamesDatabaseModel>().HasKey(c => c.gameID);
            modelBuilder.Entity<WalletsDatabaseModel>().HasKey(c => c.walletID);
            modelBuilder.Entity<CommentsDatabaseModel>().HasKey(c => c.commentID);


            //SEEDING DATA
            var Users = new List<UsersDatabaseModel>()
            {
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                    //Gamer Tag buat sendiri
                    userName = "Cytzr",
                    //Password = 123 + huruf pertama gamer tag
                    userPassword = "123C",
                    //buat pake description generator (kasih tag yg sesuai)
                    userDescription = "Dive into the gaming universe with me! Let's level up together and discover new strategies to conquer every game we encounter. #GamingCommunity #LevelUp #AdventureAwaits",
                    //buat pake random person generator (copy image link)
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male20171084078698944.jpg",
                    userIsPlayer = false,
                    userPrice = 0,
                    userGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                    userName = "Archz",
                    userPassword = "123A",
                    userDescription = "Welcome to the world of gaming! Join me as we explore different game genres and embark on exciting virtual adventures. #GamerLife #GameOn #VirtualWorld",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male1085243424652.jpg",
                    userIsPlayer = false,
                    userPrice = 0,
                    userGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db"),
                    userName = "Sguishs",
                    userPassword = "123S",
                    userDescription = "Step into the realm of gaming with me! From classic favorites to the latest releases, let's journey through the diverse and thrilling world of games. #GamingJourney #ExploreGames #GameEnthusiast",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male20161085956397827.jpg",
                    userIsPlayer = false,
                    userPrice = 0,
                    userGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("1a0d6253-b9fd-463e-b9f1-c79c442dbd94"),
                    userName = "Venom",
                    userPassword = "123V",
                    userDescription = "Gamer for life! Playing all the latest releases and retro classics. Let's connect and talk about our favorite games! #GamerLife #VideoGames #GameOn",
                    userPicture = "https://www.fakepersongenerator.com/Face/female/female20171025977528839.jpg",
                    userIsPlayer = false,
                    userPrice = 0,
                    userGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("4b0e25cf-d151-49d1-b4ff-520e417ea0e2"),
                    userName = "Phoenix",
                    userPassword = "123P",
                    userDescription = "Obsessed with gaming! From RPGs to shooters, I love it all. Join me on my gaming adventures! #GamingObsessed #GamersUnite #GameTime",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male20161086523975494.jpg",
                    userIsPlayer = false,
                    userPrice = 0,
                    userGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    userName = "Blaze",
                    userPassword = "123B",
                    userDescription = "Leveling up one game at a time! Follow me for gaming tips, reviews, and more. Let's dominate the virtual world together! #LevelUp #GamingCommunity #GameAddict",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male1084560160767.jpg",
                    userIsPlayer = true,
                    userPrice = 5,
                    userGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f"),
                    userName = "Nova",
                    userPassword = "123N",
                    userDescription = "Level up your gaming experience with me! Join me on this virtual adventure as we explore the world of games together. #GamingAddict #GameOn #VirtualAdventures",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male20151083680496277.jpg",
                    userIsPlayer = true,
                    userPrice = 5,
                    userGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7"),
                    userName = "Spectre",
                    userPassword = "123S",
                    userDescription = "Gaming enthusiast on a mission to conquer every virtual world out there! Join me as I share my gaming journey, tips, and tricks. Let's connect and level up together! #GamingEnthusiast #LevelUp #GameOn",
                    userPicture = "https://www.fakepersongenerator.com/Face/male/male20171084094112519.jpg",
                    userIsPlayer = true,
                    userPrice = 10,
                    userGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("99a5c6fd-b832-4375-b5ac-5f78c3c895d2"),
                    userName = "Vortex",
                    userPassword = "123V",
                    userDescription = "Welcome to my gaming universe! Join me as I dive into the exciting realm of games, sharing my favorite titles, epic moments, and gaming hacks. Let's embark on this digital adventure together! #GamingUniverse #DigitalAdventure #GameOn",
                    userPicture = "https://www.fakepersongenerator.com/Face/female/female1022729599975.jpg",
                    userIsPlayer = true,
                    userPrice = 10,
                    userGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
                new UsersDatabaseModel()
                {
                    userID = Guid.Parse("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6"),
                    userName = "Eclipse",
                    userPassword = "123E",
                    userDescription = "Gamer for life! Playing all the latest releases and retro classics. Join me on my gaming adventures! #GamerLife #VideoGames #GamingCommunity",
                    userPicture = "https://www.fakepersongenerator.com/Face/female/female1022091454834.jpg",
                    userIsPlayer = true,
                    userPrice = 10,
                    userGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
            };
            modelBuilder.Entity<UsersDatabaseModel>().HasData(Users);

            var Coaches = new List<CoachesDatabaseModel>()
            {
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                    //Coach Gamer Tag
                    coachName = "Kairi",
                    //password = 123 + huruf pertama gamer tag coach
                    coachPassword = "123K",
                    //buat pake description generator (kasih tag yang sesuai)
                    coachDescription = "Currently playing for ONIC Indonesia",
                    //buat pake random person generator (copy image link)
                    coachPicture = "https://yt3.googleusercontent.com/zxzV3gMi_XpIiQkvPu1-UraWLCk4wLls7oBJ15MiEgdtRHsY1Wv99WqmnT_r9a-3VhU4kjaCD40=s900-c-k-c0x00ffffff-no-rj",
                    coachPrice = 200,
                    coachGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                    coachName = "Lemon",
                    coachPassword = "123L",
                    coachDescription = "Mid Laner for RRQ Hoshi Indonesia",
                    coachPicture = "https://www.blibli.com/friends-backend/wp-content/uploads/2023/10/B1000704-Biodata-dan-Profil-RRQ-Lemon-1024x538.jpg",
                    coachPrice = 200,
                    coachGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"),
                    coachName = "MobaZane",
                    coachPassword = "123M",
                    coachDescription = "Currently playing for Avalon",
                    coachPicture = "https://cdn.oneesports.id/cdn-data/sites/2/2023/01/322822698_475115058029640_312986676990991925_n-450x253.jpg",
                    coachPrice = 300,
                    coachGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("13db2917-dbc9-4eb8-8f3c-926ed41d747f"),
                    coachName = "R7",
                    coachPassword = "123R",
                    coachDescription = "EXP Laner for RRQ Hoshi Indonesia",
                    coachPicture = "https://static.promediateknologi.id/crop/0x0:0x0/0x0/webp/photo/indizone/2023/01/15/9DsbyOn/rrq-hoshi-kalah-lagi-di-m4-world-championship-r7-bakal-pensiun-dari-mobile-legends56.jpg",
                    coachPrice = 300,
                    coachGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("b4c87739-f2c0-4b08-a319-4fb45774b5e5"),
                    coachName = "s1mple",
                    coachPassword = "123s",
                    coachDescription = "Professional CS-GO Player",
                    coachPicture = "https://files.bo3.gg/uploads/news/24900/title_image/960x480-fb585de213ff273e61e8f92e4e922503.webp",
                    coachPrice = 400,
                    coachGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("6a00e27e-9a9a-499b-afe4-233bf52edf5a"),
                    coachName = "kennyS",
                    coachPassword = "123k",
                    coachDescription = "Former CS-GO Professional Player",
                    coachPicture = "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2018/04/20/3d960532-3d9d-481e-a45f-036fbb998d11/kennys-starladder-g2-csgo",
                    coachPrice = 400,
                    coachGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"),
                    coachName = "m0NESY",
                    coachPassword = "123m",
                    coachDescription = "Currently playing for G2 E-Sports",
                    coachPicture = "https://yt3.googleusercontent.com/xV9eoeHWJLmFooOaB0MYw-dJJQf4q6j3fv55U6v5Qwr_eLmr4CESi_mFzkYCqnmAsldq_2_vZQ=s900-c-k-c0x00ffffff-no-rj",
                    coachPrice = 500,
                    coachGameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"),
                    coachName = "f0rsakeN",
                    coachPassword = "123f",
                    coachDescription = "Valorant professional player for PaperRex",
                    coachPicture = "https://cdn.oneesports.gg/cdn-data/2023/06/Valorant_MastersTokyo2023_PaperRex_f0rsaken_DoubleFist.jpg",
                    coachPrice = 500,
                    coachGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("11b83625-aa92-468b-bf1b-123f2051a01f"),
                    coachName = "mindfreak",
                    coachPassword = "123m",
                    coachDescription = "Valorant professional player for PaperRex",
                    coachPicture = "https://assets.ggwp.id/2023/06/profil-mindfreak-featured-640x360.jpg",
                    coachPrice = 600,
                    coachGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
                new CoachesDatabaseModel()
                {
                    coachID = Guid.Parse("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"),
                    coachName = "something",
                    coachPassword = "123s",
                    coachDescription = "Valorant professional player for PaperRex",
                    coachPicture = "https://cdn.oneesports.gg/cdn-data/2023/05/Valorant_VCTPacific2023_Week6Day3_PRX_something_GunPose.jpg",
                    coachPrice = 600,
                    coachGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                },
            };
            modelBuilder.Entity<CoachesDatabaseModel>().HasData(Coaches);

            var Wallets = new List<WalletsDatabaseModel>()
            {
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("6b024b88-ff19-4f84-9dd5-4b773a671e05"),
                    walletOwnerID = Guid.Parse("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                    currencyOwned = 100,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("13f9f80b-5e2d-4b11-b1d3-364b5f674e9d"),
                    walletOwnerID = Guid.Parse("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                    currencyOwned = 200,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("cfab0e4e-cff6-4c5f-bc91-d7ab5a29b800"),
                    walletOwnerID = Guid.Parse("ee2e1814-2db3-4e29-b4c5-f5c69b24f6db"),
                    currencyOwned = 300,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("8b24e288-d5df-4d6c-ba34-68dfebb8f3d8"),
                    walletOwnerID = Guid.Parse("1a0d6253-b9fd-463e-b9f1-c79c442dbd94"),
                    currencyOwned = 400,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("6ff8c3a7-d7f4-4ba3-bd99-13b13b3a8e7d"),
                    walletOwnerID = Guid.Parse("4b0e25cf-d151-49d1-b4ff-520e417ea0e2"),
                    currencyOwned = 100,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("a1ae09e9-cc0e-4f38-9a24-95e3f9d6c71d"),
                    walletOwnerID = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    currencyOwned = 100,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("7cf950a7-3b7c-4e6e-8c97-ee6b5fc1532d"),
                    walletOwnerID = Guid.Parse("d4fd0f6e-69f4-43a1-98a5-d0cf2f85392f"),
                    currencyOwned = 100,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("bfb75d15-0fb8-40cc-8407-47dc8a20d55b"),
                    walletOwnerID = Guid.Parse("1e0ee16c-d78b-45a0-bb1e-9ab4a784b2f7"),
                    currencyOwned = 100,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("9298b63e-c117-480b-8d9e-5af67b91cf0b"),
                    walletOwnerID = Guid.Parse("99a5c6fd-b832-4375-b5ac-5f78c3c895d2"),
                    currencyOwned = 200,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("5645459f-6673-4bb5-93f3-cde981dd91e1"),
                    walletOwnerID = Guid.Parse("faf9bc4b-f8ac-414d-8d1f-66fdd454d4a6"),
                    currencyOwned = 200,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("d33db8f4-0c0d-4aa3-88e6-7f07d318c3eb"),
                    walletOwnerID = Guid.Parse("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                    currencyOwned = 200,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("ef16936f-7467-49fd-9269-0e4d775d2b07"),
                    walletOwnerID = Guid.Parse("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                    currencyOwned = 200,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("3122b812-b934-4e02-8827-cd8cf41e905f"),
                    walletOwnerID = Guid.Parse("9f54e945-d17c-43d5-8d1b-8837ac4a86d2"),
                    currencyOwned = 300,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("1bca0053-4d8c-4b68-9e17-f4ee7a6dd06f"),
                    walletOwnerID = Guid.Parse("13db2917-dbc9-4eb8-8f3c-926ed41d747f"),
                    currencyOwned = 300,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("2d0c5297-6f7d-4492-8ac7-d0b35f982160"),
                    walletOwnerID = Guid.Parse("b4c87739-f2c0-4b08-a319-4fb45774b5e5"),
                    currencyOwned = 300,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("8e0a3bb7-ae7a-4624-91b7-ee83ab9e5ee8"),
                    walletOwnerID = Guid.Parse("6a00e27e-9a9a-499b-afe4-233bf52edf5a"),
                    currencyOwned = 300,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("ccf33a5b-44a6-484b-97d1-7e7b7dd230f6"),
                    walletOwnerID = Guid.Parse("8a5eb77e-4a36-4598-8a64-1f167b7af6cb"),
                    currencyOwned = 400,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("d2d81b3d-5154-4394-ba45-2c0407f39e67"),
                    walletOwnerID = Guid.Parse("0d57e615-4c7b-4d6b-8b7c-9de18e3a8059"),
                    currencyOwned = 400,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("27b065a4-317e-47c8-97d4-c4c0d94921a4"),
                    walletOwnerID = Guid.Parse("11b83625-aa92-468b-bf1b-123f2051a01f"),
                    currencyOwned = 400,
                },
                new WalletsDatabaseModel()
                {
                    walletID = Guid.Parse("84c484bf-cf95-4b20-b6ff-1c7b776bba09"),
                    walletOwnerID = Guid.Parse("ff6c13e2-ff58-40c3-b3ab-675f1c2dca32"),
                    currencyOwned = 400,
                },
            };
            modelBuilder.Entity<WalletsDatabaseModel>().HasData(Wallets);

            var Games = new List<GamesDatabaseModel>()
            {
                new GamesDatabaseModel()
                {
                    gameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                    gameName = "Mobile Legends",
                    gamePicture = "https://static.wikia.nocookie.net/mobile-legends/images/e/ee/Mobile_Legends_5v5_Logo_Fair_MOBA_for_Mobile.JPG/revision/latest?cb=20200819062413",
                },
                new GamesDatabaseModel()
                {
                    gameID = Guid.Parse("684af5b7-9da8-4ae3-8d2a-ef1a3d18a5a7"),
                    gameName = "Counter Strike",
                    gamePicture = "https://cdn.akamai.steamstatic.com/steam/apps/730/capsule_616x353.jpg?t=1698860631",
                },
                new GamesDatabaseModel()
                {
                    gameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                    gameName = "Valorant",
                    gamePicture = "https://www.acerid.com/wp-content/uploads/2021/05/thumbnail-1.jpg",
                }
            };
            modelBuilder.Entity<GamesDatabaseModel>().HasData(Games);

            var Comments = new List<CommentsDatabaseModel>()
            {
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("72e8a29a-4413-4d4f-98bc-3a70218f6e39"),
                    commentedUser = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    commentContent = "Playing with him has been a blast! They're always up for a challenge and bring a lot of energy to our gaming sessions. However, there have been times when they get a bit too competitive, which can create tension and detract from the overall fun",
                    commentSender = "Cytzr",
                    commentRating = 5,
                    commentPicture = "",
                    commentType = "User"
                },
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("a13f6494-7141-4b5b-95af-21b12beafac5"),
                    commentedUser = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    commentContent = "He is incredibly skilled and has helped me improve a lot in the games we play together. They're also very reliable and always show up on time for our sessions. However, there are occasions when they're not very communicative, which can make coordinating strategies difficult.",
                    commentSender = "Archz",
                    commentRating = 2,
                    commentPicture = "",
                    commentType = "User"
                },
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("45d29558-8fc1-4628-9d9e-0a05741be9e3"),
                    commentedUser = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    commentContent = "I enjoy gaming with him most of the time. They have a great sense of humor and make our gaming sessions enjoyable. However, there are times when they become overly focused on winning, which can take away from the casual and laid-back atmosphere I prefer during gaming",
                    commentSender = "Sguishs",
                    commentRating = 5,
                    commentPicture = "",
                    commentType = "User"
                },
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("2f1ab3c7-e0c8-4d5a-b6b2-54b3b87f20d2"),
                    commentedUser = Guid.Parse("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                    commentContent = "I had high expectations when hiring the gaming coach, but unfortunately, I was left disappointed. While the coach had good intentions, their teaching style didn't resonate with me, and I didn't see much improvement in my gameplay. Additionally, there were frequent technical issues during online sessions, which disrupted the learning process.",
                    commentSender = "Cytzr",
                    commentRating = 1,
                    commentPicture = "",
                    commentType = "Coach"
                },
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("e9182aeb-465d-4d0b-ae76-19ef122d3e1b"),
                    commentedUser = Guid.Parse("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                    commentContent = "The gaming coach was friendly and supportive, creating a comfortable learning environment. However, I felt that the coaching sessions were a bit rushed, and there wasn't enough time to delve deep into advanced strategies.",
                    commentSender = "Archz",
                    commentRating = 4,
                    commentPicture = "",
                    commentType = "Coach"
                },
                new CommentsDatabaseModel()
                {
                    commentID = Guid.Parse("1b29c773-2e3c-4e9b-b59f-4888c6b18738"),
                    commentedUser = Guid.Parse("3a45f13f-b905-4e9d-8c18-b68f6653b141"),
                    commentContent = "The gaming coach was very patient and understanding, especially when I struggled with certain techniques.",
                    commentSender = "Sguishs",
                    commentRating = 5,
                    commentPicture = "",
                    commentType = "Coach"
                },
            };
            modelBuilder.Entity<CommentsDatabaseModel>().HasData(Comments);

            var events = new List<EventsDatabaseModel>()
            {
                new EventsDatabaseModel()
                {
                    eventID = Guid.Parse("1f5cb1a0-1e78-4f89-950d-d49e4d0e2e67"),
                    eventGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                    eventName = "MLBB x The King of Fighters 2024",
                    eventDescription = "MLBB × The King of Fighters is the collaboration of Mobile Legends: Bang Bang and The King of Fighters franchise.",
                    eventPicture = "https://i0.wp.com/www.gamerisme.com/wp-content/uploads/2023/12/event-kof-2024.webp?resize=860%2C484&ssl=1",
                    startDate = "02-01-2024",
                    endDate = "16-01-2024",
                },
                new EventsDatabaseModel()
                {
                    eventID = Guid.Parse("7d0c8771-8878-4baf-aad7-9d5487456956"),
                    eventGameID = Guid.Parse("e4b80f07-7c43-4e8d-a26f-83264604d8af"),
                    eventName = "MLBB x AOT",
                    eventDescription = "Three of Eldia’s greatest heroes will be in the Land of Dawn this month for the much-awaited Attack on Titan MLBB skins event.",
                    eventPicture = "https://cdn.oneesports.gg/cdn-data/2024/01/MLBB_AttackOnTitan_MLBB_skins_Levi_Eren_Mikasa-1024x576.jpg",
                    startDate = "31-01-2024",
                    endDate = "14-02-2024",
                },
                new EventsDatabaseModel()
                {
                    eventID = Guid.Parse("ac0e72d3-8e2c-4c5b-b7c6-30e7cf01eabc"),
                    eventGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                    eventName = "VCT 2024 - Pacific Kickoff",
                    eventDescription = "VCT 2024: Pacific Kickoff is an offline Korean tournament organized by Riot Games.",
                    eventPicture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWsSstTTgvyVtGvGSwQ6lpFLqsgtSt2vBmf2opOxAu3JuYeJGh0Hbid0xAAXtmEoBnpdU&usqp=CAU",
                    startDate = "17-02-2024",
                    endDate = "24-02-2024",
                },
                new EventsDatabaseModel()
                {
                    eventID = Guid.Parse("e9ef8c6b-c318-41f5-a7d0-90368a37bf6c"),
                    eventGameID = Guid.Parse("d9d4c4e1-9360-4d0c-8cf5-683786d7d01d"),
                    eventName = "Valorant Champions Tour 2024: Masters Madrid",
                    eventDescription = "VCT 2024: Masters Madrid is an offline Spanish tournament organized by Riot Games.",
                    eventPicture = "https://cdn.oneesports.id/cdn-data/sites/2/2024/02/420606774_1716048858883537_467729496432484881_n-450x253.jpg",
                    startDate = "14-03-2024",
                    endDate = "24-03-2024",
                },
            };
            modelBuilder.Entity<EventsDatabaseModel>().HasData(events);

            var UserOrders = new List<UserOrdersDatabaseModel>()
            {
                new UserOrdersDatabaseModel()
                {
                    orderID = Guid.Parse("8cf4bbfe-ec32-496d-bac9-16ab8450d4d9"),
                    customerID = Guid.Parse("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                    sellerID = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    orderType = "Playing",
                    orderStatus = "In Progress",
                    orderPrice = 10,
                },
                new UserOrdersDatabaseModel()
                {
                    orderID = Guid.Parse("9d83e380-084d-4d3a-a56e-d23cbf6b45e8"),
                    customerID = Guid.Parse("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                    sellerID = Guid.Parse("8572e71e-3561-487d-8f12-432a3e1b6dbb"),
                    orderType = "Playing",
                    orderStatus = "In Progress",
                    orderPrice = 15,
                }
            };
            modelBuilder.Entity<UserOrdersDatabaseModel>().HasData(UserOrders);

            var CoachOrders = new List<CoachOrdersDatabaseModel>()
            {
                new CoachOrdersDatabaseModel()
                {
                    orderID = Guid.Parse("6f83ff91-383e-4c7b-b2a3-8dfb5b47dd6d"),
                    customerID = Guid.Parse("2b536497-b4b2-4c0b-8bd3-721a62a6c53d"),
                    sellerID = Guid.Parse("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                    orderType = "Coaching",
                    orderStatus = "In Progress",
                    orderPrice = 200,
                },
                new CoachOrdersDatabaseModel()
                {
                    orderID = Guid.Parse("7a0c9db8-b228-4db5-9dd1-1bf0f25c4995"),
                    customerID = Guid.Parse("921f2f45-7360-4c9e-b7cb-af7d2b168e67"),
                    sellerID = Guid.Parse("72c084fb-dc7b-4825-a720-7f60702cfbb7"),
                    orderType = "Coaching",
                    orderStatus = "In Progress",
                    orderPrice = 200,
                }
            };
            modelBuilder.Entity<CoachOrdersDatabaseModel>().HasData(CoachOrders);
        }
    }
}
