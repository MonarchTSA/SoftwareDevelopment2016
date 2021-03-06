﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopment2016
{
    public partial class FormCreateDataSet : Form
    {
        public FormCreateDataSet(string name)
        {
            InitializeComponent();
            textBoxName.Text = name;
            DataSetName = name;
        }

        public String DataSetName { get; set; }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text == "Done")
            {
                if (textBoxName.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                    DataSetName = textBoxName.Text;
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Please enter a name.");
                }
            } 
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
