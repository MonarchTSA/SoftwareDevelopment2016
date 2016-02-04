namespace SoftwareDevelopment2016
{
    partial class FormEditPlot
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
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.labelShape = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEditPlots = new System.Windows.Forms.Label();
            this.colorSamplePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(44, 56);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(34, 13);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "Color:";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(130, 51);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Pick color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.OnButtonColorClick);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(44, 91);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size:";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "Diamond"});
            this.comboBoxShapes.Location = new System.Drawing.Point(101, 123);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(104, 21);
            this.comboBoxShapes.TabIndex = 4;
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Location = new System.Drawing.Point(44, 126);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(41, 13);
            this.labelShape.TabIndex = 5;
            this.labelShape.Text = "Shape:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(101, 89);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownSize.TabIndex = 6;
            this.numericUpDownSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonDone
            // 
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDone.Location = new System.Drawing.Point(47, 161);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.OnButonClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(130, 161);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelEditPlots
            // 
            this.labelEditPlots.AutoSize = true;
            this.labelEditPlots.Location = new System.Drawing.Point(67, 21);
            this.labelEditPlots.Name = "labelEditPlots";
            this.labelEditPlots.Size = new System.Drawing.Size(115, 13);
            this.labelEditPlots.TabIndex = 9;
            this.labelEditPlots.Text = "Edit the plot properties:";
            // 
            // colorSamplePanel
            // 
            this.colorSamplePanel.BackColor = System.Drawing.SystemColors.Window;
            this.colorSamplePanel.Location = new System.Drawing.Point(101, 51);
            this.colorSamplePanel.Name = "colorSamplePanel";
            this.colorSamplePanel.Size = new System.Drawing.Size(23, 23);
            this.colorSamplePanel.TabIndex = 10;
            // 
            // FormEditPlot
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(248, 204);
            this.Controls.Add(this.colorSamplePanel);
            this.Controls.Add(this.labelEditPlots);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEditPlot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit plot";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelEditPlots;
        private System.Windows.Forms.Panel colorSamplePanel;
    }
}