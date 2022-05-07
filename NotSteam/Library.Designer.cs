namespace NotSteam
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDateBought = new System.Windows.Forms.Label();
            this.lbLastPlayed = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbAfis = new System.Windows.Forms.ListBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Played";
            // 
            // lbDateBought
            // 
            this.lbDateBought.AutoSize = true;
            this.lbDateBought.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBought.Location = new System.Drawing.Point(170, 37);
            this.lbDateBought.Name = "lbDateBought";
            this.lbDateBought.Size = new System.Drawing.Size(35, 13);
            this.lbDateBought.TabIndex = 6;
            this.lbDateBought.Text = "label4";
            // 
            // lbLastPlayed
            // 
            this.lbLastPlayed.AutoSize = true;
            this.lbLastPlayed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastPlayed.Location = new System.Drawing.Point(288, 37);
            this.lbLastPlayed.Name = "lbLastPlayed";
            this.lbLastPlayed.Size = new System.Drawing.Size(35, 13);
            this.lbLastPlayed.TabIndex = 7;
            this.lbLastPlayed.Text = "label5";
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
            // lbAfis
            // 
            this.lbAfis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.lbAfis.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAfis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfis.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbAfis.FormattingEnabled = true;
            this.lbAfis.ItemHeight = 16;
            this.lbAfis.Location = new System.Drawing.Point(0, 0);
            this.lbAfis.Name = "lbAfis";
            this.lbAfis.Size = new System.Drawing.Size(276, 638);
            this.lbAfis.Sorted = true;
            this.lbAfis.TabIndex = 9;
            this.lbAfis.SelectedIndexChanged += new System.EventHandler(this.lbAfis_SelectedIndexChanged_1);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(163)))), ((int)(((byte)(241)))));
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btPlay.Location = new System.Drawing.Point(16, 13);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(137, 37);
            this.btPlay.TabIndex = 11;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            // 
            // pbAfis
            // 
            this.pbAfis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAfis.Location = new System.Drawing.Point(0, 0);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(1074, 350);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 10;
            this.pbAfis.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Location = new System.Drawing.Point(6, 144);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(244, 134);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lbLastPlayed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbDateBought);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 66);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pbAfis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 350);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(276, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 288);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1329, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 288);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(289, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1040, 47);
            this.panel5.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button7.Location = new System.Drawing.Point(742, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 29);
            this.button7.TabIndex = 20;
            this.button7.Text = "Support";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button6.Location = new System.Drawing.Point(630, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "Guides";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button5.Location = new System.Drawing.Point(509, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 29);
            this.button5.TabIndex = 20;
            this.button5.Text = "Discussions";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button4.Location = new System.Drawing.Point(385, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 29);
            this.button4.TabIndex = 20;
            this.button4.Text = "Find Groups";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button3.Location = new System.Drawing.Point(262, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Points Shop";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button2.Location = new System.Drawing.Point(115, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Community Hub";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(107)))), ((int)(((byte)(113)))));
            this.button1.Location = new System.Drawing.Point(3, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Store Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1350, 638);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbAfis);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Library";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDateBought;
        private System.Windows.Forms.Label lbLastPlayed;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbAfis;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}