namespace Tugas_W9B_Jevon_Valentino_160424066
{
    partial class Latihan_A
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
            this.lblNilaiInput = new System.Windows.Forms.Label();
            this.nudNilai = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnRatarata = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNilaiInput
            // 
            this.lblNilaiInput.AutoSize = true;
            this.lblNilaiInput.Location = new System.Drawing.Point(87, 66);
            this.lblNilaiInput.Name = "lblNilaiInput";
            this.lblNilaiInput.Size = new System.Drawing.Size(116, 13);
            this.lblNilaiInput.TabIndex = 0;
            this.lblNilaiInput.Text = "Input Nilai Mahasiswa :";
            // 
            // nudNilai
            // 
            this.nudNilai.Location = new System.Drawing.Point(361, 64);
            this.nudNilai.Name = "nudNilai";
            this.nudNilai.Size = new System.Drawing.Size(120, 20);
            this.nudNilai.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(406, 115);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(90, 188);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 3;
            this.btnTampil.Text = "TAMPIL";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnRatarata
            // 
            this.btnRatarata.Location = new System.Drawing.Point(205, 188);
            this.btnRatarata.Name = "btnRatarata";
            this.btnRatarata.Size = new System.Drawing.Size(75, 23);
            this.btnRatarata.TabIndex = 4;
            this.btnRatarata.Text = "RATA2";
            this.btnRatarata.UseVisualStyleBackColor = true;
            this.btnRatarata.Click += new System.EventHandler(this.btnRatarata_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(314, 188);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(406, 188);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(90, 236);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(391, 108);
            this.lstHasil.TabIndex = 7;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(406, 377);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "KELUAR";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(287, 377);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(75, 23);
            this.btnLaporan.TabIndex = 9;
            this.btnLaporan.Text = "LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(90, 377);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Latihan_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnRatarata);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.nudNilai);
            this.Controls.Add(this.lblNilaiInput);
            this.Name = "Latihan_A";
            this.Text = "Nilai Mahasiswa";
            this.Load += new System.EventHandler(this.Latihan_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNilaiInput;
        private System.Windows.Forms.NumericUpDown nudNilai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnRatarata;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.ListBox lstHasil;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnSort;
    }
}

