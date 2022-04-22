using System.Windows.Forms;
using System.Drawing;

namespace NotSteam
{
    public class ExtendedToolStripSeparator : ToolStripSeparator
    {
        public ExtendedToolStripSeparator() => this.Paint += ExtendedToolStripSeparator_Paint;

        private void ExtendedToolStripSeparator_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;
            Color foreColor = System.Drawing.SystemColors.ActiveBorder;
            Color backColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));

            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
        }
    }
    partial class NotSteamForm
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


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotSteamForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goOffnileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new NotSteam.ExtendedToolStripSeparator();
            this.checkForNotSteamClientUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new NotSteam.ExtendedToolStripSeparator();
            this.backupAndRestoreGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new NotSteam.ExtendedToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new NotSteam.ExtendedToolStripSeparator();
            this.addGameToNotSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new NotSteam.ExtendedToolStripSeparator();
            this.smallModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigPictureModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new NotSteam.ExtendedToolStripSeparator();
            this.musicPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new NotSteam.ExtendedToolStripSeparator();
            this.friendsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenshotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new NotSteam.ExtendedToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFriendListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new NotSteam.ExtendedToolStripSeparator();
            this.addAFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new NotSteam.ExtendedToolStripSeparator();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGamesLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new NotSteam.ExtendedToolStripSeparator();
            this.activateAProductOnNotSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeemANotSteamWalletCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGiftsAndGuestPassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new NotSteam.ExtendedToolStripSeparator();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutOfAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storePreferanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamSubscriberAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Steam_service-Logo.wine.png");
            this.imageList1.Images.SetKeyName(1, "gta 5.jpg");
            this.imageList1.Images.SetKeyName(2, "bloons-td6-purple.jpg");
            this.imageList1.Images.SetKeyName(3, "Dying_Light.jpg");
            this.imageList1.Images.SetKeyName(4, "new world.jpg");
            this.imageList1.Images.SetKeyName(5, "cs1.6.jpg");
            this.imageList1.Images.SetKeyName(6, "pubg.jpg");
            this.imageList1.Images.SetKeyName(7, "sims4.jpg");
            this.imageList1.Images.SetKeyName(8, "csgo.png");
            this.imageList1.Images.SetKeyName(9, "Farming simulator.jpg");
            this.imageList1.Images.SetKeyName(10, "who\'s your daddy.jpg");
            this.imageList1.Images.SetKeyName(11, "unturned.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.friendsToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveform);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAccountToolStripMenuItem,
            this.goOffnileToolStripMenuItem,
            this.toolStripSeparator4,
            this.checkForNotSteamClientUpdatesToolStripMenuItem,
            this.toolStripSeparator5,
            this.backupAndRestoreGamesToolStripMenuItem,
            this.toolStripSeparator6,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator14,
            this.addGameToNotSteamToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "NotSteam";
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.changeAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.changeAccountToolStripMenuItem.Text = "Change Account";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // goOffnileToolStripMenuItem
            // 
            this.goOffnileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.goOffnileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.goOffnileToolStripMenuItem.Name = "goOffnileToolStripMenuItem";
            this.goOffnileToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.goOffnileToolStripMenuItem.Text = "Go Offline";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // checkForNotSteamClientUpdatesToolStripMenuItem
            // 
            this.checkForNotSteamClientUpdatesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.checkForNotSteamClientUpdatesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkForNotSteamClientUpdatesToolStripMenuItem.Name = "checkForNotSteamClientUpdatesToolStripMenuItem";
            this.checkForNotSteamClientUpdatesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.checkForNotSteamClientUpdatesToolStripMenuItem.Text = "Check for NotSteam Client Updates";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(258, 6);
            // 
            // backupAndRestoreGamesToolStripMenuItem
            // 
            this.backupAndRestoreGamesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.backupAndRestoreGamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.backupAndRestoreGamesToolStripMenuItem.Name = "backupAndRestoreGamesToolStripMenuItem";
            this.backupAndRestoreGamesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.backupAndRestoreGamesToolStripMenuItem.Text = "Backup and Restore Games";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(258, 6);
            // 
            // addGameToNotSteamToolStripMenuItem
            // 
            this.addGameToNotSteamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addGameToNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addGameToNotSteamToolStripMenuItem.Name = "addGameToNotSteamToolStripMenuItem";
            this.addGameToNotSteamToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.addGameToNotSteamToolStripMenuItem.Text = "Add game to NotSteam";
            this.addGameToNotSteamToolStripMenuItem.Click += new System.EventHandler(this.addGameToNotSteamToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.hiddenGamesToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.toolStripSeparator10,
            this.smallModeToolStripMenuItem,
            this.bigPictureModeToolStripMenuItem,
            this.toolStripSeparator11,
            this.musicPlayerToolStripMenuItem,
            this.toolStripSeparator12,
            this.friendsToolStripMenuItem1,
            this.playersToolStripMenuItem,
            this.serversToolStripMenuItem,
            this.screenshotsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.updateNewsToolStripMenuItem,
            this.toolStripSeparator13,
            this.settingsToolStripMenuItem1});
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "View";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.libraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // hiddenGamesToolStripMenuItem
            // 
            this.hiddenGamesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.hiddenGamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hiddenGamesToolStripMenuItem.Name = "hiddenGamesToolStripMenuItem";
            this.hiddenGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hiddenGamesToolStripMenuItem.Text = "Hidden Games";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.downloadsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
            // 
            // smallModeToolStripMenuItem
            // 
            this.smallModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.smallModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.smallModeToolStripMenuItem.Name = "smallModeToolStripMenuItem";
            this.smallModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallModeToolStripMenuItem.Text = "Small Mode";
            // 
            // bigPictureModeToolStripMenuItem
            // 
            this.bigPictureModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.bigPictureModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bigPictureModeToolStripMenuItem.Name = "bigPictureModeToolStripMenuItem";
            this.bigPictureModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bigPictureModeToolStripMenuItem.Text = "Big Picture Mode";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(177, 6);
            // 
            // musicPlayerToolStripMenuItem
            // 
            this.musicPlayerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.musicPlayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.musicPlayerToolStripMenuItem.Name = "musicPlayerToolStripMenuItem";
            this.musicPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musicPlayerToolStripMenuItem.Text = "Music Player";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(177, 6);
            // 
            // friendsToolStripMenuItem1
            // 
            this.friendsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.friendsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.friendsToolStripMenuItem1.Name = "friendsToolStripMenuItem1";
            this.friendsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.friendsToolStripMenuItem1.Text = "Friends";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.playersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.serversToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            // 
            // screenshotsToolStripMenuItem
            // 
            this.screenshotsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.screenshotsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.screenshotsToolStripMenuItem.Name = "screenshotsToolStripMenuItem";
            this.screenshotsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.screenshotsToolStripMenuItem.Text = "Screenshots";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // updateNewsToolStripMenuItem
            // 
            this.updateNewsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.updateNewsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateNewsToolStripMenuItem.Name = "updateNewsToolStripMenuItem";
            this.updateNewsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateNewsToolStripMenuItem.Text = "Update news";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(177, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.settingsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // friendsToolStripMenuItem
            // 
            this.friendsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFriendListToolStripMenuItem,
            this.toolStripSeparator1,
            this.addAFriendToolStripMenuItem,
            this.editProfileNameToolStripMenuItem,
            this.toolStripSeparator2,
            this.onlineToolStripMenuItem,
            this.awayToolStripMenuItem,
            this.invisibleToolStripMenuItem,
            this.offlineToolStripMenuItem});
            this.friendsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            this.friendsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.friendsToolStripMenuItem.Text = "Friends";
            // 
            // viewFriendListToolStripMenuItem
            // 
            this.viewFriendListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewFriendListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewFriendListToolStripMenuItem.Name = "viewFriendListToolStripMenuItem";
            this.viewFriendListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewFriendListToolStripMenuItem.Text = "View Friend List";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // addAFriendToolStripMenuItem
            // 
            this.addAFriendToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addAFriendToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addAFriendToolStripMenuItem.Name = "addAFriendToolStripMenuItem";
            this.addAFriendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAFriendToolStripMenuItem.Text = "Add a Friend";
            // 
            // editProfileNameToolStripMenuItem
            // 
            this.editProfileNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.editProfileNameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.editProfileNameToolStripMenuItem.Name = "editProfileNameToolStripMenuItem";
            this.editProfileNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editProfileNameToolStripMenuItem.Text = "Edit Profile Name";
            this.editProfileNameToolStripMenuItem.Click += new System.EventHandler(this.editProfileNameToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.onlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.awayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.awayToolStripMenuItem.Text = "Away";
            // 
            // invisibleToolStripMenuItem
            // 
            this.invisibleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.invisibleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.invisibleToolStripMenuItem.Name = "invisibleToolStripMenuItem";
            this.invisibleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invisibleToolStripMenuItem.Text = "Invisible";
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.offlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGamesLibraryToolStripMenuItem,
            this.toolStripSeparator3,
            this.activateAProductOnNotSteamToolStripMenuItem,
            this.redeemANotSteamWalletCodeToolStripMenuItem,
            this.manageGiftsAndGuestPassesToolStripMenuItem,
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem});
            this.gamesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // viewGamesLibraryToolStripMenuItem
            // 
            this.viewGamesLibraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewGamesLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewGamesLibraryToolStripMenuItem.Name = "viewGamesLibraryToolStripMenuItem";
            this.viewGamesLibraryToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.viewGamesLibraryToolStripMenuItem.Text = "View Games Library";
            this.viewGamesLibraryToolStripMenuItem.Click += new System.EventHandler(this.viewGamesLibraryToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // activateAProductOnNotSteamToolStripMenuItem
            // 
            this.activateAProductOnNotSteamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.activateAProductOnNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.activateAProductOnNotSteamToolStripMenuItem.Name = "activateAProductOnNotSteamToolStripMenuItem";
            this.activateAProductOnNotSteamToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.activateAProductOnNotSteamToolStripMenuItem.Text = "Activate a Product on NotSteam";
            // 
            // redeemANotSteamWalletCodeToolStripMenuItem
            // 
            this.redeemANotSteamWalletCodeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.redeemANotSteamWalletCodeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.redeemANotSteamWalletCodeToolStripMenuItem.Name = "redeemANotSteamWalletCodeToolStripMenuItem";
            this.redeemANotSteamWalletCodeToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.redeemANotSteamWalletCodeToolStripMenuItem.Text = "Redeem a NotSteam Wallet Code";
            // 
            // manageGiftsAndGuestPassesToolStripMenuItem
            // 
            this.manageGiftsAndGuestPassesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.manageGiftsAndGuestPassesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.manageGiftsAndGuestPassesToolStripMenuItem.Name = "manageGiftsAndGuestPassesToolStripMenuItem";
            this.manageGiftsAndGuestPassesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.manageGiftsAndGuestPassesToolStripMenuItem.Text = "Manage Gifts and Guest Passes";
            // 
            // addANonNotSteamGameToMyLibraryToolStripMenuItem
            // 
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Name = "addANonNotSteamGameToMyLibraryToolStripMenuItem";
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Text = "Add a Non-NotSteam Game to My Library";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privacyPolicyToolStripMenuItem,
            this.legalInformationToolStripMenuItem,
            this.notSteamSupportToolStripMenuItem,
            this.toolStripSeparator9,
            this.systemInformationToolStripMenuItem,
            this.aboutNotSteamToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // privacyPolicyToolStripMenuItem
            // 
            this.privacyPolicyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.privacyPolicyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.privacyPolicyToolStripMenuItem.Name = "privacyPolicyToolStripMenuItem";
            this.privacyPolicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privacyPolicyToolStripMenuItem.Text = "Privacy Policy";
            // 
            // legalInformationToolStripMenuItem
            // 
            this.legalInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.legalInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.legalInformationToolStripMenuItem.Name = "legalInformationToolStripMenuItem";
            this.legalInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.legalInformationToolStripMenuItem.Text = "Legal Information";
            // 
            // notSteamSupportToolStripMenuItem
            // 
            this.notSteamSupportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.notSteamSupportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.notSteamSupportToolStripMenuItem.Name = "notSteamSupportToolStripMenuItem";
            this.notSteamSupportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notSteamSupportToolStripMenuItem.Text = "NotSteam Support";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.systemInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            // 
            // aboutNotSteamToolStripMenuItem
            // 
            this.aboutNotSteamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.aboutNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.aboutNotSteamToolStripMenuItem.Name = "aboutNotSteamToolStripMenuItem";
            this.aboutNotSteamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutNotSteamToolStripMenuItem.Text = "About NotSteam";
            this.aboutNotSteamToolStripMenuItem.Click += new System.EventHandler(this.aboutNotSteamToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyProfileToolStripMenuItem,
            this.accountDetailsToolStripMenuItem,
            this.logoutOfAccountToolStripMenuItem,
            this.storePreferanceToolStripMenuItem,
            this.viewMyWalletToolStripMenuItem});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // viewMyProfileToolStripMenuItem
            // 
            this.viewMyProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewMyProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewMyProfileToolStripMenuItem.Name = "viewMyProfileToolStripMenuItem";
            this.viewMyProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewMyProfileToolStripMenuItem.Text = "View my profile";
            this.viewMyProfileToolStripMenuItem.Click += new System.EventHandler(this.viewMyProfileToolStripMenuItem_Click);
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.accountDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accountDetailsToolStripMenuItem.Text = "Account details";
            // 
            // logoutOfAccountToolStripMenuItem
            // 
            this.logoutOfAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.logoutOfAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutOfAccountToolStripMenuItem.Name = "logoutOfAccountToolStripMenuItem";
            this.logoutOfAccountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logoutOfAccountToolStripMenuItem.Text = "Logout of account";
            this.logoutOfAccountToolStripMenuItem.Click += new System.EventHandler(this.logoutOfAccountToolStripMenuItem_Click);
            // 
            // storePreferanceToolStripMenuItem
            // 
            this.storePreferanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.storePreferanceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.storePreferanceToolStripMenuItem.Name = "storePreferanceToolStripMenuItem";
            this.storePreferanceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.storePreferanceToolStripMenuItem.Text = "Store preferance";
            // 
            // viewMyWalletToolStripMenuItem
            // 
            this.viewMyWalletToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewMyWalletToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewMyWalletToolStripMenuItem.Name = "viewMyWalletToolStripMenuItem";
            this.viewMyWalletToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewMyWalletToolStripMenuItem.Text = "View my wallet";
            this.viewMyWalletToolStripMenuItem.Click += new System.EventHandler(this.viewMyWalletToolStripMenuItem_Click);
            // 
            // notSteamSubscriberAgreementToolStripMenuItem
            // 
            this.notSteamSubscriberAgreementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notSteamSubscriberAgreementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.notSteamSubscriberAgreementToolStripMenuItem.Name = "notSteamSubscriberAgreementToolStripMenuItem";
            this.notSteamSubscriberAgreementToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.notSteamSubscriberAgreementToolStripMenuItem.Text = "NotSteam Subscriber Agreement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pbForward);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 48);
            this.panel2.TabIndex = 16;
            // 
            // pbForward
            // 
            this.pbForward.Image = ((System.Drawing.Image)(resources.GetObject("pbForward.Image")));
            this.pbForward.Location = new System.Drawing.Point(47, 11);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(29, 24);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForward.TabIndex = 22;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            Image img = pbForward.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbForward.Image = img;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 11);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(29, 24);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 21;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(483, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profile";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(326, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Community";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(223, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NotSteam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 518);
            this.panel1.TabIndex = 17;
            // 
            // NotSteamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(790, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NotSteamForm";
            this.Text = "NotSteamForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goOffnileToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem checkForNotSteamClientUpdatesToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem backupAndRestoreGamesToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFriendListToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addAFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileNameToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGamesLibraryToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem activateAProductOnNotSteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redeemANotSteamWalletCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGiftsAndGuestPassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANonNotSteamGameToMyLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSteamSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privacyPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSteamSubscriberAgreementToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNotSteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem smallModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigPictureModeToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem musicPlayerToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenshotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateNewsToolStripMenuItem;
        private ExtendedToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private ExtendedToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem addGameToNotSteamToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PictureBox pbForward;
        private PictureBox pbBack;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem viewMyProfileToolStripMenuItem;
        private ToolStripMenuItem accountDetailsToolStripMenuItem;
        private ToolStripMenuItem logoutOfAccountToolStripMenuItem;
        private ToolStripMenuItem storePreferanceToolStripMenuItem;
        private ToolStripMenuItem viewMyWalletToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
    }
}