namespace Tugas_W10B_Jevon_Valentino_160424066
{
    partial class latihan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.nudJumlahTugas = new System.Windows.Forms.NumericUpDown();
            this.nudJumlahMhs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInputTugas = new System.Windows.Forms.ComboBox();
            this.cmbInputMhs = new System.Windows.Forms.ComboBox();
            this.nudInputNilai = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoRataRata = new System.Windows.Forms.RadioButton();
            this.rdoTertinggi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoTugas = new System.Windows.Forms.RadioButton();
            this.rdoMhs = new System.Windows.Forms.RadioButton();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahMhs)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputNilai)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.nudJumlahTugas);
            this.groupBox1.Controls.Add(this.nudJumlahMhs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input jumlah mhs dan tugas";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(27, 127);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // nudJumlahTugas
            // 
            this.nudJumlahTugas.Location = new System.Drawing.Point(114, 80);
            this.nudJumlahTugas.Name = "nudJumlahTugas";
            this.nudJumlahTugas.Size = new System.Drawing.Size(68, 20);
            this.nudJumlahTugas.TabIndex = 3;
            // 
            // nudJumlahMhs
            // 
            this.nudJumlahMhs.Location = new System.Drawing.Point(114, 44);
            this.nudJumlahMhs.Name = "nudJumlahMhs";
            this.nudJumlahMhs.Size = new System.Drawing.Size(68, 20);
            this.nudJumlahMhs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tugas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mhs";
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(377, 61);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(262, 251);
            this.lstOut.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbInputTugas);
            this.groupBox2.Controls.Add(this.cmbInputMhs);
            this.groupBox2.Controls.Add(this.nudInputNilai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(55, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputkan nilai tugas mhs";
            // 
            // cmbInputTugas
            // 
            this.cmbInputTugas.FormattingEnabled = true;
            this.cmbInputTugas.Location = new System.Drawing.Point(98, 75);
            this.cmbInputTugas.Name = "cmbInputTugas";
            this.cmbInputTugas.Size = new System.Drawing.Size(75, 21);
            this.cmbInputTugas.TabIndex = 8;
            // 
            // cmbInputMhs
            // 
            this.cmbInputMhs.FormattingEnabled = true;
            this.cmbInputMhs.Location = new System.Drawing.Point(98, 36);
            this.cmbInputMhs.Name = "cmbInputMhs";
            this.cmbInputMhs.Size = new System.Drawing.Size(75, 21);
            this.cmbInputMhs.TabIndex = 7;
            // 
            // nudInputNilai
            // 
            this.nudInputNilai.Location = new System.Drawing.Point(98, 118);
            this.nudInputNilai.Name = "nudInputNilai";
            this.nudInputNilai.Size = new System.Drawing.Size(75, 20);
            this.nudInputNilai.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nilai";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(27, 157);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tugas ke -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mhs ke-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoRataRata);
            this.groupBox3.Controls.Add(this.rdoTertinggi);
            this.groupBox3.Location = new System.Drawing.Point(55, 471);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // rdoRataRata
            // 
            this.rdoRataRata.AutoSize = true;
            this.rdoRataRata.Location = new System.Drawing.Point(17, 61);
            this.rdoRataRata.Name = "rdoRataRata";
            this.rdoRataRata.Size = new System.Drawing.Size(69, 17);
            this.rdoRataRata.TabIndex = 1;
            this.rdoRataRata.TabStop = true;
            this.rdoRataRata.Text = "Rata-rata";
            this.rdoRataRata.UseVisualStyleBackColor = true;
            // 
            // rdoTertinggi
            // 
            this.rdoTertinggi.AutoSize = true;
            this.rdoTertinggi.Location = new System.Drawing.Point(17, 38);
            this.rdoTertinggi.Name = "rdoTertinggi";
            this.rdoTertinggi.Size = new System.Drawing.Size(66, 17);
            this.rdoTertinggi.TabIndex = 0;
            this.rdoTertinggi.TabStop = true;
            this.rdoTertinggi.Text = "Tertinggi";
            this.rdoTertinggi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoTugas);
            this.groupBox4.Controls.Add(this.rdoMhs);
            this.groupBox4.Location = new System.Drawing.Point(238, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // rdoTugas
            // 
            this.rdoTugas.AutoSize = true;
            this.rdoTugas.Location = new System.Drawing.Point(20, 61);
            this.rdoTugas.Name = "rdoTugas";
            this.rdoTugas.Size = new System.Drawing.Size(55, 17);
            this.rdoTugas.TabIndex = 1;
            this.rdoTugas.TabStop = true;
            this.rdoTugas.Text = "Tugas";
            this.rdoTugas.UseVisualStyleBackColor = true;
            // 
            // rdoMhs
            // 
            this.rdoMhs.AutoSize = true;
            this.rdoMhs.Location = new System.Drawing.Point(20, 38);
            this.rdoMhs.Name = "rdoMhs";
            this.rdoMhs.Size = new System.Drawing.Size(45, 17);
            this.rdoMhs.TabIndex = 0;
            this.rdoMhs.TabStop = true;
            this.rdoMhs.Text = "Mhs";
            this.rdoMhs.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(437, 457);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(75, 23);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(437, 509);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahMhs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputNilai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.NumericUpDown nudJumlahTugas;
        private System.Windows.Forms.NumericUpDown nudJumlahMhs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoRataRata;
        private System.Windows.Forms.RadioButton rdoTertinggi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudInputNilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoTugas;
        private System.Windows.Forms.RadioButton rdoMhs;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ComboBox cmbInputTugas;
        private System.Windows.Forms.ComboBox cmbInputMhs;
    }
}

