namespace Tugas_W12A_Jevon_Valentino_160424066
{
    partial class Form3
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
            this.nudKamar = new System.Windows.Forms.NumericUpDown();
            this.nudLantai = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLantai = new System.Windows.Forms.ComboBox();
            this.cmbKamar = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCIn = new System.Windows.Forms.Button();
            this.btnCOut = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLantai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah kamar = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah lantai = ";
            // 
            // nudKamar
            // 
            this.nudKamar.Location = new System.Drawing.Point(91, 31);
            this.nudKamar.Name = "nudKamar";
            this.nudKamar.Size = new System.Drawing.Size(62, 20);
            this.nudKamar.TabIndex = 2;
            // 
            // nudLantai
            // 
            this.nudLantai.Location = new System.Drawing.Point(91, 65);
            this.nudLantai.Name = "nudLantai";
            this.nudLantai.Size = new System.Drawing.Size(62, 20);
            this.nudLantai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Lantai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. Kamar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nama";
            // 
            // cmbLantai
            // 
            this.cmbLantai.FormattingEnabled = true;
            this.cmbLantai.Location = new System.Drawing.Point(145, 129);
            this.cmbLantai.Name = "cmbLantai";
            this.cmbLantai.Size = new System.Drawing.Size(62, 21);
            this.cmbLantai.TabIndex = 7;
            // 
            // cmbKamar
            // 
            this.cmbKamar.FormattingEnabled = true;
            this.cmbKamar.Location = new System.Drawing.Point(145, 160);
            this.cmbKamar.Name = "cmbKamar";
            this.cmbKamar.Size = new System.Drawing.Size(62, 21);
            this.cmbKamar.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(145, 196);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(62, 20);
            this.txtNama.TabIndex = 9;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(176, 41);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 10;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCIn
            // 
            this.btnCIn.Location = new System.Drawing.Point(48, 241);
            this.btnCIn.Name = "btnCIn";
            this.btnCIn.Size = new System.Drawing.Size(75, 23);
            this.btnCIn.TabIndex = 11;
            this.btnCIn.Text = "Check in";
            this.btnCIn.UseVisualStyleBackColor = true;
            // 
            // btnCOut
            // 
            this.btnCOut.Location = new System.Drawing.Point(145, 241);
            this.btnCOut.Name = "btnCOut";
            this.btnCOut.Size = new System.Drawing.Size(75, 23);
            this.btnCOut.TabIndex = 12;
            this.btnCOut.Text = "Check out";
            this.btnCOut.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(249, 241);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(75, 23);
            this.btnLaporan.TabIndex = 13;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(343, 38);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(380, 238);
            this.lstOut.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.nudKamar);
            this.groupBox1.Controls.Add(this.nudLantai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnCOut);
            this.Controls.Add(this.btnCIn);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cmbKamar);
            this.Controls.Add(this.cmbLantai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.nudKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLantai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKamar;
        private System.Windows.Forms.NumericUpDown nudLantai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLantai;
        private System.Windows.Forms.ComboBox cmbKamar;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnCIn;
        private System.Windows.Forms.Button btnCOut;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}