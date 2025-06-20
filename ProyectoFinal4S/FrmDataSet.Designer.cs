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
            lblData = new Label();
            groupBox4 = new GroupBox();
            lblView = new Label();
            cmbViewOption = new ComboBox();
            rbDistant = new RadioButton();
            btnSearch = new Button();
            btnRedshift = new Button();
            rbClose = new RadioButton();
            txtSearch = new TextBox();
            btnGoBack = new Button();
            cmbClassFilter = new ComboBox();
            btnFilterClass = new Button();
            label1 = new Label();
            pgb = new ProgressBar();
            groupBox3 = new GroupBox();
            btnSaveSqlChanges = new Button();
            cmbExportFormat = new ComboBox();
            btnExport = new Button();
            btnExportPDF = new Button();
            groupBox2 = new GroupBox();
            btnOpen = new Button();
            btnsqlDate = new Button();
            groupBox1 = new GroupBox();
            cmbDeleteType = new ComboBox();
            btnDelete = new Button();
            btnClearData = new Button();
            btnEnviarArchivo = new Button();
            txtPlainText = new TextBox();
            treeView = new TreeView();
            dgvData = new DataGridView();
            groupBox5 = new GroupBox();
            btnGraphics = new Button();
            btnScatterPlot = new Button();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            lblProgress = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AllowDrop = true;
            lblData.AutoSize = true;
            lblData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(810, 578);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 31);
            lblData.TabIndex = 36;
            lblData.Text = "No:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblView);
            groupBox4.Controls.Add(cmbViewOption);
            groupBox4.Controls.Add(rbDistant);
            groupBox4.Controls.Add(btnSearch);
            groupBox4.Controls.Add(btnRedshift);
            groupBox4.Controls.Add(rbClose);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(btnGoBack);
            groupBox4.Controls.Add(cmbClassFilter);
            groupBox4.Controls.Add(btnFilterClass);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(13, 14);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1780, 113);
            groupBox4.TabIndex = 37;
            groupBox4.TabStop = false;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Font = new Font("Yu Gothic UI", 11.25F);
            lblView.Location = new Point(1493, 43);
            lblView.Name = "lblView";
            lblView.Size = new Size(63, 31);
            lblView.TabIndex = 40;
            lblView.Text = "View";
            // 
            // cmbViewOption
            // 
            cmbViewOption.FormattingEnabled = true;
            cmbViewOption.Location = new Point(1569, 42);
            cmbViewOption.Name = "cmbViewOption";
            cmbViewOption.Size = new Size(183, 33);
            cmbViewOption.TabIndex = 40;
            // 
            // rbDistant
            // 
            rbDistant.AutoSize = true;
            rbDistant.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDistant.Location = new Point(797, 28);
            rbDistant.Margin = new Padding(4, 5, 4, 5);
            rbDistant.Name = "rbDistant";
            rbDistant.Size = new Size(149, 35);
            rbDistant.TabIndex = 32;
            rbDistant.TabStop = true;
            rbDistant.Text = "Far objects";
            rbDistant.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Yu Gothic UI", 12F);
            btnSearch.Location = new Point(548, 41);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 50);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRedshift
            // 
            btnRedshift.Font = new Font("Yu Gothic UI", 12F);
            btnRedshift.Location = new Point(971, 41);
            btnRedshift.Margin = new Padding(4, 5, 4, 5);
            btnRedshift.Name = "btnRedshift";
            btnRedshift.Size = new Size(110, 50);
            btnRedshift.TabIndex = 34;
            btnRedshift.Text = "Order";
            btnRedshift.UseVisualStyleBackColor = true;
            btnRedshift.Click += btnRedshift_Click;
            // 
            // rbClose
            // 
            rbClose.AutoSize = true;
            rbClose.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbClose.Location = new Point(798, 70);
            rbClose.Margin = new Padding(4, 5, 4, 5);
            rbClose.Name = "rbClose";
            rbClose.Size = new Size(168, 35);
            rbClose.TabIndex = 31;
            rbClose.TabStop = true;
            rbClose.Text = "Near objects";
            rbClose.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(143, 48);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 37);
            txtSearch.TabIndex = 28;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Yu Gothic UI", 12F);
            btnGoBack.Location = new Point(15, 41);
            btnGoBack.Margin = new Padding(4, 5, 4, 5);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(110, 50);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // cmbClassFilter
            // 
            cmbClassFilter.Font = new Font("Yu Gothic UI", 11.25F);
            cmbClassFilter.FormattingEnabled = true;
            cmbClassFilter.Location = new Point(1122, 41);
            cmbClassFilter.Name = "cmbClassFilter";
            cmbClassFilter.Size = new Size(183, 39);
            cmbClassFilter.TabIndex = 18;
            // 
            // btnFilterClass
            // 
            btnFilterClass.Font = new Font("Yu Gothic UI", 11.25F);
            btnFilterClass.Location = new Point(1313, 32);
            btnFilterClass.Name = "btnFilterClass";
            btnFilterClass.Size = new Size(110, 50);
            btnFilterClass.TabIndex = 19;
            btnFilterClass.Text = "Filter";
            btnFilterClass.UseVisualStyleBackColor = true;
            btnFilterClass.Click += btnFilterClass_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(701, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 30;
            label1.Text = "Redshift";
            // 
            // pgb
            // 
            pgb.Location = new Point(20, 470);
            pgb.Name = "pgb";
            pgb.Size = new Size(232, 34);
            pgb.TabIndex = 45;
            pgb.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSaveSqlChanges);
            groupBox3.Controls.Add(cmbExportFormat);
            groupBox3.Controls.Add(btnExport);
            groupBox3.Controls.Add(btnExportPDF);
            groupBox3.Location = new Point(18, 241);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(260, 192);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Exportar";
            // 
            // btnSaveSqlChanges
            // 
            btnSaveSqlChanges.Font = new Font("Yu Gothic UI", 11.25F);
            btnSaveSqlChanges.Location = new Point(13, 100);
            btnSaveSqlChanges.Margin = new Padding(4, 5, 4, 5);
            btnSaveSqlChanges.Name = "btnSaveSqlChanges";
            btnSaveSqlChanges.Size = new Size(110, 76);
            btnSaveSqlChanges.TabIndex = 41;
            btnSaveSqlChanges.Text = "Changes SQL";
            btnSaveSqlChanges.UseVisualStyleBackColor = true;
            btnSaveSqlChanges.Click += btnSaveSqlChanges_Click;
            // 
            // cmbExportFormat
            // 
            cmbExportFormat.Font = new Font("Yu Gothic UI", 11.25F);
            cmbExportFormat.FormattingEnabled = true;
            cmbExportFormat.Location = new Point(8, 32);
            cmbExportFormat.Name = "cmbExportFormat";
            cmbExportFormat.Size = new Size(129, 39);
            cmbExportFormat.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Yu Gothic UI", 11.25F);
            btnExport.Location = new Point(143, 32);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(110, 50);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Yu Gothic UI", 11.25F);
            btnExportPDF.Location = new Point(143, 100);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(110, 76);
            btnExportPDF.TabIndex = 27;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnsqlDate);
            groupBox2.Location = new Point(13, 134);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(260, 106);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(13, 34);
            btnOpen.Margin = new Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(110, 50);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnsqlDate
            // 
            btnsqlDate.Font = new Font("Yu Gothic UI", 11.25F);
            btnsqlDate.Location = new Point(131, 36);
            btnsqlDate.Margin = new Padding(4, 5, 4, 5);
            btnsqlDate.Name = "btnsqlDate";
            btnsqlDate.Size = new Size(110, 50);
            btnsqlDate.TabIndex = 40;
            btnsqlDate.Text = "Sql";
            btnsqlDate.UseVisualStyleBackColor = true;
            btnsqlDate.Click += btnsqlDate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDeleteType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClearData);
            groupBox1.Location = new Point(13, 506);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(258, 138);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            // 
            // cmbDeleteType
            // 
            cmbDeleteType.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDeleteType.FormattingEnabled = true;
            cmbDeleteType.Location = new Point(13, 25);
            cmbDeleteType.Name = "cmbDeleteType";
            cmbDeleteType.Size = new Size(164, 39);
            cmbDeleteType.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(13, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 50);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearData
            // 
            btnClearData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearData.Location = new Point(129, 75);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(110, 50);
            btnClearData.TabIndex = 14;
            btnClearData.Text = "Clear data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnEnviarArchivo
            // 
            btnEnviarArchivo.Font = new Font("Yu Gothic UI", 11.25F);
            btnEnviarArchivo.Location = new Point(296, 559);
            btnEnviarArchivo.Name = "btnEnviarArchivo";
            btnEnviarArchivo.Size = new Size(110, 50);
            btnEnviarArchivo.TabIndex = 50;
            btnEnviarArchivo.Text = "Email";
            btnEnviarArchivo.UseVisualStyleBackColor = true;
            btnEnviarArchivo.Click += btnEnviarArchivo_Click;
            // 
            // txtPlainText
            // 
            txtPlainText.Location = new Point(1441, 148);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.ScrollBars = ScrollBars.Vertical;
            txtPlainText.Size = new Size(344, 393);
            txtPlainText.TabIndex = 49;
            txtPlainText.Visible = false;
            // 
            // treeView
            // 
            treeView.Location = new Point(966, 148);
            treeView.Name = "treeView";
            treeView.Size = new Size(469, 393);
            treeView.TabIndex = 48;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ControlLight;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(296, 148);
            dgvData.Margin = new Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(663, 393);
            dgvData.TabIndex = 46;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnGraphics);
            groupBox5.Controls.Add(btnScatterPlot);
            groupBox5.Location = new Point(556, 657);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(138, 163);
            groupBox5.TabIndex = 53;
            groupBox5.TabStop = false;
            // 
            // btnGraphics
            // 
            btnGraphics.Font = new Font("Yu Gothic UI", 11.25F);
            btnGraphics.Location = new Point(17, 32);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new Size(110, 50);
            btnGraphics.TabIndex = 23;
            btnGraphics.Text = "Pie ";
            btnGraphics.UseVisualStyleBackColor = true;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // btnScatterPlot
            // 
            btnScatterPlot.Font = new Font("Yu Gothic UI", 11.25F);
            btnScatterPlot.Location = new Point(17, 88);
            btnScatterPlot.Name = "btnScatterPlot";
            btnScatterPlot.Size = new Size(110, 50);
            btnScatterPlot.TabIndex = 26;
            btnScatterPlot.Text = "Scatter";
            btnScatterPlot.UseVisualStyleBackColor = true;
            btnScatterPlot.Click += btnScatterPlot_Click;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(724, 657);
            formsPlot2.Margin = new Padding(4, 5, 4, 5);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(1069, 403);
            formsPlot2.TabIndex = 52;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(8, 657);
            formsPlot1.Margin = new Padding(4, 5, 4, 5);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(511, 403);
            formsPlot1.TabIndex = 51;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(31, 442);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 25);
            lblProgress.TabIndex = 54;
            // 
            // FrmDataSet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1806, 1050);
            Controls.Add(lblProgress);
            Controls.Add(groupBox5);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Controls.Add(btnEnviarArchivo);
            Controls.Add(txtPlainText);
            Controls.Add(treeView);
            Controls.Add(dgvData);
            Controls.Add(pgb);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(lblData);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmDataSet";
            Text = "Form2";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblData;
        private GroupBox groupBox4;
        private Label lblView;
        private ComboBox cmbViewOption;
        private RadioButton rbDistant;
        private Button btnSearch;
        private Button btnRedshift;
        private RadioButton rbClose;
        private TextBox txtSearch;
        private Button btnGoBack;
        private ComboBox cmbClassFilter;
        private Button btnFilterClass;
        private Label label1;
        private ProgressBar pgb;
        private GroupBox groupBox3;
        private Button btnSaveSqlChanges;
        private ComboBox cmbExportFormat;
        private Button btnExport;
        private Button btnExportPDF;
        private GroupBox groupBox2;
        private Button btnOpen;
        private Button btnsqlDate;
        private GroupBox groupBox1;
        private ComboBox cmbDeleteType;
        private Button btnDelete;
        private Button btnClearData;
        private Button btnEnviarArchivo;
        private TextBox txtPlainText;
        private TreeView treeView;
        private DataGridView dgvData;
        private GroupBox groupBox5;
        private Button btnGraphics;
        private Button btnScatterPlot;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label lblProgress;
    }
}