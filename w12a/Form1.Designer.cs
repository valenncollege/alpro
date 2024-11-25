namespace Tugas_W12A_Jevon_Valentino_160424066
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstOut1 = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSeparate = new System.Windows.Forms.Button();
            this.lstEven = new System.Windows.Forms.ListBox();
            this.lstOdd = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Numbers";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstOut1
            // 
            this.lstOut1.FormattingEnabled = true;
            this.lstOut1.Location = new System.Drawing.Point(61, 174);
            this.lstOut1.Name = "lstOut1";
            this.lstOut1.Size = new System.Drawing.Size(120, 95);
            this.lstOut1.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(95, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(72, 20);
            this.txtInput.TabIndex = 8;
            // 
            // btnSeparate
            // 
            this.btnSeparate.Location = new System.Drawing.Point(220, 99);
            this.btnSeparate.Name = "btnSeparate";
            this.btnSeparate.Size = new System.Drawing.Size(126, 23);
            this.btnSeparate.TabIndex = 11;
            this.btnSeparate.Text = "Separate Numbers";
            this.btnSeparate.UseVisualStyleBackColor = true;
            this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
            // 
            // lstEven
            // 
            this.lstEven.FormattingEnabled = true;
            this.lstEven.Location = new System.Drawing.Point(220, 174);
            this.lstEven.Name = "lstEven";
            this.lstEven.Size = new System.Drawing.Size(57, 95);
            this.lstEven.TabIndex = 14;
            // 
            // lstOdd
            // 
            this.lstOdd.FormattingEnabled = true;
            this.lstOdd.Location = new System.Drawing.Point(289, 174);
            this.lstOdd.Name = "lstOdd";
            this.lstOdd.Size = new System.Drawing.Size(57, 95);
            this.lstOdd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Even";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Odd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstOdd);
            this.Controls.Add(this.lstEven);
            this.Controls.Add(this.btnSeparate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstOut1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstOut1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSeparate;
        private System.Windows.Forms.ListBox lstEven;
        private System.Windows.Forms.ListBox lstOdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

