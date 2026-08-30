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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.pnlHeading.Size = new System.Drawing.Size(783, 71);
            this.pnlHeading.TabIndex = 0;
            this.pnlHeading.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // tlpHeading
            // 
            this.tlpHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.703704F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.71265F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5247F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.Controls.Add(this.tlpHeaderSpace, 1, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(783, 69);
            this.tlpHeading.TabIndex = 0;
            this.tlpHeading.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // tlpHeaderSpace
            // 
            this.tlpHeaderSpace.ColumnCount = 2;
            this.tlpHeaderSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpHeaderSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderSpace.Controls.Add(this.tlpTitle, 1, 0);
            this.tlpHeaderSpace.Controls.Add(this.picBoxEmployeeIcon, 0, 0);
            this.tlpHeaderSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderSpace.Location = new System.Drawing.Point(29, 0);
            this.tlpHeaderSpace.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeaderSpace.Name = "tlpHeaderSpace";
            this.tlpHeaderSpace.RowCount = 1;
            this.tlpHeaderSpace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderSpace.Size = new System.Drawing.Size(585, 69);
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
            this.tlpTitle.Location = new System.Drawing.Point(55, 2);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 2;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tlpTitle.Size = new System.Drawing.Size(528, 65);
            this.tlpTitle.TabIndex = 1;
            this.tlpTitle.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 32);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
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
            this.lblEmployeeDetails.Location = new System.Drawing.Point(2, 11);
            this.lblEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(135, 21);
            this.lblEmployeeDetails.TabIndex = 0;
            this.lblEmployeeDetails.Text = "Employee Details";
            this.lblEmployeeDetails.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // picBoxEmployeeIcon
            // 
            this.picBoxEmployeeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxEmployeeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxEmployeeIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEmployeeIcon.Image")));
            this.picBoxEmployeeIcon.Location = new System.Drawing.Point(0, 9);
            this.picBoxEmployeeIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxEmployeeIcon.Name = "picBoxEmployeeIcon";
            this.picBoxEmployeeIcon.Size = new System.Drawing.Size(53, 51);
            this.picBoxEmployeeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEmployeeIcon.TabIndex = 0;
            this.picBoxEmployeeIcon.TabStop = false;
            this.picBoxEmployeeIcon.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // pnlAddNewEmployee
            // 
            this.pnlAddNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlAddNewEmployee.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAddNewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddNewEmployee.Controls.Add(this.tlpAddNewEmployee);
            this.pnlAddNewEmployee.Location = new System.Drawing.Point(625, 9);
            this.pnlAddNewEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddNewEmployee.Name = "pnlAddNewEmployee";
            this.pnlAddNewEmployee.Size = new System.Drawing.Size(90, 29);
            this.pnlAddNewEmployee.TabIndex = 1;
            this.pnlAddNewEmployee.Click += new System.EventHandler(this.pnlAddNewEmployee_Click);
            this.pnlAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.pnlAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // tlpAddNewEmployee
            // 
            this.tlpAddNewEmployee.BackColor = System.Drawing.Color.Transparent;
            this.tlpAddNewEmployee.ColumnCount = 2;
            this.tlpAddNewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.13636F));
            this.tlpAddNewEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.86364F));
            this.tlpAddNewEmployee.Controls.Add(this.picBoxPluseIcon, 0, 0);
            this.tlpAddNewEmployee.Controls.Add(this.lblAddNewEmployee, 1, 0);
            this.tlpAddNewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewEmployee.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpAddNewEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddNewEmployee.Name = "tlpAddNewEmployee";
            this.tlpAddNewEmployee.RowCount = 1;
            this.tlpAddNewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpAddNewEmployee.Size = new System.Drawing.Size(88, 27);
            this.tlpAddNewEmployee.TabIndex = 0;
            this.tlpAddNewEmployee.Click += new System.EventHandler(this.tlpAddNewEmployee_Click);
            this.tlpAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.tlpAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // picBoxPluseIcon
            // 
            this.picBoxPluseIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picBoxPluseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPluseIcon.Image = global::GymManagementSystem.Properties.Resources.plus;
            this.picBoxPluseIcon.Location = new System.Drawing.Point(8, 6);
            this.picBoxPluseIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxPluseIcon.Name = "picBoxPluseIcon";
            this.picBoxPluseIcon.Size = new System.Drawing.Size(15, 15);
            this.picBoxPluseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPluseIcon.TabIndex = 1;
            this.picBoxPluseIcon.TabStop = false;
            this.picBoxPluseIcon.Click += new System.EventHandler(this.pnlAddNewEmployee_Click);
            this.picBoxPluseIcon.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.picBoxPluseIcon.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // lblAddNewEmployee
            // 
            this.lblAddNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewEmployee.AutoSize = true;
            this.lblAddNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddNewEmployee.Location = new System.Drawing.Point(25, 6);
            this.lblAddNewEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewEmployee.Name = "lblAddNewEmployee";
            this.lblAddNewEmployee.Size = new System.Drawing.Size(58, 15);
            this.lblAddNewEmployee.TabIndex = 2;
            this.lblAddNewEmployee.Text = "Add New";
            this.lblAddNewEmployee.Click += new System.EventHandler(this.pnlAddNewEmployee_Click);
            this.lblAddNewEmployee.MouseEnter += new System.EventHandler(this.pnlAddNewEmployee_MouseEnter);
            this.lblAddNewEmployee.MouseLeave += new System.EventHandler(this.pnlAddNewEmployee_MouseLeave);
            // 
            // tlpEmployeeDataGrid
            // 
            this.tlpEmployeeDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpEmployeeDataGrid.ColumnCount = 3;
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.57599F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.31545F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEmployeeDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpEmployeeDataGrid.Controls.Add(this.dvgEmployeeDetails, 1, 1);
            this.tlpEmployeeDataGrid.Controls.Add(this.tlpSearch, 1, 0);
            this.tlpEmployeeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeDataGrid.Location = new System.Drawing.Point(0, 71);
            this.tlpEmployeeDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeDataGrid.Name = "tlpEmployeeDataGrid";
            this.tlpEmployeeDataGrid.RowCount = 3;
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpEmployeeDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpEmployeeDataGrid.Size = new System.Drawing.Size(783, 400);
            this.tlpEmployeeDataGrid.TabIndex = 1;
            this.tlpEmployeeDataGrid.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // dvgEmployeeDetails
            // 
            this.dvgEmployeeDetails.AllowUserToAddRows = false;
            this.dvgEmployeeDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgEmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEmployeeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dvgEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEmployeeDetails.ColumnHeadersHeight = 40;
            this.dvgEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colEmployeeId,
            this.colName,
            this.colGender,
            this.colPhoneNo,
            this.colJoiningDate,
            this.colRole,
            this.colBankAccount,
            this.colStatus,
            this.colUpdate,
            this.colDeactivate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dvgEmployeeDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dvgEmployeeDetails.Location = new System.Drawing.Point(30, 49);
            this.dvgEmployeeDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dvgEmployeeDetails.Name = "dvgEmployeeDetails";
            this.dvgEmployeeDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgEmployeeDetails.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmployeeDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgEmployeeDetails.RowTemplate.Height = 30;
            this.dvgEmployeeDetails.RowTemplate.ReadOnly = true;
            this.dvgEmployeeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvgEmployeeDetails.Size = new System.Drawing.Size(711, 328);
            this.dvgEmployeeDetails.TabIndex = 0;
            this.dvgEmployeeDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployeeDetails_CellContentClick);
            this.dvgEmployeeDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployeeDetails_CellMouseEnter);
            this.dvgEmployeeDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployeeDetails_CellMouseLeave);
            this.dvgEmployeeDetails.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvgEmployeeDetails_CellPainting);
            // 
            // colSlNo
            // 
            this.colSlNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colSlNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSlNo.FillWeight = 60F;
            this.colSlNo.HeaderText = "Sl No.";
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.ReadOnly = true;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSlNo.Width = 50;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            this.colEmployeeId.HeaderText = "Employee Id";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colName.FillWeight = 130F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 130;
            // 
            // colGender
            // 
            this.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGender.DataPropertyName = "GenderName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colGender.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGender.FillWeight = 70F;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGender.Width = 70;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPhoneNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPhoneNo.HeaderText = "Mobile No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPhoneNo.Width = 120;
            // 
            // colJoiningDate
            // 
            this.colJoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJoiningDate.DataPropertyName = "JoiningDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colJoiningDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colJoiningDate.FillWeight = 90F;
            this.colJoiningDate.HeaderText = "Joining Date";
            this.colJoiningDate.Name = "colJoiningDate";
            this.colJoiningDate.ReadOnly = true;
            this.colJoiningDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRole
            // 
            this.colRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRole.DataPropertyName = "RoleName";
            this.colRole.FillWeight = 90F;
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBankAccount
            // 
            this.colBankAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankAccount.DataPropertyName = "BankAccountNo";
            this.colBankAccount.FillWeight = 110F;
            this.colBankAccount.HeaderText = "Bank A/C";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.ReadOnly = true;
            this.colBankAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatus.FillWeight = 80F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStatus.Width = 80;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUpdate.FillWeight = 80F;
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "Action";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUpdate.Width = 80;
            // 
            // colDeactivate
            // 
            this.colDeactivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDeactivate.HeaderText = "Action";
            this.colDeactivate.Name = "colDeactivate";
            this.colDeactivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeactivate.Width = 80;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 4;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Controls.Add(this.picBoxSearchIcon, 0, 0);
            this.tlpSearch.Controls.Add(this.pnlAddNewEmployee, 3, 0);
            this.tlpSearch.Controls.Add(this.txtSearch, 1, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(28, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(715, 47);
            this.tlpSearch.TabIndex = 1;
            this.tlpSearch.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // picBoxSearchIcon
            // 
            this.picBoxSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picBoxSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSearchIcon.Image")));
            this.picBoxSearchIcon.Location = new System.Drawing.Point(2, 12);
            this.picBoxSearchIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxSearchIcon.MaximumSize = new System.Drawing.Size(29, 23);
            this.picBoxSearchIcon.MinimumSize = new System.Drawing.Size(29, 23);
            this.picBoxSearchIcon.Name = "picBoxSearchIcon";
            this.picBoxSearchIcon.Size = new System.Drawing.Size(29, 23);
            this.picBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSearchIcon.TabIndex = 0;
            this.picBoxSearchIcon.TabStop = false;
            this.picBoxSearchIcon.Click += new System.EventHandler(this.FrmSADisplayAllEmployee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(35, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter Mobile No";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // FrmSADisplayAllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.tlpEmployeeDataGrid);
            this.Controls.Add(this.pnlHeading);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Panel pnlAddNewEmployee;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewEmployee;
        private System.Windows.Forms.PictureBox picBoxPluseIcon;
        private System.Windows.Forms.Label lblAddNewEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
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