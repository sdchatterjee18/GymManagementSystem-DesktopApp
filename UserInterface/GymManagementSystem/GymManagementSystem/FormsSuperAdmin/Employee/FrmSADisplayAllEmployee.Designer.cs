using System.Drawing;
namespace GymManagementSystem.FormsSuperAdmin.Employee
{
    partial class FrmSADisplayAllEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSADisplayAllEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeaderSpace = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.picBoxEmployeeIcon = new System.Windows.Forms.PictureBox();
            this.pnlAddNewEmployee = new System.Windows.Forms.Panel();
            this.tlpAddNewEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxPluseIcon = new System.Windows.Forms.PictureBox();
            this.lblAddNewEmployee = new System.Windows.Forms.Label();
            this.tlpEmployeeDataGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dvgEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.tlpHeaderSpace.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployeeIcon)).BeginInit();
            this.pnlAddNewEmployee.SuspendLayout();
            this.tlpAddNewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPluseIcon)).BeginInit();
            this.tlpEmployeeDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployeeDetails)).BeginInit();
            this.tlpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlHeading.Controls.Add(this.tlpHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(783, 54);
            this.pnlHeading.TabIndex = 0;
            this.pnlHeading.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // tlpHeading
            // 
            this.tlpHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.42419F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5247F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.Controls.Add(this.tlpHeaderSpace, 1, 0);
            this.tlpHeading.Controls.Add(this.pnlAddNewEmployee, 2, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(783, 54);
            this.tlpHeading.TabIndex = 0;
            this.tlpHeading.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // tlpHeaderSpace
            // 
            this.tlpHeaderSpace.ColumnCount = 2;
            this.tlpHeaderSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHeaderSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderSpace.Controls.Add(this.tlpTitle, 1, 0);
            this.tlpHeaderSpace.Controls.Add(this.picBoxEmployeeIcon, 0, 0);
            this.tlpHeaderSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderSpace.Location = new System.Drawing.Point(39, 0);
            this.tlpHeaderSpace.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeaderSpace.Name = "tlpHeaderSpace";
            this.tlpHeaderSpace.RowCount = 1;
            this.tlpHeaderSpace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderSpace.Size = new System.Drawing.Size(575, 54);
            this.tlpHeaderSpace.TabIndex = 0;
            this.tlpHeaderSpace.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpTitle.Controls.Add(this.lblSubtitle, 0, 1);
            this.tlpTitle.Controls.Add(this.lblEmployeeDetails, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(32, 2);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 2;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlpTitle.Size = new System.Drawing.Size(541, 50);
            this.tlpTitle.TabIndex = 1;
            this.tlpTitle.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(2, 27);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(155, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Display all employee records";
            this.lblSubtitle.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDetails.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeDetails.Location = new System.Drawing.Point(2, 6);
            this.lblEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(135, 21);
            this.lblEmployeeDetails.TabIndex = 0;
            this.lblEmployeeDetails.Text = "Employee Details";
            this.lblEmployeeDetails.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // picBoxEmployeeIcon
            // 
            this.picBoxEmployeeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxEmployeeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxEmployeeIcon.BackgroundImage")));
            this.picBoxEmployeeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxEmployeeIcon.Location = new System.Drawing.Point(0, 9);
            this.picBoxEmployeeIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxEmployeeIcon.Name = "picBoxEmployeeIcon";
            this.picBoxEmployeeIcon.Size = new System.Drawing.Size(30, 36);
            this.picBoxEmployeeIcon.TabIndex = 0;
            this.picBoxEmployeeIcon.TabStop = false;
            this.picBoxEmployeeIcon.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // pnlAddNewEmployee
            // 
            this.pnlAddNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlAddNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.pnlAddNewEmployee.Controls.Add(this.tlpAddNewEmployee);
            this.pnlAddNewEmployee.Location = new System.Drawing.Point(640, 14);
            this.pnlAddNewEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddNewEmployee.Name = "pnlAddNewEmployee";
            this.pnlAddNewEmployee.Size = new System.Drawing.Size(103, 25);
            this.pnlAddNewEmployee.TabIndex = 1;
            this.pnlAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.pnlAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // tlpAddNewEmployee
            // 
            this.tlpAddNewEmployee.ColumnCount = 2;
            this.tlpAddNewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tlpAddNewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.92593F));
            this.tlpAddNewEmployee.Controls.Add(this.picBoxPluseIcon, 0, 0);
            this.tlpAddNewEmployee.Controls.Add(this.lblAddNewEmployee, 1, 0);
            this.tlpAddNewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewEmployee.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpAddNewEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpAddNewEmployee.Name = "tlpAddNewEmployee";
            this.tlpAddNewEmployee.RowCount = 1;
            this.tlpAddNewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAddNewEmployee.Size = new System.Drawing.Size(103, 25);
            this.tlpAddNewEmployee.TabIndex = 0;
            this.tlpAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.tlpAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // picBoxPluseIcon
            // 
            this.picBoxPluseIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picBoxPluseIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxPluseIcon.BackgroundImage")));
            this.picBoxPluseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPluseIcon.Location = new System.Drawing.Point(9, 5);
            this.picBoxPluseIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxPluseIcon.Name = "picBoxPluseIcon";
            this.picBoxPluseIcon.Size = new System.Drawing.Size(15, 15);
            this.picBoxPluseIcon.TabIndex = 1;
            this.picBoxPluseIcon.TabStop = false;
            this.picBoxPluseIcon.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.picBoxPluseIcon.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // lblAddNewEmployee
            // 
            this.lblAddNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewEmployee.AutoSize = true;
            this.lblAddNewEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewEmployee.ForeColor = System.Drawing.Color.Blue;
            this.lblAddNewEmployee.Location = new System.Drawing.Point(26, 3);
            this.lblAddNewEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewEmployee.Name = "lblAddNewEmployee";
            this.lblAddNewEmployee.Size = new System.Drawing.Size(67, 19);
            this.lblAddNewEmployee.TabIndex = 2;
            this.lblAddNewEmployee.Text = "Add New";
            this.lblAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.lblAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // tlpEmployeeDataGrid
            // 
            this.tlpEmployeeDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpEmployeeDataGrid.ColumnCount = 3;
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpEmployeeDataGrid.Controls.Add(this.dvgEmployeeDetails, 1, 1);
            this.tlpEmployeeDataGrid.Controls.Add(this.tlpSearch, 1, 0);
            this.tlpEmployeeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeDataGrid.Location = new System.Drawing.Point(0, 54);
            this.tlpEmployeeDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeDataGrid.Name = "tlpEmployeeDataGrid";
            this.tlpEmployeeDataGrid.RowCount = 3;
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82391F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.00646F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpEmployeeDataGrid.Size = new System.Drawing.Size(783, 417);
            this.tlpEmployeeDataGrid.TabIndex = 1;
            this.tlpEmployeeDataGrid.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // dvgEmployeeDetails
            // 
            this.dvgEmployeeDetails.AllowUserToAddRows = false;
            this.dvgEmployeeDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgEmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEmployeeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dvgEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEmployeeDetails.ColumnHeadersHeight = 50;
            this.dvgEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colName,
            this.colGender,
            this.colPhoneNo,
            this.colJoiningDate,
            this.colRole,
            this.colBankAccount,
            this.colStatus,
            this.colUpdate,
            this.colDeactivate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dvgEmployeeDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dvgEmployeeDetails.Location = new System.Drawing.Point(41, 47);
            this.dvgEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgEmployeeDetails.Name = "dvgEmployeeDetails";
            this.dvgEmployeeDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgEmployeeDetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgEmployeeDetails.RowTemplate.Height = 40;
            this.dvgEmployeeDetails.RowTemplate.ReadOnly = true;
            this.dvgEmployeeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvgEmployeeDetails.Size = new System.Drawing.Size(700, 346);
            this.dvgEmployeeDetails.TabIndex = 0;
            this.dvgEmployeeDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployeeDetails_CellMouseEnter);
            this.dvgEmployeeDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployeeDetails_CellMouseLeave);
            this.dvgEmployeeDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvgEmployeeDetails_CellPainting);
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 4;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Controls.Add(this.picBoxSearchIcon, 0, 0);
            this.tlpSearch.Controls.Add(this.txtSearch, 1, 0);
            this.tlpSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(39, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(704, 45);
            this.tlpSearch.TabIndex = 1;
            this.tlpSearch.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // picBoxSearchIcon
            // 
            this.picBoxSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxSearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSearchIcon.BackgroundImage")));
            this.picBoxSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSearchIcon.Location = new System.Drawing.Point(2, 9);
            this.picBoxSearchIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxSearchIcon.MaximumSize = new System.Drawing.Size(29, 27);
            this.picBoxSearchIcon.MinimumSize = new System.Drawing.Size(29, 27);
            this.picBoxSearchIcon.Name = "picBoxSearchIcon";
            this.picBoxSearchIcon.Size = new System.Drawing.Size(29, 27);
            this.picBoxSearchIcon.TabIndex = 0;
            this.picBoxSearchIcon.TabStop = false;
            this.picBoxSearchIcon.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(35, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter Mobile No";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(212, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // colSlNo
            // 
            this.colSlNo.FillWeight = 60F;
            this.colSlNo.HeaderText = "Sl No.";
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.ReadOnly = true;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "EmployeeName";
            this.colName.FillWeight = 130F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "GenderName";
            this.colGender.FillWeight = 70F;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.HeaderText = "Mobile No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colJoiningDate
            // 
            this.colJoiningDate.DataPropertyName = "JoiningDate";
            this.colJoiningDate.FillWeight = 90F;
            this.colJoiningDate.HeaderText = "Joining Date";
            this.colJoiningDate.Name = "colJoiningDate";
            this.colJoiningDate.ReadOnly = true;
            this.colJoiningDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "RoleName";
            this.colRole.FillWeight = 90F;
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBankAccount
            // 
            this.colBankAccount.DataPropertyName = "BankAccountNo";
            this.colBankAccount.FillWeight = 110F;
            this.colBankAccount.HeaderText = "Bank A/C";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.ReadOnly = true;
            this.colBankAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 80F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUpdate
            // 
            this.colUpdate.FillWeight = 80F;
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "Action";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDeactivate
            // 
            this.colDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDeactivate.HeaderText = "Action";
            this.colDeactivate.Name = "colDeactivate";
            this.colDeactivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmSADisplayAllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.tlpEmployeeDataGrid);
            this.Controls.Add(this.pnlHeading);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSADisplayAllEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSADisplayAllEmployee";
            this.Load += new System.EventHandler(this.FrmSADisplayAllEmployee_Load);
            this.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            this.pnlHeading.ResumeLayout(false);
            this.tlpHeading.ResumeLayout(false);
            this.tlpHeaderSpace.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployeeIcon)).EndInit();
            this.pnlAddNewEmployee.ResumeLayout(false);
            this.tlpAddNewEmployee.ResumeLayout(false);
            this.tlpAddNewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPluseIcon)).EndInit();
            this.tlpEmployeeDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployeeDetails)).EndInit();
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeaderSpace;
        private System.Windows.Forms.PictureBox picBoxEmployeeIcon;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmployeeDetails;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeDataGrid;
        private System.Windows.Forms.DataGridView dvgEmployeeDetails;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.PictureBox picBoxSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlAddNewEmployee;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewEmployee;
        private System.Windows.Forms.PictureBox picBoxPluseIcon;
        private System.Windows.Forms.Label lblAddNewEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colDeactivate;
    }
}