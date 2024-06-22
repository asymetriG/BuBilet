namespace ProlabWithFP
{
    partial class removeVehicleForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.removeVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // removeVehicle
            // 
            this.removeVehicle.Location = new System.Drawing.Point(24, 108);
            this.removeVehicle.Name = "removeVehicle";
            this.removeVehicle.Size = new System.Drawing.Size(235, 39);
            this.removeVehicle.TabIndex = 1;
            this.removeVehicle.Text = "Araç Sil";
            this.removeVehicle.UseVisualStyleBackColor = true;
            this.removeVehicle.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // removeVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 184);
            this.Controls.Add(this.removeVehicle);
            this.Controls.Add(this.comboBox1);
            this.Name = "removeVehicleForm";
            this.Text = "removeVehicleForm";
            this.Load += new System.EventHandler(this.removeVehicleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button removeVehicle;
    }
}