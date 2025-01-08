namespace Tugas_W14B_Jevon_Valentino_160424066
{
    partial class Latihan_2
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
            this.rdoKelvin = new System.Windows.Forms.RadioButton();
            this.rdoFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoReamur = new System.Windows.Forms.RadioButton();
            this.rdoCelcius = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnTampilSuhu = new System.Windows.Forms.Button();
            this.btnTampilSemua = new System.Windows.Forms.Button();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.txtSuhu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoKelvin);
            this.groupBox1.Controls.Add(this.rdoFahrenheit);
            this.groupBox1.Controls.Add(this.rdoReamur);
            this.groupBox1.Controls.Add(this.rdoCelcius);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 92);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konversi Suhu";
            // 
            // rdoKelvin
            // 
            this.rdoKelvin.AutoSize = true;
            this.rdoKelvin.Location = new System.Drawing.Point(515, 45);
            this.rdoKelvin.Name = "rdoKelvin";
            this.rdoKelvin.Size = new System.Drawing.Size(79, 28);
            this.rdoKelvin.TabIndex = 3;
            this.rdoKelvin.Text = "Kelvin";
            this.rdoKelvin.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheit
            // 
            this.rdoFahrenheit.AutoSize = true;
            this.rdoFahrenheit.Location = new System.Drawing.Point(161, 45);
            this.rdoFahrenheit.Name = "rdoFahrenheit";
            this.rdoFahrenheit.Size = new System.Drawing.Size(119, 28);
            this.rdoFahrenheit.TabIndex = 2;
            this.rdoFahrenheit.Text = "Fahrenheit";
            this.rdoFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdoReamur
            // 
            this.rdoReamur.AutoSize = true;
            this.rdoReamur.Location = new System.Drawing.Point(336, 45);
            this.rdoReamur.Name = "rdoReamur";
            this.rdoReamur.Size = new System.Drawing.Size(95, 28);
            this.rdoReamur.TabIndex = 1;
            this.rdoReamur.Text = "Reamur";
            this.rdoReamur.UseVisualStyleBackColor = true;
            // 
            // rdoCelcius
            // 
            this.rdoCelcius.AutoSize = true;
            this.rdoCelcius.Checked = true;
            this.rdoCelcius.Location = new System.Drawing.Point(23, 45);
            this.rdoCelcius.Name = "rdoCelcius";
            this.rdoCelcius.Size = new System.Drawing.Size(90, 28);
            this.rdoCelcius.TabIndex = 0;
            this.rdoCelcius.TabStop = true;
            this.rdoCelcius.Text = "Celcius";
            this.rdoCelcius.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(469, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 32);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 24;
            this.lstOut.Location = new System.Drawing.Point(79, 239);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(640, 316);
            this.lstOut.TabIndex = 44;
            // 
            // btnTampilSuhu
            // 
            this.btnTampilSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilSuhu.Location = new System.Drawing.Point(329, 122);
            this.btnTampilSuhu.Name = "btnTampilSuhu";
            this.btnTampilSuhu.Size = new System.Drawing.Size(134, 33);
            this.btnTampilSuhu.TabIndex = 43;
            this.btnTampilSuhu.Text = "Tampil Suhu";
            this.btnTampilSuhu.UseVisualStyleBackColor = true;
            this.btnTampilSuhu.Click += new System.EventHandler(this.btnTampilSuhu_Click);
            // 
            // btnTampilSemua
            // 
            this.btnTampilSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilSemua.Location = new System.Drawing.Point(179, 122);
            this.btnTampilSemua.Name = "btnTampilSemua";
            this.btnTampilSemua.Size = new System.Drawing.Size(144, 33);
            this.btnTampilSemua.TabIndex = 42;
            this.btnTampilSemua.Text = "Tampil Semua";
            this.btnTampilSemua.UseVisualStyleBackColor = true;
            this.btnTampilSemua.Click += new System.EventHandler(this.btnTampilSemua_Click);
            // 
            // btnKonversi
            // 
            this.btnKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonversi.Location = new System.Drawing.Point(79, 123);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(94, 33);
            this.btnKonversi.TabIndex = 41;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // txtSuhu
            // 
            this.txtSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuhu.Location = new System.Drawing.Point(223, -35);
            this.txtSuhu.Name = "txtSuhu";
            this.txtSuhu.Size = new System.Drawing.Size(100, 29);
            this.txtSuhu.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Suhu (Celcius)";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcius.Location = new System.Drawing.Point(218, 184);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 29);
            this.txtCelcius.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Suhu (Celcius)";
            // 
            // Latihan_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnTampilSuhu);
            this.Controls.Add(this.btnTampilSemua);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtSuhu);
            this.Controls.Add(this.label2);
            this.Name = "Latihan_2";
            this.Text = "Latihan_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoKelvin;
        private System.Windows.Forms.RadioButton rdoFahrenheit;
        private System.Windows.Forms.RadioButton rdoReamur;
        private System.Windows.Forms.RadioButton rdoCelcius;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnTampilSuhu;
        private System.Windows.Forms.Button btnTampilSemua;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.TextBox txtSuhu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Label label1;
    }
}