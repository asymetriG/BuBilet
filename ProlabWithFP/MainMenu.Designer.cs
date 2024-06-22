namespace ProlabWithFP
{
    partial class MainMenu
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
            this.userButton = new System.Windows.Forms.Button();
            this.firmButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userButton.Location = new System.Drawing.Point(409, 517);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(274, 59);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "Kullanıcı Paneli";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // firmButton
            // 
            this.firmButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.firmButton.ImageKey = "(yok)";
            this.firmButton.Location = new System.Drawing.Point(409, 372);
            this.firmButton.Name = "firmButton";
            this.firmButton.Size = new System.Drawing.Size(274, 60);
            this.firmButton.TabIndex = 3;
            this.firmButton.Text = "Firma Paneli";
            this.firmButton.UseVisualStyleBackColor = false;
            this.firmButton.Click += new System.EventHandler(this.firmButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminButton.Location = new System.Drawing.Point(409, 224);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(274, 60);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Admin Paneli";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProlabWithFP.Properties.Resources.The_Road_Less_Travelled_Motivational_Instagram_Post___1_;
            this.ClientSize = new System.Drawing.Size(1080, 874);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.firmButton);
            this.Controls.Add(this.adminButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESERVATION SYSTEM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button firmButton;
        private System.Windows.Forms.Button adminButton;
    }
}

