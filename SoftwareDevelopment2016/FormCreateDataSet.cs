﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment2016
{
    public partial class FormCreateDataSet : Form
    {
        public FormCreateDataSet()
        {
            InitializeComponent();
            DataSetName = "";
            Labeled = false;
        }

        public String DataSetName { get; set; }
        public bool Labeled { get; set; }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Done")
            {
                if (textBoxName.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                    DataSetName = textBoxName.Text;
                    Labeled = checkBoxLabel.CheckState == CheckState.Checked ? true : false;
                }
                else
                {
                    MessageBox.Show("Please enter a name.");
                }
            } 
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}