using System.Windows.Forms;
using System.Drawing;
using System;

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
            Color foreColor = SystemColors.ActiveCaption;
            Color backColor = SystemColors.ActiveCaptionText;

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
            this.ToolStripSeparator7 = new NotSteam.ExtendedToolStripSeparator();
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
            this.toolStripSeparator8 = new NotSteam.ExtendedToolStripSeparator();
            this.privacyPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new NotSteam.ExtendedToolStripSeparator();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutNotSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripmoney = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripProfile = new System.Windows.Forms.ToolStripTextBox();
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.friendsToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripmoney,
            this.toolStripProfile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(790, 27);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
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
            this.ToolStripSeparator7,
            this.exitToolStripMenuItem,
            this.toolStripSeparator14,
            this.addGameToNotSteamToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 23);
            this.toolStripMenuItem1.Text = "NotSteam";
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.changeAccountToolStripMenuItem.Text = "Change Account";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // goOffnileToolStripMenuItem
            // 
            this.goOffnileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.goOffnileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.checkForNotSteamClientUpdatesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkForNotSteamClientUpdatesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.backupAndRestoreGamesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backupAndRestoreGamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(258, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.addGameToNotSteamToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addGameToNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 23);
            this.toolStripMenuItem2.Text = "View";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.libraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // hiddenGamesToolStripMenuItem
            // 
            this.hiddenGamesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hiddenGamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hiddenGamesToolStripMenuItem.Name = "hiddenGamesToolStripMenuItem";
            this.hiddenGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hiddenGamesToolStripMenuItem.Text = "Hidden Games";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.smallModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.smallModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.smallModeToolStripMenuItem.Name = "smallModeToolStripMenuItem";
            this.smallModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smallModeToolStripMenuItem.Text = "Small Mode";
            // 
            // bigPictureModeToolStripMenuItem
            // 
            this.bigPictureModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigPictureModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.musicPlayerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicPlayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.friendsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.friendsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.friendsToolStripMenuItem1.Name = "friendsToolStripMenuItem1";
            this.friendsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.friendsToolStripMenuItem1.Text = "Friends";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serversToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            // 
            // screenshotsToolStripMenuItem
            // 
            this.screenshotsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screenshotsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.screenshotsToolStripMenuItem.Name = "screenshotsToolStripMenuItem";
            this.screenshotsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.screenshotsToolStripMenuItem.Text = "Screenshots";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // updateNewsToolStripMenuItem
            // 
            this.updateNewsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateNewsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.settingsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.friendsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            this.friendsToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.friendsToolStripMenuItem.Text = "Friends";
            // 
            // viewFriendListToolStripMenuItem
            // 
            this.viewFriendListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewFriendListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.addAFriendToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addAFriendToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAFriendToolStripMenuItem.Name = "addAFriendToolStripMenuItem";
            this.addAFriendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAFriendToolStripMenuItem.Text = "Add a Friend";
            // 
            // editProfileNameToolStripMenuItem
            // 
            this.editProfileNameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editProfileNameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.onlineToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.onlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.awayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.awayToolStripMenuItem.Text = "Away";
            // 
            // invisibleToolStripMenuItem
            // 
            this.invisibleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.invisibleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.invisibleToolStripMenuItem.Name = "invisibleToolStripMenuItem";
            this.invisibleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invisibleToolStripMenuItem.Text = "Invisible";
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.offlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.gamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // viewGamesLibraryToolStripMenuItem
            // 
            this.viewGamesLibraryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewGamesLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.activateAProductOnNotSteamToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.activateAProductOnNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.activateAProductOnNotSteamToolStripMenuItem.Name = "activateAProductOnNotSteamToolStripMenuItem";
            this.activateAProductOnNotSteamToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.activateAProductOnNotSteamToolStripMenuItem.Text = "Activate a Product on NotSteam";
            // 
            // redeemANotSteamWalletCodeToolStripMenuItem
            // 
            this.redeemANotSteamWalletCodeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.redeemANotSteamWalletCodeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.redeemANotSteamWalletCodeToolStripMenuItem.Name = "redeemANotSteamWalletCodeToolStripMenuItem";
            this.redeemANotSteamWalletCodeToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.redeemANotSteamWalletCodeToolStripMenuItem.Text = "Redeem a NotSteam Wallet Code";
            // 
            // manageGiftsAndGuestPassesToolStripMenuItem
            // 
            this.manageGiftsAndGuestPassesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageGiftsAndGuestPassesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageGiftsAndGuestPassesToolStripMenuItem.Name = "manageGiftsAndGuestPassesToolStripMenuItem";
            this.manageGiftsAndGuestPassesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.manageGiftsAndGuestPassesToolStripMenuItem.Text = "Manage Gifts and Guest Passes";
            // 
            // addANonNotSteamGameToMyLibraryToolStripMenuItem
            // 
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Name = "addANonNotSteamGameToMyLibraryToolStripMenuItem";
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Text = "Add a Non-NotSteam Game to My Library";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.privacyPolicyToolStripMenuItem,
            this.legalInformationToolStripMenuItem,
            this.notSteamSupportToolStripMenuItem,
            this.toolStripSeparator9,
            this.systemInformationToolStripMenuItem,
            this.aboutNotSteamToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // privacyPolicyToolStripMenuItem
            // 
            this.privacyPolicyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.privacyPolicyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.privacyPolicyToolStripMenuItem.Name = "privacyPolicyToolStripMenuItem";
            this.privacyPolicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privacyPolicyToolStripMenuItem.Text = "Privacy Policy";
            // 
            // legalInformationToolStripMenuItem
            // 
            this.legalInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.legalInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.legalInformationToolStripMenuItem.Name = "legalInformationToolStripMenuItem";
            this.legalInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.legalInformationToolStripMenuItem.Text = "Legal Information";
            // 
            // notSteamSupportToolStripMenuItem
            // 
            this.notSteamSupportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notSteamSupportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.systemInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.systemInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            // 
            // aboutNotSteamToolStripMenuItem
            // 
            this.aboutNotSteamToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutNotSteamToolStripMenuItem.Name = "aboutNotSteamToolStripMenuItem";
            this.aboutNotSteamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutNotSteamToolStripMenuItem.Text = "About NotSteam";
            this.aboutNotSteamToolStripMenuItem.Click += new System.EventHandler(this.aboutNotSteamToolStripMenuItem_Click);
            // 
            // toolStripmoney
            // 
            this.toolStripmoney.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripmoney.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripmoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripmoney.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripmoney.Name = "toolStripmoney";
            this.toolStripmoney.Size = new System.Drawing.Size(50, 23);
            this.toolStripmoney.Text = "xcer";
            this.toolStripmoney.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripmoney.Click += new System.EventHandler(this.toolStripmoney_Click);
            // 
            // toolStripProfile
            // 
            this.toolStripProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripProfile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripProfile.Name = "toolStripProfile";
            this.toolStripProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProfile.Size = new System.Drawing.Size(100, 23);
            this.toolStripProfile.Text = "ceva";
            this.toolStripProfile.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.panel2.Controls.Add(this.pbForward);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 54);
            this.panel2.TabIndex = 16;
            // 
            // pbForward
            // 
            this.pbForward.Image = ((System.Drawing.Image)(resources.GetObject("pbForward.Image")));
            this.pbForward.Location = new System.Drawing.Point(47, 18);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(29, 24);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForward.TabIndex = 22;
            this.pbForward.TabStop = false;
            Image img = pbForward.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.pbForward.Image = img;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 18);
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
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(483, 11);
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
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(326, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Community";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(223, 11);
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
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(82, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NotSteam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 509);
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
        private ExtendedToolStripSeparator toolStripSeparator8;
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
        private System.Windows.Forms.ToolStripTextBox toolStripmoney;
        private System.Windows.Forms.ToolStripTextBox toolStripProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ExtendedToolStripSeparator ToolStripSeparator7;
        private PictureBox pbForward;
        private PictureBox pbBack;
    }
}