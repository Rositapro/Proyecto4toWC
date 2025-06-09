namespace ProyectoFinal4S
{
    partial class FrmDataSet
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
            btnOpen = new Button();
            dgvData = new DataGridView();
            cmbDeleteType = new ComboBox();
            btnDelete = new Button();
            btnClearData = new Button();
            btnSave = new Button();
            cmbExportFormat = new ComboBox();
            btnExport = new Button();
            cmbClassFilter = new ComboBox();
            btnFilterClass = new Button();
            groupBox1 = new GroupBox();
            btnGoBack = new Button();
            groupBox2 = new GroupBox();
            btnGraphics = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            btnScatterPlot = new Button();
            btnExportPDF = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            rbClose = new RadioButton();
            rbDistant = new RadioButton();
            btnRedshift = new Button();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            lblData = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(28, 46);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(85, 36);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ControlLight;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(620, 131);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(595, 236);
            dgvData.TabIndex = 5;
            // 
            // cmbDeleteType
            // 
            cmbDeleteType.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDeleteType.FormattingEnabled = true;
            cmbDeleteType.Location = new Point(90, 30);
            cmbDeleteType.Margin = new Padding(2);
            cmbDeleteType.Name = "cmbDeleteType";
            cmbDeleteType.Size = new Size(116, 28);
            cmbDeleteType.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(31, 67);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearData
            // 
            btnClearData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearData.Location = new Point(165, 67);
            btnClearData.Margin = new Padding(2);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(102, 37);
            btnClearData.TabIndex = 14;
            btnClearData.Text = "Clear data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Yu Gothic UI", 11.25F);
            btnSave.Location = new Point(134, 46);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 36);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbExportFormat
            // 
            cmbExportFormat.Font = new Font("Yu Gothic UI", 11.25F);
            cmbExportFormat.FormattingEnabled = true;
            cmbExportFormat.Location = new Point(88, 41);
            cmbExportFormat.Margin = new Padding(2);
            cmbExportFormat.Name = "cmbExportFormat";
            cmbExportFormat.Size = new Size(102, 28);
            cmbExportFormat.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Yu Gothic UI", 11.25F);
            btnExport.Location = new Point(217, 36);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(85, 37);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cmbClassFilter
            // 
            cmbClassFilter.Font = new Font("Yu Gothic UI", 11.25F);
            cmbClassFilter.FormattingEnabled = true;
            cmbClassFilter.Location = new Point(902, 34);
            cmbClassFilter.Margin = new Padding(2);
            cmbClassFilter.Name = "cmbClassFilter";
            cmbClassFilter.Size = new Size(129, 28);
            cmbClassFilter.TabIndex = 18;
            cmbClassFilter.SelectedIndexChanged += cmbClassFilter_SelectedIndexChanged;
            // 
            // btnFilterClass
            // 
            btnFilterClass.Font = new Font("Yu Gothic UI", 11.25F);
            btnFilterClass.Location = new Point(1045, 29);
            btnFilterClass.Margin = new Padding(2);
            btnFilterClass.Name = "btnFilterClass";
            btnFilterClass.Size = new Size(102, 37);
            btnFilterClass.TabIndex = 19;
            btnFilterClass.Text = "Filter";
            btnFilterClass.UseVisualStyleBackColor = true;
            btnFilterClass.Click += btnFilterClass_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDeleteType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClearData);
            groupBox1.Location = new Point(315, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 125);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Yu Gothic UI", 12F);
            btnGoBack.Location = new Point(28, 34);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(105, 37);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(50, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 125);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnGraphics
            // 
            btnGraphics.Font = new Font("Yu Gothic UI", 11.25F);
            btnGraphics.Location = new Point(167, 381);
            btnGraphics.Margin = new Padding(2);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new Size(102, 37);
            btnGraphics.TabIndex = 23;
            btnGraphics.Text = "Pie ";
            btnGraphics.UseVisualStyleBackColor = true;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(50, 431);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(358, 242);
            formsPlot1.TabIndex = 24;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(467, 431);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(748, 242);
            formsPlot2.TabIndex = 25;
            // 
            // btnScatterPlot
            // 
            btnScatterPlot.Font = new Font("Yu Gothic UI", 11.25F);
            btnScatterPlot.Location = new Point(670, 381);
            btnScatterPlot.Margin = new Padding(2);
            btnScatterPlot.Name = "btnScatterPlot";
            btnScatterPlot.Size = new Size(102, 37);
            btnScatterPlot.TabIndex = 26;
            btnScatterPlot.Text = "Scatter";
            btnScatterPlot.UseVisualStyleBackColor = true;
            btnScatterPlot.Click += btnScatterPlot_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Yu Gothic UI", 11.25F);
            btnExportPDF.Location = new Point(440, 301);
            btnExportPDF.Margin = new Padding(2);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(102, 37);
            btnExportPDF.TabIndex = 27;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(168, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(267, 27);
            txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Yu Gothic UI", 12F);
            btnSearch.Location = new Point(454, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 37);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 30;
            label1.Text = "Redshift";
            // 
            // rbClose
            // 
            rbClose.AutoSize = true;
            rbClose.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbClose.Location = new Point(652, 52);
            rbClose.Name = "rbClose";
            rbClose.Size = new Size(111, 24);
            rbClose.TabIndex = 31;
            rbClose.TabStop = true;
            rbClose.Text = "Near objects";
            rbClose.UseVisualStyleBackColor = true;
            rbClose.CheckedChanged += rbClose_CheckedChanged;
            // 
            // rbDistant
            // 
            rbDistant.AutoSize = true;
            rbDistant.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDistant.Location = new Point(653, 22);
            rbDistant.Name = "rbDistant";
            rbDistant.Size = new Size(98, 24);
            rbDistant.TabIndex = 32;
            rbDistant.TabStop = true;
            rbDistant.Text = "Far objects";
            rbDistant.UseVisualStyleBackColor = true;
            // 
            // btnRedshift
            // 
            btnRedshift.Font = new Font("Yu Gothic UI", 12F);
            btnRedshift.Location = new Point(769, 31);
            btnRedshift.Name = "btnRedshift";
            btnRedshift.Size = new Size(81, 37);
            btnRedshift.TabIndex = 34;
            btnRedshift.Text = "Order";
            btnRedshift.UseVisualStyleBackColor = true;
            btnRedshift.Click += btnRedshift_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbDistant);
            groupBox4.Controls.Add(btnSearch);
            groupBox4.Controls.Add(btnRedshift);
            groupBox4.Controls.Add(rbClose);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(btnGoBack);
            groupBox4.Controls.Add(cmbClassFilter);
            groupBox4.Controls.Add(btnFilterClass);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(50, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1165, 93);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cmbExportFormat);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Location = new Point(50, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 98);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 35;
            label2.Text = "Export:";
            // 
            // lblData
            // 
            lblData.AllowDrop = true;
            lblData.AutoSize = true;
            lblData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(1053, 389);
            lblData.Name = "lblData";
            lblData.Size = new Size(32, 20);
            lblData.TabIndex = 36;
            lblData.Text = "No:";
            // 
            // FrmDataSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1264, 727);
            Controls.Add(lblData);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(btnExportPDF);
            Controls.Add(btnScatterPlot);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Controls.Add(btnGraphics);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvData);
            Name = "FrmDataSet";
            Text = "Form2";
            Load += FrmDataSet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpen;
        private DataGridView dgvData;
        private ComboBox cmbDeleteType;
        private Button btnDelete;
        private Button btnClearData;
        private Button btnSave;
        private ComboBox cmbExportFormat;
        private Button btnExport;
        private ComboBox cmbClassFilter;
        private Button btnFilterClass;
        private GroupBox groupBox1;
        private Button btnGoBack;
        private GroupBox groupBox2;
        private Button btnGraphics;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Button btnScatterPlot;
        private Button btnExportPDF;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private RadioButton rbClose;
        private RadioButton rbDistant;
        private Button btnRedshift;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label2;
        private Label lblData;
    }
}