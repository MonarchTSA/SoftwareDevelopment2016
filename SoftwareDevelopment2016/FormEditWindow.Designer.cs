namespace SoftwareDevelopment2016
{
    partial class FormEditWindow
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
            this.labelXMin = new System.Windows.Forms.Label();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelYMin = new System.Windows.Forms.Label();
            this.labelYMax = new System.Windows.Forms.Label();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMax = new System.Windows.Forms.NumericUpDown();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelXMin
            // 
            this.labelXMin.AutoSize = true;
            this.labelXMin.Location = new System.Drawing.Point(32, 46);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(58, 13);
            this.labelXMin.TabIndex = 0;
            this.labelXMin.Text = "X Minimum";
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.Location = new System.Drawing.Point(127, 42);
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownXMin.TabIndex = 1;
            this.numericUpDownXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(32, 72);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(61, 13);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "X Maximum";
            // 
            // labelYMin
            // 
            this.labelYMin.AutoSize = true;
            this.labelYMin.Location = new System.Drawing.Point(32, 98);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(58, 13);
            this.labelYMin.TabIndex = 3;
            this.labelYMin.Text = "Y Minimum";
            // 
            // labelYMax
            // 
            this.labelYMax.AutoSize = true;
            this.labelYMax.Location = new System.Drawing.Point(32, 124);
            this.labelYMax.Name = "labelYMax";
            this.labelYMax.Size = new System.Drawing.Size(61, 13);
            this.labelYMax.TabIndex = 4;
            this.labelYMax.Text = "Y Maximum";
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.Location = new System.Drawing.Point(127, 68);
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownXMax.TabIndex = 5;
            this.numericUpDownXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownYMin
            // 
            this.numericUpDownYMin.Location = new System.Drawing.Point(127, 96);
            this.numericUpDownYMin.Name = "numericUpDownYMin";
            this.numericUpDownYMin.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownYMin.TabIndex = 6;
            this.numericUpDownYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownYMax
            // 
            this.numericUpDownYMax.Location = new System.Drawing.Point(127, 122);
            this.numericUpDownYMax.Name = "numericUpDownYMax";
            this.numericUpDownYMax.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownYMax.TabIndex = 7;
            this.numericUpDownYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(35, 156);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 8;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(127, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit the window:";
            // 
            // FormEditWindow
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(237, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.numericUpDownYMax);
            this.Controls.Add(this.numericUpDownYMin);
            this.Controls.Add(this.numericUpDownXMax);
            this.Controls.Add(this.labelYMax);
            this.Controls.Add(this.labelYMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.numericUpDownXMin);
            this.Controls.Add(this.labelXMin);
            this.Name = "FormEditWindow";
            this.Text = "FormEditWindow";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelYMax;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.NumericUpDown numericUpDownYMin;
        private System.Windows.Forms.NumericUpDown numericUpDownYMax;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
    }
}