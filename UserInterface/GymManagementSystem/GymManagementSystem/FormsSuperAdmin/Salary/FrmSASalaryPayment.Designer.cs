namespace GymManagementSystem.FormsSuperAdmin.Salary
{
    partial class FrmSASalaryPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSASalaryPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpSalary = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmployeeSalary = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSalaryManagement = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmployeeSalaryHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picSalary = new System.Windows.Forms.PictureBox();
            this.tlpSalaryTitleAndSubTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSalaryTitleAndSubTitleSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblTrainerDetails = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tlpSearchSection = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.tlpShowEmployeeSalary = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEmployeeSalaryDetails = new System.Windows.Forms.DataGridView();
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpSalary.SuspendLayout();
            this.tlpEmployeeSalary.SuspendLayout();
            this.tlpSalaryManagement.SuspendLayout();
            this.tlpEmployeeSalaryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalary)).BeginInit();
            this.tlpSalaryTitleAndSubTitle.SuspendLayout();
            this.tlpSalaryTitleAndSubTitleSection.SuspendLayout();
            this.tlpSearchSection.SuspendLayout();
            this.tlpSearchBar.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tlpShowEmployeeSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSalaryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSalary
            // 
            this.tlpSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpSalary.ColumnCount = 3;
            this.tlpSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpSalary.Controls.Add(this.tlpEmployeeSalary, 1, 0);
            this.tlpSalary.Location = new System.Drawing.Point(-1, 0);
            this.tlpSalary.Name = "tlpSalary";
            this.tlpSalary.RowCount = 1;
            this.tlpSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSalary.Size = new System.Drawing.Size(1149, 794);
            this.tlpSalary.TabIndex = 0;
            this.tlpSalary.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpEmployeeSalary
            // 
            this.tlpEmployeeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEmployeeSalary.ColumnCount = 1;
            this.tlpEmployeeSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeSalary.Controls.Add(this.tlpSalaryManagement, 0, 0);
            this.tlpEmployeeSalary.Controls.Add(this.tlpSearchSection, 0, 1);
            this.tlpEmployeeSalary.Controls.Add(this.tlpShowEmployeeSalary, 0, 3);
            this.tlpEmployeeSalary.Location = new System.Drawing.Point(57, 0);
            this.tlpEmployeeSalary.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeSalary.Name = "tlpEmployeeSalary";
            this.tlpEmployeeSalary.RowCount = 5;
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76713F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.16451F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.029318F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.43825F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.600793F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmployeeSalary.Size = new System.Drawing.Size(1034, 794);
            this.tlpEmployeeSalary.TabIndex = 1;
            this.tlpEmployeeSalary.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSalaryManagement
            // 
            this.tlpSalaryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSalaryManagement.ColumnCount = 1;
            this.tlpSalaryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSalaryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSalaryManagement.Controls.Add(this.tlpEmployeeSalaryHeader, 0, 0);
            this.tlpSalaryManagement.Location = new System.Drawing.Point(0, 0);
            this.tlpSalaryManagement.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSalaryManagement.Name = "tlpSalaryManagement";
            this.tlpSalaryManagement.RowCount = 1;
            this.tlpSalaryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaryManagement.Size = new System.Drawing.Size(1034, 109);
            this.tlpSalaryManagement.TabIndex = 0;
            this.tlpSalaryManagement.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpEmployeeSalaryHeader
            // 
            this.tlpEmployeeSalaryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEmployeeSalaryHeader.ColumnCount = 2;
            this.tlpEmployeeSalaryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpEmployeeSalaryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeSalaryHeader.Controls.Add(this.picSalary, 0, 0);
            this.tlpEmployeeSalaryHeader.Controls.Add(this.tlpSalaryTitleAndSubTitle, 1, 0);
            this.tlpEmployeeSalaryHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployeeSalaryHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeSalaryHeader.Name = "tlpEmployeeSalaryHeader";
            this.tlpEmployeeSalaryHeader.RowCount = 1;
            this.tlpEmployeeSalaryHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeSalaryHeader.Size = new System.Drawing.Size(1034, 109);
            this.tlpEmployeeSalaryHeader.TabIndex = 0;
            this.tlpEmployeeSalaryHeader.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // picSalary
            // 
            this.picSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picSalary.Image = ((System.Drawing.Image)(resources.GetObject("picSalary.Image")));
            this.picSalary.Location = new System.Drawing.Point(0, 0);
            this.picSalary.Margin = new System.Windows.Forms.Padding(0);
            this.picSalary.Name = "picSalary";
            this.picSalary.Size = new System.Drawing.Size(75, 109);
            this.picSalary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalary.TabIndex = 0;
            this.picSalary.TabStop = false;
            this.picSalary.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSalaryTitleAndSubTitle
            // 
            this.tlpSalaryTitleAndSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSalaryTitleAndSubTitle.ColumnCount = 2;
            this.tlpSalaryTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSalaryTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSalaryTitleAndSubTitle.Controls.Add(this.tlpSalaryTitleAndSubTitleSection, 0, 0);
            this.tlpSalaryTitleAndSubTitle.Location = new System.Drawing.Point(75, 0);
            this.tlpSalaryTitleAndSubTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSalaryTitleAndSubTitle.Name = "tlpSalaryTitleAndSubTitle";
            this.tlpSalaryTitleAndSubTitle.RowCount = 1;
            this.tlpSalaryTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaryTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpSalaryTitleAndSubTitle.Size = new System.Drawing.Size(959, 109);
            this.tlpSalaryTitleAndSubTitle.TabIndex = 1;
            this.tlpSalaryTitleAndSubTitle.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSalaryTitleAndSubTitleSection
            // 
            this.tlpSalaryTitleAndSubTitleSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSalaryTitleAndSubTitleSection.ColumnCount = 1;
            this.tlpSalaryTitleAndSubTitleSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalaryTitleAndSubTitleSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSalaryTitleAndSubTitleSection.Controls.Add(this.lblTrainerDetails, 0, 0);
            this.tlpSalaryTitleAndSubTitleSection.Controls.Add(this.lblSubTitle, 0, 1);
            this.tlpSalaryTitleAndSubTitleSection.Location = new System.Drawing.Point(6, 0);
            this.tlpSalaryTitleAndSubTitleSection.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tlpSalaryTitleAndSubTitleSection.Name = "tlpSalaryTitleAndSubTitleSection";
            this.tlpSalaryTitleAndSubTitleSection.RowCount = 2;
            this.tlpSalaryTitleAndSubTitleSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tlpSalaryTitleAndSubTitleSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tlpSalaryTitleAndSubTitleSection.Size = new System.Drawing.Size(473, 109);
            this.tlpSalaryTitleAndSubTitleSection.TabIndex = 0;
            this.tlpSalaryTitleAndSubTitleSection.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // lblTrainerDetails
            // 
            this.lblTrainerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrainerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerDetails.Location = new System.Drawing.Point(3, 15);
            this.lblTrainerDetails.Name = "lblTrainerDetails";
            this.lblTrainerDetails.Size = new System.Drawing.Size(261, 40);
            this.lblTrainerDetails.TabIndex = 0;
            this.lblTrainerDetails.Text = "Salary Payment";
            this.lblTrainerDetails.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTrainerDetails.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubTitle.Location = new System.Drawing.Point(5, 55);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(463, 54);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Search Employee and Pay Salary";
            this.lblSubTitle.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSearchSection
            // 
            this.tlpSearchSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchSection.ColumnCount = 1;
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchSection.Controls.Add(this.tlpSearchBar, 0, 0);
            this.tlpSearchSection.Location = new System.Drawing.Point(0, 109);
            this.tlpSearchSection.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchSection.Name = "tlpSearchSection";
            this.tlpSearchSection.RowCount = 1;
            this.tlpSearchSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchSection.Size = new System.Drawing.Size(1034, 80);
            this.tlpSearchSection.TabIndex = 2;
            this.tlpSearchSection.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSearchBar
            // 
            this.tlpSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchBar.ColumnCount = 2;
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.44916F));
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.55084F));
            this.tlpSearchBar.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpSearchBar.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchBar.Name = "tlpSearchBar";
            this.tlpSearchBar.RowCount = 1;
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchBar.Size = new System.Drawing.Size(1034, 80);
            this.tlpSearchBar.TabIndex = 0;
            this.tlpSearchBar.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // tlpSearch
            // 
            this.tlpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearch.ColumnCount = 3;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tlpSearch.Controls.Add(this.picSearch, 0, 0);
            this.tlpSearch.Controls.Add(this.txtSearchBar, 1, 0);
            this.tlpSearch.Controls.Add(this.btnSeach, 2, 0);
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(676, 80);
            this.tlpSearch.TabIndex = 0;
            this.tlpSearch.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(0, 17);
            this.picSearch.Margin = new System.Windows.Forms.Padding(0);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(38, 45);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.tlpSalary_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchBar.Location = new System.Drawing.Point(49, 25);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(307, 30);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Text = "Enter Pnone No";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeach.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.ForeColor = System.Drawing.Color.White;
            this.btnSeach.Location = new System.Drawing.Point(383, 17);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(104, 45);
            this.btnSeach.TabIndex = 3;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = false;
            // 
            // tlpShowEmployeeSalary
            // 
            this.tlpShowEmployeeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowEmployeeSalary.ColumnCount = 1;
            this.tlpShowEmployeeSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowEmployeeSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowEmployeeSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowEmployeeSalary.Controls.Add(this.dgvEmployeeSalaryDetails, 0, 0);
            this.tlpShowEmployeeSalary.Location = new System.Drawing.Point(0, 197);
            this.tlpShowEmployeeSalary.Margin = new System.Windows.Forms.Padding(0);
            this.tlpShowEmployeeSalary.Name = "tlpShowEmployeeSalary";
            this.tlpShowEmployeeSalary.RowCount = 1;
            this.tlpShowEmployeeSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowEmployeeSalary.Size = new System.Drawing.Size(1034, 575);
            this.tlpShowEmployeeSalary.TabIndex = 3;
            // 
            // dgvEmployeeSalaryDetails
            // 
            this.dgvEmployeeSalaryDetails.AllowUserToAddRows = false;
            this.dgvEmployeeSalaryDetails.AllowUserToResizeColumns = false;
            this.dgvEmployeeSalaryDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeSalaryDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployeeSalaryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeSalaryDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvEmployeeSalaryDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeSalaryDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeSalaryDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeSalaryDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployeeSalaryDetails.ColumnHeadersHeight = 55;
            this.dgvEmployeeSalaryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeSalaryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colEmployeeFullName,
            this.colPhoneNo,
            this.colSalary,
            this.colAction});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeSalaryDetails.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployeeSalaryDetails.EnableHeadersVisualStyles = false;
            this.dgvEmployeeSalaryDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployeeSalaryDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeSalaryDetails.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEmployeeSalaryDetails.Name = "dgvEmployeeSalaryDetails";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeSalaryDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEmployeeSalaryDetails.RowHeadersVisible = false;
            this.dgvEmployeeSalaryDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployeeSalaryDetails.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEmployeeSalaryDetails.RowTemplate.Height = 40;
            this.dgvEmployeeSalaryDetails.Size = new System.Drawing.Size(1034, 575);
            this.dgvEmployeeSalaryDetails.TabIndex = 0;
            this.dgvEmployeeSalaryDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeSalaryDetails_CellMouseEnter);
            this.dgvEmployeeSalaryDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeSalaryDetails_CellMouseLeave);
            this.dgvEmployeeSalaryDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvEmployeeSalaryDetails_CellPainting);
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSLNo.Width = 70;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmployeeFullName.DataPropertyName = "EmployeeName";
            this.colEmployeeFullName.HeaderText = "Employee Name";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.HeaderText = "Phone No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSalary
            // 
            this.colSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSalary.DataPropertyName = "SalaryAmount";
            this.colSalary.HeaderText = "Salary";
            this.colSalary.Name = "colSalary";
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAction.DefaultCellStyle = dataGridViewCellStyle9;
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Text = "₹ Pay";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // FrmSASalaryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpSalary);
            this.Name = "FrmSASalaryPayment";
            this.Text = "FrmSASalaryPayment";
            this.Load += new System.EventHandler(this.FrmSASalaryPayment_Load);
            this.Shown += new System.EventHandler(this.FrmSASalaryPayment_Shown);
            this.tlpSalary.ResumeLayout(false);
            this.tlpEmployeeSalary.ResumeLayout(false);
            this.tlpSalaryManagement.ResumeLayout(false);
            this.tlpEmployeeSalaryHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSalary)).EndInit();
            this.tlpSalaryTitleAndSubTitle.ResumeLayout(false);
            this.tlpSalaryTitleAndSubTitleSection.ResumeLayout(false);
            this.tlpSalaryTitleAndSubTitleSection.PerformLayout();
            this.tlpSearchSection.ResumeLayout(false);
            this.tlpSearchBar.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tlpShowEmployeeSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSalaryDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSalary;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeSalary;
        private System.Windows.Forms.TableLayoutPanel tlpSalaryManagement;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeSalaryHeader;
        private System.Windows.Forms.PictureBox picSalary;
        private System.Windows.Forms.TableLayoutPanel tlpSalaryTitleAndSubTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSalaryTitleAndSubTitleSection;
        private System.Windows.Forms.Label lblTrainerDetails;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSearchSection;
        private System.Windows.Forms.TableLayoutPanel tlpSearchBar;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TableLayoutPanel tlpShowEmployeeSalary;
        private System.Windows.Forms.DataGridView dgvEmployeeSalaryDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}