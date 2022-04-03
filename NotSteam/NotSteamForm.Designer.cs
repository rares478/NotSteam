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
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.lvAfis = new System.Windows.Forms.ListView();
            this.btAfis = new System.Windows.Forms.Button();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(258, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Steam";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbUsername.Location = new System.Drawing.Point(753, 9);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(35, 13);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "label2";
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(12, 415);
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
            this.lvAfis.Location = new System.Drawing.Point(591, 180);
            this.lvAfis.Name = "lvAfis";
            this.lvAfis.Size = new System.Drawing.Size(197, 165);
            this.lvAfis.TabIndex = 2;
            this.lvAfis.UseCompatibleStateImageBehavior = false;
            // 
            // btAfis
            // 
            this.btAfis.Location = new System.Drawing.Point(107, 415);
            this.btAfis.Name = "btAfis";
            this.btAfis.Size = new System.Drawing.Size(75, 23);
            this.btAfis.TabIndex = 4;
            this.btAfis.Text = "List";
            this.btAfis.UseVisualStyleBackColor = true;
            this.btAfis.Click += new System.EventHandler(this.btAfis_Click);
            // 
            // cbGames
            // 
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(12, 111);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(121, 21);
            this.cbGames.TabIndex = 11;
            // 
            // NotSteamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbGames);
            this.Controls.Add(this.btAfis);
            this.Controls.Add(this.lvAfis);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label1);
            this.Name = "NotSteamForm";
            this.Text = "NotSteamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.ListView lvAfis;
        private System.Windows.Forms.Button btAfis;
        private System.Windows.Forms.ComboBox cbGames;
    }
}