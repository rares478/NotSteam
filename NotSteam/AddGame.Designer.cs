﻿namespace NotSteam
{
    partial class AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.rbDesc = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDev = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btPic = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdd
            // 
            this.pbAdd.Location = new System.Drawing.Point(581, 98);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(177, 153);
            this.pbAdd.TabIndex = 9;
            this.pbAdd.TabStop = false;
            this.pbAdd.Visible = false;
            // 
            // rbDesc
            // 
            this.rbDesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDesc.Location = new System.Drawing.Point(264, 230);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(260, 89);
            this.rbDesc.TabIndex = 10;
            this.rbDesc.Text = "";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbName.Location = new System.Drawing.Point(264, 98);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 20);
            this.tbName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(177, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(177, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Developer";
            // 
            // tbDev
            // 
            this.tbDev.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbDev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDev.Location = new System.Drawing.Point(264, 139);
            this.tbDev.Name = "tbDev";
            this.tbDev.Size = new System.Drawing.Size(260, 20);
            this.tbDev.TabIndex = 14;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPrice.Location = new System.Drawing.Point(264, 181);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(260, 20);
            this.tbPrice.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(184, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "Price";
            // 
            // btPic
            // 
            this.btPic.BackColor = System.Drawing.SystemColors.ControlText;
            this.btPic.FlatAppearance.BorderSize = 0;
            this.btPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPic.Location = new System.Drawing.Point(340, 325);
            this.btPic.Name = "btPic";
            this.btPic.Size = new System.Drawing.Size(102, 28);
            this.btPic.TabIndex = 17;
            this.btPic.Text = "Add Picture";
            this.btPic.UseVisualStyleBackColor = false;
            this.btPic.Click += new System.EventHandler(this.btPic_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.BackColor = System.Drawing.SystemColors.ControlText;
            this.btAddNew.FlatAppearance.BorderSize = 0;
            this.btAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNew.Location = new System.Drawing.Point(12, 406);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(134, 32);
            this.btAddNew.TabIndex = 18;
            this.btAddNew.Text = "Add New Game";
            this.btAddNew.UseVisualStyleBackColor = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btPic);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.pbAdd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "AddGame";
            this.Text = "AddGame";
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.RichTextBox rbDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDev;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}