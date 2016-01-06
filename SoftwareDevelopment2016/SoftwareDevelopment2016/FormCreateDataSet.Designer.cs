namespace SoftwareDevelopment2016
{
    partial class FormCreateDataSet
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
            this.components = new System.ComponentModel.Container();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxLabel = new System.Windows.Forms.CheckBox();
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterName
            // 
            this.labelEnterName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(19, 9);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(153, 13);
            this.labelEnterName.TabIndex = 0;
            this.labelEnterName.Text = "Enter the name of the data set:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(30, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Location = new System.Drawing.Point(58, 66);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLabel.TabIndex = 2;
            this.checkBoxLabel.Text = "Labled set";
            this.toolTipLabel.SetToolTip(this.checkBoxLabel, "Use this if you need to create a bar graph. For example:\r\nDogs: 5\r\nCats: 3\r\nRabbi" +
        "ts: 2");
            this.checkBoxLabel.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(17, 89);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(98, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonClick);
            // 
            // FormCreateDataSet
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(191, 125);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.checkBoxLabel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEnterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(207, 164);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(207, 164);
            this.Name = "FormCreateDataSet";
            this.Text = "Create data set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxLabel;
        private System.Windows.Forms.ToolTip toolTipLabel;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
    }
}