namespace Tugas_W10A_Jevon_Valentino_160424066
{
    partial class latihan_5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNRP = new System.Windows.Forms.TextBox();
            this.nudNTS = new System.Windows.Forms.NumericUpDown();
            this.nudNAS = new System.Windows.Forms.NumericUpDown();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnTampilNTS = new System.Windows.Forms.Button();
            this.btnTampilNAS = new System.Windows.Forms.Button();
            this.btnTdkLulus = new System.Windows.Forms.Button();
            this.btnTertinggi = new System.Windows.Forms.Button();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnNisbi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNAS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NRP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NTS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAS :";
            // 
            // txtNRP
            // 
            this.txtNRP.Location = new System.Drawing.Point(156, 39);
            this.txtNRP.Name = "txtNRP";
            this.txtNRP.Size = new System.Drawing.Size(148, 20);
            this.txtNRP.TabIndex = 3;
            // 
            // nudNTS
            // 
            this.nudNTS.Location = new System.Drawing.Point(156, 67);
            this.nudNTS.Name = "nudNTS";
            this.nudNTS.Size = new System.Drawing.Size(148, 20);
            this.nudNTS.TabIndex = 4;
            // 
            // nudNAS
            // 
            this.nudNAS.Location = new System.Drawing.Point(156, 93);
            this.nudNAS.Name = "nudNAS";
            this.nudNAS.Size = new System.Drawing.Size(148, 20);
            this.nudNAS.TabIndex = 5;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(74, 142);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(536, 186);
            this.lstOut.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(364, 39);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(364, 74);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 8;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnTampilNTS
            // 
            this.btnTampilNTS.Location = new System.Drawing.Point(465, 39);
            this.btnTampilNTS.Name = "btnTampilNTS";
            this.btnTampilNTS.Size = new System.Drawing.Size(75, 23);
            this.btnTampilNTS.TabIndex = 9;
            this.btnTampilNTS.Text = "Tampil NTS";
            this.btnTampilNTS.UseVisualStyleBackColor = true;
            this.btnTampilNTS.Click += new System.EventHandler(this.btnTampilNTS_Click);
            // 
            // btnTampilNAS
            // 
            this.btnTampilNAS.Location = new System.Drawing.Point(465, 74);
            this.btnTampilNAS.Name = "btnTampilNAS";
            this.btnTampilNAS.Size = new System.Drawing.Size(75, 23);
            this.btnTampilNAS.TabIndex = 10;
            this.btnTampilNAS.Text = "Tampil NAS";
            this.btnTampilNAS.UseVisualStyleBackColor = true;
            this.btnTampilNAS.Click += new System.EventHandler(this.btnTampilNAS_Click);
            // 
            // btnTdkLulus
            // 
            this.btnTdkLulus.Location = new System.Drawing.Point(560, 39);
            this.btnTdkLulus.Name = "btnTdkLulus";
            this.btnTdkLulus.Size = new System.Drawing.Size(75, 23);
            this.btnTdkLulus.TabIndex = 11;
            this.btnTdkLulus.Text = "Tidak Lulus";
            this.btnTdkLulus.UseVisualStyleBackColor = true;
            this.btnTdkLulus.Click += new System.EventHandler(this.btnTdkLulus_Click);
            // 
            // btnTertinggi
            // 
            this.btnTertinggi.Location = new System.Drawing.Point(560, 73);
            this.btnTertinggi.Name = "btnTertinggi";
            this.btnTertinggi.Size = new System.Drawing.Size(75, 23);
            this.btnTertinggi.TabIndex = 12;
            this.btnTertinggi.Text = "Tertinggi";
            this.btnTertinggi.UseVisualStyleBackColor = true;
            this.btnTertinggi.Click += new System.EventHandler(this.btnTertinggi_Click);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(651, 73);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 13;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnNisbi
            // 
            this.btnNisbi.Location = new System.Drawing.Point(651, 39);
            this.btnNisbi.Name = "btnNisbi";
            this.btnNisbi.Size = new System.Drawing.Size(75, 23);
            this.btnNisbi.TabIndex = 14;
            this.btnNisbi.Text = "Nisbi";
            this.btnNisbi.UseVisualStyleBackColor = true;
            this.btnNisbi.Click += new System.EventHandler(this.btnNisbi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(650, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // latihan_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNisbi);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.btnTertinggi);
            this.Controls.Add(this.btnTdkLulus);
            this.Controls.Add(this.btnTampilNAS);
            this.Controls.Add(this.btnTampilNTS);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.nudNAS);
            this.Controls.Add(this.nudNTS);
            this.Controls.Add(this.txtNRP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "latihan_5";
            this.Text = "Perkuliahan";
            ((System.ComponentModel.ISupportInitialize)(this.nudNTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNRP;
        private System.Windows.Forms.NumericUpDown nudNTS;
        private System.Windows.Forms.NumericUpDown nudNAS;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnTampilNTS;
        private System.Windows.Forms.Button btnTampilNAS;
        private System.Windows.Forms.Button btnTdkLulus;
        private System.Windows.Forms.Button btnTertinggi;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnNisbi;
        private System.Windows.Forms.Button btnExit;
    }
}