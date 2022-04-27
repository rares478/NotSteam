using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace NotSteam
{
    partial class Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public class CustomToolStripRenderer : ToolStripProfessionalRenderer
        {
            public CustomToolStripRenderer() { }

            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                //you may want to change this based on the toolstrip's dock or layout style
                LinearGradientMode mode = LinearGradientMode.Horizontal;

                using (LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.FromArgb(47, 125, 192), Color.FromArgb(15, 33, 110), mode))
                {
                    e.Graphics.FillRectangle(b, e.AffectedBounds);
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yourStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followedGamesSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.recommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoveryQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReleaseQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communityRecommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactiveRecommenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularAmongFriendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamCuratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteWorthyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topSellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTrendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSpecialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyUpdatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularUpcomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earlyAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllerFriendlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remotePlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundtracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vRTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vRHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greatOnDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamOSLinuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forPCCafesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionRogueLikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arcadeAndRhythmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beatEmUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fightingAndMartialArtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPersonShooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformerAndRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdPersonShooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureAndCasualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureRPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroidvanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyRichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualNovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolePlayingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionRPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureRPGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jRPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rogueLijkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strategyRPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingAndAutomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmingAndCraftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobbyAndJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lifeAndImmersiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandboxNadPhysicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceAndFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardAndBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityAndSettlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandAnd4XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.militaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towerDefenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnBasedStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsAndRacingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fishingAndHuntingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualSportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racingSimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsSimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adultOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goingRogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysteryAndDetectiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sciFiAndCyberpunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coOperativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localAndPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineCompetitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Steam_service-Logo.wine.png");
            this.imageList1.Images.SetKeyName(1, "GTA V");
            this.imageList1.Images.SetKeyName(2, "BTD 6");
            this.imageList1.Images.SetKeyName(3, "Dying Light");
            this.imageList1.Images.SetKeyName(4, "New World");
            this.imageList1.Images.SetKeyName(5, "CS 1.6");
            this.imageList1.Images.SetKeyName(6, "PUBG");
            this.imageList1.Images.SetKeyName(7, "The Sims 4");
            this.imageList1.Images.SetKeyName(8, "CSGO");
            this.imageList1.Images.SetKeyName(9, "Farming Simulator 2022");
            this.imageList1.Images.SetKeyName(10, "who daddy");
            this.imageList1.Images.SetKeyName(11, "Unturned");
            this.imageList1.Images.SetKeyName(12, "Forza Horizon 5");
            this.imageList1.Images.SetKeyName(13, "Elden Ring");
            this.imageList1.Images.SetKeyName(14, "Sekiro: Shadow Die Twice");
            this.imageList1.Images.SetKeyName(15, "Cyberpunk 2077");
            this.imageList1.Images.SetKeyName(16, "Dread Hunger");
            this.imageList1.Images.SetKeyName(17, "The Walking Dead");
            this.imageList1.Images.SetKeyName(18, "Resident Evil Village");
            this.imageList1.Images.SetKeyName(19, "The Witcher 3");
            this.imageList1.Images.SetKeyName(20, "Kingdom Come: Deliverance");
            this.imageList1.Images.SetKeyName(21, "DayZ");
            this.imageList1.Images.SetKeyName(22, "Phasmophobia");
            this.imageList1.Images.SetKeyName(23, "Rust");
            this.imageList1.Images.SetKeyName(24, "Ready or Not");
            this.imageList1.Images.SetKeyName(25, "Sea of Thieves");
            this.imageList1.Images.SetKeyName(26, "Raft");
            this.imageList1.Images.SetKeyName(27, "Stardew Valley");
            this.imageList1.Images.SetKeyName(28, "Dead by Daylight");
            this.imageList1.Images.SetKeyName(29, "Dying Light 2");
            this.imageList1.Images.SetKeyName(30, "It Takes Two");
            this.imageList1.Images.SetKeyName(31, "God of War");
            this.imageList1.Images.SetKeyName(32, "Squad");
            this.imageList1.Images.SetKeyName(33, "Resident Evil 3");
            this.imageList1.Images.SetKeyName(34, "Valheim");
            this.imageList1.Images.SetKeyName(35, "The Forest");
            this.imageList1.Images.SetKeyName(36, "Red Dead Redemption 2");
            this.imageList1.Images.SetKeyName(37, "Terraria");
            this.imageList1.Images.SetKeyName(38, "Grounded");
            this.imageList1.Images.SetKeyName(39, "A Way Out");
            this.imageList1.Images.SetKeyName(40, "Factorio");
            this.imageList1.Images.SetKeyName(41, "Resident Evil 2");
            this.imageList1.Images.SetKeyName(42, "Satisfactory");
            this.imageList1.Images.SetKeyName(43, "No Mans Sky");
            this.imageList1.Images.SetKeyName(44, "The Elder Scrolls Online");
            this.imageList1.Images.SetKeyName(45, "FIFA 22");
            this.imageList1.Images.SetKeyName(46, "ARK Survival Evolved");
            this.imageList1.Images.SetKeyName(47, "Call of Duty Black Ops III");
            this.imageList1.Images.SetKeyName(48, "Teardown");
            this.imageList1.Images.SetKeyName(49, "Hades");
            this.imageList1.Images.SetKeyName(50, "Dont Starve Together");
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 536);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourStoreToolStripMenuItem,
            this.newNoteWorthyToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.pointsShopToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.labsToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "search";
            // 
            // yourStoreToolStripMenuItem
            // 
            this.yourStoreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.yourStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followedGamesSoftwareToolStripMenuItem,
            this.toolStripSeparator1,
            this.subscriptionsToolStripMenuItem,
            this.manageSubscriptionsToolStripMenuItem,
            this.preferanceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recommendationsToolStripMenuItem,
            this.discoveryQueueToolStripMenuItem,
            this.newReleaseQueueToolStripMenuItem,
            this.communityRecommendationsToolStripMenuItem,
            this.interactiveRecommenderToolStripMenuItem,
            this.popularAmongFriendsToolStripMenuItem,
            this.steamCuratorsToolStripMenuItem});
            this.yourStoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourStoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yourStoreToolStripMenuItem.Name = "yourStoreToolStripMenuItem";
            this.yourStoreToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.yourStoreToolStripMenuItem.Size = new System.Drawing.Size(86, 30);
            this.yourStoreToolStripMenuItem.Text = "Your Store";
            // 
            // followedGamesSoftwareToolStripMenuItem
            // 
            this.followedGamesSoftwareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followedGamesSoftwareToolStripMenuItem.Name = "followedGamesSoftwareToolStripMenuItem";
            this.followedGamesSoftwareToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.followedGamesSoftwareToolStripMenuItem.Text = "Followed Games & Software";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // subscriptionsToolStripMenuItem
            // 
            this.subscriptionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionsToolStripMenuItem.Name = "subscriptionsToolStripMenuItem";
            this.subscriptionsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.subscriptionsToolStripMenuItem.Text = "Subscriptions";
            // 
            // manageSubscriptionsToolStripMenuItem
            // 
            this.manageSubscriptionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubscriptionsToolStripMenuItem.Name = "manageSubscriptionsToolStripMenuItem";
            this.manageSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.manageSubscriptionsToolStripMenuItem.Text = "Manage Subscriptions";
            // 
            // preferanceToolStripMenuItem
            // 
            this.preferanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferanceToolStripMenuItem.Name = "preferanceToolStripMenuItem";
            this.preferanceToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.preferanceToolStripMenuItem.Text = "Preferances";
            this.preferanceToolStripMenuItem.Click += new System.EventHandler(this.preferanceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // recommendationsToolStripMenuItem
            // 
            this.recommendationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationsToolStripMenuItem.Name = "recommendationsToolStripMenuItem";
            this.recommendationsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.recommendationsToolStripMenuItem.Text = "Recommendations";
            // 
            // discoveryQueueToolStripMenuItem
            // 
            this.discoveryQueueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discoveryQueueToolStripMenuItem.Name = "discoveryQueueToolStripMenuItem";
            this.discoveryQueueToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.discoveryQueueToolStripMenuItem.Text = "Discovery Queue";
            // 
            // newReleaseQueueToolStripMenuItem
            // 
            this.newReleaseQueueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReleaseQueueToolStripMenuItem.Name = "newReleaseQueueToolStripMenuItem";
            this.newReleaseQueueToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.newReleaseQueueToolStripMenuItem.Text = "New Release Queue";
            // 
            // communityRecommendationsToolStripMenuItem
            // 
            this.communityRecommendationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communityRecommendationsToolStripMenuItem.Name = "communityRecommendationsToolStripMenuItem";
            this.communityRecommendationsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.communityRecommendationsToolStripMenuItem.Text = "Community Recommendations";
            // 
            // interactiveRecommenderToolStripMenuItem
            // 
            this.interactiveRecommenderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactiveRecommenderToolStripMenuItem.Name = "interactiveRecommenderToolStripMenuItem";
            this.interactiveRecommenderToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.interactiveRecommenderToolStripMenuItem.Text = "Interactive Recommender";
            // 
            // popularAmongFriendsToolStripMenuItem
            // 
            this.popularAmongFriendsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularAmongFriendsToolStripMenuItem.Name = "popularAmongFriendsToolStripMenuItem";
            this.popularAmongFriendsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.popularAmongFriendsToolStripMenuItem.Text = "Popular Among Friends";
            // 
            // steamCuratorsToolStripMenuItem
            // 
            this.steamCuratorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamCuratorsToolStripMenuItem.Name = "steamCuratorsToolStripMenuItem";
            this.steamCuratorsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.steamCuratorsToolStripMenuItem.Text = "Steam Curators";
            // 
            // newNoteWorthyToolStripMenuItem
            // 
            this.newNoteWorthyToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.newNoteWorthyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topSellersToolStripMenuItem,
            this.newTrendingToolStripMenuItem,
            this.currentSpecialsToolStripMenuItem,
            this.recentlyUpdatedToolStripMenuItem,
            this.popularUpcomingToolStripMenuItem});
            this.newNoteWorthyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoteWorthyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newNoteWorthyToolStripMenuItem.Name = "newNoteWorthyToolStripMenuItem";
            this.newNoteWorthyToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.newNoteWorthyToolStripMenuItem.Text = "New and Noteworthy";
            // 
            // topSellersToolStripMenuItem
            // 
            this.topSellersToolStripMenuItem.Name = "topSellersToolStripMenuItem";
            this.topSellersToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.topSellersToolStripMenuItem.Text = "Top Sellers";
            // 
            // newTrendingToolStripMenuItem
            // 
            this.newTrendingToolStripMenuItem.Name = "newTrendingToolStripMenuItem";
            this.newTrendingToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.newTrendingToolStripMenuItem.Text = "New & Trending";
            // 
            // currentSpecialsToolStripMenuItem
            // 
            this.currentSpecialsToolStripMenuItem.Name = "currentSpecialsToolStripMenuItem";
            this.currentSpecialsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.currentSpecialsToolStripMenuItem.Text = "Current Specials";
            // 
            // recentlyUpdatedToolStripMenuItem
            // 
            this.recentlyUpdatedToolStripMenuItem.Name = "recentlyUpdatedToolStripMenuItem";
            this.recentlyUpdatedToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.recentlyUpdatedToolStripMenuItem.Text = "Recently Updated";
            // 
            // popularUpcomingToolStripMenuItem
            // 
            this.popularUpcomingToolStripMenuItem.Name = "popularUpcomingToolStripMenuItem";
            this.popularUpcomingToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.popularUpcomingToolStripMenuItem.Text = "Popular Upcoming";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialSectionsToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.playerSupportToolStripMenuItem});
            this.categoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 30);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // specialSectionsToolStripMenuItem
            // 
            this.specialSectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeToPlayToolStripMenuItem,
            this.demosToolStripMenuItem,
            this.earlyAccessToolStripMenuItem,
            this.controllerFriendlyToolStripMenuItem,
            this.remotePlayToolStripMenuItem,
            this.softwareToolStripMenuItem,
            this.soundtracksToolStripMenuItem,
            this.vRTitlesToolStripMenuItem,
            this.vRHardwareToolStripMenuItem,
            this.notSteamDeckToolStripMenuItem,
            this.greatOnDeckToolStripMenuItem,
            this.macOSToolStripMenuItem,
            this.notSteamOSLinuxToolStripMenuItem,
            this.forPCCafesToolStripMenuItem});
            this.specialSectionsToolStripMenuItem.Name = "specialSectionsToolStripMenuItem";
            this.specialSectionsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.specialSectionsToolStripMenuItem.Text = "Special Sections";
            // 
            // freeToPlayToolStripMenuItem
            // 
            this.freeToPlayToolStripMenuItem.Name = "freeToPlayToolStripMenuItem";
            this.freeToPlayToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.freeToPlayToolStripMenuItem.Text = "Free to Play";
            // 
            // demosToolStripMenuItem
            // 
            this.demosToolStripMenuItem.Name = "demosToolStripMenuItem";
            this.demosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.demosToolStripMenuItem.Text = "Demos";
            // 
            // earlyAccessToolStripMenuItem
            // 
            this.earlyAccessToolStripMenuItem.Name = "earlyAccessToolStripMenuItem";
            this.earlyAccessToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.earlyAccessToolStripMenuItem.Text = "Early Access";
            // 
            // controllerFriendlyToolStripMenuItem
            // 
            this.controllerFriendlyToolStripMenuItem.Name = "controllerFriendlyToolStripMenuItem";
            this.controllerFriendlyToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.controllerFriendlyToolStripMenuItem.Text = "Controller-Friendly";
            // 
            // remotePlayToolStripMenuItem
            // 
            this.remotePlayToolStripMenuItem.Name = "remotePlayToolStripMenuItem";
            this.remotePlayToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.remotePlayToolStripMenuItem.Text = "Remote Play";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.softwareToolStripMenuItem.Text = "Software";
            // 
            // soundtracksToolStripMenuItem
            // 
            this.soundtracksToolStripMenuItem.Name = "soundtracksToolStripMenuItem";
            this.soundtracksToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.soundtracksToolStripMenuItem.Text = "Soundtracks";
            // 
            // vRTitlesToolStripMenuItem
            // 
            this.vRTitlesToolStripMenuItem.Name = "vRTitlesToolStripMenuItem";
            this.vRTitlesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.vRTitlesToolStripMenuItem.Text = "VR Titles";
            // 
            // vRHardwareToolStripMenuItem
            // 
            this.vRHardwareToolStripMenuItem.Name = "vRHardwareToolStripMenuItem";
            this.vRHardwareToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.vRHardwareToolStripMenuItem.Text = "VR Hardware";
            // 
            // notSteamDeckToolStripMenuItem
            // 
            this.notSteamDeckToolStripMenuItem.Name = "notSteamDeckToolStripMenuItem";
            this.notSteamDeckToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.notSteamDeckToolStripMenuItem.Text = "NotSteam Deck";
            // 
            // greatOnDeckToolStripMenuItem
            // 
            this.greatOnDeckToolStripMenuItem.Name = "greatOnDeckToolStripMenuItem";
            this.greatOnDeckToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.greatOnDeckToolStripMenuItem.Text = "Great on Deck";
            // 
            // macOSToolStripMenuItem
            // 
            this.macOSToolStripMenuItem.Name = "macOSToolStripMenuItem";
            this.macOSToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.macOSToolStripMenuItem.Text = "macOS";
            // 
            // notSteamOSLinuxToolStripMenuItem
            // 
            this.notSteamOSLinuxToolStripMenuItem.Name = "notSteamOSLinuxToolStripMenuItem";
            this.notSteamOSLinuxToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.notSteamOSLinuxToolStripMenuItem.Text = "NotSteamOS + Linux";
            // 
            // forPCCafesToolStripMenuItem
            // 
            this.forPCCafesToolStripMenuItem.Name = "forPCCafesToolStripMenuItem";
            this.forPCCafesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.forPCCafesToolStripMenuItem.Text = "For PC Cafes";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionToolStripMenuItem,
            this.adventureAndCasualToolStripMenuItem,
            this.rolePlayingToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.strategyToolStripMenuItem,
            this.sportsAndRacingToolStripMenuItem});
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // ActionToolStripMenuItem
            // 
            this.ActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionRogueLikeToolStripMenuItem1,
            this.arcadeAndRhythmToolStripMenuItem,
            this.beatEmUpToolStripMenuItem,
            this.fightingAndMartialArtsToolStripMenuItem,
            this.firstPersonShooterToolStripMenuItem,
            this.platformerAndRunnerToolStripMenuItem,
            this.thirdPersonShooterToolStripMenuItem});
            this.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem";
            this.ActionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ActionToolStripMenuItem.Text = "Action";
            // 
            // actionRogueLikeToolStripMenuItem1
            // 
            this.actionRogueLikeToolStripMenuItem1.Name = "actionRogueLikeToolStripMenuItem1";
            this.actionRogueLikeToolStripMenuItem1.Size = new System.Drawing.Size(252, 26);
            this.actionRogueLikeToolStripMenuItem1.Text = "Action Rogue-Like";
            // 
            // arcadeAndRhythmToolStripMenuItem
            // 
            this.arcadeAndRhythmToolStripMenuItem.Name = "arcadeAndRhythmToolStripMenuItem";
            this.arcadeAndRhythmToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.arcadeAndRhythmToolStripMenuItem.Text = "Arcade and Rhythm";
            // 
            // beatEmUpToolStripMenuItem
            // 
            this.beatEmUpToolStripMenuItem.Name = "beatEmUpToolStripMenuItem";
            this.beatEmUpToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.beatEmUpToolStripMenuItem.Text = "Beat \'Em Up";
            // 
            // fightingAndMartialArtsToolStripMenuItem
            // 
            this.fightingAndMartialArtsToolStripMenuItem.Name = "fightingAndMartialArtsToolStripMenuItem";
            this.fightingAndMartialArtsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.fightingAndMartialArtsToolStripMenuItem.Text = "Fighting and Martial Arts";
            // 
            // firstPersonShooterToolStripMenuItem
            // 
            this.firstPersonShooterToolStripMenuItem.Name = "firstPersonShooterToolStripMenuItem";
            this.firstPersonShooterToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.firstPersonShooterToolStripMenuItem.Text = "First-Person Shooter";
            // 
            // platformerAndRunnerToolStripMenuItem
            // 
            this.platformerAndRunnerToolStripMenuItem.Name = "platformerAndRunnerToolStripMenuItem";
            this.platformerAndRunnerToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.platformerAndRunnerToolStripMenuItem.Text = "Platformer and Runner";
            // 
            // thirdPersonShooterToolStripMenuItem
            // 
            this.thirdPersonShooterToolStripMenuItem.Name = "thirdPersonShooterToolStripMenuItem";
            this.thirdPersonShooterToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.thirdPersonShooterToolStripMenuItem.Text = "Third-Person Shooter";
            // 
            // adventureAndCasualToolStripMenuItem
            // 
            this.adventureAndCasualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adventureToolStripMenuItem,
            this.adventureRPGToolStripMenuItem,
            this.casualToolStripMenuItem,
            this.metroidvanaToolStripMenuItem,
            this.puzzleToolStripMenuItem,
            this.storyRichToolStripMenuItem,
            this.visualNovelToolStripMenuItem});
            this.adventureAndCasualToolStripMenuItem.Name = "adventureAndCasualToolStripMenuItem";
            this.adventureAndCasualToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.adventureAndCasualToolStripMenuItem.Text = "Adventure and Casual";
            // 
            // adventureToolStripMenuItem
            // 
            this.adventureToolStripMenuItem.Name = "adventureToolStripMenuItem";
            this.adventureToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.adventureToolStripMenuItem.Text = "Adventure";
            // 
            // adventureRPGToolStripMenuItem
            // 
            this.adventureRPGToolStripMenuItem.Name = "adventureRPGToolStripMenuItem";
            this.adventureRPGToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.adventureRPGToolStripMenuItem.Text = "Adventure RPG";
            // 
            // casualToolStripMenuItem
            // 
            this.casualToolStripMenuItem.Name = "casualToolStripMenuItem";
            this.casualToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.casualToolStripMenuItem.Text = "Casual";
            // 
            // metroidvanaToolStripMenuItem
            // 
            this.metroidvanaToolStripMenuItem.Name = "metroidvanaToolStripMenuItem";
            this.metroidvanaToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.metroidvanaToolStripMenuItem.Text = "Metroidvana";
            // 
            // puzzleToolStripMenuItem
            // 
            this.puzzleToolStripMenuItem.Name = "puzzleToolStripMenuItem";
            this.puzzleToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.puzzleToolStripMenuItem.Text = "Puzzle";
            // 
            // storyRichToolStripMenuItem
            // 
            this.storyRichToolStripMenuItem.Name = "storyRichToolStripMenuItem";
            this.storyRichToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.storyRichToolStripMenuItem.Text = "Story-Rich";
            // 
            // visualNovelToolStripMenuItem
            // 
            this.visualNovelToolStripMenuItem.Name = "visualNovelToolStripMenuItem";
            this.visualNovelToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.visualNovelToolStripMenuItem.Text = "Visual Novel";
            // 
            // rolePlayingToolStripMenuItem
            // 
            this.rolePlayingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionRPGToolStripMenuItem,
            this.adventureRPGToolStripMenuItem1,
            this.jRPGToolStripMenuItem,
            this.partyBasedToolStripMenuItem,
            this.rogueLijkeToolStripMenuItem,
            this.strategyRPGToolStripMenuItem,
            this.turnBasedToolStripMenuItem});
            this.rolePlayingToolStripMenuItem.Name = "rolePlayingToolStripMenuItem";
            this.rolePlayingToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.rolePlayingToolStripMenuItem.Text = "Role-Playing";
            // 
            // actionRPGToolStripMenuItem
            // 
            this.actionRPGToolStripMenuItem.Name = "actionRPGToolStripMenuItem";
            this.actionRPGToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.actionRPGToolStripMenuItem.Text = "Action-RPG";
            // 
            // adventureRPGToolStripMenuItem1
            // 
            this.adventureRPGToolStripMenuItem1.Name = "adventureRPGToolStripMenuItem1";
            this.adventureRPGToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.adventureRPGToolStripMenuItem1.Text = "Adventure-RPG";
            // 
            // jRPGToolStripMenuItem
            // 
            this.jRPGToolStripMenuItem.Name = "jRPGToolStripMenuItem";
            this.jRPGToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.jRPGToolStripMenuItem.Text = "JRPG";
            // 
            // partyBasedToolStripMenuItem
            // 
            this.partyBasedToolStripMenuItem.Name = "partyBasedToolStripMenuItem";
            this.partyBasedToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.partyBasedToolStripMenuItem.Text = "Party-Based";
            // 
            // rogueLijkeToolStripMenuItem
            // 
            this.rogueLijkeToolStripMenuItem.Name = "rogueLijkeToolStripMenuItem";
            this.rogueLijkeToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.rogueLijkeToolStripMenuItem.Text = "Rogue-Like";
            // 
            // strategyRPGToolStripMenuItem
            // 
            this.strategyRPGToolStripMenuItem.Name = "strategyRPGToolStripMenuItem";
            this.strategyRPGToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.strategyRPGToolStripMenuItem.Text = "Strategy RPG";
            // 
            // turnBasedToolStripMenuItem
            // 
            this.turnBasedToolStripMenuItem.Name = "turnBasedToolStripMenuItem";
            this.turnBasedToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.turnBasedToolStripMenuItem.Text = "Turn-Based";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingAndAutomationToolStripMenuItem,
            this.datingToolStripMenuItem,
            this.farmingAndCraftingToolStripMenuItem,
            this.hobbyAndJobToolStripMenuItem,
            this.lifeAndImmersiveToolStripMenuItem,
            this.sandboxNadPhysicsToolStripMenuItem,
            this.spaceAndFlightToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // buildingAndAutomationToolStripMenuItem
            // 
            this.buildingAndAutomationToolStripMenuItem.Name = "buildingAndAutomationToolStripMenuItem";
            this.buildingAndAutomationToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.buildingAndAutomationToolStripMenuItem.Text = "Building and Automation";
            // 
            // datingToolStripMenuItem
            // 
            this.datingToolStripMenuItem.Name = "datingToolStripMenuItem";
            this.datingToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.datingToolStripMenuItem.Text = "Dating";
            // 
            // farmingAndCraftingToolStripMenuItem
            // 
            this.farmingAndCraftingToolStripMenuItem.Name = "farmingAndCraftingToolStripMenuItem";
            this.farmingAndCraftingToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.farmingAndCraftingToolStripMenuItem.Text = "Farming and Crafting";
            // 
            // hobbyAndJobToolStripMenuItem
            // 
            this.hobbyAndJobToolStripMenuItem.Name = "hobbyAndJobToolStripMenuItem";
            this.hobbyAndJobToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.hobbyAndJobToolStripMenuItem.Text = "Hobby and Job";
            // 
            // lifeAndImmersiveToolStripMenuItem
            // 
            this.lifeAndImmersiveToolStripMenuItem.Name = "lifeAndImmersiveToolStripMenuItem";
            this.lifeAndImmersiveToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.lifeAndImmersiveToolStripMenuItem.Text = "Life and Immersive";
            // 
            // sandboxNadPhysicsToolStripMenuItem
            // 
            this.sandboxNadPhysicsToolStripMenuItem.Name = "sandboxNadPhysicsToolStripMenuItem";
            this.sandboxNadPhysicsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.sandboxNadPhysicsToolStripMenuItem.Text = "Sandbox nad Physics";
            // 
            // spaceAndFlightToolStripMenuItem
            // 
            this.spaceAndFlightToolStripMenuItem.Name = "spaceAndFlightToolStripMenuItem";
            this.spaceAndFlightToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.spaceAndFlightToolStripMenuItem.Text = "Space and Flight";
            // 
            // strategyToolStripMenuItem
            // 
            this.strategyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardAndBoardToolStripMenuItem,
            this.cityAndSettlementToolStripMenuItem,
            this.grandAnd4XToolStripMenuItem,
            this.militaryToolStripMenuItem,
            this.realTimeStrategyToolStripMenuItem,
            this.towerDefenseToolStripMenuItem,
            this.turnBasedStrategyToolStripMenuItem});
            this.strategyToolStripMenuItem.Name = "strategyToolStripMenuItem";
            this.strategyToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.strategyToolStripMenuItem.Text = "Strategy";
            // 
            // cardAndBoardToolStripMenuItem
            // 
            this.cardAndBoardToolStripMenuItem.Name = "cardAndBoardToolStripMenuItem";
            this.cardAndBoardToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.cardAndBoardToolStripMenuItem.Text = "Card and Board";
            // 
            // cityAndSettlementToolStripMenuItem
            // 
            this.cityAndSettlementToolStripMenuItem.Name = "cityAndSettlementToolStripMenuItem";
            this.cityAndSettlementToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.cityAndSettlementToolStripMenuItem.Text = "City and Settlement";
            // 
            // grandAnd4XToolStripMenuItem
            // 
            this.grandAnd4XToolStripMenuItem.Name = "grandAnd4XToolStripMenuItem";
            this.grandAnd4XToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.grandAnd4XToolStripMenuItem.Text = "Grand and 4X";
            // 
            // militaryToolStripMenuItem
            // 
            this.militaryToolStripMenuItem.Name = "militaryToolStripMenuItem";
            this.militaryToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.militaryToolStripMenuItem.Text = "Military";
            // 
            // realTimeStrategyToolStripMenuItem
            // 
            this.realTimeStrategyToolStripMenuItem.Name = "realTimeStrategyToolStripMenuItem";
            this.realTimeStrategyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.realTimeStrategyToolStripMenuItem.Text = "Real-Time Strategy";
            // 
            // towerDefenseToolStripMenuItem
            // 
            this.towerDefenseToolStripMenuItem.Name = "towerDefenseToolStripMenuItem";
            this.towerDefenseToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.towerDefenseToolStripMenuItem.Text = "Tower Defense";
            // 
            // turnBasedStrategyToolStripMenuItem
            // 
            this.turnBasedStrategyToolStripMenuItem.Name = "turnBasedStrategyToolStripMenuItem";
            this.turnBasedStrategyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.turnBasedStrategyToolStripMenuItem.Text = "Turn-Based Strategy";
            // 
            // sportsAndRacingToolStripMenuItem
            // 
            this.sportsAndRacingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSportsToolStripMenuItem,
            this.fishingAndHuntingToolStripMenuItem,
            this.individualSportsToolStripMenuItem,
            this.racingToolStripMenuItem,
            this.racingSimToolStripMenuItem,
            this.sportsSimToolStripMenuItem,
            this.teamSportsToolStripMenuItem});
            this.sportsAndRacingToolStripMenuItem.Name = "sportsAndRacingToolStripMenuItem";
            this.sportsAndRacingToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.sportsAndRacingToolStripMenuItem.Text = "Sports and Racing";
            // 
            // allSportsToolStripMenuItem
            // 
            this.allSportsToolStripMenuItem.Name = "allSportsToolStripMenuItem";
            this.allSportsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.allSportsToolStripMenuItem.Text = "All Sports";
            // 
            // fishingAndHuntingToolStripMenuItem
            // 
            this.fishingAndHuntingToolStripMenuItem.Name = "fishingAndHuntingToolStripMenuItem";
            this.fishingAndHuntingToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.fishingAndHuntingToolStripMenuItem.Text = "Fishing and Hunting";
            // 
            // individualSportsToolStripMenuItem
            // 
            this.individualSportsToolStripMenuItem.Name = "individualSportsToolStripMenuItem";
            this.individualSportsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.individualSportsToolStripMenuItem.Text = "Individual Sports";
            // 
            // racingToolStripMenuItem
            // 
            this.racingToolStripMenuItem.Name = "racingToolStripMenuItem";
            this.racingToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.racingToolStripMenuItem.Text = "Racing";
            // 
            // racingSimToolStripMenuItem
            // 
            this.racingSimToolStripMenuItem.Name = "racingSimToolStripMenuItem";
            this.racingSimToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.racingSimToolStripMenuItem.Text = "Racing Sim";
            // 
            // sportsSimToolStripMenuItem
            // 
            this.sportsSimToolStripMenuItem.Name = "sportsSimToolStripMenuItem";
            this.sportsSimToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sportsSimToolStripMenuItem.Text = "Sports Sim";
            // 
            // teamSportsToolStripMenuItem
            // 
            this.teamSportsToolStripMenuItem.Name = "teamSportsToolStripMenuItem";
            this.teamSportsToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.teamSportsToolStripMenuItem.Text = "Team Sports";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adultOnlyToolStripMenuItem,
            this.animeToolStripMenuItem,
            this.goingRogueToolStripMenuItem,
            this.horrorToolStripMenuItem,
            this.mysteryAndDetectiveToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.sciFiAndCyberpunkToolStripMenuItem,
            this.spaceToolStripMenuItem,
            this.survivalToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // adultOnlyToolStripMenuItem
            // 
            this.adultOnlyToolStripMenuItem.Name = "adultOnlyToolStripMenuItem";
            this.adultOnlyToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.adultOnlyToolStripMenuItem.Text = "Adult Only";
            // 
            // animeToolStripMenuItem
            // 
            this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            this.animeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.animeToolStripMenuItem.Text = "Anime";
            // 
            // goingRogueToolStripMenuItem
            // 
            this.goingRogueToolStripMenuItem.Name = "goingRogueToolStripMenuItem";
            this.goingRogueToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.goingRogueToolStripMenuItem.Text = "Going Rogue";
            // 
            // horrorToolStripMenuItem
            // 
            this.horrorToolStripMenuItem.Name = "horrorToolStripMenuItem";
            this.horrorToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.horrorToolStripMenuItem.Text = "Horror";
            // 
            // mysteryAndDetectiveToolStripMenuItem
            // 
            this.mysteryAndDetectiveToolStripMenuItem.Name = "mysteryAndDetectiveToolStripMenuItem";
            this.mysteryAndDetectiveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.mysteryAndDetectiveToolStripMenuItem.Text = "Mystery and Detective";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openWorldToolStripMenuItem.Text = "Open World";
            // 
            // sciFiAndCyberpunkToolStripMenuItem
            // 
            this.sciFiAndCyberpunkToolStripMenuItem.Name = "sciFiAndCyberpunkToolStripMenuItem";
            this.sciFiAndCyberpunkToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.sciFiAndCyberpunkToolStripMenuItem.Text = "Sci-Fi and Cyberpunk";
            // 
            // spaceToolStripMenuItem
            // 
            this.spaceToolStripMenuItem.Name = "spaceToolStripMenuItem";
            this.spaceToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.spaceToolStripMenuItem.Text = "Space";
            // 
            // survivalToolStripMenuItem
            // 
            this.survivalToolStripMenuItem.Name = "survivalToolStripMenuItem";
            this.survivalToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.survivalToolStripMenuItem.Text = "Survival";
            // 
            // playerSupportToolStripMenuItem
            // 
            this.playerSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coOperativeToolStripMenuItem,
            this.lANToolStripMenuItem,
            this.localAndPartyToolStripMenuItem,
            this.mMOToolStripMenuItem,
            this.multiplayerToolStripMenuItem,
            this.onlineCompetitiveToolStripMenuItem,
            this.singleplayerToolStripMenuItem});
            this.playerSupportToolStripMenuItem.Name = "playerSupportToolStripMenuItem";
            this.playerSupportToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.playerSupportToolStripMenuItem.Text = "Player Support";
            // 
            // coOperativeToolStripMenuItem
            // 
            this.coOperativeToolStripMenuItem.Name = "coOperativeToolStripMenuItem";
            this.coOperativeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.coOperativeToolStripMenuItem.Text = "Co-Operative";
            // 
            // lANToolStripMenuItem
            // 
            this.lANToolStripMenuItem.Name = "lANToolStripMenuItem";
            this.lANToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.lANToolStripMenuItem.Text = "LAN";
            // 
            // localAndPartyToolStripMenuItem
            // 
            this.localAndPartyToolStripMenuItem.Name = "localAndPartyToolStripMenuItem";
            this.localAndPartyToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.localAndPartyToolStripMenuItem.Text = "Local and Party";
            // 
            // mMOToolStripMenuItem
            // 
            this.mMOToolStripMenuItem.Name = "mMOToolStripMenuItem";
            this.mMOToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.mMOToolStripMenuItem.Text = "MMO";
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.multiplayerToolStripMenuItem.Text = "Multiplayer";
            // 
            // onlineCompetitiveToolStripMenuItem
            // 
            this.onlineCompetitiveToolStripMenuItem.Name = "onlineCompetitiveToolStripMenuItem";
            this.onlineCompetitiveToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.onlineCompetitiveToolStripMenuItem.Text = "Online Competitive";
            // 
            // singleplayerToolStripMenuItem
            // 
            this.singleplayerToolStripMenuItem.Name = "singleplayerToolStripMenuItem";
            this.singleplayerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.singleplayerToolStripMenuItem.Text = "Singleplayer";
            // 
            // pointsShopToolStripMenuItem
            // 
            this.pointsShopToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.pointsShopToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsShopToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pointsShopToolStripMenuItem.Name = "pointsShopToolStripMenuItem";
            this.pointsShopToolStripMenuItem.Size = new System.Drawing.Size(104, 30);
            this.pointsShopToolStripMenuItem.Text = "Points Shop";
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.newsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(61, 30);
            this.newsToolStripMenuItem.Text = "News";
            // 
            // labsToolStripMenuItem
            // 
            this.labsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.labsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labsToolStripMenuItem.Name = "labsToolStripMenuItem";
            this.labsToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.labsToolStripMenuItem.Text = "Labs";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(175, 30);
            this.toolStripTextBox1.Text = "search";
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(953, 536);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Store";
            this.Text = "Store";
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yourStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followedGamesSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem subscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSubscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem recommendationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discoveryQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReleaseQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communityRecommendationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactiveRecommenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularAmongFriendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamCuratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteWorthyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topSellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTrendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSpecialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyUpdatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularUpcomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earlyAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllerFriendlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remotePlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundtracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vRTitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vRHardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSteamDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greatOnDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSteamOSLinuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forPCCafesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionRogueLikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arcadeAndRhythmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beatEmUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fightingAndMartialArtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstPersonShooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformerAndRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdPersonShooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureAndCasualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureRPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metroidvanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storyRichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualNovelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolePlayingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionRPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureRPGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jRPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rogueLijkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strategyRPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingAndAutomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farmingAndCraftingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobbyAndJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lifeAndImmersiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandboxNadPhysicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceAndFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardAndBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityAndSettlementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandAnd4XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem militaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeStrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towerDefenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnBasedStrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsAndRacingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fishingAndHuntingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualSportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racingSimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsSimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamSportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adultOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goingRogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mysteryAndDetectiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sciFiAndCyberpunkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem survivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coOperativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localAndPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mMOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineCompetitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}