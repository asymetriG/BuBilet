namespace ProlabWithFP
{
    partial class AddCompanyForm
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
            this.firmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firmPassword = new System.Windows.Forms.TextBox();
            this.addCompany = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.firmUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firmName
            // 
            this.firmName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmName.Location = new System.Drawing.Point(42, 124);
            this.firmName.Multiline = true;
            this.firmName.Name = "firmName";
            this.firmName.Size = new System.Drawing.Size(268, 30);
            this.firmName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Firma Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firma Şifresi";
            // 
            // firmPassword
            // 
            this.firmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmPassword.Location = new System.Drawing.Point(42, 296);
            this.firmPassword.Multiline = true;
            this.firmPassword.Name = "firmPassword";
            this.firmPassword.Size = new System.Drawing.Size(268, 30);
            this.firmPassword.TabIndex = 3;
            // 
            // addCompany
            // 
            this.addCompany.Location = new System.Drawing.Point(81, 356);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(194, 41);
            this.addCompany.TabIndex = 5;
            this.addCompany.Text = "Yeni Firma Ekle";
            this.addCompany.UseVisualStyleBackColor = true;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firma Kullanıcı Adı ";
            // 
            // firmUserName
            // 
            this.firmUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firmUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmUserName.Location = new System.Drawing.Point(42, 212);
            this.firmUserName.Multiline = true;
            this.firmUserName.Name = "firmUserName";
            this.firmUserName.Size = new System.Drawing.Size(268, 30);
            this.firmUserName.TabIndex = 6;
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firmUserName);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firmName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompanyForm";
            this.Load += new System.EventHandler(this.AddCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firmPassword;
        private System.Windows.Forms.Button addCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firmUserName;
    }
}