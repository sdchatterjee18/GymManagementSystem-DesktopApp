namespace GymManagementSystem.FORMS.Attendance
{
    partial class FrmMarkAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkAttendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMarkAttendanceHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picMarkAttendanceMark = new System.Windows.Forms.PictureBox();
            this.tlpAttendanceTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblInputMarkAttendance = new System.Windows.Forms.Label();
            this.lblMarkAttendance = new System.Windows.Forms.Label();
            this.tlpMarkAttendanceEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMarkAttendance = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkAttendance = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpMarkAttendanceSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnMarkAttendanceSearch = new System.Windows.Forms.Button();
            this.picMarkAttendanceSearch = new System.Windows.Forms.PictureBox();
            this.txtMarkMemberMobileNumber = new System.Windows.Forms.TextBox();
            this.cmbMarkAttendanceShiftSearch = new System.Windows.Forms.ComboBox();
            this.tlpMarkAttendanceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMarkAttendanceMark)).BeginInit();
            this.tlpAttendanceTitle.SuspendLayout();
            this.tlpMarkAttendanceEntireForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkAttendance)).BeginInit();
            this.tlpMarkAttendanceSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMarkAttendanceSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMarkAttendanceHeader
            // 
            this.tlpMarkAttendanceHeader.ColumnCount = 3;
            this.tlpMarkAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpMarkAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tlpMarkAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarkAttendanceHeader.Controls.Add(this.picMarkAttendanceMark, 0, 0);
            this.tlpMarkAttendanceHeader.Controls.Add(this.tlpAttendanceTitle, 1, 0);
            this.tlpMarkAttendanceHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarkAttendanceHeader.Location = new System.Drawing.Point(57, 38);
            this.tlpMarkAttendanceHeader.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.tlpMarkAttendanceHeader.Name = "tlpMarkAttendanceHeader";
            this.tlpMarkAttendanceHeader.RowCount = 1;
            this.tlpMarkAttendanceHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarkAttendanceHeader.Size = new System.Drawing.Size(1032, 62);
            this.tlpMarkAttendanceHeader.TabIndex = 9;
            // 
            // picMarkAttendanceMark
            // 
            this.picMarkAttendanceMark.Image = ((System.Drawing.Image)(resources.GetObject("picMarkAttendanceMark.Image")));
            this.picMarkAttendanceMark.Location = new System.Drawing.Point(0, 0);
            this.picMarkAttendanceMark.Margin = new System.Windows.Forms.Padding(0);
            this.picMarkAttendanceMark.Name = "picMarkAttendanceMark";
            this.picMarkAttendanceMark.Size = new System.Drawing.Size(69, 62);
            this.picMarkAttendanceMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMarkAttendanceMark.TabIndex = 0;
            this.picMarkAttendanceMark.TabStop = false;
            // 
            // tlpAttendanceTitle
            // 
            this.tlpAttendanceTitle.ColumnCount = 1;
            this.tlpAttendanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttendanceTitle.Controls.Add(this.lblInputMarkAttendance, 0, 1);
            this.tlpAttendanceTitle.Controls.Add(this.lblMarkAttendance, 0, 0);
            this.tlpAttendanceTitle.Location = new System.Drawing.Point(69, 0);
            this.tlpAttendanceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAttendanceTitle.Name = "tlpAttendanceTitle";
            this.tlpAttendanceTitle.RowCount = 2;
            this.tlpAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.tlpAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.48387F));
            this.tlpAttendanceTitle.Size = new System.Drawing.Size(356, 62);
            this.tlpAttendanceTitle.TabIndex = 1;
            // 
            // lblInputMarkAttendance
            // 
            this.lblInputMarkAttendance.AutoEllipsis = true;
            this.lblInputMarkAttendance.AutoSize = true;
            this.lblInputMarkAttendance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputMarkAttendance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblInputMarkAttendance.Location = new System.Drawing.Point(3, 36);
            this.lblInputMarkAttendance.Name = "lblInputMarkAttendance";
            this.lblInputMarkAttendance.Size = new System.Drawing.Size(181, 19);
            this.lblInputMarkAttendance.TabIndex = 3;
            this.lblInputMarkAttendance.Text = "Input Member\'s Attendance";
            // 
            // lblMarkAttendance
            // 
            this.lblMarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarkAttendance.AutoSize = true;
            this.lblMarkAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkAttendance.Location = new System.Drawing.Point(3, 8);
            this.lblMarkAttendance.Name = "lblMarkAttendance";
            this.lblMarkAttendance.Size = new System.Drawing.Size(264, 28);
            this.lblMarkAttendance.TabIndex = 2;
            this.lblMarkAttendance.Text = "Mark Member\'s Attendance";
            // 
            // tlpMarkAttendanceEntireForm
            // 
            this.tlpMarkAttendanceEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMarkAttendanceEntireForm.ColumnCount = 3;
            this.tlpMarkAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMarkAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMarkAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMarkAttendanceEntireForm.Controls.Add(this.tlpMarkAttendanceHeader, 1, 1);
            this.tlpMarkAttendanceEntireForm.Controls.Add(this.dgvMarkAttendance, 1, 4);
            this.tlpMarkAttendanceEntireForm.Controls.Add(this.tlpMarkAttendanceSearchBar, 1, 3);
            this.tlpMarkAttendanceEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarkAttendanceEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpMarkAttendanceEntireForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMarkAttendanceEntireForm.Name = "tlpMarkAttendanceEntireForm";
            this.tlpMarkAttendanceEntireForm.RowCount = 6;
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.809199F));
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.816866F));
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5059017F));
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.614565F));
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.93625F));
            this.tlpMarkAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.317221F));
            this.tlpMarkAttendanceEntireForm.Size = new System.Drawing.Size(1151, 750);
            this.tlpMarkAttendanceEntireForm.TabIndex = 0;
            // 
            // dgvMarkAttendance
            // 
            this.dgvMarkAttendance.AllowUserToAddRows = false;
            this.dgvMarkAttendance.AllowUserToDeleteRows = false;
            this.dgvMarkAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMarkAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarkAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvMarkAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarkAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarkAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarkAttendance.ColumnHeadersHeight = 50;
            this.dgvMarkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarkAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMemberId,
            this.colMemberName,
            this.colPhoneNo,
            this.colShiftId,
            this.colShiftName,
            this.colMarkAttendance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarkAttendance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMarkAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarkAttendance.EnableHeadersVisualStyles = false;
            this.dgvMarkAttendance.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMarkAttendance.Location = new System.Drawing.Point(60, 164);
            this.dgvMarkAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMarkAttendance.MultiSelect = false;
            this.dgvMarkAttendance.Name = "dgvMarkAttendance";
            this.dgvMarkAttendance.ReadOnly = true;
            this.dgvMarkAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarkAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMarkAttendance.RowHeadersVisible = false;
            this.dgvMarkAttendance.RowHeadersWidth = 50;
            this.dgvMarkAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvMarkAttendance.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMarkAttendance.RowTemplate.Height = 50;
            this.dgvMarkAttendance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarkAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMarkAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMarkAttendance.Size = new System.Drawing.Size(1029, 543);
            this.dgvMarkAttendance.TabIndex = 18;
            this.dgvMarkAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkAttendance_CellContentClick);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMemberId
            // 
            this.colMemberId.DataPropertyName = "MemberId";
            this.colMemberId.HeaderText = "Member Id";
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.ReadOnly = true;
            this.colMemberId.Visible = false;
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
            // colShiftId
            // 
            this.colShiftId.DataPropertyName = "ShiftId";
            this.colShiftId.HeaderText = "Shift Id";
            this.colShiftId.Name = "colShiftId";
            this.colShiftId.ReadOnly = true;
            this.colShiftId.Visible = false;
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
            // colMarkAttendance
            // 
            this.colMarkAttendance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMarkAttendance.HeaderText = "Mark Attendance";
            this.colMarkAttendance.Name = "colMarkAttendance";
            this.colMarkAttendance.ReadOnly = true;
            this.colMarkAttendance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMarkAttendance.Text = "✅Present";
            this.colMarkAttendance.UseColumnTextForButtonValue = true;
            // 
            // tlpMarkAttendanceSearchBar
            // 
            this.tlpMarkAttendanceSearchBar.ColumnCount = 6;
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tlpMarkAttendanceSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarkAttendanceSearchBar.Controls.Add(this.btnMarkAttendanceSearch, 4, 0);
            this.tlpMarkAttendanceSearchBar.Controls.Add(this.picMarkAttendanceSearch, 0, 0);
            this.tlpMarkAttendanceSearchBar.Controls.Add(this.txtMarkMemberMobileNumber, 3, 0);
            this.tlpMarkAttendanceSearchBar.Controls.Add(this.cmbMarkAttendanceShiftSearch, 1, 0);
            this.tlpMarkAttendanceSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarkAttendanceSearchBar.Location = new System.Drawing.Point(60, 107);
            this.tlpMarkAttendanceSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMarkAttendanceSearchBar.Name = "tlpMarkAttendanceSearchBar";
            this.tlpMarkAttendanceSearchBar.RowCount = 1;
            this.tlpMarkAttendanceSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarkAttendanceSearchBar.Size = new System.Drawing.Size(1029, 53);
            this.tlpMarkAttendanceSearchBar.TabIndex = 19;
            // 
            // btnMarkAttendanceSearch
            // 
            this.btnMarkAttendanceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAttendanceSearch.AutoSize = true;
            this.btnMarkAttendanceSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMarkAttendanceSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMarkAttendanceSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMarkAttendanceSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAttendanceSearch.ForeColor = System.Drawing.Color.White;
            this.btnMarkAttendanceSearch.Location = new System.Drawing.Point(685, 6);
            this.btnMarkAttendanceSearch.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMarkAttendanceSearch.Name = "btnMarkAttendanceSearch";
            this.btnMarkAttendanceSearch.Size = new System.Drawing.Size(99, 40);
            this.btnMarkAttendanceSearch.TabIndex = 2;
            this.btnMarkAttendanceSearch.Text = "Search";
            this.btnMarkAttendanceSearch.UseVisualStyleBackColor = false;
            this.btnMarkAttendanceSearch.Click += new System.EventHandler(this.btnMarkAttendanceSearch_Click);
            // 
            // picMarkAttendanceSearch
            // 
            this.picMarkAttendanceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picMarkAttendanceSearch.Image = ((System.Drawing.Image)(resources.GetObject("picMarkAttendanceSearch.Image")));
            this.picMarkAttendanceSearch.Location = new System.Drawing.Point(0, 9);
            this.picMarkAttendanceSearch.Margin = new System.Windows.Forms.Padding(0);
            this.picMarkAttendanceSearch.Name = "picMarkAttendanceSearch";
            this.picMarkAttendanceSearch.Size = new System.Drawing.Size(44, 35);
            this.picMarkAttendanceSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMarkAttendanceSearch.TabIndex = 3;
            this.picMarkAttendanceSearch.TabStop = false;
            // 
            // txtMarkMemberMobileNumber
            // 
            this.txtMarkMemberMobileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarkMemberMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkMemberMobileNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkMemberMobileNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtMarkMemberMobileNumber.Location = new System.Drawing.Point(367, 11);
            this.txtMarkMemberMobileNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtMarkMemberMobileNumber.Name = "txtMarkMemberMobileNumber";
            this.txtMarkMemberMobileNumber.Size = new System.Drawing.Size(316, 30);
            this.txtMarkMemberMobileNumber.TabIndex = 5;
            this.txtMarkMemberMobileNumber.Text = " Enter Mobile No.";
            // 
            // cmbMarkAttendanceShiftSearch
            // 
            this.cmbMarkAttendanceShiftSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarkAttendanceShiftSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarkAttendanceShiftSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarkAttendanceShiftSearch.ForeColor = System.Drawing.Color.Gray;
            this.cmbMarkAttendanceShiftSearch.FormattingEnabled = true;
            this.cmbMarkAttendanceShiftSearch.Location = new System.Drawing.Point(44, 11);
            this.cmbMarkAttendanceShiftSearch.Margin = new System.Windows.Forms.Padding(0);
            this.cmbMarkAttendanceShiftSearch.Name = "cmbMarkAttendanceShiftSearch";
            this.cmbMarkAttendanceShiftSearch.Size = new System.Drawing.Size(316, 31);
            this.cmbMarkAttendanceShiftSearch.TabIndex = 4;
            this.cmbMarkAttendanceShiftSearch.SelectedIndexChanged += new System.EventHandler(this.cmbMarkAttendanceShiftSearch_SelectedIndexChanged);
            this.cmbMarkAttendanceShiftSearch.SelectionChangeCommitted += new System.EventHandler(this.cmbMarkAttendanceShiftSearch_SelectionChangeCommitted);
            // 
            // FrmMarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 750);
            this.Controls.Add(this.tlpMarkAttendanceEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1166, 717);
            this.Name = "FrmMarkAttendance";
            this.Text = "FrmMarkAttendance";
            this.Load += new System.EventHandler(this.FrmMarkAttendance_Load);
            this.tlpMarkAttendanceHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMarkAttendanceMark)).EndInit();
            this.tlpAttendanceTitle.ResumeLayout(false);
            this.tlpAttendanceTitle.PerformLayout();
            this.tlpMarkAttendanceEntireForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkAttendance)).EndInit();
            this.tlpMarkAttendanceSearchBar.ResumeLayout(false);
            this.tlpMarkAttendanceSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMarkAttendanceSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMarkAttendanceHeader;
        private System.Windows.Forms.PictureBox picMarkAttendanceMark;
        private System.Windows.Forms.TableLayoutPanel tlpAttendanceTitle;
        private System.Windows.Forms.Label lblInputMarkAttendance;
        private System.Windows.Forms.Label lblMarkAttendance;
        private System.Windows.Forms.TableLayoutPanel tlpMarkAttendanceEntireForm;
        private System.Windows.Forms.DataGridView dgvMarkAttendance;
        private System.Windows.Forms.TableLayoutPanel tlpMarkAttendanceSearchBar;
        private System.Windows.Forms.Button btnMarkAttendanceSearch;
        private System.Windows.Forms.PictureBox picMarkAttendanceSearch;
        private System.Windows.Forms.ComboBox cmbMarkAttendanceShiftSearch;
        private System.Windows.Forms.TextBox txtMarkMemberMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftName;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAttendance;

    }
}