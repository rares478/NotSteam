using System.Windows.Forms;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;

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

    public class CustomPanelRenderer : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(22, 44, 68), Color.FromArgb(33, 36, 40), 90);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
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

        #region toolstrip actions
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
            senderit.ForeColor = System.Drawing.Color.FromArgb(85, 109, 126);
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
        #endregion


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
            this.notSteamSubscriberAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new NotSteam.CustomPanelRenderer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator1 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator2 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator3 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator4 = new NotSteam.ExtendedToolStripSeparator();
            this.addGameToNotSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator5 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator6 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator7 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator8 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator9 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator10 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator11 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripSeparator12 = new NotSteam.ExtendedToolStripSeparator();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripMenuItem();
            this.nimicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.panel2.Angle = 0F;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel2.BottomColor = System.Drawing.Color.Empty;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.pbForward);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 70);
            this.panel2.TabIndex = 16;
            this.panel2.TopColor = System.Drawing.Color.Empty;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem15,
            this.toolStripMenuItem29,
            this.toolStripMenuItem37,
            this.toolStripMenuItem43,
            this.toolStripMenuItem49,
            this.toolStripMenuItem50,
            this.toolStripMenuItem51,
            this.toolStripMenuItem3,
            this.nimicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip2";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveform);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.extendedToolStripSeparator1,
            this.toolStripMenuItem10,
            this.extendedToolStripSeparator2,
            this.toolStripMenuItem11,
            this.extendedToolStripSeparator3,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.extendedToolStripSeparator4,
            this.addGameToNotSteamToolStripMenuItem});
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem7.Text = "NotSteam";
            this.toolStripMenuItem7.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem7.MouseLeave += new System.EventHandler(this.OnExit);
            this.toolStripMenuItem7.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem8.Text = "Change Account";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            this.toolStripMenuItem8.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem8.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem9.Text = "Go Offline";
            this.toolStripMenuItem9.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem9.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator1
            // 
            this.extendedToolStripSeparator1.Name = "extendedToolStripSeparator1";
            this.extendedToolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem10.Text = "Check for NotSteam Client Updates";
            this.toolStripMenuItem10.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem10.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator2
            // 
            this.extendedToolStripSeparator2.Name = "extendedToolStripSeparator2";
            this.extendedToolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem11.Text = "Backup and Restore Games";
            this.toolStripMenuItem11.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem11.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator3
            // 
            this.extendedToolStripSeparator3.Name = "extendedToolStripSeparator3";
            this.extendedToolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem12.Text = "Settings";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            this.toolStripMenuItem12.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem12.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem13.Text = "Exit";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            this.toolStripMenuItem13.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem13.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator4
            // 
            this.extendedToolStripSeparator4.Name = "extendedToolStripSeparator4";
            this.extendedToolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // addGameToNotSteamToolStripMenuItem
            // 
            this.addGameToNotSteamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.addGameToNotSteamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.addGameToNotSteamToolStripMenuItem.Name = "addGameToNotSteamToolStripMenuItem";
            this.addGameToNotSteamToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.addGameToNotSteamToolStripMenuItem.Text = "Add game to NotSteam";
            this.addGameToNotSteamToolStripMenuItem.Click += new System.EventHandler(this.addGameToNotSteamToolStripMenuItem_Click_1);
            this.addGameToNotSteamToolStripMenuItem.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.addGameToNotSteamToolStripMenuItem.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.extendedToolStripSeparator5,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.extendedToolStripSeparator6,
            this.toolStripMenuItem21,
            this.extendedToolStripSeparator7,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.extendedToolStripSeparator8,
            this.toolStripMenuItem28});
            this.toolStripMenuItem15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem15.Text = "View";
            this.toolStripMenuItem15.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem15.MouseLeave += new System.EventHandler(this.OnExit);
            this.toolStripMenuItem15.MouseHover += new System.EventHandler(this.OnHover);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem16.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem16.Text = "Library";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            this.toolStripMenuItem16.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem16.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem17.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem17.Text = "Hidden Games";
            this.toolStripMenuItem17.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem17.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem18.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem18.Text = "Downloads";
            this.toolStripMenuItem18.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem18.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator5
            // 
            this.extendedToolStripSeparator5.Name = "extendedToolStripSeparator5";
            this.extendedToolStripSeparator5.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem19.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem19.Text = "Small Mode";
            this.toolStripMenuItem19.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem19.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem20.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem20.Text = "Big Picture Mode";
            this.toolStripMenuItem20.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem20.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator6
            // 
            this.extendedToolStripSeparator6.Name = "extendedToolStripSeparator6";
            this.extendedToolStripSeparator6.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem21.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem21.Text = "Music Player";
            this.toolStripMenuItem21.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem21.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator7
            // 
            this.extendedToolStripSeparator7.Name = "extendedToolStripSeparator7";
            this.extendedToolStripSeparator7.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem22.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem22.Text = "Friends";
            this.toolStripMenuItem22.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem22.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem23.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem23.Text = "Players";
            this.toolStripMenuItem23.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem23.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem24.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem24.Text = "Servers";
            this.toolStripMenuItem24.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem24.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem25.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem25.Text = "Screenshots";
            this.toolStripMenuItem25.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem25.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem26.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem26.Text = "Inventory";
            this.toolStripMenuItem26.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem26.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem27.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem27.Text = "Update news";
            this.toolStripMenuItem27.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem27.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator8
            // 
            this.extendedToolStripSeparator8.Name = "extendedToolStripSeparator8";
            this.extendedToolStripSeparator8.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem28.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem28.Text = "Settings";
            this.toolStripMenuItem28.Click += new System.EventHandler(this.toolStripMenuItem28_Click);
            this.toolStripMenuItem28.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem28.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem30,
            this.extendedToolStripSeparator9,
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.extendedToolStripSeparator10,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.toolStripMenuItem35,
            this.toolStripMenuItem36});
            this.toolStripMenuItem29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem29.Text = "Friends";
            this.toolStripMenuItem29.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem29.MouseLeave += new System.EventHandler(this.OnExit);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem30.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem30.Text = "View Friend List";
            this.toolStripMenuItem30.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem30.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator9
            // 
            this.extendedToolStripSeparator9.Name = "extendedToolStripSeparator9";
            this.extendedToolStripSeparator9.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem31.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem31.Text = "Add a Friend";
            this.toolStripMenuItem31.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem31.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem32.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem32.Text = "Edit Profile Name";
            this.toolStripMenuItem32.Click += new System.EventHandler(this.toolStripMenuItem32_Click);
            this.toolStripMenuItem32.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem32.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator10
            // 
            this.extendedToolStripSeparator10.Name = "extendedToolStripSeparator10";
            this.extendedToolStripSeparator10.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem33.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem33.Text = "Online";
            this.toolStripMenuItem33.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem33.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem34.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem34.Text = "Away";
            this.toolStripMenuItem34.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem34.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem35.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem35.Text = "Invisible";
            this.toolStripMenuItem35.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem35.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem36.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem36.Text = "Offline";
            this.toolStripMenuItem36.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem36.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem38,
            this.extendedToolStripSeparator11,
            this.toolStripMenuItem39,
            this.toolStripMenuItem40,
            this.toolStripMenuItem41,
            this.toolStripMenuItem42});
            this.toolStripMenuItem37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem37.Text = "Games";
            this.toolStripMenuItem37.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem37.MouseLeave += new System.EventHandler(this.OnExit);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem38.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem38.Text = "View Games Library";
            this.toolStripMenuItem38.Click += new System.EventHandler(this.toolStripMenuItem38_Click);
            this.toolStripMenuItem38.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem38.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator11
            // 
            this.extendedToolStripSeparator11.Name = "extendedToolStripSeparator11";
            this.extendedToolStripSeparator11.Size = new System.Drawing.Size(293, 6);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem39.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem39.Text = "Activate a Product on NotSteam";
            this.toolStripMenuItem39.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem39.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem40.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem40.Text = "Redeem a NotSteam Wallet Code";
            this.toolStripMenuItem40.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem40.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem41.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem41.Text = "Manage Gifts and Guest Passes";
            this.toolStripMenuItem41.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem41.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem42.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem42.Text = "Add a Non-NotSteam Game to My Library";
            this.toolStripMenuItem42.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem42.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem44,
            this.toolStripMenuItem45,
            this.toolStripMenuItem46,
            this.extendedToolStripSeparator12,
            this.toolStripMenuItem47,
            this.toolStripMenuItem48});
            this.toolStripMenuItem43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem43.Text = "Help";
            this.toolStripMenuItem43.MouseEnter += new System.EventHandler(this.OnHover);
            this.toolStripMenuItem43.MouseLeave += new System.EventHandler(this.OnExit);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem44.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem44.Text = "Privacy Policy";
            this.toolStripMenuItem44.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem44.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem45
            // 
            this.toolStripMenuItem45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem45.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem45.Name = "toolStripMenuItem45";
            this.toolStripMenuItem45.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem45.Text = "Legal Information";
            this.toolStripMenuItem45.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem45.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem46.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem46.Text = "NotSteam Support";
            this.toolStripMenuItem46.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem46.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // extendedToolStripSeparator12
            // 
            this.extendedToolStripSeparator12.Name = "extendedToolStripSeparator12";
            this.extendedToolStripSeparator12.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem47.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem47.Text = "System Information";
            this.toolStripMenuItem47.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem47.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem48.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem48.Text = "About NotSteam";
            this.toolStripMenuItem48.Click += new System.EventHandler(this.toolStripMenuItem48_Click);
            this.toolStripMenuItem48.MouseEnter += new System.EventHandler(this.OnHoverToolstrip);
            this.toolStripMenuItem48.MouseLeave += new System.EventHandler(this.OnExitToolstrip);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem49.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem49.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem49.Image")));
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem49.Click += new System.EventHandler(this.toolStripMenuItem49_Click);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem50.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem50.Image")));
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem50.Click += new System.EventHandler(this.toolStripMenuItem50_Click);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem51.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem51.Image")));
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem51.Click += new System.EventHandler(this.toolStripMenuItem51_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem53,
            this.toolStripMenuItem54,
            this.toolStripMenuItem55,
            this.toolStripMenuItem56,
            this.toolStripMenuItem57});
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(196)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem53.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem53.Text = "View my profile";
            this.toolStripMenuItem53.Click += new System.EventHandler(this.toolStripMenuItem53_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem54.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem54.Text = "Account details";
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem55.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem55.Text = "Logout of account";
            this.toolStripMenuItem55.Click += new System.EventHandler(this.toolStripMenuItem55_Click);
            // 
            // toolStripMenuItem56
            // 
            this.toolStripMenuItem56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem56.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem56.Name = "toolStripMenuItem56";
            this.toolStripMenuItem56.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem56.Text = "Store preferance";
            // 
            // toolStripMenuItem57
            // 
            this.toolStripMenuItem57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem57.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem57.Name = "toolStripMenuItem57";
            this.toolStripMenuItem57.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem57.Text = "View my wallet";
            this.toolStripMenuItem57.Click += new System.EventHandler(this.toolStripMenuItem57_Click);
            // 
            // nimicToolStripMenuItem
            // 
            this.nimicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nimicToolStripMenuItem.Name = "nimicToolStripMenuItem";
            this.nimicToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nimicToolStripMenuItem.Text = "nimic";
            // 
            // pbForward
            // 
            this.pbForward.BackColor = System.Drawing.Color.Transparent;
            this.pbForward.Image = ((System.Drawing.Image)(resources.GetObject("pbForward.Image")));
            this.pbForward.Location = new System.Drawing.Point(47, 42);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(29, 24);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForward.TabIndex = 22;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 42);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(483, 35);
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(326, 35);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(223, 35);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 35);
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
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 685);
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
            this.label33.Click += new System.EventHandler(this.label33_Click);
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
            this.label15.Click += new System.EventHandler(this.label15_Click);
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
            this.panel3.Location = new System.Drawing.Point(288, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 685);
            this.panel3.TabIndex = 18;
            // 
            // NotSteamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1015, 755);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "NotSteamForm";
            this.Text = "NotSteamForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem notSteamSubscriberAgreementToolStripMenuItem;
        private CustomPanelRenderer panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PictureBox pbForward;
        private PictureBox pbBack;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ExtendedToolStripSeparator extendedToolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem10;
        private ExtendedToolStripSeparator extendedToolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem11;
        private ExtendedToolStripSeparator extendedToolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ExtendedToolStripSeparator extendedToolStripSeparator4;
        private ToolStripMenuItem addGameToNotSteamToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ExtendedToolStripSeparator extendedToolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem20;
        private ExtendedToolStripSeparator extendedToolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItem21;
        private ExtendedToolStripSeparator extendedToolStripSeparator7;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripMenuItem toolStripMenuItem25;
        private ToolStripMenuItem toolStripMenuItem26;
        private ToolStripMenuItem toolStripMenuItem27;
        private ExtendedToolStripSeparator extendedToolStripSeparator8;
        private ToolStripMenuItem toolStripMenuItem28;
        private ToolStripMenuItem toolStripMenuItem29;
        private ToolStripMenuItem toolStripMenuItem30;
        private ExtendedToolStripSeparator extendedToolStripSeparator9;
        private ToolStripMenuItem toolStripMenuItem31;
        private ToolStripMenuItem toolStripMenuItem32;
        private ExtendedToolStripSeparator extendedToolStripSeparator10;
        private ToolStripMenuItem toolStripMenuItem33;
        private ToolStripMenuItem toolStripMenuItem34;
        private ToolStripMenuItem toolStripMenuItem35;
        private ToolStripMenuItem toolStripMenuItem36;
        private ToolStripMenuItem toolStripMenuItem37;
        private ToolStripMenuItem toolStripMenuItem38;
        private ExtendedToolStripSeparator extendedToolStripSeparator11;
        private ToolStripMenuItem toolStripMenuItem39;
        private ToolStripMenuItem toolStripMenuItem40;
        private ToolStripMenuItem toolStripMenuItem41;
        private ToolStripMenuItem toolStripMenuItem42;
        private ToolStripMenuItem toolStripMenuItem43;
        private ToolStripMenuItem toolStripMenuItem44;
        private ToolStripMenuItem toolStripMenuItem45;
        private ToolStripMenuItem toolStripMenuItem46;
        private ExtendedToolStripSeparator extendedToolStripSeparator12;
        private ToolStripMenuItem toolStripMenuItem47;
        private ToolStripMenuItem toolStripMenuItem48;
        private ToolStripMenuItem toolStripMenuItem49;
        private ToolStripMenuItem toolStripMenuItem50;
        private ToolStripMenuItem toolStripMenuItem51;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem53;
        private ToolStripMenuItem toolStripMenuItem54;
        private ToolStripMenuItem toolStripMenuItem55;
        private ToolStripMenuItem toolStripMenuItem56;
        private ToolStripMenuItem toolStripMenuItem57;
        private ToolStripMenuItem nimicToolStripMenuItem;
    }
}