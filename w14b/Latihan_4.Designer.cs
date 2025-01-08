namespace Tugas_W14B_Jevon_Valentino_160424066
{
    partial class Latihan_4
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDrSpesialis = new System.Windows.Forms.RadioButton();
            this.rdoDrGigi = new System.Windows.Forms.RadioButton();
            this.rdoDrUmum = new System.Windows.Forms.RadioButton();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.txtBiayaLain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(55, 302);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(120, 37);
            this.btnTambah.TabIndex = 23;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDrSpesialis);
            this.groupBox1.Controls.Add(this.rdoDrGigi);
            this.groupBox1.Controls.Add(this.rdoDrUmum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 180);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biaya jasa dokter";
            // 
            // rdoDrSpesialis
            // 
            this.rdoDrSpesialis.AutoSize = true;
            this.rdoDrSpesialis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDrSpesialis.Location = new System.Drawing.Point(22, 136);
            this.rdoDrSpesialis.Name = "rdoDrSpesialis";
            this.rdoDrSpesialis.Size = new System.Drawing.Size(243, 28);
            this.rdoDrSpesialis.TabIndex = 2;
            this.rdoDrSpesialis.Text = "Dr. Spesialis (Rp 45.000,-)";
            this.rdoDrSpesialis.UseVisualStyleBackColor = true;
            // 
            // rdoDrGigi
            // 
            this.rdoDrGigi.AutoSize = true;
            this.rdoDrGigi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDrGigi.Location = new System.Drawing.Point(22, 88);
            this.rdoDrGigi.Name = "rdoDrGigi";
            this.rdoDrGigi.Size = new System.Drawing.Size(202, 28);
            this.rdoDrGigi.TabIndex = 1;
            this.rdoDrGigi.Text = "Dr. Gigi (Rp 40.000,-)";
            this.rdoDrGigi.UseVisualStyleBackColor = true;
            // 
            // rdoDrUmum
            // 
            this.rdoDrUmum.AutoSize = true;
            this.rdoDrUmum.Checked = true;
            this.rdoDrUmum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDrUmum.Location = new System.Drawing.Point(22, 40);
            this.rdoDrUmum.Name = "rdoDrUmum";
            this.rdoDrUmum.Size = new System.Drawing.Size(225, 28);
            this.rdoDrUmum.TabIndex = 0;
            this.rdoDrUmum.TabStop = true;
            this.rdoDrUmum.Text = "Dr. Umum (Rp 30.000,-)";
            this.rdoDrUmum.UseVisualStyleBackColor = true;
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPasien.Location = new System.Drawing.Point(181, 17);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(321, 29);
            this.txtNamaPasien.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama pasien";
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 24;
            this.lstOut.Location = new System.Drawing.Point(54, 351);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(448, 244);
            this.lstOut.TabIndex = 26;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(297, 302);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(131, 37);
            this.btnLaporan.TabIndex = 25;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.Location = new System.Drawing.Point(181, 302);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(110, 37);
            this.btnTampil.TabIndex = 24;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // txtBiayaLain
            // 
            this.txtBiayaLain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiayaLain.Location = new System.Drawing.Point(232, 258);
            this.txtBiayaLain.Name = "txtBiayaLain";
            this.txtBiayaLain.Size = new System.Drawing.Size(270, 29);
            this.txtBiayaLain.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Biaya lain-lain (Rp)";
            // 
            // Latihan_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 612);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.txtBiayaLain);
            this.Controls.Add(this.label2);
            this.Name = "Latihan_4";
            this.Text = "Latihan_4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDrSpesialis;
        private System.Windows.Forms.RadioButton rdoDrGigi;
        private System.Windows.Forms.RadioButton rdoDrUmum;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.TextBox txtBiayaLain;
        private System.Windows.Forms.Label label2;
    }
}