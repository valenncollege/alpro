namespace Tugas_W13B_Jevon_Valentino_160424066
{
    partial class Latihan_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnAboveAverage = new System.Windows.Forms.Button();
            this.btnUnder55 = new System.Windows.Forms.Button();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mark:";
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(121, 23);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(100, 20);
            this.txtNilai.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.txtNilai);
            this.gbList.Controls.Add(this.label2);
            this.gbList.Controls.Add(this.btnSave);
            this.gbList.Location = new System.Drawing.Point(53, 45);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(255, 92);
            this.gbList.TabIndex = 4;
            this.gbList.TabStop = false;
            this.gbList.Text = "List of Student Mark";
            // 
            // btnAboveAverage
            // 
            this.btnAboveAverage.Location = new System.Drawing.Point(81, 165);
            this.btnAboveAverage.Name = "btnAboveAverage";
            this.btnAboveAverage.Size = new System.Drawing.Size(75, 50);
            this.btnAboveAverage.TabIndex = 5;
            this.btnAboveAverage.Text = "Above Average";
            this.btnAboveAverage.UseVisualStyleBackColor = true;
            this.btnAboveAverage.Click += new System.EventHandler(this.btnAboveAverage_Click);
            // 
            // btnUnder55
            // 
            this.btnUnder55.Location = new System.Drawing.Point(208, 165);
            this.btnUnder55.Name = "btnUnder55";
            this.btnUnder55.Size = new System.Drawing.Size(75, 50);
            this.btnUnder55.TabIndex = 6;
            this.btnUnder55.Text = "Under Mark 55";
            this.btnUnder55.UseVisualStyleBackColor = true;
            this.btnUnder55.Click += new System.EventHandler(this.btnUnder55_Click);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(81, 226);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(227, 199);
            this.lstOut.TabIndex = 7;
            // 
            // Latihan_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.btnUnder55);
            this.Controls.Add(this.btnAboveAverage);
            this.Controls.Add(this.gbList);
            this.Name = "Latihan_7";
            this.Text = "Latihan_7";
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnAboveAverage;
        private System.Windows.Forms.Button btnUnder55;
        private System.Windows.Forms.ListBox lstOut;
    }
}