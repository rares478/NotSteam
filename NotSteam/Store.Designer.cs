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

        public class CustomPanelRenderer : Panel
        {
            public Color TopColor { get; set; }
            public Color BottomColor { get; set; }
            public float Angle { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(27, 40, 56), Color.FromArgb(42, 71, 94), 270);
                Graphics g = e.Graphics;
                g.FillRectangle(brush, this.ClientRectangle);
                base.OnPaint(e);
            }
        }

        public class CustomPanelRendererButton : Panel
        {
            public Color TopColor { get; set; }
            public Color BottomColor { get; set; }
            public float Angle { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(23, 38, 53), Color.FromArgb(18, 29, 41), 180);
                Graphics g = e.Graphics;
                g.FillRectangle(brush, this.ClientRectangle);
                base.OnPaint(e);
            }
        }

        public class CustomButtonRenderer : Button
        {
            public Color TopColor { get; set; }
            public Color BottomColor { get; set; }
            public float Angle { get; set; }

            protected override void OnPaint(PaintEventArgs e)
            {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(23, 38, 53), Color.FromArgb(18, 29, 41), 180);
                Graphics g = e.Graphics;
                g.FillRectangle(brush, this.ClientRectangle);
                base.OnPaint(e);
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbQueue1 = new System.Windows.Forms.PictureBox();
            this.pbQueue2 = new System.Windows.Forms.PictureBox();
            this.pbQueue3 = new System.Windows.Forms.PictureBox();
            this.pbQueue4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new NotSteam.Store.CustomButtonRenderer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGamePrice = new System.Windows.Forms.Label();
            this.pbSS4 = new System.Windows.Forms.PictureBox();
            this.pbSS2 = new System.Windows.Forms.PictureBox();
            this.pbSS3 = new System.Windows.Forms.PictureBox();
            this.pbSS1 = new System.Windows.Forms.PictureBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.button1 = new NotSteam.Store.CustomButtonRenderer();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pbMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 1061);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pbQueue1);
            this.panel1.Controls.Add(this.pbQueue2);
            this.panel1.Controls.Add(this.pbQueue3);
            this.panel1.Controls.Add(this.pbQueue4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(131, 887);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 235);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(77, 99);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(782, 51);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pbQueue1
            // 
            this.pbQueue1.Location = new System.Drawing.Point(5, 31);
            this.pbQueue1.Name = "pbQueue1";
            this.pbQueue1.Size = new System.Drawing.Size(396, 192);
            this.pbQueue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueue1.TabIndex = 1;
            this.pbQueue1.TabStop = false;
            this.pbQueue1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pbQueue2
            // 
            this.pbQueue2.Location = new System.Drawing.Point(205, 43);
            this.pbQueue2.Name = "pbQueue2";
            this.pbQueue2.Size = new System.Drawing.Size(384, 167);
            this.pbQueue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueue2.TabIndex = 2;
            this.pbQueue2.TabStop = false;
            this.pbQueue2.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pbQueue3
            // 
            this.pbQueue3.Location = new System.Drawing.Point(451, 57);
            this.pbQueue3.Name = "pbQueue3";
            this.pbQueue3.Size = new System.Drawing.Size(306, 133);
            this.pbQueue3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueue3.TabIndex = 3;
            this.pbQueue3.TabStop = false;
            this.pbQueue3.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pbQueue4
            // 
            this.pbQueue4.Location = new System.Drawing.Point(669, 71);
            this.pbQueue4.Name = "pbQueue4";
            this.pbQueue4.Size = new System.Drawing.Size(260, 106);
            this.pbQueue4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQueue4.TabIndex = 4;
            this.pbQueue4.TabStop = false;
            this.pbQueue4.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "YOUR DISCOVERY QUEUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(128, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "FEATURED AND RECCOMENDED";
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
            this.menuStrip1.Location = new System.Drawing.Point(156, 9);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Angle = 0F;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BottomColor = System.Drawing.Color.Empty;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(84, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 97);
            this.button2.TabIndex = 4;
            this.button2.TopColor = System.Drawing.Color.Empty;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbGamePrice);
            this.panel4.Controls.Add(this.pbSS4);
            this.panel4.Controls.Add(this.pbSS2);
            this.panel4.Controls.Add(this.pbSS3);
            this.panel4.Controls.Add(this.pbSS1);
            this.panel4.Controls.Add(this.lbGameName);
            this.panel4.Location = new System.Drawing.Point(745, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 353);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOW AVAILABLE";
            // 
            // lbGamePrice
            // 
            this.lbGamePrice.AutoSize = true;
            this.lbGamePrice.Location = new System.Drawing.Point(29, 329);
            this.lbGamePrice.Name = "lbGamePrice";
            this.lbGamePrice.Size = new System.Drawing.Size(35, 13);
            this.lbGamePrice.TabIndex = 5;
            this.lbGamePrice.Text = "label2";
            // 
            // pbSS4
            // 
            this.pbSS4.Location = new System.Drawing.Point(163, 154);
            this.pbSS4.Name = "pbSS4";
            this.pbSS4.Size = new System.Drawing.Size(152, 60);
            this.pbSS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSS4.TabIndex = 4;
            this.pbSS4.TabStop = false;
            this.pbSS4.MouseEnter += new System.EventHandler(this.swappics);
            this.pbSS4.MouseLeave += new System.EventHandler(this.swapback);
            // 
            // pbSS2
            // 
            this.pbSS2.Location = new System.Drawing.Point(163, 88);
            this.pbSS2.Name = "pbSS2";
            this.pbSS2.Size = new System.Drawing.Size(152, 60);
            this.pbSS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSS2.TabIndex = 3;
            this.pbSS2.TabStop = false;
            this.pbSS2.MouseEnter += new System.EventHandler(this.swappics);
            this.pbSS2.MouseLeave += new System.EventHandler(this.swapback);
            // 
            // pbSS3
            // 
            this.pbSS3.Location = new System.Drawing.Point(3, 154);
            this.pbSS3.Name = "pbSS3";
            this.pbSS3.Size = new System.Drawing.Size(152, 60);
            this.pbSS3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSS3.TabIndex = 2;
            this.pbSS3.TabStop = false;
            this.pbSS3.MouseEnter += new System.EventHandler(this.swappics);
            this.pbSS3.MouseLeave += new System.EventHandler(this.swapback);
            // 
            // pbSS1
            // 
            this.pbSS1.Location = new System.Drawing.Point(5, 88);
            this.pbSS1.Name = "pbSS1";
            this.pbSS1.Size = new System.Drawing.Size(152, 60);
            this.pbSS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSS1.TabIndex = 1;
            this.pbSS1.TabStop = false;
            this.pbSS1.MouseEnter += new System.EventHandler(this.swappics);
            this.pbSS1.MouseLeave += new System.EventHandler(this.swapback);
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGameName.Location = new System.Drawing.Point(27, 23);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(70, 25);
            this.lbGameName.TabIndex = 0;
            this.lbGameName.Text = "label1";
            // 
            // button1
            // 
            this.button1.Angle = 0F;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BottomColor = System.Drawing.Color.Empty;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1075, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 97);
            this.button1.TabIndex = 1;
            this.button1.TopColor = System.Drawing.Color.Empty;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(128, 424);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(616, 353);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 1061);
            this.panel2.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dw.png");
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1172, 1061);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Store";
            this.Text = "Store";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQueue4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Timer timer1;
        private Panel panel3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yourStoreToolStripMenuItem;
        private ToolStripMenuItem followedGamesSoftwareToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem subscriptionsToolStripMenuItem;
        private ToolStripMenuItem manageSubscriptionsToolStripMenuItem;
        private ToolStripMenuItem preferanceToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem recommendationsToolStripMenuItem;
        private ToolStripMenuItem discoveryQueueToolStripMenuItem;
        private ToolStripMenuItem newReleaseQueueToolStripMenuItem;
        private ToolStripMenuItem communityRecommendationsToolStripMenuItem;
        private ToolStripMenuItem interactiveRecommenderToolStripMenuItem;
        private ToolStripMenuItem popularAmongFriendsToolStripMenuItem;
        private ToolStripMenuItem steamCuratorsToolStripMenuItem;
        private ToolStripMenuItem newNoteWorthyToolStripMenuItem;
        private ToolStripMenuItem topSellersToolStripMenuItem;
        private ToolStripMenuItem newTrendingToolStripMenuItem;
        private ToolStripMenuItem currentSpecialsToolStripMenuItem;
        private ToolStripMenuItem recentlyUpdatedToolStripMenuItem;
        private ToolStripMenuItem popularUpcomingToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem specialSectionsToolStripMenuItem;
        private ToolStripMenuItem freeToPlayToolStripMenuItem;
        private ToolStripMenuItem demosToolStripMenuItem;
        private ToolStripMenuItem earlyAccessToolStripMenuItem;
        private ToolStripMenuItem controllerFriendlyToolStripMenuItem;
        private ToolStripMenuItem remotePlayToolStripMenuItem;
        private ToolStripMenuItem softwareToolStripMenuItem;
        private ToolStripMenuItem soundtracksToolStripMenuItem;
        private ToolStripMenuItem vRTitlesToolStripMenuItem;
        private ToolStripMenuItem vRHardwareToolStripMenuItem;
        private ToolStripMenuItem notSteamDeckToolStripMenuItem;
        private ToolStripMenuItem greatOnDeckToolStripMenuItem;
        private ToolStripMenuItem macOSToolStripMenuItem;
        private ToolStripMenuItem notSteamOSLinuxToolStripMenuItem;
        private ToolStripMenuItem forPCCafesToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem ActionToolStripMenuItem;
        private ToolStripMenuItem actionRogueLikeToolStripMenuItem1;
        private ToolStripMenuItem arcadeAndRhythmToolStripMenuItem;
        private ToolStripMenuItem beatEmUpToolStripMenuItem;
        private ToolStripMenuItem fightingAndMartialArtsToolStripMenuItem;
        private ToolStripMenuItem firstPersonShooterToolStripMenuItem;
        private ToolStripMenuItem platformerAndRunnerToolStripMenuItem;
        private ToolStripMenuItem thirdPersonShooterToolStripMenuItem;
        private ToolStripMenuItem adventureAndCasualToolStripMenuItem;
        private ToolStripMenuItem adventureToolStripMenuItem;
        private ToolStripMenuItem adventureRPGToolStripMenuItem;
        private ToolStripMenuItem casualToolStripMenuItem;
        private ToolStripMenuItem metroidvanaToolStripMenuItem;
        private ToolStripMenuItem puzzleToolStripMenuItem;
        private ToolStripMenuItem storyRichToolStripMenuItem;
        private ToolStripMenuItem visualNovelToolStripMenuItem;
        private ToolStripMenuItem rolePlayingToolStripMenuItem;
        private ToolStripMenuItem actionRPGToolStripMenuItem;
        private ToolStripMenuItem adventureRPGToolStripMenuItem1;
        private ToolStripMenuItem jRPGToolStripMenuItem;
        private ToolStripMenuItem partyBasedToolStripMenuItem;
        private ToolStripMenuItem rogueLijkeToolStripMenuItem;
        private ToolStripMenuItem strategyRPGToolStripMenuItem;
        private ToolStripMenuItem turnBasedToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem buildingAndAutomationToolStripMenuItem;
        private ToolStripMenuItem datingToolStripMenuItem;
        private ToolStripMenuItem farmingAndCraftingToolStripMenuItem;
        private ToolStripMenuItem hobbyAndJobToolStripMenuItem;
        private ToolStripMenuItem lifeAndImmersiveToolStripMenuItem;
        private ToolStripMenuItem sandboxNadPhysicsToolStripMenuItem;
        private ToolStripMenuItem spaceAndFlightToolStripMenuItem;
        private ToolStripMenuItem strategyToolStripMenuItem;
        private ToolStripMenuItem cardAndBoardToolStripMenuItem;
        private ToolStripMenuItem cityAndSettlementToolStripMenuItem;
        private ToolStripMenuItem grandAnd4XToolStripMenuItem;
        private ToolStripMenuItem militaryToolStripMenuItem;
        private ToolStripMenuItem realTimeStrategyToolStripMenuItem;
        private ToolStripMenuItem towerDefenseToolStripMenuItem;
        private ToolStripMenuItem turnBasedStrategyToolStripMenuItem;
        private ToolStripMenuItem sportsAndRacingToolStripMenuItem;
        private ToolStripMenuItem allSportsToolStripMenuItem;
        private ToolStripMenuItem fishingAndHuntingToolStripMenuItem;
        private ToolStripMenuItem individualSportsToolStripMenuItem;
        private ToolStripMenuItem racingToolStripMenuItem;
        private ToolStripMenuItem racingSimToolStripMenuItem;
        private ToolStripMenuItem sportsSimToolStripMenuItem;
        private ToolStripMenuItem teamSportsToolStripMenuItem;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem adultOnlyToolStripMenuItem;
        private ToolStripMenuItem animeToolStripMenuItem;
        private ToolStripMenuItem goingRogueToolStripMenuItem;
        private ToolStripMenuItem horrorToolStripMenuItem;
        private ToolStripMenuItem mysteryAndDetectiveToolStripMenuItem;
        private ToolStripMenuItem openWorldToolStripMenuItem;
        private ToolStripMenuItem sciFiAndCyberpunkToolStripMenuItem;
        private ToolStripMenuItem spaceToolStripMenuItem;
        private ToolStripMenuItem survivalToolStripMenuItem;
        private ToolStripMenuItem playerSupportToolStripMenuItem;
        private ToolStripMenuItem coOperativeToolStripMenuItem;
        private ToolStripMenuItem lANToolStripMenuItem;
        private ToolStripMenuItem localAndPartyToolStripMenuItem;
        private ToolStripMenuItem mMOToolStripMenuItem;
        private ToolStripMenuItem multiplayerToolStripMenuItem;
        private ToolStripMenuItem onlineCompetitiveToolStripMenuItem;
        private ToolStripMenuItem singleplayerToolStripMenuItem;
        private ToolStripMenuItem pointsShopToolStripMenuItem;
        private ToolStripMenuItem newsToolStripMenuItem;
        private ToolStripMenuItem labsToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private PictureBox pictureBox1;
        private CustomButtonRenderer button2;
        private Panel panel4;
        private Label label2;
        private Label lbGamePrice;
        private PictureBox pbSS4;
        private PictureBox pbSS2;
        private PictureBox pbSS3;
        private PictureBox pbSS1;
        private Label lbGameName;
        private CustomButtonRenderer button1;
        private PictureBox pbMain;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pbQueue1;
        private PictureBox pbQueue2;
        private PictureBox pbQueue3;
        private PictureBox pbQueue4;
        private Label label3;
        private ImageList imageList1;
    }
}