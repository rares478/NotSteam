namespace NotSteam
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.lvAfis = new System.Windows.Forms.ListView();
            this.btAfis = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbDescriere = new System.Windows.Forms.RichTextBox();
            this.lbdev = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(249, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Steam";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbUsername.Location = new System.Drawing.Point(64, 30);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(86, 31);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "label2";
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(46, 443);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(75, 23);
            this.btBuy.TabIndex = 2;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // lvAfis
            // 
            this.lvAfis.HideSelection = false;
            this.lvAfis.Location = new System.Drawing.Point(116, 117);
            this.lvAfis.Name = "lvAfis";
            this.lvAfis.Size = new System.Drawing.Size(197, 277);
            this.lvAfis.TabIndex = 2;
            this.lvAfis.UseCompatibleStateImageBehavior = false;
            // 
            // btAfis
            // 
            this.btAfis.Location = new System.Drawing.Point(679, 371);
            this.btAfis.Name = "btAfis";
            this.btAfis.Size = new System.Drawing.Size(75, 23);
            this.btAfis.TabIndex = 4;
            this.btAfis.Text = "List";
            this.btAfis.UseVisualStyleBackColor = true;
            this.btAfis.Click += new System.EventHandler(this.btAfis_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 498);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbDescriere);
            this.tabPage1.Controls.Add(this.lbdev);
            this.tabPage1.Controls.Add(this.lbName);
            this.tabPage1.Controls.Add(this.pbPic);
            this.tabPage1.Controls.Add(this.cbGames);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btBuy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Store";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(276, 207);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.ReadOnly = true;
            this.tbDescriere.Size = new System.Drawing.Size(429, 126);
            this.tbDescriere.TabIndex = 9;
            this.tbDescriere.Text = "";
            // 
            // lbdev
            // 
            this.lbdev.AutoSize = true;
            this.lbdev.Location = new System.Drawing.Point(273, 171);
            this.lbdev.Name = "lbdev";
            this.lbdev.Size = new System.Drawing.Size(35, 13);
            this.lbdev.TabIndex = 8;
            this.lbdev.Text = "label5";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(271, 134);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 25);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "label4";
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(16, 134);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(213, 199);
            this.pbPic.TabIndex = 6;
            this.pbPic.TabStop = false;
            // 
            // cbGames
            // 
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(620, 84);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(121, 21);
            this.cbGames.TabIndex = 5;
            this.cbGames.SelectedIndexChanged += new System.EventHandler(this.cbGames_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lvAfis);
            this.tabPage2.Controls.Add(this.btAfis);
            this.tabPage2.Controls.Add(this.lbUsername);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Games";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(213, 199);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NotSteamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "NotSteamForm";
            this.Text = "NotSteamForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.ListView lvAfis;
        private System.Windows.Forms.Button btAfis;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.Label lbdev;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox tbDescriere;
    }
}