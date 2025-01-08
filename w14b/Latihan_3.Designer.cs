namespace Tugas_W14B_Jevon_Valentino_160424066
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGopay = new System.Windows.Forms.RadioButton();
            this.rdoOvo = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.btnRedisplay = new System.Windows.Forms.Button();
            this.txtJumMieAyam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJumBakso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGopay);
            this.groupBox1.Controls.Add(this.rdoOvo);
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 181);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Pembayaran";
            // 
            // rdoGopay
            // 
            this.rdoGopay.AutoSize = true;
            this.rdoGopay.Location = new System.Drawing.Point(33, 125);
            this.rdoGopay.Name = "rdoGopay";
            this.rdoGopay.Size = new System.Drawing.Size(83, 28);
            this.rdoGopay.TabIndex = 2;
            this.rdoGopay.Text = "Gopay";
            this.rdoGopay.UseVisualStyleBackColor = true;
            // 
            // rdoOvo
            // 
            this.rdoOvo.AutoSize = true;
            this.rdoOvo.Location = new System.Drawing.Point(33, 85);
            this.rdoOvo.Name = "rdoOvo";
            this.rdoOvo.Size = new System.Drawing.Size(63, 28);
            this.rdoOvo.TabIndex = 1;
            this.rdoOvo.Text = "Ovo";
            this.rdoOvo.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Checked = true;
            this.rdoCash.Location = new System.Drawing.Point(33, 45);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(71, 28);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // btnRedisplay
            // 
            this.btnRedisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedisplay.Location = new System.Drawing.Point(123, 345);
            this.btnRedisplay.Name = "btnRedisplay";
            this.btnRedisplay.Size = new System.Drawing.Size(117, 33);
            this.btnRedisplay.TabIndex = 55;
            this.btnRedisplay.Text = "Redisplay";
            this.btnRedisplay.UseVisualStyleBackColor = true;
            this.btnRedisplay.Click += new System.EventHandler(this.btnRedisplay_Click);
            // 
            // txtJumMieAyam
            // 
            this.txtJumMieAyam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumMieAyam.Location = new System.Drawing.Point(172, 96);
            this.txtJumMieAyam.Name = "txtJumMieAyam";
            this.txtJumMieAyam.Size = new System.Drawing.Size(100, 29);
            this.txtJumMieAyam.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Jumlah mie ayam";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(172, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 29);
            this.txtName.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nama Pelanggan";
            // 
            // txtJumBakso
            // 
            this.txtJumBakso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumBakso.Location = new System.Drawing.Point(172, 61);
            this.txtJumBakso.Name = "txtJumBakso";
            this.txtJumBakso.Size = new System.Drawing.Size(100, 29);
            this.txtJumBakso.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Jumlah Bakso";
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 24;
            this.lstOut.Location = new System.Drawing.Point(412, 26);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(557, 412);
            this.lstOut.TabIndex = 59;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(23, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 32);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(123, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 32);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(246, 346);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 33);
            this.btnReport.TabIndex = 56;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(23, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // Latihan_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRedisplay);
            this.Controls.Add(this.txtJumMieAyam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJumBakso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdd);
            this.Name = "Latihan_3";
            this.Text = "Latihan_3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGopay;
        private System.Windows.Forms.RadioButton rdoOvo;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.Button btnRedisplay;
        private System.Windows.Forms.TextBox txtJumMieAyam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJumBakso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAdd;
    }
}