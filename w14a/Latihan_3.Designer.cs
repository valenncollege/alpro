namespace Tugas_W14A_Jevon_Valentino_160424066
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
            this.txtTotalBelanja = new System.Windows.Forms.TextBox();
            this.gbPaidMethod = new System.Windows.Forms.GroupBox();
            this.rdoCredit = new System.Windows.Forms.RadioButton();
            this.rdoOvo = new System.Windows.Forms.RadioButton();
            this.rdoGopay = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.gbPaidMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Payment :";
            // 
            // txtTotalBelanja
            // 
            this.txtTotalBelanja.Location = new System.Drawing.Point(153, 74);
            this.txtTotalBelanja.Name = "txtTotalBelanja";
            this.txtTotalBelanja.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBelanja.TabIndex = 1;
            // 
            // gbPaidMethod
            // 
            this.gbPaidMethod.Controls.Add(this.rdoCash);
            this.gbPaidMethod.Controls.Add(this.rdoGopay);
            this.gbPaidMethod.Controls.Add(this.rdoOvo);
            this.gbPaidMethod.Controls.Add(this.rdoCredit);
            this.gbPaidMethod.Location = new System.Drawing.Point(69, 124);
            this.gbPaidMethod.Name = "gbPaidMethod";
            this.gbPaidMethod.Size = new System.Drawing.Size(157, 140);
            this.gbPaidMethod.TabIndex = 2;
            this.gbPaidMethod.TabStop = false;
            this.gbPaidMethod.Text = "Paid Method";
            // 
            // rdoCredit
            // 
            this.rdoCredit.AutoSize = true;
            this.rdoCredit.Checked = true;
            this.rdoCredit.Location = new System.Drawing.Point(37, 34);
            this.rdoCredit.Name = "rdoCredit";
            this.rdoCredit.Size = new System.Drawing.Size(77, 17);
            this.rdoCredit.TabIndex = 0;
            this.rdoCredit.TabStop = true;
            this.rdoCredit.Text = "Credit Card";
            this.rdoCredit.UseVisualStyleBackColor = true;
            // 
            // rdoOvo
            // 
            this.rdoOvo.AutoSize = true;
            this.rdoOvo.Location = new System.Drawing.Point(37, 57);
            this.rdoOvo.Name = "rdoOvo";
            this.rdoOvo.Size = new System.Drawing.Size(48, 17);
            this.rdoOvo.TabIndex = 1;
            this.rdoOvo.TabStop = true;
            this.rdoOvo.Text = "OVO";
            this.rdoOvo.UseVisualStyleBackColor = true;
            // 
            // rdoGopay
            // 
            this.rdoGopay.AutoSize = true;
            this.rdoGopay.Location = new System.Drawing.Point(37, 80);
            this.rdoGopay.Name = "rdoGopay";
            this.rdoGopay.Size = new System.Drawing.Size(56, 17);
            this.rdoGopay.TabIndex = 2;
            this.rdoGopay.TabStop = true;
            this.rdoGopay.Text = "Gopay";
            this.rdoGopay.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(37, 103);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(49, 17);
            this.rdoCash.TabIndex = 3;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(293, 136);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(238, 121);
            this.lstOut.TabIndex = 3;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(151, 270);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 4;
            this.btnProses.Text = "Process";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // Latihan_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.gbPaidMethod);
            this.Controls.Add(this.txtTotalBelanja);
            this.Controls.Add(this.label1);
            this.Name = "Latihan_3";
            this.Text = "Latihan_3";
            this.gbPaidMethod.ResumeLayout(false);
            this.gbPaidMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalBelanja;
        private System.Windows.Forms.GroupBox gbPaidMethod;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoGopay;
        private System.Windows.Forms.RadioButton rdoOvo;
        private System.Windows.Forms.RadioButton rdoCredit;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnProses;
    }
}