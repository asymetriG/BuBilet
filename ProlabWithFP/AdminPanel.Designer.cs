namespace ProlabWithFP
{
    partial class AdminPanel
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeCompany = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addCompany = new System.Windows.Forms.Button();
            this.servicePay = new System.Windows.Forms.Label();
            this.setPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeCompany
            // 
            this.removeCompany.Location = new System.Drawing.Point(267, 29);
            this.removeCompany.Name = "removeCompany";
            this.removeCompany.Size = new System.Drawing.Size(150, 37);
            this.removeCompany.TabIndex = 2;
            this.removeCompany.Text = "Firma Sil";
            this.removeCompany.UseVisualStyleBackColor = true;
            this.removeCompany.Click += new System.EventHandler(this.removeCompany_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 216);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(232, 37);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Yenile";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addCompany
            // 
            this.addCompany.Location = new System.Drawing.Point(267, 118);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(150, 37);
            this.addCompany.TabIndex = 4;
            this.addCompany.Text = "Firma Ekle";
            this.addCompany.UseVisualStyleBackColor = true;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // servicePay
            // 
            this.servicePay.AutoSize = true;
            this.servicePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servicePay.Location = new System.Drawing.Point(261, 276);
            this.servicePay.Name = "servicePay";
            this.servicePay.Size = new System.Drawing.Size(0, 33);
            this.servicePay.TabIndex = 6;
            this.servicePay.Click += new System.EventHandler(this.servicePay_Click);
            // 
            // setPay
            // 
            this.setPay.Location = new System.Drawing.Point(267, 216);
            this.setPay.Name = "setPay";
            this.setPay.Size = new System.Drawing.Size(150, 37);
            this.setPay.TabIndex = 7;
            this.setPay.Text = "Servis Bedeli Değiştir";
            this.setPay.UseVisualStyleBackColor = true;
            this.setPay.Click += new System.EventHandler(this.setPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Servis Bedeli : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProlabWithFP.Properties.Resources.logo_no_background;
            this.pictureBox4.Location = new System.Drawing.Point(478, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(296, 269);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setPay);
            this.Controls.Add(this.servicePay);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.removeCompany);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeCompany;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addCompany;
        private System.Windows.Forms.Label servicePay;
        private System.Windows.Forms.Button setPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}