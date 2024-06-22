namespace ProlabWithFP
{
    partial class BuyTicketPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicketPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(215, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilet Almak İçin Lütfen Bilet Satın Al Tuşuna Basınız";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.BackColor = System.Drawing.SystemColors.Menu;
            this.BuyTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyTicketButton.Location = new System.Drawing.Point(47, 578);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(276, 84);
            this.BuyTicketButton.TabIndex = 2;
            this.BuyTicketButton.Text = "Bilet Satın Al";
            this.BuyTicketButton.UseVisualStyleBackColor = false;
            this.BuyTicketButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.SystemColors.Menu;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.goBack.Location = new System.Drawing.Point(341, 578);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(275, 84);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "Ana Menüye Dön";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(625, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(19, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BuyTicketPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.BuyTicketButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyTicketPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTicket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuyTicket_FormClosed);
            this.Load += new System.EventHandler(this.BuyTicketPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}