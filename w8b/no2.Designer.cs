namespace Latihan_W8B
{
    partial class no2
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.cmbKota = new System.Windows.Forms.ComboBox();
            this.boxPendidikan = new System.Windows.Forms.GroupBox();
            this.rdoDoktor = new System.Windows.Forms.RadioButton();
            this.rdoMagister = new System.Windows.Forms.RadioButton();
            this.rdoSarjana = new System.Windows.Forms.RadioButton();
            this.boxBidang = new System.Windows.Forms.GroupBox();
            this.cbMultimedia = new System.Windows.Forms.CheckBox();
            this.cbStatistics = new System.Windows.Forms.CheckBox();
            this.cbGameDev = new System.Windows.Forms.CheckBox();
            this.cbEnterprise = new System.Windows.Forms.CheckBox();
            this.cbITManage = new System.Windows.Forms.CheckBox();
            this.cbDataAnalytics = new System.Windows.Forms.CheckBox();
            this.cbSoftwareEngine = new System.Windows.Forms.CheckBox();
            this.cbMachineLearning = new System.Windows.Forms.CheckBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsia = new System.Windows.Forms.Label();
            this.nudUsia = new System.Windows.Forms.NumericUpDown();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.boxPendidikan.SuspendLayout();
            this.boxBidang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(82, 41);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(41, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(85, 68);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(316, 20);
            this.txtNama.TabIndex = 1;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(82, 109);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(58, 13);
            this.lblKota.TabIndex = 2;
            this.lblKota.Text = "Kota Asal :";
            // 
            // cmbKota
            // 
            this.cmbKota.FormattingEnabled = true;
            this.cmbKota.Items.AddRange(new object[] {
            "Surabaya",
            "Malang",
            "Jakarta",
            "Yogyakarta",
            "Medan",
            "Makassar"});
            this.cmbKota.Location = new System.Drawing.Point(85, 141);
            this.cmbKota.Name = "cmbKota";
            this.cmbKota.Size = new System.Drawing.Size(316, 21);
            this.cmbKota.TabIndex = 3;
            this.cmbKota.Text = "--Pilih Kota Asal--";
            this.cmbKota.SelectedIndexChanged += new System.EventHandler(this.cmbKota_SelectedIndexChanged);
            // 
            // boxPendidikan
            // 
            this.boxPendidikan.Controls.Add(this.rdoDoktor);
            this.boxPendidikan.Controls.Add(this.rdoMagister);
            this.boxPendidikan.Controls.Add(this.rdoSarjana);
            this.boxPendidikan.Location = new System.Drawing.Point(85, 193);
            this.boxPendidikan.Name = "boxPendidikan";
            this.boxPendidikan.Size = new System.Drawing.Size(316, 56);
            this.boxPendidikan.TabIndex = 4;
            this.boxPendidikan.TabStop = false;
            this.boxPendidikan.Text = "Pendidikan Terakhir :";
            // 
            // rdoDoktor
            // 
            this.rdoDoktor.AutoSize = true;
            this.rdoDoktor.Location = new System.Drawing.Point(171, 20);
            this.rdoDoktor.Name = "rdoDoktor";
            this.rdoDoktor.Size = new System.Drawing.Size(57, 17);
            this.rdoDoktor.TabIndex = 5;
            this.rdoDoktor.TabStop = true;
            this.rdoDoktor.Text = "Doktor";
            this.rdoDoktor.UseVisualStyleBackColor = true;
            // 
            // rdoMagister
            // 
            this.rdoMagister.AutoSize = true;
            this.rdoMagister.Location = new System.Drawing.Point(84, 20);
            this.rdoMagister.Name = "rdoMagister";
            this.rdoMagister.Size = new System.Drawing.Size(65, 17);
            this.rdoMagister.TabIndex = 1;
            this.rdoMagister.TabStop = true;
            this.rdoMagister.Text = "Magister";
            this.rdoMagister.UseVisualStyleBackColor = true;
            // 
            // rdoSarjana
            // 
            this.rdoSarjana.AutoSize = true;
            this.rdoSarjana.Location = new System.Drawing.Point(6, 19);
            this.rdoSarjana.Name = "rdoSarjana";
            this.rdoSarjana.Size = new System.Drawing.Size(61, 17);
            this.rdoSarjana.TabIndex = 0;
            this.rdoSarjana.TabStop = true;
            this.rdoSarjana.Text = "Sarjana";
            this.rdoSarjana.UseVisualStyleBackColor = true;
            // 
            // boxBidang
            // 
            this.boxBidang.Controls.Add(this.cbMultimedia);
            this.boxBidang.Controls.Add(this.cbStatistics);
            this.boxBidang.Controls.Add(this.cbGameDev);
            this.boxBidang.Controls.Add(this.cbEnterprise);
            this.boxBidang.Controls.Add(this.cbITManage);
            this.boxBidang.Controls.Add(this.cbDataAnalytics);
            this.boxBidang.Controls.Add(this.cbSoftwareEngine);
            this.boxBidang.Controls.Add(this.cbMachineLearning);
            this.boxBidang.Location = new System.Drawing.Point(85, 290);
            this.boxBidang.Name = "boxBidang";
            this.boxBidang.Size = new System.Drawing.Size(316, 188);
            this.boxBidang.TabIndex = 5;
            this.boxBidang.TabStop = false;
            this.boxBidang.Text = "Bidang Keahlian";
            // 
            // cbMultimedia
            // 
            this.cbMultimedia.AutoSize = true;
            this.cbMultimedia.Location = new System.Drawing.Point(148, 154);
            this.cbMultimedia.Name = "cbMultimedia";
            this.cbMultimedia.Size = new System.Drawing.Size(111, 17);
            this.cbMultimedia.TabIndex = 7;
            this.cbMultimedia.Text = "Multimedia Editing";
            this.cbMultimedia.UseVisualStyleBackColor = true;
            // 
            // cbStatistics
            // 
            this.cbStatistics.AutoSize = true;
            this.cbStatistics.Location = new System.Drawing.Point(6, 154);
            this.cbStatistics.Name = "cbStatistics";
            this.cbStatistics.Size = new System.Drawing.Size(68, 17);
            this.cbStatistics.TabIndex = 6;
            this.cbStatistics.Text = "Statistics";
            this.cbStatistics.UseVisualStyleBackColor = true;
            // 
            // cbGameDev
            // 
            this.cbGameDev.AutoSize = true;
            this.cbGameDev.Location = new System.Drawing.Point(148, 118);
            this.cbGameDev.Name = "cbGameDev";
            this.cbGameDev.Size = new System.Drawing.Size(120, 17);
            this.cbGameDev.TabIndex = 5;
            this.cbGameDev.Text = "Game Development";
            this.cbGameDev.UseVisualStyleBackColor = true;
            // 
            // cbEnterprise
            // 
            this.cbEnterprise.AutoSize = true;
            this.cbEnterprise.Location = new System.Drawing.Point(148, 78);
            this.cbEnterprise.Name = "cbEnterprise";
            this.cbEnterprise.Size = new System.Drawing.Size(110, 17);
            this.cbEnterprise.TabIndex = 4;
            this.cbEnterprise.Text = "Enterprise System";
            this.cbEnterprise.UseVisualStyleBackColor = true;
            // 
            // cbITManage
            // 
            this.cbITManage.AutoSize = true;
            this.cbITManage.Location = new System.Drawing.Point(148, 37);
            this.cbITManage.Name = "cbITManage";
            this.cbITManage.Size = new System.Drawing.Size(101, 17);
            this.cbITManage.TabIndex = 3;
            this.cbITManage.Text = "IT Management";
            this.cbITManage.UseVisualStyleBackColor = true;
            this.cbITManage.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbDataAnalytics
            // 
            this.cbDataAnalytics.AutoSize = true;
            this.cbDataAnalytics.Location = new System.Drawing.Point(6, 118);
            this.cbDataAnalytics.Name = "cbDataAnalytics";
            this.cbDataAnalytics.Size = new System.Drawing.Size(94, 17);
            this.cbDataAnalytics.TabIndex = 2;
            this.cbDataAnalytics.Text = "Data Analytics";
            this.cbDataAnalytics.UseVisualStyleBackColor = true;
            // 
            // cbSoftwareEngine
            // 
            this.cbSoftwareEngine.AutoSize = true;
            this.cbSoftwareEngine.Location = new System.Drawing.Point(6, 78);
            this.cbSoftwareEngine.Name = "cbSoftwareEngine";
            this.cbSoftwareEngine.Size = new System.Drawing.Size(127, 17);
            this.cbSoftwareEngine.TabIndex = 1;
            this.cbSoftwareEngine.Text = "Software Engineering";
            this.cbSoftwareEngine.UseVisualStyleBackColor = true;
            // 
            // cbMachineLearning
            // 
            this.cbMachineLearning.AutoSize = true;
            this.cbMachineLearning.Location = new System.Drawing.Point(6, 37);
            this.cbMachineLearning.Name = "cbMachineLearning";
            this.cbMachineLearning.Size = new System.Drawing.Size(111, 17);
            this.cbMachineLearning.TabIndex = 0;
            this.cbMachineLearning.Text = "Machine Learning";
            this.cbMachineLearning.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(85, 500);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(316, 42);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // lblUsia
            // 
            this.lblUsia.AutoSize = true;
            this.lblUsia.Location = new System.Drawing.Point(535, 109);
            this.lblUsia.Name = "lblUsia";
            this.lblUsia.Size = new System.Drawing.Size(34, 13);
            this.lblUsia.TabIndex = 8;
            this.lblUsia.Text = "Usia :";
            // 
            // nudUsia
            // 
            this.nudUsia.Location = new System.Drawing.Point(538, 141);
            this.nudUsia.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudUsia.Name = "nudUsia";
            this.nudUsia.Size = new System.Drawing.Size(120, 20);
            this.nudUsia.TabIndex = 9;
            this.nudUsia.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(475, 241);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(352, 238);
            this.lstHasil.TabIndex = 10;
            this.lstHasil.SelectedIndexChanged += new System.EventHandler(this.lstHasil_SelectedIndexChanged);
            // 
            // no2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 607);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.nudUsia);
            this.Controls.Add(this.lblUsia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.boxBidang);
            this.Controls.Add(this.boxPendidikan);
            this.Controls.Add(this.cmbKota);
            this.Controls.Add(this.lblKota);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Name = "no2";
            this.Text = "Sistem Administrasi Lulusan";
            this.Load += new System.EventHandler(this.no2_Load);
            this.boxPendidikan.ResumeLayout(false);
            this.boxPendidikan.PerformLayout();
            this.boxBidang.ResumeLayout(false);
            this.boxBidang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.ComboBox cmbKota;
        private System.Windows.Forms.GroupBox boxPendidikan;
        private System.Windows.Forms.RadioButton rdoDoktor;
        private System.Windows.Forms.RadioButton rdoMagister;
        private System.Windows.Forms.RadioButton rdoSarjana;
        private System.Windows.Forms.GroupBox boxBidang;
        private System.Windows.Forms.CheckBox cbGameDev;
        private System.Windows.Forms.CheckBox cbEnterprise;
        private System.Windows.Forms.CheckBox cbITManage;
        private System.Windows.Forms.CheckBox cbDataAnalytics;
        private System.Windows.Forms.CheckBox cbSoftwareEngine;
        private System.Windows.Forms.CheckBox cbMachineLearning;
        private System.Windows.Forms.CheckBox cbMultimedia;
        private System.Windows.Forms.CheckBox cbStatistics;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsia;
        private System.Windows.Forms.NumericUpDown nudUsia;
        private System.Windows.Forms.ListBox lstHasil;
    }
}