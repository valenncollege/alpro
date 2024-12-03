namespace Tugas_W13A_Jevon_Valentino_160424066
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.txtInputC = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // txtInputA
            // 
            this.txtInputA.Location = new System.Drawing.Point(162, 65);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(100, 20);
            this.txtInputA.TabIndex = 3;
            // 
            // txtInputB
            // 
            this.txtInputB.Location = new System.Drawing.Point(162, 110);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(100, 20);
            this.txtInputB.TabIndex = 4;
            // 
            // txtInputC
            // 
            this.txtInputC.Location = new System.Drawing.Point(162, 150);
            this.txtInputC.Name = "txtInputC";
            this.txtInputC.Size = new System.Drawing.Size(100, 20);
            this.txtInputC.TabIndex = 5;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(324, 63);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(428, 62);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(325, 129);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 8;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(428, 128);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(321, 193);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(30, 13);
            this.lblHasil.TabIndex = 10;
            this.lblHasil.Text = "Hasil";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // Latihan_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtInputC);
            this.Controls.Add(this.txtInputB);
            this.Controls.Add(this.txtInputA);
            this.Controls.Add(this.label1);
            this.Name = "Latihan_2";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.TextBox txtInputC;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}