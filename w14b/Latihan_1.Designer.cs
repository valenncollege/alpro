namespace Tugas_W14B_Jevon_Valentino_160424066
{
    partial class Latihan_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaMhs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNilaiUts = new System.Windows.Forms.NumericUpDown();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNilaiUts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // txtNamaMhs
            // 
            this.txtNamaMhs.Location = new System.Drawing.Point(146, 49);
            this.txtNamaMhs.Name = "txtNamaMhs";
            this.txtNamaMhs.Size = new System.Drawing.Size(236, 20);
            this.txtNamaMhs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai UTS";
            // 
            // nudNilaiUts
            // 
            this.nudNilaiUts.Location = new System.Drawing.Point(146, 87);
            this.nudNilaiUts.Name = "nudNilaiUts";
            this.nudNilaiUts.Size = new System.Drawing.Size(120, 20);
            this.nudNilaiUts.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(64, 153);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(92, 31);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(183, 153);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(92, 31);
            this.btnTampil.TabIndex = 5;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(302, 153);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(92, 31);
            this.btnLaporan.TabIndex = 6;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(36, 212);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(387, 199);
            this.lstOut.TabIndex = 7;
            // 
            // Latihan_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.nudNilaiUts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaMhs);
            this.Controls.Add(this.label1);
            this.Name = "Latihan_1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNilaiUts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaMhs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNilaiUts;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.ListBox lstOut;
    }
}

