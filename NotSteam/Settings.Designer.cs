﻿namespace NotSteam
{
    partial class Settings
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
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.btChangeEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCurrentPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPassword.Location = new System.Drawing.Point(343, 107);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(206, 20);
            this.tbCurrentPassword.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label25.Location = new System.Drawing.Point(216, 108);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 16);
            this.label25.TabIndex = 15;
            this.label25.Text = "Current Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(216, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPassword.Location = new System.Drawing.Point(343, 154);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(206, 20);
            this.tbNewPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(216, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "New Email";
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewEmail.Location = new System.Drawing.Point(343, 204);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(206, 20);
            this.tbNewEmail.TabIndex = 19;
            // 
            // btChangePassword
            // 
            this.btChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btChangePassword.FlatAppearance.BorderSize = 0;
            this.btChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.btChangePassword.Location = new System.Drawing.Point(219, 267);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(149, 23);
            this.btChangePassword.TabIndex = 20;
            this.btChangePassword.Text = "Change Password";
            this.btChangePassword.UseVisualStyleBackColor = false;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click);
            // 
            // btChangeEmail
            // 
            this.btChangeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChangeEmail.FlatAppearance.BorderSize = 0;
            this.btChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(154)))), ((int)(((byte)(188)))));
            this.btChangeEmail.Location = new System.Drawing.Point(400, 267);
            this.btChangeEmail.Name = "btChangeEmail";
            this.btChangeEmail.Size = new System.Drawing.Size(149, 23);
            this.btChangeEmail.TabIndex = 21;
            this.btChangeEmail.Text = "Change Email";
            this.btChangeEmail.UseVisualStyleBackColor = true;
            this.btChangeEmail.Click += new System.EventHandler(this.btChangeEmail_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChangeEmail);
            this.Controls.Add(this.btChangePassword);
            this.Controls.Add(this.tbNewEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tbCurrentPassword);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Button btChangeEmail;
    }
}