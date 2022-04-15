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
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDateBought = new System.Windows.Forms.Label();
            this.lbLastPlayed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbAfis = new System.Windows.Forms.ListBox();
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.btPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbUsername.Location = new System.Drawing.Point(33, 61);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(86, 31);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Played";
            // 
            // lbDateBought
            // 
            this.lbDateBought.AutoSize = true;
            this.lbDateBought.Location = new System.Drawing.Point(495, 133);
            this.lbDateBought.Name = "lbDateBought";
            this.lbDateBought.Size = new System.Drawing.Size(35, 13);
            this.lbDateBought.TabIndex = 6;
            this.lbDateBought.Text = "label4";
            // 
            // lbLastPlayed
            // 
            this.lbLastPlayed.AutoSize = true;
            this.lbLastPlayed.Location = new System.Drawing.Point(495, 187);
            this.lbLastPlayed.Name = "lbLastPlayed";
            this.lbLastPlayed.Size = new System.Drawing.Size(35, 13);
            this.lbLastPlayed.TabIndex = 7;
            this.lbLastPlayed.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
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
            this.lbAfis.FormattingEnabled = true;
            this.lbAfis.Location = new System.Drawing.Point(12, 95);
            this.lbAfis.Name = "lbAfis";
            this.lbAfis.Size = new System.Drawing.Size(147, 394);
            this.lbAfis.Sorted = true;
            this.lbAfis.TabIndex = 9;
            this.lbAfis.SelectedIndexChanged += new System.EventHandler(this.lbAfis_SelectedIndexChanged_1);
            // 
            // pbAfis
            // 
            this.pbAfis.Location = new System.Drawing.Point(189, 95);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(194, 147);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 10;
            this.pbAfis.TabStop = false;
            // 
            // btPlay
            // 
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.Location = new System.Drawing.Point(244, 248);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(93, 30);
            this.btPlay.TabIndex = 11;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.pbAfis);
            this.Controls.Add(this.lbAfis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLastPlayed);
            this.Controls.Add(this.lbDateBought);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUsername);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDateBought;
        private System.Windows.Forms.Label lbLastPlayed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbAfis;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.Button btPlay;
    }
}