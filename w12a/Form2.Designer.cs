namespace Tugas_W12A_Jevon_Valentino_160424066
{
    partial class Form2
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOut1 = new System.Windows.Forms.ListBox();
            this.btnFibo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(166, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(72, 20);
            this.txtInput.TabIndex = 13;
            // 
            // lstOut1
            // 
            this.lstOut1.FormattingEnabled = true;
            this.lstOut1.Location = new System.Drawing.Point(132, 151);
            this.lstOut1.Name = "lstOut1";
            this.lstOut1.Size = new System.Drawing.Size(120, 95);
            this.lstOut1.TabIndex = 12;
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(132, 75);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(137, 23);
            this.btnFibo.TabIndex = 11;
            this.btnFibo.Text = "Get Fibonacci";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "All Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstOut1);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOut1;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}