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

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer(): base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            #region MenuItem color
            public override Color MenuItemSelected => Color.FromArgb(54, 58, 65);
            public override Color MenuItemSelectedGradientBegin => Color.Transparent;
            public override Color MenuItemSelectedGradientEnd => Color.Transparent;
            public override Color MenuBorder => Color.Transparent;
            public override Color MenuStripGradientBegin => Color.Transparent;
            public override Color MenuStripGradientEnd => Color.Transparent;
            public override Color MenuItemPressedGradientBegin => Color.Transparent;
            public override Color MenuItemPressedGradientEnd => Color.Transparent;
            public override Color MenuItemBorder => Color.Transparent;
            #endregion

            #region Tooltrip color
            public override Color ToolStripBorder => Color.FromArgb(24, 30, 42);
            public override Color ToolStripDropDownBackground => Color.FromArgb(24, 30, 42);
            public override Color ToolStripGradientBegin => Color.FromArgb(24, 30, 42);
            public override Color ToolStripGradientEnd => Color.FromArgb(24, 30, 42);
            public override Color ToolStripGradientMiddle => Color.FromArgb(24, 30, 42);
            public override Color ToolStripContentPanelGradientEnd => Color.FromArgb(24, 30, 42);
            public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(24, 30, 42);
            #endregion
        }

        private void MenuClick(object sender, MouseEventArgs e)
        {
            if(sender is Label)
            {
                label1.ForeColor = Color.FromArgb(176, 196, 203);
                label2.ForeColor = Color.FromArgb(176, 196, 203);
                label3.ForeColor = Color.FromArgb(176, 196, 203);
                label4.ForeColor = Color.FromArgb(176, 196, 203);
                Label lb = sender as Label;
                lb.ForeColor = Color.White;
            }
            if(sender is ToolStripMenuItem)
            {
                ToolStripMenuItem senderit = sender as ToolStripMenuItem;
                senderit.ForeColor = System.Drawing.Color.White;
            }
            
        }

        private void OnHover(object sender, EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.ForeColor = System.Drawing.Color.White;
        }
        private void OnHoverToolstrip(object sender, EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.ForeColor = System.Drawing.Color.White;
        }
        private void OnExitToolstrip(object sender, EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
        }

        private void OnExit(object sender, EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.ForeColor = System.Drawing.Color.FromArgb(94, 108, 123);
        }
        private void HoverName(object sender,EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.BackColor = Color.FromArgb(35, 55, 75);
        }

        private void ExitName(object sender,EventArgs e)
        {
            ToolStripMenuItem senderit = sender as ToolStripMenuItem;
            senderit.BackColor = Color.FromArgb(27, 44, 61);
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
            this.nimicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSteamSubscriberAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStripMenuItem3,
            this.nimicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
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
            this.toolStripMenuItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            this.toolStripMenuItem1.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem1.MouseLeave += new System.EventHandler(this.OnExit);
            this.toolStripMenuItem1.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.changeAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.changeAccountToolStripMenuItem.Text = "Change Account";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            this.changeAccountToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.changeAccountToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.changeAccountToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // goOffnileToolStripMenuItem
            // 
            this.goOffnileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.goOffnileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.goOffnileToolStripMenuItem.Name = "goOffnileToolStripMenuItem";
            this.goOffnileToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.goOffnileToolStripMenuItem.Text = "Go Offline";
            this.goOffnileToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.goOffnileToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.goOffnileToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.checkForNotSteamClientUpdatesToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.checkForNotSteamClientUpdatesToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.checkForNotSteamClientUpdatesToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.backupAndRestoreGamesToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.backupAndRestoreGamesToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.backupAndRestoreGamesToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.settingsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.settingsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.settingsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.addGameToNotSteamToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.addGameToNotSteamToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.addGameToNotSteamToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.toolStripMenuItem2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            this.toolStripMenuItem2.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem2.MouseLeave += new System.EventHandler(this.OnExit);
            this.toolStripMenuItem2.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.libraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            this.libraryToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.libraryToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.libraryToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // hiddenGamesToolStripMenuItem
            // 
            this.hiddenGamesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.hiddenGamesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.hiddenGamesToolStripMenuItem.Name = "hiddenGamesToolStripMenuItem";
            this.hiddenGamesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.hiddenGamesToolStripMenuItem.Text = "Hidden Games";
            this.hiddenGamesToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.hiddenGamesToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.hiddenGamesToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.downloadsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            this.downloadsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.downloadsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.downloadsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(162, 6);
            // 
            // smallModeToolStripMenuItem
            // 
            this.smallModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.smallModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.smallModeToolStripMenuItem.Name = "smallModeToolStripMenuItem";
            this.smallModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.smallModeToolStripMenuItem.Text = "Small Mode";
            this.smallModeToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.smallModeToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.smallModeToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // bigPictureModeToolStripMenuItem
            // 
            this.bigPictureModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.bigPictureModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bigPictureModeToolStripMenuItem.Name = "bigPictureModeToolStripMenuItem";
            this.bigPictureModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bigPictureModeToolStripMenuItem.Text = "Big Picture Mode";
            this.bigPictureModeToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.bigPictureModeToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.bigPictureModeToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(162, 6);
            // 
            // musicPlayerToolStripMenuItem
            // 
            this.musicPlayerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.musicPlayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.musicPlayerToolStripMenuItem.Name = "musicPlayerToolStripMenuItem";
            this.musicPlayerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.musicPlayerToolStripMenuItem.Text = "Music Player";
            this.musicPlayerToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.musicPlayerToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.musicPlayerToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(162, 6);
            // 
            // friendsToolStripMenuItem1
            // 
            this.friendsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.friendsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.friendsToolStripMenuItem1.Name = "friendsToolStripMenuItem1";
            this.friendsToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.friendsToolStripMenuItem1.Text = "Friends";
            this.friendsToolStripMenuItem1.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.friendsToolStripMenuItem1.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.friendsToolStripMenuItem1.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.playersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.playersToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.playersToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.serversToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            this.serversToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.serversToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.serversToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // screenshotsToolStripMenuItem
            // 
            this.screenshotsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.screenshotsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.screenshotsToolStripMenuItem.Name = "screenshotsToolStripMenuItem";
            this.screenshotsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.screenshotsToolStripMenuItem.Text = "Screenshots";
            this.screenshotsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.screenshotsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.screenshotsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.inventoryToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.inventoryToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // updateNewsToolStripMenuItem
            // 
            this.updateNewsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.updateNewsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateNewsToolStripMenuItem.Name = "updateNewsToolStripMenuItem";
            this.updateNewsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.updateNewsToolStripMenuItem.Text = "Update news";
            this.updateNewsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.updateNewsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.updateNewsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(162, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.settingsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            this.settingsToolStripMenuItem1.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.settingsToolStripMenuItem1.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.settingsToolStripMenuItem1.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.friendsToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            this.friendsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHover);
            this.friendsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExit);
            this.friendsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // viewFriendListToolStripMenuItem
            // 
            this.viewFriendListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewFriendListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewFriendListToolStripMenuItem.Name = "viewFriendListToolStripMenuItem";
            this.viewFriendListToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewFriendListToolStripMenuItem.Text = "View Friend List";
            this.viewFriendListToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.viewFriendListToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.viewFriendListToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // addAFriendToolStripMenuItem
            // 
            this.addAFriendToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addAFriendToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addAFriendToolStripMenuItem.Name = "addAFriendToolStripMenuItem";
            this.addAFriendToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addAFriendToolStripMenuItem.Text = "Add a Friend";
            this.addAFriendToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.addAFriendToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.addAFriendToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // editProfileNameToolStripMenuItem
            // 
            this.editProfileNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.editProfileNameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.editProfileNameToolStripMenuItem.Name = "editProfileNameToolStripMenuItem";
            this.editProfileNameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editProfileNameToolStripMenuItem.Text = "Edit Profile Name";
            this.editProfileNameToolStripMenuItem.Click += new System.EventHandler(this.editProfileNameToolStripMenuItem_Click);
            this.editProfileNameToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.editProfileNameToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.editProfileNameToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.onlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            this.onlineToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.onlineToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.onlineToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.awayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.awayToolStripMenuItem.Text = "Away";
            this.awayToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.awayToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.awayToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // invisibleToolStripMenuItem
            // 
            this.invisibleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.invisibleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.invisibleToolStripMenuItem.Name = "invisibleToolStripMenuItem";
            this.invisibleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.invisibleToolStripMenuItem.Text = "Invisible";
            this.invisibleToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.invisibleToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.invisibleToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.offlineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            this.offlineToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.offlineToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.offlineToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.gamesToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            this.gamesToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHover);
            this.gamesToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExit);
            this.gamesToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // viewGamesLibraryToolStripMenuItem
            // 
            this.viewGamesLibraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewGamesLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewGamesLibraryToolStripMenuItem.Name = "viewGamesLibraryToolStripMenuItem";
            this.viewGamesLibraryToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.viewGamesLibraryToolStripMenuItem.Text = "View Games Library";
            this.viewGamesLibraryToolStripMenuItem.Click += new System.EventHandler(this.viewGamesLibraryToolStripMenuItem_Click);
            this.viewGamesLibraryToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.viewGamesLibraryToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.viewGamesLibraryToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.activateAProductOnNotSteamToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.activateAProductOnNotSteamToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.activateAProductOnNotSteamToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // redeemANotSteamWalletCodeToolStripMenuItem
            // 
            this.redeemANotSteamWalletCodeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.redeemANotSteamWalletCodeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.redeemANotSteamWalletCodeToolStripMenuItem.Name = "redeemANotSteamWalletCodeToolStripMenuItem";
            this.redeemANotSteamWalletCodeToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.redeemANotSteamWalletCodeToolStripMenuItem.Text = "Redeem a NotSteam Wallet Code";
            this.redeemANotSteamWalletCodeToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.redeemANotSteamWalletCodeToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.redeemANotSteamWalletCodeToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // manageGiftsAndGuestPassesToolStripMenuItem
            // 
            this.manageGiftsAndGuestPassesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.manageGiftsAndGuestPassesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.manageGiftsAndGuestPassesToolStripMenuItem.Name = "manageGiftsAndGuestPassesToolStripMenuItem";
            this.manageGiftsAndGuestPassesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.manageGiftsAndGuestPassesToolStripMenuItem.Text = "Manage Gifts and Guest Passes";
            this.manageGiftsAndGuestPassesToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.manageGiftsAndGuestPassesToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.manageGiftsAndGuestPassesToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // addANonNotSteamGameToMyLibraryToolStripMenuItem
            // 
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Name = "addANonNotSteamGameToMyLibraryToolStripMenuItem";
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.Text = "Add a Non-NotSteam Game to My Library";
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.addANonNotSteamGameToMyLibraryToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.helpToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            this.helpToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHover);
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExit);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // privacyPolicyToolStripMenuItem
            // 
            this.privacyPolicyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.privacyPolicyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.privacyPolicyToolStripMenuItem.Name = "privacyPolicyToolStripMenuItem";
            this.privacyPolicyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.privacyPolicyToolStripMenuItem.Text = "Privacy Policy";
            this.privacyPolicyToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.privacyPolicyToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.privacyPolicyToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // legalInformationToolStripMenuItem
            // 
            this.legalInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.legalInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.legalInformationToolStripMenuItem.Name = "legalInformationToolStripMenuItem";
            this.legalInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.legalInformationToolStripMenuItem.Text = "Legal Information";
            this.legalInformationToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.legalInformationToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.legalInformationToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // notSteamSupportToolStripMenuItem
            // 
            this.notSteamSupportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.notSteamSupportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.notSteamSupportToolStripMenuItem.Name = "notSteamSupportToolStripMenuItem";
            this.notSteamSupportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.notSteamSupportToolStripMenuItem.Text = "NotSteam Support";
            this.notSteamSupportToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.notSteamSupportToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.notSteamSupportToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(175, 6);
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.systemInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            this.systemInformationToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.systemInformationToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.systemInformationToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // aboutNotSteamToolStripMenuItem
            // 
            this.aboutNotSteamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.aboutNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.aboutNotSteamToolStripMenuItem.Name = "aboutNotSteamToolStripMenuItem";
            this.aboutNotSteamToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutNotSteamToolStripMenuItem.Text = "About NotSteam";
            this.aboutNotSteamToolStripMenuItem.Click += new System.EventHandler(this.aboutNotSteamToolStripMenuItem_Click);
            this.aboutNotSteamToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.aboutNotSteamToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.aboutNotSteamToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
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
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
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
            this.toolStripMenuItem3.MouseEnter += new System.EventHandler(this.HoverName);
            this.toolStripMenuItem3.MouseLeave += new System.EventHandler(this.ExitName);
            this.toolStripMenuItem3.MouseHover += new System.EventHandler(this.HoverName);
            // 
            // viewMyProfileToolStripMenuItem
            // 
            this.viewMyProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewMyProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewMyProfileToolStripMenuItem.Name = "viewMyProfileToolStripMenuItem";
            this.viewMyProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewMyProfileToolStripMenuItem.Text = "View my profile";
            this.viewMyProfileToolStripMenuItem.Click += new System.EventHandler(this.viewMyProfileToolStripMenuItem_Click);
            this.viewMyProfileToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.viewMyProfileToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.viewMyProfileToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.accountDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accountDetailsToolStripMenuItem.Text = "Account details";
            this.accountDetailsToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.accountDetailsToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.accountDetailsToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // logoutOfAccountToolStripMenuItem
            // 
            this.logoutOfAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.logoutOfAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.logoutOfAccountToolStripMenuItem.Name = "logoutOfAccountToolStripMenuItem";
            this.logoutOfAccountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logoutOfAccountToolStripMenuItem.Text = "Logout of account";
            this.logoutOfAccountToolStripMenuItem.Click += new System.EventHandler(this.logoutOfAccountToolStripMenuItem_Click);
            this.logoutOfAccountToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.logoutOfAccountToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.logoutOfAccountToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // storePreferanceToolStripMenuItem
            // 
            this.storePreferanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.storePreferanceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.storePreferanceToolStripMenuItem.Name = "storePreferanceToolStripMenuItem";
            this.storePreferanceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.storePreferanceToolStripMenuItem.Text = "Store preferance";
            this.storePreferanceToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.storePreferanceToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.storePreferanceToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // viewMyWalletToolStripMenuItem
            // 
            this.viewMyWalletToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.viewMyWalletToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.viewMyWalletToolStripMenuItem.Name = "viewMyWalletToolStripMenuItem";
            this.viewMyWalletToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewMyWalletToolStripMenuItem.Text = "View my wallet";
            this.viewMyWalletToolStripMenuItem.Click += new System.EventHandler(this.viewMyWalletToolStripMenuItem_Click);
            this.viewMyWalletToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.viewMyWalletToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            this.viewMyWalletToolStripMenuItem.MouseHover += new System.EventHandler(this.OnHoverToolstrip);
            // 
            // nimicToolStripMenuItem
            // 
            this.nimicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nimicToolStripMenuItem.Name = "nimicToolStripMenuItem";
            this.nimicToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nimicToolStripMenuItem.Text = "nimic";
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
            this.panel2.Size = new System.Drawing.Size(924, 42);
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
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(483, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profile";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(326, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Community";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(223, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NotSteam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 689);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label33.Location = new System.Drawing.Point(82, 426);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 13);
            this.label33.TabIndex = 28;
            this.label33.Text = "New Releases";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label32.Location = new System.Drawing.Point(82, 404);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 13);
            this.label32.TabIndex = 27;
            this.label32.Text = "Recommendations";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label31.Location = new System.Drawing.Point(82, 919);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = "Strategy";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label30.Location = new System.Drawing.Point(82, 893);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Sports";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label29.Location = new System.Drawing.Point(82, 871);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "Simulation";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label28.Location = new System.Drawing.Point(82, 848);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "RPG";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label27.Location = new System.Drawing.Point(82, 826);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Racing";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label26.Location = new System.Drawing.Point(82, 803);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "Massively Multiplayer";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label25.Location = new System.Drawing.Point(82, 781);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Indie";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label24.Location = new System.Drawing.Point(82, 759);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Casual";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label23.Location = new System.Drawing.Point(82, 737);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Adventure";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label22.Location = new System.Drawing.Point(82, 715);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "Action";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label21.Location = new System.Drawing.Point(82, 691);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Early Access";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label20.Location = new System.Drawing.Point(82, 669);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Free to Play";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label19.Location = new System.Drawing.Point(82, 606);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Controller-Friendly";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label18.Location = new System.Drawing.Point(82, 584);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "VR Titles";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label17.Location = new System.Drawing.Point(82, 561);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Specials";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label16.Location = new System.Drawing.Point(82, 539);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Upcoming";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label15.Location = new System.Drawing.Point(82, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "New Releases";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label14.Location = new System.Drawing.Point(82, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Top Sellers";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label13.Location = new System.Drawing.Point(82, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tags";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label12.Location = new System.Drawing.Point(82, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "By Curators";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label11.Location = new System.Drawing.Point(82, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "By Friends";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(82, 646);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "BROWSE BY GENRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.label9.Location = new System.Drawing.Point(82, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "BROWSE CATEGORIES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(82, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "DISCOVERY QUEUES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(82, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "RECOMMENDED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.label6.Location = new System.Drawing.Point(82, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "GIFT CARDS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.label5.Location = new System.Drawing.Point(82, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Now Available on NotSteam";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 689);
            this.panel3.TabIndex = 18;
            // 
            // NotSteamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(924, 755);
            this.Controls.Add(this.panel3);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private ToolStripMenuItem nimicToolStripMenuItem;
        private Panel panel1;
        private Panel panel3;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}