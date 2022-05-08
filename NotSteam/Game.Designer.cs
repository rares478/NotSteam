using System.Drawing;
using System.Windows.Forms;
using System;

namespace NotSteam
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbMainBig = new System.Windows.Forms.PictureBox();
            this.lbGameNameSolo = new System.Windows.Forms.Label();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDeveloper = new System.Windows.Forms.Label();
            this.category1 = new System.Windows.Forms.Button();
            this.category2 = new System.Windows.Forms.Button();
            this.category3 = new System.Windows.Forms.Button();
            this.lbGameNameBuy = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.panelbuy = new System.Windows.Forms.Panel();
            this.pbPic1 = new System.Windows.Forms.PictureBox();
            this.pbPic2 = new System.Windows.Forms.PictureBox();
            this.pbPic3 = new System.Windows.Forms.PictureBox();
            this.pbPic4 = new System.Windows.Forms.PictureBox();
            this.pbPic5 = new System.Windows.Forms.PictureBox();
            this.pbqueue = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelbuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbqueue)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainBig
            // 
            this.pbMainBig.Location = new System.Drawing.Point(111, 106);
            this.pbMainBig.Name = "pbMainBig";
            this.pbMainBig.Size = new System.Drawing.Size(598, 336);
            this.pbMainBig.TabIndex = 0;
            this.pbMainBig.TabStop = false;
            // 
            // lbGameNameSolo
            // 
            this.lbGameNameSolo.AutoSize = true;
            this.lbGameNameSolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameNameSolo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGameNameSolo.Location = new System.Drawing.Point(106, 74);
            this.lbGameNameSolo.Name = "lbGameNameSolo";
            this.lbGameNameSolo.Size = new System.Drawing.Size(79, 29);
            this.lbGameNameSolo.TabIndex = 1;
            this.lbGameNameSolo.Text = "label1";
            // 
            // pbHeader
            // 
            this.pbHeader.Location = new System.Drawing.Point(729, 106);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(321, 151);
            this.pbHeader.TabIndex = 2;
            this.pbHeader.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescription.Location = new System.Drawing.Point(729, 264);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(321, 97);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(729, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Release Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(729, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Developer: ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(152)))), ((int)(((byte)(160)))));
            this.lbDate.Location = new System.Drawing.Point(823, 360);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(35, 13);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "label3";
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
            this.lbDeveloper.Location = new System.Drawing.Point(826, 380);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(35, 13);
            this.lbDeveloper.TabIndex = 7;
            this.lbDeveloper.Text = "label3";
            // 
            // category1
            // 
            this.category1.AutoSize = true;
            this.category1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.category1.FlatAppearance.BorderSize = 0;
            this.category1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
            this.category1.Location = new System.Drawing.Point(729, 410);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(75, 23);
            this.category1.TabIndex = 2;
            this.category1.Text = "label1";
            this.category1.UseVisualStyleBackColor = false;
            // 
            // category2
            // 
            this.category2.AutoSize = true;
            this.category2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.category2.FlatAppearance.BorderSize = 0;
            this.category2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
            this.category2.Location = new System.Drawing.Point(810, 410);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(75, 23);
            this.category2.TabIndex = 1;
            this.category2.Text = "label2";
            this.category2.UseVisualStyleBackColor = false;
            // 
            // category3
            // 
            this.category3.AutoSize = true;
            this.category3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.category3.FlatAppearance.BorderSize = 0;
            this.category3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(162)))), ((int)(((byte)(206)))));
            this.category3.Location = new System.Drawing.Point(890, 410);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(75, 23);
            this.category3.TabIndex = 0;
            this.category3.Text = "label3";
            this.category3.UseVisualStyleBackColor = false;
            // 
            // lbGameNameBuy
            // 
            this.lbGameNameBuy.AutoSize = true;
            this.lbGameNameBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameNameBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGameNameBuy.Location = new System.Drawing.Point(12, 21);
            this.lbGameNameBuy.Name = "lbGameNameBuy";
            this.lbGameNameBuy.Size = new System.Drawing.Size(0, 25);
            this.lbGameNameBuy.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel5.Controls.Add(this.lbGameNameBuy);
            this.panel5.Location = new System.Drawing.Point(111, 558);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 68);
            this.panel5.TabIndex = 8;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPrice.Location = new System.Drawing.Point(32, 14);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(0, 13);
            this.lbPrice.TabIndex = 1;
            // 
            // btBuy
            // 
            this.btBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(166)))), ((int)(((byte)(33)))));
            this.btBuy.FlatAppearance.BorderSize = 0;
            this.btBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBuy.Location = new System.Drawing.Point(83, 3);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(102, 35);
            this.btBuy.TabIndex = 0;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = false;
            // 
            // panelbuy
            // 
            this.panelbuy.BackColor = System.Drawing.Color.Black;
            this.panelbuy.Controls.Add(this.btBuy);
            this.panelbuy.Controls.Add(this.lbPrice);
            this.panelbuy.Location = new System.Drawing.Point(502, 608);
            this.panelbuy.Name = "panelbuy";
            this.panelbuy.Size = new System.Drawing.Size(188, 41);
            this.panelbuy.TabIndex = 9;
            // 
            // pbPic1
            // 
            this.pbPic1.Location = new System.Drawing.Point(125, 448);
            this.pbPic1.Name = "pbPic1";
            this.pbPic1.Size = new System.Drawing.Size(109, 58);
            this.pbPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic1.TabIndex = 10;
            this.pbPic1.TabStop = false;
            // 
            // pbPic2
            // 
            this.pbPic2.Location = new System.Drawing.Point(240, 448);
            this.pbPic2.Name = "pbPic2";
            this.pbPic2.Size = new System.Drawing.Size(109, 58);
            this.pbPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic2.TabIndex = 11;
            this.pbPic2.TabStop = false;
            // 
            // pbPic3
            // 
            this.pbPic3.Location = new System.Drawing.Point(355, 448);
            this.pbPic3.Name = "pbPic3";
            this.pbPic3.Size = new System.Drawing.Size(109, 58);
            this.pbPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic3.TabIndex = 12;
            this.pbPic3.TabStop = false;
            // 
            // pbPic4
            // 
            this.pbPic4.Location = new System.Drawing.Point(470, 448);
            this.pbPic4.Name = "pbPic4";
            this.pbPic4.Size = new System.Drawing.Size(109, 58);
            this.pbPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic4.TabIndex = 13;
            this.pbPic4.TabStop = false;
            // 
            // pbPic5
            // 
            this.pbPic5.Location = new System.Drawing.Point(585, 448);
            this.pbPic5.Name = "pbPic5";
            this.pbPic5.Size = new System.Drawing.Size(109, 58);
            this.pbPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic5.TabIndex = 14;
            this.pbPic5.TabStop = false;
            // 
            // pbqueue
            // 
            this.pbqueue.Location = new System.Drawing.Point(900, 500);
            this.pbqueue.Name = "pbqueue";
            this.pbqueue.Size = new System.Drawing.Size(147, 47);
            this.pbqueue.TabIndex = 0;
            this.pbqueue.TabStop = false;
            this.pbqueue.Visible = false;
            this.pbqueue.Click += new System.EventHandler(this.queueclick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dw.png");
            this.imageList1.Images.SetKeyName(1, "finishqueue.png");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1172, 1061);
            this.Controls.Add(this.pbqueue);
            this.Controls.Add(this.pbPic5);
            this.Controls.Add(this.pbPic4);
            this.Controls.Add(this.pbPic3);
            this.Controls.Add(this.pbPic2);
            this.Controls.Add(this.pbPic1);
            this.Controls.Add(this.panelbuy);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.category3);
            this.Controls.Add(this.category2);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.lbGameNameSolo);
            this.Controls.Add(this.pbMainBig);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelbuy.ResumeLayout(false);
            this.panelbuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbqueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainBig;
        private System.Windows.Forms.Label lbGameNameSolo;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.RichTextBox tbDescription;
        private Label label1;
        private Label label2;
        private Label lbDate;
        private Label lbDeveloper;
        private Button category1;
        private Button category2;
        private Button category3;
        private Label lbGameNameBuy;
        private Panel panel5;
        private Label lbPrice;
        private Button btBuy;
        private Panel panelbuy;
        private PictureBox pbPic1;
        private PictureBox pbPic2;
        private PictureBox pbPic3;
        private PictureBox pbPic4;
        private PictureBox pbPic5;
        private PictureBox pbqueue;
        private ImageList imageList1;
    }
}