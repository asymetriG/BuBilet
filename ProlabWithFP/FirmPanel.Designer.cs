namespace ProlabWithFP
{
    partial class FirmPanel
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
            this.labell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buses = new System.Windows.Forms.ListBox();
            this.planes = new System.Windows.Forms.ListBox();
            this.trains = new System.Windows.Forms.ListBox();
            this.getBusRoad = new System.Windows.Forms.Button();
            this.getPlaneRoad = new System.Windows.Forms.Button();
            this.getTrainRoad = new System.Windows.Forms.Button();
            this.showRoutesBus = new System.Windows.Forms.Button();
            this.showRoutesPlane = new System.Windows.Forms.Button();
            this.showRoutesTrain = new System.Windows.Forms.Button();
            this.addRoadBus = new System.Windows.Forms.Button();
            this.addRoadTrain = new System.Windows.Forms.Button();
            this.removeRoadTrain = new System.Windows.Forms.Button();
            this.removeRoadBus = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showTicket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyCostText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weeklyCostText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalEarningsText = new System.Windows.Forms.Label();
            this.totalProfitText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addVehicleBus = new System.Windows.Forms.Button();
            this.addVehiclePlane = new System.Windows.Forms.Button();
            this.addVehicleTrain = new System.Windows.Forms.Button();
            this.removeVehicle = new System.Windows.Forms.Button();
            this.dailyProfitShow = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.Location = new System.Drawing.Point(287, 78);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(272, 55);
            this.labell.TabIndex = 0;
            this.labell.Text = "Hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(650, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüsler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(878, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uçaklar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1083, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trenler";
            // 
            // buses
            // 
            this.buses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buses.FormattingEnabled = true;
            this.buses.ItemHeight = 24;
            this.buses.Location = new System.Drawing.Point(644, 135);
            this.buses.Name = "buses";
            this.buses.Size = new System.Drawing.Size(173, 124);
            this.buses.TabIndex = 4;
            // 
            // planes
            // 
            this.planes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.planes.FormattingEnabled = true;
            this.planes.ItemHeight = 24;
            this.planes.Location = new System.Drawing.Point(852, 135);
            this.planes.Name = "planes";
            this.planes.Size = new System.Drawing.Size(173, 124);
            this.planes.TabIndex = 5;
            // 
            // trains
            // 
            this.trains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trains.FormattingEnabled = true;
            this.trains.ItemHeight = 24;
            this.trains.Location = new System.Drawing.Point(1057, 135);
            this.trains.Name = "trains";
            this.trains.Size = new System.Drawing.Size(173, 124);
            this.trains.TabIndex = 6;
            // 
            // getBusRoad
            // 
            this.getBusRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getBusRoad.Location = new System.Drawing.Point(644, 287);
            this.getBusRoad.Name = "getBusRoad";
            this.getBusRoad.Size = new System.Drawing.Size(173, 77);
            this.getBusRoad.TabIndex = 7;
            this.getBusRoad.Text = "Seçili Güzergahı Göster";
            this.getBusRoad.UseVisualStyleBackColor = true;
            this.getBusRoad.Click += new System.EventHandler(this.getBusRoad_Click);
            // 
            // getPlaneRoad
            // 
            this.getPlaneRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getPlaneRoad.Location = new System.Drawing.Point(852, 287);
            this.getPlaneRoad.Name = "getPlaneRoad";
            this.getPlaneRoad.Size = new System.Drawing.Size(173, 77);
            this.getPlaneRoad.TabIndex = 8;
            this.getPlaneRoad.Text = "Seçili Güzergahı Göster";
            this.getPlaneRoad.UseVisualStyleBackColor = true;
            this.getPlaneRoad.Click += new System.EventHandler(this.getPlaneRoad_Click);
            // 
            // getTrainRoad
            // 
            this.getTrainRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getTrainRoad.Location = new System.Drawing.Point(1057, 287);
            this.getTrainRoad.Name = "getTrainRoad";
            this.getTrainRoad.Size = new System.Drawing.Size(173, 77);
            this.getTrainRoad.TabIndex = 9;
            this.getTrainRoad.Text = "Seçili Güzergahı Göster";
            this.getTrainRoad.UseVisualStyleBackColor = true;
            this.getTrainRoad.Click += new System.EventHandler(this.getTrainRoad_Click);
            // 
            // showRoutesBus
            // 
            this.showRoutesBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showRoutesBus.Location = new System.Drawing.Point(644, 389);
            this.showRoutesBus.Name = "showRoutesBus";
            this.showRoutesBus.Size = new System.Drawing.Size(173, 40);
            this.showRoutesBus.TabIndex = 10;
            this.showRoutesBus.Text = "Seferleri Göster";
            this.showRoutesBus.UseVisualStyleBackColor = true;
            this.showRoutesBus.Click += new System.EventHandler(this.showRoutesBus_Click);
            // 
            // showRoutesPlane
            // 
            this.showRoutesPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showRoutesPlane.Location = new System.Drawing.Point(852, 389);
            this.showRoutesPlane.Name = "showRoutesPlane";
            this.showRoutesPlane.Size = new System.Drawing.Size(173, 40);
            this.showRoutesPlane.TabIndex = 11;
            this.showRoutesPlane.Text = "Seferleri Göster";
            this.showRoutesPlane.UseVisualStyleBackColor = true;
            this.showRoutesPlane.Click += new System.EventHandler(this.showRoutesPlane_Click);
            // 
            // showRoutesTrain
            // 
            this.showRoutesTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showRoutesTrain.Location = new System.Drawing.Point(1057, 389);
            this.showRoutesTrain.Name = "showRoutesTrain";
            this.showRoutesTrain.Size = new System.Drawing.Size(173, 40);
            this.showRoutesTrain.TabIndex = 12;
            this.showRoutesTrain.Text = "Seferleri Göster";
            this.showRoutesTrain.UseVisualStyleBackColor = true;
            this.showRoutesTrain.Click += new System.EventHandler(this.showRoutesTrain_Click);
            // 
            // addRoadBus
            // 
            this.addRoadBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addRoadBus.Location = new System.Drawing.Point(644, 500);
            this.addRoadBus.Name = "addRoadBus";
            this.addRoadBus.Size = new System.Drawing.Size(173, 40);
            this.addRoadBus.TabIndex = 19;
            this.addRoadBus.Text = "Sefer Ekle";
            this.addRoadBus.UseVisualStyleBackColor = true;
            this.addRoadBus.Click += new System.EventHandler(this.addRoadBus_Click);
            // 
            // addRoadTrain
            // 
            this.addRoadTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addRoadTrain.Location = new System.Drawing.Point(1060, 500);
            this.addRoadTrain.Name = "addRoadTrain";
            this.addRoadTrain.Size = new System.Drawing.Size(173, 40);
            this.addRoadTrain.TabIndex = 22;
            this.addRoadTrain.Text = "Sefer Ekle";
            this.addRoadTrain.UseVisualStyleBackColor = true;
            this.addRoadTrain.Click += new System.EventHandler(this.addRoadTrain_Click);
            // 
            // removeRoadTrain
            // 
            this.removeRoadTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeRoadTrain.Location = new System.Drawing.Point(1060, 565);
            this.removeRoadTrain.Name = "removeRoadTrain";
            this.removeRoadTrain.Size = new System.Drawing.Size(173, 40);
            this.removeRoadTrain.TabIndex = 23;
            this.removeRoadTrain.Text = "Sefer Çıkar";
            this.removeRoadTrain.UseVisualStyleBackColor = true;
            this.removeRoadTrain.Click += new System.EventHandler(this.removeRoadTrain_Click);
            // 
            // removeRoadBus
            // 
            this.removeRoadBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeRoadBus.Location = new System.Drawing.Point(644, 565);
            this.removeRoadBus.Name = "removeRoadBus";
            this.removeRoadBus.Size = new System.Drawing.Size(173, 40);
            this.removeRoadBus.TabIndex = 24;
            this.removeRoadBus.Text = "Sefer Çıkar";
            this.removeRoadBus.UseVisualStyleBackColor = true;
            this.removeRoadBus.Click += new System.EventHandler(this.removeRoadBus_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reloadButton.Location = new System.Drawing.Point(644, 681);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(586, 40);
            this.reloadButton.TabIndex = 25;
            this.reloadButton.Text = "Yenile";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 344);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showTicket
            // 
            this.showTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showTicket.Location = new System.Drawing.Point(30, 587);
            this.showTicket.Name = "showTicket";
            this.showTicket.Size = new System.Drawing.Size(529, 43);
            this.showTicket.TabIndex = 27;
            this.showTicket.Text = "Seçili Bileti Göster";
            this.showTicket.UseVisualStyleBackColor = true;
            this.showTicket.Click += new System.EventHandler(this.showTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 715);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Günlük Maliyet : ";
            // 
            // dailyCostText
            // 
            this.dailyCostText.AutoSize = true;
            this.dailyCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dailyCostText.Location = new System.Drawing.Point(181, 715);
            this.dailyCostText.Name = "dailyCostText";
            this.dailyCostText.Size = new System.Drawing.Size(70, 25);
            this.dailyCostText.TabIndex = 29;
            this.dailyCostText.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(267, 715);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Haftalık Maliyet : ";
            // 
            // weeklyCostText
            // 
            this.weeklyCostText.AutoSize = true;
            this.weeklyCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.weeklyCostText.Location = new System.Drawing.Point(450, 715);
            this.weeklyCostText.Name = "weeklyCostText";
            this.weeklyCostText.Size = new System.Drawing.Size(70, 25);
            this.weeklyCostText.TabIndex = 31;
            this.weeklyCostText.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 765);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Toplam Kazanç : ";
            // 
            // totalEarningsText
            // 
            this.totalEarningsText.AutoSize = true;
            this.totalEarningsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalEarningsText.Location = new System.Drawing.Point(181, 765);
            this.totalEarningsText.Name = "totalEarningsText";
            this.totalEarningsText.Size = new System.Drawing.Size(70, 25);
            this.totalEarningsText.TabIndex = 33;
            this.totalEarningsText.Text = "label5";
            // 
            // totalProfitText
            // 
            this.totalProfitText.AutoSize = true;
            this.totalProfitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalProfitText.Location = new System.Drawing.Point(542, 765);
            this.totalProfitText.Name = "totalProfitText";
            this.totalProfitText.Size = new System.Drawing.Size(70, 25);
            this.totalProfitText.TabIndex = 34;
            this.totalProfitText.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(267, 765);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Günlük Kar/Zarar Durumu :";
            // 
            // addVehicleBus
            // 
            this.addVehicleBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addVehicleBus.Location = new System.Drawing.Point(644, 444);
            this.addVehicleBus.Name = "addVehicleBus";
            this.addVehicleBus.Size = new System.Drawing.Size(173, 40);
            this.addVehicleBus.TabIndex = 13;
            this.addVehicleBus.Text = "Araç Ekle";
            this.addVehicleBus.UseVisualStyleBackColor = true;
            this.addVehicleBus.Click += new System.EventHandler(this.addVehicleBus_Click);
            // 
            // addVehiclePlane
            // 
            this.addVehiclePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addVehiclePlane.Location = new System.Drawing.Point(852, 444);
            this.addVehiclePlane.Name = "addVehiclePlane";
            this.addVehiclePlane.Size = new System.Drawing.Size(173, 40);
            this.addVehiclePlane.TabIndex = 14;
            this.addVehiclePlane.Text = "Araç Ekle";
            this.addVehiclePlane.UseVisualStyleBackColor = true;
            this.addVehiclePlane.Click += new System.EventHandler(this.addVehiclePlane_Click);
            // 
            // addVehicleTrain
            // 
            this.addVehicleTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addVehicleTrain.Location = new System.Drawing.Point(1057, 444);
            this.addVehicleTrain.Name = "addVehicleTrain";
            this.addVehicleTrain.Size = new System.Drawing.Size(173, 40);
            this.addVehicleTrain.TabIndex = 15;
            this.addVehicleTrain.Text = "Araç Ekle";
            this.addVehicleTrain.UseVisualStyleBackColor = true;
            this.addVehicleTrain.Click += new System.EventHandler(this.addVehicleTrain_Click);
            // 
            // removeVehicle
            // 
            this.removeVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeVehicle.Location = new System.Drawing.Point(644, 623);
            this.removeVehicle.Name = "removeVehicle";
            this.removeVehicle.Size = new System.Drawing.Size(589, 40);
            this.removeVehicle.TabIndex = 36;
            this.removeVehicle.Text = "Araç Sil";
            this.removeVehicle.UseVisualStyleBackColor = true;
            this.removeVehicle.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // dailyProfitShow
            // 
            this.dailyProfitShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dailyProfitShow.Location = new System.Drawing.Point(30, 646);
            this.dailyProfitShow.Name = "dailyProfitShow";
            this.dailyProfitShow.Size = new System.Drawing.Size(529, 43);
            this.dailyProfitShow.TabIndex = 37;
            this.dailyProfitShow.Text = "Gün Bazında Kar/Zarar Göster";
            this.dailyProfitShow.UseVisualStyleBackColor = true;
            this.dailyProfitShow.Click += new System.EventHandler(this.dailyProfitShow_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Image = global::ProlabWithFP.Properties.Resources.logo_no_background;
            this.pictureBox4.Location = new System.Drawing.Point(30, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 203);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // FirmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 806);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dailyProfitShow);
            this.Controls.Add(this.removeVehicle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalProfitText);
            this.Controls.Add(this.totalEarningsText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weeklyCostText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dailyCostText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showTicket);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.removeRoadBus);
            this.Controls.Add(this.removeRoadTrain);
            this.Controls.Add(this.addRoadTrain);
            this.Controls.Add(this.addRoadBus);
            this.Controls.Add(this.addVehicleTrain);
            this.Controls.Add(this.addVehiclePlane);
            this.Controls.Add(this.addVehicleBus);
            this.Controls.Add(this.showRoutesTrain);
            this.Controls.Add(this.showRoutesPlane);
            this.Controls.Add(this.showRoutesBus);
            this.Controls.Add(this.getTrainRoad);
            this.Controls.Add(this.getPlaneRoad);
            this.Controls.Add(this.getBusRoad);
            this.Controls.Add(this.trains);
            this.Controls.Add(this.planes);
            this.Controls.Add(this.buses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labell);
            this.Name = "FirmPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirmPanel_FormClosed);
            this.Load += new System.EventHandler(this.FirmPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox buses;
        private System.Windows.Forms.ListBox planes;
        private System.Windows.Forms.ListBox trains;
        private System.Windows.Forms.Button getBusRoad;
        private System.Windows.Forms.Button getPlaneRoad;
        private System.Windows.Forms.Button getTrainRoad;
        private System.Windows.Forms.Button showRoutesBus;
        private System.Windows.Forms.Button showRoutesPlane;
        private System.Windows.Forms.Button showRoutesTrain;
        private System.Windows.Forms.Button addRoadBus;
        private System.Windows.Forms.Button addRoadTrain;
        private System.Windows.Forms.Button removeRoadTrain;
        private System.Windows.Forms.Button removeRoadBus;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dailyCostText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weeklyCostText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalEarningsText;
        private System.Windows.Forms.Label totalProfitText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addVehicleBus;
        private System.Windows.Forms.Button addVehiclePlane;
        private System.Windows.Forms.Button addVehicleTrain;
        private System.Windows.Forms.Button removeVehicle;
        private System.Windows.Forms.Button dailyProfitShow;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}