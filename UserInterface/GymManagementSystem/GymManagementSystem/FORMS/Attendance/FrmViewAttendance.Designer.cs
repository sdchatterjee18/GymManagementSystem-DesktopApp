namespace GymManagementSystem.FORMS.Attendance
{
    partial class FrmViewAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAttendance));
            this.tlpViewAttendanceEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpViewAttendanceHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picViewAttendanceMark = new System.Windows.Forms.PictureBox();
            this.tlpViewAttendanceTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewMemberAttendance = new System.Windows.Forms.Label();
            this.lblViewAttendance = new System.Windows.Forms.Label();
            this.dgvViewAttendance = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpViewAttendanceMonthAndYearSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picViewAttendanceSearch2 = new System.Windows.Forms.PictureBox();
            this.btnViewAttendanceSearch = new System.Windows.Forms.Button();
            this.txtYearSearch = new System.Windows.Forms.TextBox();
            this.cmbViewAttendanceShiftSearch = new System.Windows.Forms.ComboBox();
            this.tlpViewAttendanceSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.picViewAttendanceSearch1 = new System.Windows.Forms.PictureBox();
            this.txtViewMemberMobileNumber = new System.Windows.Forms.TextBox();
            this.tlpViewAttendanceEntireForm.SuspendLayout();
            this.tlpViewAttendanceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceMark)).BeginInit();
            this.tlpViewAttendanceTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttendance)).BeginInit();
            this.tlpViewAttendanceMonthAndYearSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceSearch2)).BeginInit();
            this.tlpViewAttendanceSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceSearch1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpViewAttendanceEntireForm
            // 
            this.tlpViewAttendanceEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpViewAttendanceEntireForm.ColumnCount = 3;
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpViewAttendanceEntireForm.Controls.Add(this.tlpViewAttendanceHeader, 1, 1);
            this.tlpViewAttendanceEntireForm.Controls.Add(this.dgvViewAttendance, 1, 5);
            this.tlpViewAttendanceEntireForm.Controls.Add(this.tlpViewAttendanceMonthAndYearSearch, 1, 4);
            this.tlpViewAttendanceEntireForm.Controls.Add(this.tlpViewAttendanceSearchBar, 1, 3);
            this.tlpViewAttendanceEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewAttendanceEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpViewAttendanceEntireForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceEntireForm.Name = "tlpViewAttendanceEntireForm";
            this.tlpViewAttendanceEntireForm.RowCount = 7;
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.840767F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.87474F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.655982F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.795938F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.292733F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.56406F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.975774F));
            this.tlpViewAttendanceEntireForm.Size = new System.Drawing.Size(1151, 750);
            this.tlpViewAttendanceEntireForm.TabIndex = 2;
            this.tlpViewAttendanceEntireForm.Click += new System.EventHandler(this.tlpViewAttendanceEntireForm_Click);
            // 
            // tlpViewAttendanceHeader
            // 
            this.tlpViewAttendanceHeader.ColumnCount = 3;
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceHeader.Controls.Add(this.picViewAttendanceMark, 0, 0);
            this.tlpViewAttendanceHeader.Controls.Add(this.tlpViewAttendanceTitle, 1, 0);
            this.tlpViewAttendanceHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewAttendanceHeader.Location = new System.Drawing.Point(57, 38);
            this.tlpViewAttendanceHeader.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.tlpViewAttendanceHeader.Name = "tlpViewAttendanceHeader";
            this.tlpViewAttendanceHeader.RowCount = 1;
            this.tlpViewAttendanceHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceHeader.Size = new System.Drawing.Size(1032, 62);
            this.tlpViewAttendanceHeader.TabIndex = 9;
            this.tlpViewAttendanceHeader.Click += new System.EventHandler(this.tlpViewAttendanceHeader_Click);
            // 
            // picViewAttendanceMark
            // 
            this.picViewAttendanceMark.Image = ((System.Drawing.Image)(resources.GetObject("picViewAttendanceMark.Image")));
            this.picViewAttendanceMark.Location = new System.Drawing.Point(0, 0);
            this.picViewAttendanceMark.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.picViewAttendanceMark.Name = "picViewAttendanceMark";
            this.picViewAttendanceMark.Size = new System.Drawing.Size(66, 60);
            this.picViewAttendanceMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewAttendanceMark.TabIndex = 0;
            this.picViewAttendanceMark.TabStop = false;
            this.picViewAttendanceMark.Click += new System.EventHandler(this.picViewAttendanceMark_Click);
            // 
            // tlpViewAttendanceTitle
            // 
            this.tlpViewAttendanceTitle.ColumnCount = 1;
            this.tlpViewAttendanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceTitle.Controls.Add(this.lblViewMemberAttendance, 0, 1);
            this.tlpViewAttendanceTitle.Controls.Add(this.lblViewAttendance, 0, 0);
            this.tlpViewAttendanceTitle.Location = new System.Drawing.Point(69, 0);
            this.tlpViewAttendanceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceTitle.Name = "tlpViewAttendanceTitle";
            this.tlpViewAttendanceTitle.RowCount = 2;
            this.tlpViewAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.45161F));
            this.tlpViewAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.54839F));
            this.tlpViewAttendanceTitle.Size = new System.Drawing.Size(331, 62);
            this.tlpViewAttendanceTitle.TabIndex = 1;
            this.tlpViewAttendanceTitle.Click += new System.EventHandler(this.tlpViewAttendanceTitle_Click);
            // 
            // lblViewMemberAttendance
            // 
            this.lblViewMemberAttendance.AutoSize = true;
            this.lblViewMemberAttendance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMemberAttendance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewMemberAttendance.Location = new System.Drawing.Point(3, 34);
            this.lblViewMemberAttendance.Name = "lblViewMemberAttendance";
            this.lblViewMemberAttendance.Size = new System.Drawing.Size(225, 19);
            this.lblViewMemberAttendance.TabIndex = 3;
            this.lblViewMemberAttendance.Text = "View Member\'s Attendance History";
            this.lblViewMemberAttendance.Click += new System.EventHandler(this.lblViewMemberAttendance_Click);
            // 
            // lblViewAttendance
            // 
            this.lblViewAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewAttendance.AutoSize = true;
            this.lblViewAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAttendance.Location = new System.Drawing.Point(3, 6);
            this.lblViewAttendance.Name = "lblViewAttendance";
            this.lblViewAttendance.Size = new System.Drawing.Size(199, 28);
            this.lblViewAttendance.TabIndex = 2;
            this.lblViewAttendance.Text = "Member Attendance";
            this.lblViewAttendance.Click += new System.EventHandler(this.lblViewAttendance_Click);
            // 
            // dgvViewAttendance
            // 
            this.dgvViewAttendance.AllowUserToAddRows = false;
            this.dgvViewAttendance.AllowUserToDeleteRows = false;
            this.dgvViewAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dgvViewAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvViewAttendance.ColumnHeadersHeight = 50;
            this.dgvViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMemberName,
            this.colPhoneNo,
            this.colShiftName,
            this.colAttendanceDate});
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAttendance.DefaultCellStyle = dataGridViewCellStyle54;
            this.dgvViewAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAttendance.EnableHeadersVisualStyles = false;
            this.dgvViewAttendance.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvViewAttendance.Location = new System.Drawing.Point(61, 208);
            this.dgvViewAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvViewAttendance.MultiSelect = false;
            this.dgvViewAttendance.Name = "dgvViewAttendance";
            this.dgvViewAttendance.ReadOnly = true;
            this.dgvViewAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dgvViewAttendance.RowHeadersVisible = false;
            this.dgvViewAttendance.RowHeadersWidth = 50;
            this.dgvViewAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvViewAttendance.RowTemplate.Height = 50;
            this.dgvViewAttendance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvViewAttendance.Size = new System.Drawing.Size(1027, 498);
            this.dgvViewAttendance.TabIndex = 20;
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle53;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.FillWeight = 180F;
            this.colMemberName.HeaderText = "Member Name";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.HeaderText = "Phone No.";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            this.colPhoneNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colShiftName
            // 
            this.colShiftName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShiftName.DataPropertyName = "ShiftName";
            this.colShiftName.HeaderText = "Shift Name";
            this.colShiftName.Name = "colShiftName";
            this.colShiftName.ReadOnly = true;
            this.colShiftName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShiftName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAttendanceDate
            // 
            this.colAttendanceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAttendanceDate.DataPropertyName = "AttendanceDate";
            this.colAttendanceDate.HeaderText = "Attendance Date";
            this.colAttendanceDate.Name = "colAttendanceDate";
            this.colAttendanceDate.ReadOnly = true;
            this.colAttendanceDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAttendanceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpViewAttendanceMonthAndYearSearch
            // 
            this.tlpViewAttendanceMonthAndYearSearch.ColumnCount = 6;
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tlpViewAttendanceMonthAndYearSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceMonthAndYearSearch.Controls.Add(this.picViewAttendanceSearch2, 0, 0);
            this.tlpViewAttendanceMonthAndYearSearch.Controls.Add(this.btnViewAttendanceSearch, 4, 0);
            this.tlpViewAttendanceMonthAndYearSearch.Controls.Add(this.txtYearSearch, 3, 0);
            this.tlpViewAttendanceMonthAndYearSearch.Controls.Add(this.cmbViewAttendanceShiftSearch, 1, 0);
            this.tlpViewAttendanceMonthAndYearSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewAttendanceMonthAndYearSearch.ForeColor = System.Drawing.Color.Gray;
            this.tlpViewAttendanceMonthAndYearSearch.Location = new System.Drawing.Point(57, 157);
            this.tlpViewAttendanceMonthAndYearSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceMonthAndYearSearch.Name = "tlpViewAttendanceMonthAndYearSearch";
            this.tlpViewAttendanceMonthAndYearSearch.RowCount = 1;
            this.tlpViewAttendanceMonthAndYearSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceMonthAndYearSearch.Size = new System.Drawing.Size(1035, 47);
            this.tlpViewAttendanceMonthAndYearSearch.TabIndex = 19;
            this.tlpViewAttendanceMonthAndYearSearch.Click += new System.EventHandler(this.tlpViewAttendanceMonthAndYearSearch_Click);
            // 
            // picViewAttendanceSearch2
            // 
            this.picViewAttendanceSearch2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picViewAttendanceSearch2.Image = ((System.Drawing.Image)(resources.GetObject("picViewAttendanceSearch2.Image")));
            this.picViewAttendanceSearch2.Location = new System.Drawing.Point(0, 6);
            this.picViewAttendanceSearch2.Margin = new System.Windows.Forms.Padding(0);
            this.picViewAttendanceSearch2.Name = "picViewAttendanceSearch2";
            this.picViewAttendanceSearch2.Size = new System.Drawing.Size(44, 34);
            this.picViewAttendanceSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewAttendanceSearch2.TabIndex = 3;
            this.picViewAttendanceSearch2.TabStop = false;
            this.picViewAttendanceSearch2.Click += new System.EventHandler(this.picViewAttendanceSearch2_Click);
            // 
            // btnViewAttendanceSearch
            // 
            this.btnViewAttendanceSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewAttendanceSearch.AutoSize = true;
            this.btnViewAttendanceSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAttendanceSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewAttendanceSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnViewAttendanceSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAttendanceSearch.ForeColor = System.Drawing.Color.White;
            this.btnViewAttendanceSearch.Location = new System.Drawing.Point(686, 3);
            this.btnViewAttendanceSearch.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnViewAttendanceSearch.Name = "btnViewAttendanceSearch";
            this.btnViewAttendanceSearch.Size = new System.Drawing.Size(99, 40);
            this.btnViewAttendanceSearch.TabIndex = 2;
            this.btnViewAttendanceSearch.Text = "Search";
            this.btnViewAttendanceSearch.UseVisualStyleBackColor = false;
            this.btnViewAttendanceSearch.Click += new System.EventHandler(this.btnViewAttendanceSearch_Click);
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtYearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtYearSearch.Location = new System.Drawing.Point(368, 8);
            this.txtYearSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(316, 30);
            this.txtYearSearch.TabIndex = 5;
            this.txtYearSearch.Text = " Enter The Year .";
            this.txtYearSearch.Click += new System.EventHandler(this.txtYearSearch_Click);
            this.txtYearSearch.Enter += new System.EventHandler(this.txtYearSearch_Enter);
            this.txtYearSearch.Leave += new System.EventHandler(this.txtYearSearch_Leave);
            // 
            // cmbViewAttendanceShiftSearch
            // 
            this.cmbViewAttendanceShiftSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbViewAttendanceShiftSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewAttendanceShiftSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewAttendanceShiftSearch.ForeColor = System.Drawing.Color.Gray;
            this.cmbViewAttendanceShiftSearch.FormattingEnabled = true;
            this.cmbViewAttendanceShiftSearch.Location = new System.Drawing.Point(44, 8);
            this.cmbViewAttendanceShiftSearch.Margin = new System.Windows.Forms.Padding(0);
            this.cmbViewAttendanceShiftSearch.Name = "cmbViewAttendanceShiftSearch";
            this.cmbViewAttendanceShiftSearch.Size = new System.Drawing.Size(316, 31);
            this.cmbViewAttendanceShiftSearch.TabIndex = 4;
            this.cmbViewAttendanceShiftSearch.Click += new System.EventHandler(this.cmbViewAttendanceShiftSearch_Click);
            this.cmbViewAttendanceShiftSearch.Enter += new System.EventHandler(this.cmbViewAttendanceShiftSearch_Enter);
            this.cmbViewAttendanceShiftSearch.Leave += new System.EventHandler(this.cmbViewAttendanceShiftSearch_Leave);
            // 
            // tlpViewAttendanceSearchBar
            // 
            this.tlpViewAttendanceSearchBar.ColumnCount = 3;
            this.tlpViewAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpViewAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpViewAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpViewAttendanceSearchBar.Controls.Add(this.picViewAttendanceSearch1, 0, 0);
            this.tlpViewAttendanceSearchBar.Controls.Add(this.txtViewMemberMobileNumber, 1, 0);
            this.tlpViewAttendanceSearchBar.Location = new System.Drawing.Point(57, 114);
            this.tlpViewAttendanceSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceSearchBar.Name = "tlpViewAttendanceSearchBar";
            this.tlpViewAttendanceSearchBar.RowCount = 1;
            this.tlpViewAttendanceSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceSearchBar.Size = new System.Drawing.Size(1028, 38);
            this.tlpViewAttendanceSearchBar.TabIndex = 17;
            this.tlpViewAttendanceSearchBar.Click += new System.EventHandler(this.tlpViewAttendanceSearchBar_Click);
            // 
            // picViewAttendanceSearch1
            // 
            this.picViewAttendanceSearch1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picViewAttendanceSearch1.Image = ((System.Drawing.Image)(resources.GetObject("picViewAttendanceSearch1.Image")));
            this.picViewAttendanceSearch1.Location = new System.Drawing.Point(0, 1);
            this.picViewAttendanceSearch1.Margin = new System.Windows.Forms.Padding(0);
            this.picViewAttendanceSearch1.Name = "picViewAttendanceSearch1";
            this.picViewAttendanceSearch1.Size = new System.Drawing.Size(44, 35);
            this.picViewAttendanceSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewAttendanceSearch1.TabIndex = 3;
            this.picViewAttendanceSearch1.TabStop = false;
            this.picViewAttendanceSearch1.Click += new System.EventHandler(this.picViewAttendanceSearch1_Click);
            // 
            // txtViewMemberMobileNumber
            // 
            this.txtViewMemberMobileNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtViewMemberMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViewMemberMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewMemberMobileNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtViewMemberMobileNumber.Location = new System.Drawing.Point(44, 4);
            this.txtViewMemberMobileNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtViewMemberMobileNumber.Name = "txtViewMemberMobileNumber";
            this.txtViewMemberMobileNumber.Size = new System.Drawing.Size(316, 30);
            this.txtViewMemberMobileNumber.TabIndex = 5;
            this.txtViewMemberMobileNumber.Text = " Enter Mobile No.";
            this.txtViewMemberMobileNumber.Click += new System.EventHandler(this.txtViewMemberMobileNumber_Click);
            this.txtViewMemberMobileNumber.Enter += new System.EventHandler(this.txtViewMemberMobileNumber_Enter);
            this.txtViewMemberMobileNumber.Leave += new System.EventHandler(this.txtViewMemberMobileNumber_Leave);
            // 
            // FrmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 750);
            this.Controls.Add(this.tlpViewAttendanceEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1166, 717);
            this.Name = "FrmViewAttendance";
            this.Text = "FrmViewAttendance";
            this.Load += new System.EventHandler(this.FrmViewAttendance_Load);
            this.Shown += new System.EventHandler(this.FrmViewAttendance_Shown);
            this.tlpViewAttendanceEntireForm.ResumeLayout(false);
            this.tlpViewAttendanceHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceMark)).EndInit();
            this.tlpViewAttendanceTitle.ResumeLayout(false);
            this.tlpViewAttendanceTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttendance)).EndInit();
            this.tlpViewAttendanceMonthAndYearSearch.ResumeLayout(false);
            this.tlpViewAttendanceMonthAndYearSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceSearch2)).EndInit();
            this.tlpViewAttendanceSearchBar.ResumeLayout(false);
            this.tlpViewAttendanceSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceSearch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpViewAttendanceEntireForm;
        private System.Windows.Forms.TableLayoutPanel tlpViewAttendanceHeader;
        private System.Windows.Forms.PictureBox picViewAttendanceMark;
        private System.Windows.Forms.TableLayoutPanel tlpViewAttendanceTitle;
        private System.Windows.Forms.Label lblViewMemberAttendance;
        private System.Windows.Forms.Label lblViewAttendance;
        private System.Windows.Forms.TableLayoutPanel tlpViewAttendanceSearchBar;
        private System.Windows.Forms.PictureBox picViewAttendanceSearch1;
        private System.Windows.Forms.TextBox txtViewMemberMobileNumber;
        private System.Windows.Forms.TableLayoutPanel tlpViewAttendanceMonthAndYearSearch;
        private System.Windows.Forms.PictureBox picViewAttendanceSearch2;
        private System.Windows.Forms.Button btnViewAttendanceSearch;
        private System.Windows.Forms.TextBox txtYearSearch;
        private System.Windows.Forms.ComboBox cmbViewAttendanceShiftSearch;
        private System.Windows.Forms.DataGridView dgvViewAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceDate;

    }
}