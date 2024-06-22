namespace ProlabWithFP
{
    partial class addRoadForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addCity = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.removeCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(23, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 172);
            this.listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(166, 230);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(78, 23);
            this.addCity.TabIndex = 2;
            this.addCity.Text = "Şehir Ekle";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(23, 269);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(321, 23);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Bitti";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // removeCity
            // 
            this.removeCity.Location = new System.Drawing.Point(263, 230);
            this.removeCity.Name = "removeCity";
            this.removeCity.Size = new System.Drawing.Size(81, 23);
            this.removeCity.TabIndex = 4;
            this.removeCity.Text = "Şehir Sil";
            this.removeCity.UseVisualStyleBackColor = true;
            this.removeCity.Click += new System.EventHandler(this.removeCity_Click);
            // 
            // addRoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 306);
            this.Controls.Add(this.removeCity);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "addRoadForm";
            this.Text = "addRoadForm";
            this.Load += new System.EventHandler(this.addRoadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button removeCity;
    }
}