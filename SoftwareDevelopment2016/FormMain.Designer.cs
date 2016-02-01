using System;

namespace SoftwareDevelopment2016
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlot = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDataSets = new System.Windows.Forms.ComboBox();
            this.plotBox = new System.Windows.Forms.GroupBox();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelStdDev = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelMedian = new System.Windows.Forms.Label();
            this.labelMean = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.numericUpDownOrder = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPlotRegression = new System.Windows.Forms.CheckBox();
            this.checkBoxPlotPoints = new System.Windows.Forms.CheckBox();
            this.divider2 = new System.Windows.Forms.Label();
            this.divider3 = new System.Windows.Forms.Label();
            this.divider4 = new System.Windows.Forms.Label();
            this.divider5 = new System.Windows.Forms.Label();
            this.divider6 = new System.Windows.Forms.Label();
            this.divider7 = new System.Windows.Forms.Label();
            this.divider8 = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.labelDomainText = new System.Windows.Forms.Label();
            this.labelRangeText = new System.Windows.Forms.Label();
            this.labelStdDevText = new System.Windows.Forms.Label();
            this.labelModeText = new System.Windows.Forms.Label();
            this.labelMedianText = new System.Windows.Forms.Label();
            this.labelMeanText = new System.Windows.Forms.Label();
            this.buttonCreateDataSet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.plotBox.SuspendLayout();
            this.dataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.plotToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNew);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnFileOpen);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSave);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPlotsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.exportPlotToolStripMenuItem});
            this.plotToolStripMenuItem.Enabled = false;
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.plotToolStripMenuItem.Text = "&Plot";
            // 
            // editPlotsToolStripMenuItem
            // 
            this.editPlotsToolStripMenuItem.Name = "editPlotsToolStripMenuItem";
            this.editPlotsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editPlotsToolStripMenuItem.Text = "Edit &Plots";
            this.editPlotsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.editPlotsToolStripMenuItem.Click += new System.EventHandler(this.OnEditPlots);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.windowToolStripMenuItem.Text = "Edit &Window";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.OnEditWindow);
            // 
            // exportPlotToolStripMenuItem
            // 
            this.exportPlotToolStripMenuItem.Name = "exportPlotToolStripMenuItem";
            this.exportPlotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportPlotToolStripMenuItem.Text = "E&xport Plot";
            this.exportPlotToolStripMenuItem.Click += new System.EventHandler(this.OnExportPlot);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // panelPlot
            // 
            this.panelPlot.BackColor = System.Drawing.SystemColors.Window;
            this.panelPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlot.Location = new System.Drawing.Point(33, 24);
            this.panelPlot.Name = "panelPlot";
            this.panelPlot.Size = new System.Drawing.Size(225, 225);
            this.panelPlot.TabIndex = 5;
            this.panelPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPlot);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(6, 46);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(209, 221);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdit);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyPress);
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            // 
            // comboBoxDataSets
            // 
            this.comboBoxDataSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataSets.Enabled = false;
            this.comboBoxDataSets.FormattingEnabled = true;
            this.comboBoxDataSets.Location = new System.Drawing.Point(6, 19);
            this.comboBoxDataSets.Name = "comboBoxDataSets";
            this.comboBoxDataSets.Size = new System.Drawing.Size(104, 21);
            this.comboBoxDataSets.TabIndex = 7;
            this.comboBoxDataSets.SelectionChangeCommitted += new System.EventHandler(this.OnDataSetChange);
            // 
            // plotBox
            // 
            this.plotBox.Controls.Add(this.panelPlot);
            this.plotBox.Location = new System.Drawing.Point(493, 38);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(290, 273);
            this.plotBox.TabIndex = 8;
            this.plotBox.TabStop = false;
            this.plotBox.Text = "Plot";
            // 
            // dataBox
            // 
            this.dataBox.Controls.Add(this.labelDomain);
            this.dataBox.Controls.Add(this.labelRange);
            this.dataBox.Controls.Add(this.labelStdDev);
            this.dataBox.Controls.Add(this.labelMode);
            this.dataBox.Controls.Add(this.labelMedian);
            this.dataBox.Controls.Add(this.labelMean);
            this.dataBox.Controls.Add(this.labelOrder);
            this.dataBox.Controls.Add(this.numericUpDownOrder);
            this.dataBox.Controls.Add(this.checkBoxPlotRegression);
            this.dataBox.Controls.Add(this.checkBoxPlotPoints);
            this.dataBox.Controls.Add(this.divider2);
            this.dataBox.Controls.Add(this.divider3);
            this.dataBox.Controls.Add(this.divider4);
            this.dataBox.Controls.Add(this.divider5);
            this.dataBox.Controls.Add(this.divider6);
            this.dataBox.Controls.Add(this.divider7);
            this.dataBox.Controls.Add(this.divider8);
            this.dataBox.Controls.Add(this.divider1);
            this.dataBox.Controls.Add(this.labelDomainText);
            this.dataBox.Controls.Add(this.labelRangeText);
            this.dataBox.Controls.Add(this.labelStdDevText);
            this.dataBox.Controls.Add(this.labelModeText);
            this.dataBox.Controls.Add(this.labelMedianText);
            this.dataBox.Controls.Add(this.labelMeanText);
            this.dataBox.Controls.Add(this.buttonCreateDataSet);
            this.dataBox.Controls.Add(this.dataGridView);
            this.dataBox.Controls.Add(this.comboBoxDataSets);
            this.dataBox.Location = new System.Drawing.Point(12, 38);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(475, 273);
            this.dataBox.TabIndex = 9;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Data";
            // 
            // labelDomain
            // 
            this.labelDomain.Enabled = false;
            this.labelDomain.Location = new System.Drawing.Point(352, 238);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(116, 13);
            this.labelDomain.TabIndex = 31;
            this.labelDomain.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRange
            // 
            this.labelRange.Enabled = false;
            this.labelRange.Location = new System.Drawing.Point(352, 203);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(116, 13);
            this.labelRange.TabIndex = 30;
            this.labelRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStdDev
            // 
            this.labelStdDev.Enabled = false;
            this.labelStdDev.Location = new System.Drawing.Point(352, 168);
            this.labelStdDev.Name = "labelStdDev";
            this.labelStdDev.Size = new System.Drawing.Size(116, 13);
            this.labelStdDev.TabIndex = 29;
            this.labelStdDev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMode
            // 
            this.labelMode.Enabled = false;
            this.labelMode.Location = new System.Drawing.Point(352, 133);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(116, 13);
            this.labelMode.TabIndex = 28;
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMedian
            // 
            this.labelMedian.Enabled = false;
            this.labelMedian.Location = new System.Drawing.Point(352, 98);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(116, 13);
            this.labelMedian.TabIndex = 27;
            this.labelMedian.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMean
            // 
            this.labelMean.Enabled = false;
            this.labelMean.Location = new System.Drawing.Point(352, 63);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(116, 13);
            this.labelMean.TabIndex = 26;
            this.labelMean.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Enabled = false;
            this.labelOrder.Location = new System.Drawing.Point(398, 22);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(36, 13);
            this.labelOrder.TabIndex = 10;
            this.labelOrder.Text = "Order:";
            // 
            // numericUpDownOrder
            // 
            this.numericUpDownOrder.Enabled = false;
            this.numericUpDownOrder.Location = new System.Drawing.Point(434, 20);
            this.numericUpDownOrder.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrder.Name = "numericUpDownOrder";
            this.numericUpDownOrder.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownOrder.TabIndex = 25;
            this.numericUpDownOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrder.ValueChanged += new System.EventHandler(this.OnOrderChange);
            // 
            // checkBoxPlotRegression
            // 
            this.checkBoxPlotRegression.AutoSize = true;
            this.checkBoxPlotRegression.Enabled = false;
            this.checkBoxPlotRegression.Location = new System.Drawing.Point(299, 21);
            this.checkBoxPlotRegression.Name = "checkBoxPlotRegression";
            this.checkBoxPlotRegression.Size = new System.Drawing.Size(95, 17);
            this.checkBoxPlotRegression.TabIndex = 24;
            this.checkBoxPlotRegression.Text = "Plot regression";
            this.checkBoxPlotRegression.UseVisualStyleBackColor = true;
            this.checkBoxPlotRegression.CheckedChanged += new System.EventHandler(this.OnRegressionCheckChange);
            // 
            // checkBoxPlotPoints
            // 
            this.checkBoxPlotPoints.AutoSize = true;
            this.checkBoxPlotPoints.Enabled = false;
            this.checkBoxPlotPoints.Location = new System.Drawing.Point(220, 21);
            this.checkBoxPlotPoints.Name = "checkBoxPlotPoints";
            this.checkBoxPlotPoints.Size = new System.Drawing.Size(75, 17);
            this.checkBoxPlotPoints.TabIndex = 10;
            this.checkBoxPlotPoints.Text = "Plot points";
            this.checkBoxPlotPoints.UseVisualStyleBackColor = true;
            this.checkBoxPlotPoints.CheckedChanged += new System.EventHandler(this.OnPlotCheckChange);
            // 
            // divider2
            // 
            this.divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider2.Enabled = false;
            this.divider2.Location = new System.Drawing.Point(220, 261);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(248, 2);
            this.divider2.TabIndex = 23;
            this.divider2.Text = "label8";
            // 
            // divider3
            // 
            this.divider3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider3.Enabled = false;
            this.divider3.Location = new System.Drawing.Point(221, 226);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(248, 2);
            this.divider3.TabIndex = 22;
            this.divider3.Text = "label7";
            // 
            // divider4
            // 
            this.divider4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider4.Enabled = false;
            this.divider4.Location = new System.Drawing.Point(221, 191);
            this.divider4.Name = "divider4";
            this.divider4.Size = new System.Drawing.Size(248, 2);
            this.divider4.TabIndex = 21;
            this.divider4.Text = "label6";
            // 
            // divider5
            // 
            this.divider5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider5.Enabled = false;
            this.divider5.Location = new System.Drawing.Point(221, 156);
            this.divider5.Name = "divider5";
            this.divider5.Size = new System.Drawing.Size(248, 2);
            this.divider5.TabIndex = 20;
            this.divider5.Text = "label5";
            // 
            // divider6
            // 
            this.divider6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider6.Enabled = false;
            this.divider6.Location = new System.Drawing.Point(221, 121);
            this.divider6.Name = "divider6";
            this.divider6.Size = new System.Drawing.Size(248, 2);
            this.divider6.TabIndex = 19;
            this.divider6.Text = "label4";
            // 
            // divider7
            // 
            this.divider7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider7.Enabled = false;
            this.divider7.Location = new System.Drawing.Point(221, 86);
            this.divider7.Name = "divider7";
            this.divider7.Size = new System.Drawing.Size(248, 2);
            this.divider7.TabIndex = 18;
            this.divider7.Text = "label3";
            // 
            // divider8
            // 
            this.divider8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider8.Enabled = false;
            this.divider8.Location = new System.Drawing.Point(221, 51);
            this.divider8.Name = "divider8";
            this.divider8.Size = new System.Drawing.Size(248, 2);
            this.divider8.TabIndex = 17;
            this.divider8.Text = "label2";
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Enabled = false;
            this.divider1.Location = new System.Drawing.Point(344, 51);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(2, 210);
            this.divider1.TabIndex = 16;
            this.divider1.Text = "label1";
            // 
            // labelDomainText
            // 
            this.labelDomainText.AutoSize = true;
            this.labelDomainText.Enabled = false;
            this.labelDomainText.Location = new System.Drawing.Point(224, 238);
            this.labelDomainText.Name = "labelDomainText";
            this.labelDomainText.Size = new System.Drawing.Size(49, 13);
            this.labelDomainText.TabIndex = 15;
            this.labelDomainText.Text = "Domain: ";
            // 
            // labelRangeText
            // 
            this.labelRangeText.AutoSize = true;
            this.labelRangeText.Enabled = false;
            this.labelRangeText.Location = new System.Drawing.Point(224, 203);
            this.labelRangeText.Name = "labelRangeText";
            this.labelRangeText.Size = new System.Drawing.Size(42, 13);
            this.labelRangeText.TabIndex = 14;
            this.labelRangeText.Text = "Range:";
            // 
            // labelStdDevText
            // 
            this.labelStdDevText.AutoSize = true;
            this.labelStdDevText.Enabled = false;
            this.labelStdDevText.Location = new System.Drawing.Point(224, 168);
            this.labelStdDevText.Name = "labelStdDevText";
            this.labelStdDevText.Size = new System.Drawing.Size(101, 13);
            this.labelStdDevText.TabIndex = 13;
            this.labelStdDevText.Text = "Standard Deviation:";
            // 
            // labelModeText
            // 
            this.labelModeText.AutoSize = true;
            this.labelModeText.Enabled = false;
            this.labelModeText.Location = new System.Drawing.Point(224, 133);
            this.labelModeText.Name = "labelModeText";
            this.labelModeText.Size = new System.Drawing.Size(40, 13);
            this.labelModeText.TabIndex = 12;
            this.labelModeText.Text = "Mode: ";
            // 
            // labelMedianText
            // 
            this.labelMedianText.AutoSize = true;
            this.labelMedianText.Enabled = false;
            this.labelMedianText.Location = new System.Drawing.Point(224, 98);
            this.labelMedianText.Name = "labelMedianText";
            this.labelMedianText.Size = new System.Drawing.Size(48, 13);
            this.labelMedianText.TabIndex = 11;
            this.labelMedianText.Text = "Median: ";
            // 
            // labelMeanText
            // 
            this.labelMeanText.AutoSize = true;
            this.labelMeanText.Enabled = false;
            this.labelMeanText.Location = new System.Drawing.Point(224, 63);
            this.labelMeanText.Name = "labelMeanText";
            this.labelMeanText.Size = new System.Drawing.Size(40, 13);
            this.labelMeanText.TabIndex = 10;
            this.labelMeanText.Text = "Mean: ";
            // 
            // buttonCreateDataSet
            // 
            this.buttonCreateDataSet.Location = new System.Drawing.Point(116, 17);
            this.buttonCreateDataSet.Name = "buttonCreateDataSet";
            this.buttonCreateDataSet.Size = new System.Drawing.Size(99, 23);
            this.buttonCreateDataSet.TabIndex = 8;
            this.buttonCreateDataSet.Text = "Create data set";
            this.buttonCreateDataSet.UseVisualStyleBackColor = true;
            this.buttonCreateDataSet.Click += new System.EventHandler(this.OnCreateDataSet);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 323);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.plotBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(815, 362);
            this.MinimumSize = new System.Drawing.Size(815, 362);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OnClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.plotBox.ResumeLayout(false);
            this.dataBox.ResumeLayout(false);
            this.dataBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelPlot;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.ComboBox comboBoxDataSets;
        private System.Windows.Forms.GroupBox plotBox;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.Button buttonCreateDataSet;
        private System.Windows.Forms.Label labelDomainText;
        private System.Windows.Forms.Label labelRangeText;
        private System.Windows.Forms.Label labelStdDevText;
        private System.Windows.Forms.Label labelModeText;
        private System.Windows.Forms.Label labelMedianText;
        private System.Windows.Forms.Label labelMeanText;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label divider2;
        private System.Windows.Forms.Label divider3;
        private System.Windows.Forms.Label divider4;
        private System.Windows.Forms.Label divider5;
        private System.Windows.Forms.Label divider6;
        private System.Windows.Forms.Label divider7;
        private System.Windows.Forms.Label divider8;
        private System.Windows.Forms.NumericUpDown numericUpDownOrder;
        private System.Windows.Forms.CheckBox checkBoxPlotRegression;
        private System.Windows.Forms.CheckBox checkBoxPlotPoints;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelStdDev;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.ToolStripMenuItem exportPlotToolStripMenuItem;
    }
}

