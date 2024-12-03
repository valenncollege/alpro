namespace Tugas_W13A_Jevon_Valentino_160424066
{
    partial class Latihan_3
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
            this.nudTanggal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKartu = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal";
            // 
            // nudTanggal
            // 
            this.nudTanggal.Location = new System.Drawing.Point(205, 36);
            this.nudTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTanggal.Name = "nudTanggal";
            this.nudTanggal.Size = new System.Drawing.Size(53, 20);
            this.nudTanggal.TabIndex = 1;
            this.nudTanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nominal Belanja";
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(138, 87);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(120, 20);
            this.txtNominal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kartu";
            // 
            // cmbKartu
            // 
            this.cmbKartu.FormattingEnabled = true;
            this.cmbKartu.Items.AddRange(new object[] {
            "SIlver",
            "Gold",
            "(Non member)"});
            this.cmbKartu.Location = new System.Drawing.Point(137, 127);
            this.cmbKartu.Name = "cmbKartu";
            this.cmbKartu.Size = new System.Drawing.Size(121, 21);
            this.cmbKartu.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(51, 182);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(183, 60);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(325, 47);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(228, 186);
            this.lstOut.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(577, 47);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Latihan_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbKartu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTanggal);
            this.Controls.Add(this.label1);
            this.Name = "Latihan_3";
            this.Text = "Departemen Store";
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKartu;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnExit;
    }
}