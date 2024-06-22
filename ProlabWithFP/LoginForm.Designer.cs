using System;
using System.Windows.Forms;

namespace ProlabWithFP
{
    partial class LoginForm
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
            this.loginText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Font = new System.Drawing.Font("Sans Serif Collection", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.Location = new System.Drawing.Point(726, 110);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(452, 71);
            this.loginText.TabIndex = 2;
            this.loginText.Text = "Admin Paneli Giriş";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            // 
            // passwordText
            // 
            this.passwordText.AcceptsReturn = true;
            this.passwordText.AcceptsTab = true;
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.CausesValidation = false;
            this.passwordText.Font = new System.Drawing.Font("Sans Serif Collection", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passwordText.Location = new System.Drawing.Point(791, 396);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(323, 79);
            this.passwordText.TabIndex = 3;
            this.passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordText_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(808, 530);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(295, 76);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.AcceptsReturn = true;
            this.usernameText.AcceptsTab = true;
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.CausesValidation = false;
            this.usernameText.Font = new System.Drawing.Font("Sans Serif Collection", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.usernameText.Location = new System.Drawing.Point(791, 237);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(323, 79);
            this.usernameText.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProlabWithFP.Properties.Resources.logo_color;
            this.pictureBox4.Location = new System.Drawing.Point(-19, -34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(726, 764);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1193, 725);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button loginButton;
        private PictureBox pictureBox4;
        private TextBox usernameText;
    }
}