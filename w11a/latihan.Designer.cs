namespace Tugas_W11A_Jevon_Valentino_160424066
{
    partial class DigitalFarm
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
            this.gbFarmCreation = new System.Windows.Forms.GroupBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.txtFarmWidth = new System.Windows.Forms.TextBox();
            this.txtFarmLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlantOnCoordinates = new System.Windows.Forms.Button();
            this.cmbPlantName = new System.Windows.Forms.ComboBox();
            this.cmbWidthPos = new System.Windows.Forms.ComboBox();
            this.cmbLengthPos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoTotalProfit = new System.Windows.Forms.RadioButton();
            this.rdoEstimatedSales = new System.Windows.Forms.RadioButton();
            this.rdoRequiredFunds = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoWholeFarmlands = new System.Windows.Forms.RadioButton();
            this.rdoEachColumns = new System.Windows.Forms.RadioButton();
            this.rdoEachRows = new System.Windows.Forms.RadioButton();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbFarmCreation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm Length";
            // 
            // gbFarmCreation
            // 
            this.gbFarmCreation.Controls.Add(this.btnInitialize);
            this.gbFarmCreation.Controls.Add(this.txtFarmWidth);
            this.gbFarmCreation.Controls.Add(this.txtFarmLength);
            this.gbFarmCreation.Controls.Add(this.label2);
            this.gbFarmCreation.Controls.Add(this.label1);
            this.gbFarmCreation.Location = new System.Drawing.Point(40, 27);
            this.gbFarmCreation.Name = "gbFarmCreation";
            this.gbFarmCreation.Size = new System.Drawing.Size(214, 201);
            this.gbFarmCreation.TabIndex = 1;
            this.gbFarmCreation.TabStop = false;
            this.gbFarmCreation.Text = "Farm Creation";
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(29, 161);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(100, 23);
            this.btnInitialize.TabIndex = 4;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // txtFarmWidth
            // 
            this.txtFarmWidth.Location = new System.Drawing.Point(29, 124);
            this.txtFarmWidth.Name = "txtFarmWidth";
            this.txtFarmWidth.Size = new System.Drawing.Size(100, 20);
            this.txtFarmWidth.TabIndex = 3;
            // 
            // txtFarmLength
            // 
            this.txtFarmLength.Location = new System.Drawing.Point(29, 65);
            this.txtFarmLength.Name = "txtFarmLength";
            this.txtFarmLength.Size = new System.Drawing.Size(100, 20);
            this.txtFarmLength.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Farm Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlantOnCoordinates);
            this.groupBox2.Controls.Add(this.cmbPlantName);
            this.groupBox2.Controls.Add(this.cmbWidthPos);
            this.groupBox2.Controls.Add(this.cmbLengthPos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(294, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plant";
            // 
            // btnPlantOnCoordinates
            // 
            this.btnPlantOnCoordinates.Location = new System.Drawing.Point(185, 152);
            this.btnPlantOnCoordinates.Name = "btnPlantOnCoordinates";
            this.btnPlantOnCoordinates.Size = new System.Drawing.Size(121, 23);
            this.btnPlantOnCoordinates.TabIndex = 6;
            this.btnPlantOnCoordinates.Text = "Plant on Coordinates";
            this.btnPlantOnCoordinates.UseVisualStyleBackColor = true;
            this.btnPlantOnCoordinates.Click += new System.EventHandler(this.btnPlantOnCoordinates_Click);
            // 
            // cmbPlantName
            // 
            this.cmbPlantName.FormattingEnabled = true;
            this.cmbPlantName.Items.AddRange(new object[] {
            "Tanah",
            "Padi",
            "Cabai",
            "Gandum",
            "Jagung"});
            this.cmbPlantName.Location = new System.Drawing.Point(185, 95);
            this.cmbPlantName.Name = "cmbPlantName";
            this.cmbPlantName.Size = new System.Drawing.Size(121, 21);
            this.cmbPlantName.TabIndex = 5;
            // 
            // cmbWidthPos
            // 
            this.cmbWidthPos.FormattingEnabled = true;
            this.cmbWidthPos.Location = new System.Drawing.Point(16, 111);
            this.cmbWidthPos.Name = "cmbWidthPos";
            this.cmbWidthPos.Size = new System.Drawing.Size(121, 21);
            this.cmbWidthPos.TabIndex = 4;
            // 
            // cmbLengthPos
            // 
            this.cmbLengthPos.FormattingEnabled = true;
            this.cmbLengthPos.Location = new System.Drawing.Point(16, 64);
            this.cmbLengthPos.Name = "cmbLengthPos";
            this.cmbLengthPos.Size = new System.Drawing.Size(121, 21);
            this.cmbLengthPos.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plant Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Width Pos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length Pos.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoTotalProfit);
            this.groupBox3.Controls.Add(this.rdoEstimatedSales);
            this.groupBox3.Controls.Add(this.rdoRequiredFunds);
            this.groupBox3.Location = new System.Drawing.Point(648, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Type";
            // 
            // rdoTotalProfit
            // 
            this.rdoTotalProfit.AutoSize = true;
            this.rdoTotalProfit.Location = new System.Drawing.Point(21, 76);
            this.rdoTotalProfit.Name = "rdoTotalProfit";
            this.rdoTotalProfit.Size = new System.Drawing.Size(76, 17);
            this.rdoTotalProfit.TabIndex = 2;
            this.rdoTotalProfit.TabStop = true;
            this.rdoTotalProfit.Text = "Total Profit";
            this.rdoTotalProfit.UseVisualStyleBackColor = true;
            // 
            // rdoEstimatedSales
            // 
            this.rdoEstimatedSales.AutoSize = true;
            this.rdoEstimatedSales.Location = new System.Drawing.Point(21, 53);
            this.rdoEstimatedSales.Name = "rdoEstimatedSales";
            this.rdoEstimatedSales.Size = new System.Drawing.Size(100, 17);
            this.rdoEstimatedSales.TabIndex = 1;
            this.rdoEstimatedSales.TabStop = true;
            this.rdoEstimatedSales.Text = "Estimated Sales";
            this.rdoEstimatedSales.UseVisualStyleBackColor = true;
            // 
            // rdoRequiredFunds
            // 
            this.rdoRequiredFunds.AutoSize = true;
            this.rdoRequiredFunds.Location = new System.Drawing.Point(21, 30);
            this.rdoRequiredFunds.Name = "rdoRequiredFunds";
            this.rdoRequiredFunds.Size = new System.Drawing.Size(100, 17);
            this.rdoRequiredFunds.TabIndex = 0;
            this.rdoRequiredFunds.TabStop = true;
            this.rdoRequiredFunds.Text = "Required Funds";
            this.rdoRequiredFunds.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoWholeFarmlands);
            this.groupBox4.Controls.Add(this.rdoEachColumns);
            this.groupBox4.Controls.Add(this.rdoEachRows);
            this.groupBox4.Location = new System.Drawing.Point(657, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 135);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Source";
            // 
            // rdoWholeFarmlands
            // 
            this.rdoWholeFarmlands.AutoSize = true;
            this.rdoWholeFarmlands.Location = new System.Drawing.Point(34, 80);
            this.rdoWholeFarmlands.Name = "rdoWholeFarmlands";
            this.rdoWholeFarmlands.Size = new System.Drawing.Size(107, 17);
            this.rdoWholeFarmlands.TabIndex = 2;
            this.rdoWholeFarmlands.TabStop = true;
            this.rdoWholeFarmlands.Text = "Whole Farmlands";
            this.rdoWholeFarmlands.UseVisualStyleBackColor = true;
            // 
            // rdoEachColumns
            // 
            this.rdoEachColumns.AutoSize = true;
            this.rdoEachColumns.Location = new System.Drawing.Point(34, 57);
            this.rdoEachColumns.Name = "rdoEachColumns";
            this.rdoEachColumns.Size = new System.Drawing.Size(93, 17);
            this.rdoEachColumns.TabIndex = 1;
            this.rdoEachColumns.TabStop = true;
            this.rdoEachColumns.Text = "Each Columns";
            this.rdoEachColumns.UseVisualStyleBackColor = true;
            // 
            // rdoEachRows
            // 
            this.rdoEachRows.AutoSize = true;
            this.rdoEachRows.Location = new System.Drawing.Point(34, 34);
            this.rdoEachRows.Name = "rdoEachRows";
            this.rdoEachRows.Size = new System.Drawing.Size(80, 17);
            this.rdoEachRows.TabIndex = 0;
            this.rdoEachRows.TabStop = true;
            this.rdoEachRows.Text = "Each Rows";
            this.rdoEachRows.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(40, 257);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(581, 238);
            this.lstDisplay.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(657, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 86);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // DigitalFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFarmCreation);
            this.Name = "DigitalFarm";
            this.Text = "Digital Farm";
            this.gbFarmCreation.ResumeLayout(false);
            this.gbFarmCreation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFarmCreation;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.TextBox txtFarmWidth;
        private System.Windows.Forms.TextBox txtFarmLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlantOnCoordinates;
        private System.Windows.Forms.ComboBox cmbPlantName;
        private System.Windows.Forms.ComboBox cmbWidthPos;
        private System.Windows.Forms.ComboBox cmbLengthPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoTotalProfit;
        private System.Windows.Forms.RadioButton rdoEstimatedSales;
        private System.Windows.Forms.RadioButton rdoRequiredFunds;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoWholeFarmlands;
        private System.Windows.Forms.RadioButton rdoEachColumns;
        private System.Windows.Forms.RadioButton rdoEachRows;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnCalculate;
    }
}

