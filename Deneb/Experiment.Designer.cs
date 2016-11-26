namespace Deneb
{
    partial class Experiment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Experiment));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddVariationToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteVariationToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelGlobalPrecursorColor = new System.Windows.Forms.Label();
            this.buttonCalculateGlobalPrecursor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGlobalPrecursorTau = new System.Windows.Forms.Label();
            this.labelGloBalPrecursorBeta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCalculatePopulations = new System.Windows.Forms.Button();
            this.dataGridViewPrecursors = new System.Windows.Forms.DataGridView();
            this.Beta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.labelInitial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.criticalityPanel1 = new Deneb.CriticalityPanel();
            this.chartPopulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecursors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVariationToolStripMenu,
            this.DeleteVariationToolStripMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // AddVariationToolStripMenu
            // 
            this.AddVariationToolStripMenu.Name = "AddVariationToolStripMenu";
            this.AddVariationToolStripMenu.Size = new System.Drawing.Size(227, 22);
            this.AddVariationToolStripMenu.Text = "Add a variation (on the right)";
            this.AddVariationToolStripMenu.Click += new System.EventHandler(this.AddVariationToolStripMenu_Click);
            // 
            // DeleteVariationToolStripMenu
            // 
            this.DeleteVariationToolStripMenu.Name = "DeleteVariationToolStripMenu";
            this.DeleteVariationToolStripMenu.Size = new System.Drawing.Size(227, 22);
            this.DeleteVariationToolStripMenu.Text = "Delete Variation (the left one)";
            this.DeleteVariationToolStripMenu.Click += new System.EventHandler(this.DeleteVariationToolStripMenu_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            this.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer2_TopToolStripPanel_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(839, 562);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.labelGlobalPrecursorColor);
            this.splitContainer2.Panel1.Controls.Add(this.buttonCalculateGlobalPrecursor);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.labelGlobalPrecursorTau);
            this.splitContainer2.Panel1.Controls.Add(this.labelGloBalPrecursorBeta);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.buttonPrint);
            this.splitContainer2.Panel1.Controls.Add(this.buttonCalculatePopulations);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewPrecursors);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer2.Panel1.Controls.Add(this.labelMax);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.labelLength);
            this.splitContainer2.Panel1.Controls.Add(this.labelMin);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.labelFinal);
            this.splitContainer2.Panel1.Controls.Add(this.labelInitial);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(764, 517);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelGlobalPrecursorColor
            // 
            this.labelGlobalPrecursorColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelGlobalPrecursorColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGlobalPrecursorColor.Location = new System.Drawing.Point(169, 367);
            this.labelGlobalPrecursorColor.Name = "labelGlobalPrecursorColor";
            this.labelGlobalPrecursorColor.Size = new System.Drawing.Size(31, 15);
            this.labelGlobalPrecursorColor.TabIndex = 12;
            this.labelGlobalPrecursorColor.Visible = false;
            // 
            // buttonCalculateGlobalPrecursor
            // 
            this.buttonCalculateGlobalPrecursor.Location = new System.Drawing.Point(12, 335);
            this.buttonCalculateGlobalPrecursor.Name = "buttonCalculateGlobalPrecursor";
            this.buttonCalculateGlobalPrecursor.Size = new System.Drawing.Size(188, 24);
            this.buttonCalculateGlobalPrecursor.TabIndex = 11;
            this.buttonCalculateGlobalPrecursor.Text = "Calculate Global Precursor";
            this.buttonCalculateGlobalPrecursor.UseVisualStyleBackColor = true;
            this.buttonCalculateGlobalPrecursor.Click += new System.EventHandler(this.buttonCalculateGlobalPrecursor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precursors Groups:";
            // 
            // labelGlobalPrecursorTau
            // 
            this.labelGlobalPrecursorTau.AutoSize = true;
            this.labelGlobalPrecursorTau.BackColor = System.Drawing.Color.White;
            this.labelGlobalPrecursorTau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGlobalPrecursorTau.Location = new System.Drawing.Point(65, 367);
            this.labelGlobalPrecursorTau.MinimumSize = new System.Drawing.Size(50, 2);
            this.labelGlobalPrecursorTau.Name = "labelGlobalPrecursorTau";
            this.labelGlobalPrecursorTau.Size = new System.Drawing.Size(50, 15);
            this.labelGlobalPrecursorTau.TabIndex = 9;
            this.labelGlobalPrecursorTau.Text = "label5";
            // 
            // labelGloBalPrecursorBeta
            // 
            this.labelGloBalPrecursorBeta.AutoSize = true;
            this.labelGloBalPrecursorBeta.BackColor = System.Drawing.Color.White;
            this.labelGloBalPrecursorBeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGloBalPrecursorBeta.Location = new System.Drawing.Point(12, 367);
            this.labelGloBalPrecursorBeta.MinimumSize = new System.Drawing.Size(50, 2);
            this.labelGloBalPrecursorBeta.Name = "labelGloBalPrecursorBeta";
            this.labelGloBalPrecursorBeta.Size = new System.Drawing.Size(50, 15);
            this.labelGloBalPrecursorBeta.TabIndex = 8;
            this.labelGloBalPrecursorBeta.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Global Precursor:";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(12, 489);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(188, 24);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCalculatePopulations
            // 
            this.buttonCalculatePopulations.Location = new System.Drawing.Point(12, 398);
            this.buttonCalculatePopulations.Name = "buttonCalculatePopulations";
            this.buttonCalculatePopulations.Size = new System.Drawing.Size(188, 24);
            this.buttonCalculatePopulations.TabIndex = 5;
            this.buttonCalculatePopulations.Text = "Redraw Graphics";
            this.buttonCalculatePopulations.UseVisualStyleBackColor = true;
            this.buttonCalculatePopulations.Visible = false;
            this.buttonCalculatePopulations.Click += new System.EventHandler(this.buttonCalculatePopulations_Click);
            // 
            // dataGridViewPrecursors
            // 
            this.dataGridViewPrecursors.AllowUserToAddRows = false;
            this.dataGridViewPrecursors.AllowUserToDeleteRows = false;
            this.dataGridViewPrecursors.AllowUserToResizeColumns = false;
            this.dataGridViewPrecursors.AllowUserToResizeRows = false;
            this.dataGridViewPrecursors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrecursors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Beta,
            this.Tau,
            this.Column1,
            this.Column2});
            this.dataGridViewPrecursors.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewPrecursors.MultiSelect = false;
            this.dataGridViewPrecursors.Name = "dataGridViewPrecursors";
            this.dataGridViewPrecursors.RowHeadersVisible = false;
            this.dataGridViewPrecursors.RowHeadersWidth = 30;
            this.dataGridViewPrecursors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPrecursors.Size = new System.Drawing.Size(188, 158);
            this.dataGridViewPrecursors.TabIndex = 4;
            this.dataGridViewPrecursors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrecursors_CellContentClick);
            this.dataGridViewPrecursors.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrecursors_CellValidated);
            this.dataGridViewPrecursors.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrecursors_CellValueChanged);
            this.dataGridViewPrecursors.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPrecursors_RowsAdded);
            this.dataGridViewPrecursors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewPrecursors_KeyPress);
            this.dataGridViewPrecursors.Validated += new System.EventHandler(this.dataGridViewPrecursors_Validated);
            // 
            // Beta
            // 
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            this.Beta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Beta.HeaderText = "Beta";
            this.Beta.MaxInputLength = 5;
            this.Beta.Name = "Beta";
            this.Beta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Beta.Width = 50;
            // 
            // Tau
            // 
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.Tau.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tau.HeaderText = "Tau";
            this.Tau.Name = "Tau";
            this.Tau.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Active";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Color";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Visible = false;
            this.Column2.Width = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Span";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 428);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(188, 24);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMax.Location = new System.Drawing.Point(131, 73);
            this.labelMax.Margin = new System.Windows.Forms.Padding(3);
            this.labelMax.MaximumSize = new System.Drawing.Size(60, 15);
            this.labelMax.MinimumSize = new System.Drawing.Size(60, 2);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(60, 15);
            this.labelMax.TabIndex = 1;
            this.labelMax.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Criticality";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLength.Location = new System.Drawing.Point(131, 16);
            this.labelLength.Margin = new System.Windows.Forms.Padding(3);
            this.labelLength.MaximumSize = new System.Drawing.Size(60, 15);
            this.labelLength.MinimumSize = new System.Drawing.Size(60, 2);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(60, 15);
            this.labelLength.TabIndex = 1;
            this.labelLength.Text = "label1";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMin.Location = new System.Drawing.Point(131, 92);
            this.labelMin.Margin = new System.Windows.Forms.Padding(3);
            this.labelMin.MaximumSize = new System.Drawing.Size(60, 15);
            this.labelMin.MinimumSize = new System.Drawing.Size(60, 2);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(60, 15);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Final Criticality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Min Criticality";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFinal.Location = new System.Drawing.Point(131, 54);
            this.labelFinal.Margin = new System.Windows.Forms.Padding(3);
            this.labelFinal.MaximumSize = new System.Drawing.Size(60, 15);
            this.labelFinal.MinimumSize = new System.Drawing.Size(60, 2);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(60, 15);
            this.labelFinal.TabIndex = 1;
            this.labelFinal.Text = "label1";
            // 
            // labelInitial
            // 
            this.labelInitial.AutoSize = true;
            this.labelInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInitial.Location = new System.Drawing.Point(131, 35);
            this.labelInitial.Margin = new System.Windows.Forms.Padding(3);
            this.labelInitial.MaximumSize = new System.Drawing.Size(60, 15);
            this.labelInitial.MinimumSize = new System.Drawing.Size(60, 2);
            this.labelInitial.Name = "labelInitial";
            this.labelInitial.Size = new System.Drawing.Size(60, 15);
            this.labelInitial.TabIndex = 1;
            this.labelInitial.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Initial Criticality";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.criticalityPanel1);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chartPopulation);
            this.splitContainer3.Size = new System.Drawing.Size(556, 517);
            this.splitContainer3.SplitterDistance = 177;
            this.splitContainer3.TabIndex = 0;
            // 
            // criticalityPanel1
            // 
            this.criticalityPanel1.BackColor = System.Drawing.Color.White;
            this.criticalityPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criticalityPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criticalityPanel1.Location = new System.Drawing.Point(0, 0);
            this.criticalityPanel1.Name = "criticalityPanel1";
            this.criticalityPanel1.Size = new System.Drawing.Size(556, 177);
            this.criticalityPanel1.TabIndex = 0;
            this.criticalityPanel1.VariationToInsert = null;
            // 
            // chartPopulation
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Title = "Neutrons";
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Title = "Population des précurseurs";
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "Neutrons";
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.PlotPosition;
            chartArea2.AlignWithChartArea = "Neutrons";
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.Title = "Precursors";
            chartArea2.Name = "Precursors";
            chartArea2.ShadowOffset = 5;
            this.chartPopulation.ChartAreas.Add(chartArea1);
            this.chartPopulation.ChartAreas.Add(chartArea2);
            this.chartPopulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPopulation.Location = new System.Drawing.Point(0, 0);
            this.chartPopulation.Name = "chartPopulation";
            this.chartPopulation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 2;
            series1.ChartArea = "Neutrons";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Crimson;
            series1.IsVisibleInLegend = false;
            series1.Name = "Neutrons";
            series2.BorderWidth = 2;
            series2.ChartArea = "Precursors";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Name = "Precursors";
            this.chartPopulation.Series.Add(series1);
            this.chartPopulation.Series.Add(series2);
            this.chartPopulation.Size = new System.Drawing.Size(556, 336);
            this.chartPopulation.TabIndex = 1;
            this.chartPopulation.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Written by Géraud Benazet and Pierre-Louis Deschamps";
            this.chartPopulation.Titles.Add(title1);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_2);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "exp";
            this.saveFileDialog.Filter = "Experiment files|*.exp";
            // 
            // Experiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Experiment";
            this.Text = "Experiment";
            this.Load += new System.EventHandler(this.Experiment_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecursors)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPopulation)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddVariationToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteVariationToolStripMenu;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewPrecursors;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopulation;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonCalculatePopulations;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGlobalPrecursorTau;
        private System.Windows.Forms.Label labelGloBalPrecursorBeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculateGlobalPrecursor;
        private System.Windows.Forms.Label labelGlobalPrecursorColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private CriticalityPanel criticalityPanel1;

    }
}