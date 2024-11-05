namespace Latihan_W8B
{
    partial class no1
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
            this.lblKota = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rdoPria = new System.Windows.Forms.RadioButton();
            this.rdoWanita = new System.Windows.Forms.RadioButton();
            this.cmbKota = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.boxJenisKelamin = new System.Windows.Forms.GroupBox();
            this.boxJenisKelamin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(106, 45);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(41, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama :";
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(106, 134);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(58, 13);
            this.lblKota.TabIndex = 1;
            this.lblKota.Text = "Kota Asal :";
            this.lblKota.Click += new System.EventHandler(this.lblKota_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(109, 76);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(313, 20);
            this.txtNama.TabIndex = 2;
            // 
            // rdoPria
            // 
            this.rdoPria.AutoSize = true;
            this.rdoPria.Location = new System.Drawing.Point(6, 32);
            this.rdoPria.Name = "rdoPria";
            this.rdoPria.Size = new System.Drawing.Size(43, 17);
            this.rdoPria.TabIndex = 5;
            this.rdoPria.TabStop = true;
            this.rdoPria.Text = "Pria";
            this.rdoPria.UseVisualStyleBackColor = true;
            this.rdoPria.CheckedChanged += new System.EventHandler(this.rdoPria_CheckedChanged);
            // 
            // rdoWanita
            // 
            this.rdoWanita.AutoSize = true;
            this.rdoWanita.Location = new System.Drawing.Point(116, 32);
            this.rdoWanita.Name = "rdoWanita";
            this.rdoWanita.Size = new System.Drawing.Size(59, 17);
            this.rdoWanita.TabIndex = 6;
            this.rdoWanita.TabStop = true;
            this.rdoWanita.Text = "Wanita";
            this.rdoWanita.UseVisualStyleBackColor = true;
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
            this.cmbKota.Location = new System.Drawing.Point(109, 169);
            this.cmbKota.Name = "cmbKota";
            this.cmbKota.Size = new System.Drawing.Size(313, 21);
            this.cmbKota.TabIndex = 7;
            this.cmbKota.Text = "Pilih Kota Asal";
            this.cmbKota.SelectedIndexChanged += new System.EventHandler(this.cmbKota_SelectedIndexChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(109, 361);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(313, 37);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // boxJenisKelamin
            // 
            this.boxJenisKelamin.Controls.Add(this.rdoWanita);
            this.boxJenisKelamin.Controls.Add(this.rdoPria);
            this.boxJenisKelamin.Location = new System.Drawing.Point(109, 217);
            this.boxJenisKelamin.Name = "boxJenisKelamin";
            this.boxJenisKelamin.Size = new System.Drawing.Size(313, 84);
            this.boxJenisKelamin.TabIndex = 9;
            this.boxJenisKelamin.TabStop = false;
            this.boxJenisKelamin.Text = "Jenis Kelamin";
            this.boxJenisKelamin.Enter += new System.EventHandler(this.boxJenisKelamin_Enter);
            // 
            // no1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxJenisKelamin);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbKota);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblKota);
            this.Controls.Add(this.lblNama);
            this.Name = "no1";
            this.Text = "Sistem Survey";
            this.boxJenisKelamin.ResumeLayout(false);
            this.boxJenisKelamin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rdoPria;
        private System.Windows.Forms.RadioButton rdoWanita;
        private System.Windows.Forms.ComboBox cmbKota;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox boxJenisKelamin;
    }
}

