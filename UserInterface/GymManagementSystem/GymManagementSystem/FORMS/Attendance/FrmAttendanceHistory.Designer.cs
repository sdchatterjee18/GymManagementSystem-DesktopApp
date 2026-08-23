namespace GymManagementSystem.FORMS.Attendance
{
    partial class FrmAttendanceHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendanceHistory));
            this.tlpAttendanceHistory = new System.Windows.Forms.TableLayoutPanel();
            this.dgvViewAttendanceHistory = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAttendanceHistoryHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picAttendanceHistory = new System.Windows.Forms.PictureBox();
            this.tlpAttendanceHistoryTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewAttendanceHistoryDetails = new System.Windows.Forms.Label();
            this.lblAttendanceHistory = new System.Windows.Forms.Label();
            this.tlpDateRangeAttendanceHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRangeAttendanceHistory = new System.Windows.Forms.Label();
            this.picDateRangeAttendanceHistory = new System.Windows.Forms.PictureBox();
            this.tlpStartAndEndDateAttendanceHistory = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchAttendanceHistory = new System.Windows.Forms.Button();
            this.lblStartDateAttendanceHistory = new System.Windows.Forms.Label();
            this.dtpStartDateAttendanceHistory = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateAttendanceHistory = new System.Windows.Forms.Label();
            this.dtpEndDateAttendanceHistory = new System.Windows.Forms.DateTimePicker();
            this.picStartDateAttendanceHistory = new System.Windows.Forms.PictureBox();
            this.picEndDateAttendanceHistory = new System.Windows.Forms.PictureBox();
            this.tlpTotalAttendance = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAttendancePaymentHistory = new System.Windows.Forms.Label();
            this.lblOutputTotalAttendance = new System.Windows.Forms.Label();
            this.tlpAttendanceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttendanceHistory)).BeginInit();
            this.tlpAttendanceHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttendanceHistory)).BeginInit();
            this.tlpAttendanceHistoryTitle.SuspendLayout();
            this.tlpDateRangeAttendanceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangeAttendanceHistory)).BeginInit();
            this.tlpStartAndEndDateAttendanceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDateAttendanceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDateAttendanceHistory)).BeginInit();
            this.tlpTotalAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAttendanceHistory
            // 
            this.tlpAttendanceHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpAttendanceHistory.ColumnCount = 3;
            this.tlpAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.30662F));
            this.tlpAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.21255F));
            this.tlpAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.480836F));
            this.tlpAttendanceHistory.Controls.Add(this.dgvViewAttendanceHistory, 1, 5);
            this.tlpAttendanceHistory.Controls.Add(this.tlpAttendanceHistoryHeader, 1, 1);
            this.tlpAttendanceHistory.Controls.Add(this.tlpDateRangeAttendanceHistory, 1, 2);
            this.tlpAttendanceHistory.Controls.Add(this.tlpStartAndEndDateAttendanceHistory, 1, 3);
            this.tlpAttendanceHistory.Controls.Add(this.tlpTotalAttendance, 1, 4);
            this.tlpAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttendanceHistory.Location = new System.Drawing.Point(0, 0);
            this.tlpAttendanceHistory.Name = "tlpAttendanceHistory";
            this.tlpAttendanceHistory.RowCount = 7;
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.039348F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28955F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.025126F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.025126F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.145729F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.97488F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.412523F));
            this.tlpAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAttendanceHistory.Size = new System.Drawing.Size(1172, 796);
            this.tlpAttendanceHistory.TabIndex = 4;
            this.tlpAttendanceHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAttendanceHistory_Paint);
            // 
            // dgvViewAttendanceHistory
            // 
            this.dgvViewAttendanceHistory.AllowUserToAddRows = false;
            this.dgvViewAttendanceHistory.AllowUserToDeleteRows = false;
            this.dgvViewAttendanceHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dgvViewAttendanceHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAttendanceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAttendanceHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvViewAttendanceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAttendanceHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendanceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewAttendanceHistory.ColumnHeadersHeight = 40;
            this.dgvViewAttendanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewAttendanceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMemberName,
            this.colPhoneNo,
            this.colShiftName,
            this.colAttendanceDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAttendanceHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAttendanceHistory.EnableHeadersVisualStyles = false;
            this.dgvViewAttendanceHistory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvViewAttendanceHistory.Location = new System.Drawing.Point(18, 212);
            this.dgvViewAttendanceHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvViewAttendanceHistory.MultiSelect = false;
            this.dgvViewAttendanceHistory.Name = "dgvViewAttendanceHistory";
            this.dgvViewAttendanceHistory.ReadOnly = true;
            this.dgvViewAttendanceHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendanceHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvViewAttendanceHistory.RowHeadersVisible = false;
            this.dgvViewAttendanceHistory.RowHeadersWidth = 50;
            this.dgvViewAttendanceHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dgvViewAttendanceHistory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvViewAttendanceHistory.RowTemplate.Height = 30;
            this.dgvViewAttendanceHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAttendanceHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewAttendanceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvViewAttendanceHistory.Size = new System.Drawing.Size(1133, 553);
            this.dgvViewAttendanceHistory.TabIndex = 21;
            this.dgvViewAttendanceHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvViewAttendanceHistory_CellFormatting);
            this.dgvViewAttendanceHistory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAttendanceHistory_CellMouseEnter);
            this.dgvViewAttendanceHistory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAttendanceHistory_CellMouseLeave);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSerialNo.Width = 70;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.FillWeight = 180F;
            this.colMemberName.HeaderText = "Member Name";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMemberName.Width = 170;
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
            // tlpAttendanceHistoryHeader
            // 
            this.tlpAttendanceHistoryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpAttendanceHistoryHeader.ColumnCount = 4;
            this.tlpAttendanceHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpAttendanceHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tlpAttendanceHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16434F));
            this.tlpAttendanceHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83566F));
            this.tlpAttendanceHistoryHeader.Controls.Add(this.picAttendanceHistory, 0, 0);
            this.tlpAttendanceHistoryHeader.Controls.Add(this.tlpAttendanceHistoryTitle, 1, 0);
            this.tlpAttendanceHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttendanceHistoryHeader.Location = new System.Drawing.Point(18, 10);
            this.tlpAttendanceHistoryHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAttendanceHistoryHeader.Name = "tlpAttendanceHistoryHeader";
            this.tlpAttendanceHistoryHeader.RowCount = 1;
            this.tlpAttendanceHistoryHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttendanceHistoryHeader.Size = new System.Drawing.Size(1133, 85);
            this.tlpAttendanceHistoryHeader.TabIndex = 10;
            // 
            // picAttendanceHistory
            // 
            this.picAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAttendanceHistory.Image = ((System.Drawing.Image)(resources.GetObject("picAttendanceHistory.Image")));
            this.picAttendanceHistory.Location = new System.Drawing.Point(0, 0);
            this.picAttendanceHistory.Margin = new System.Windows.Forms.Padding(0);
            this.picAttendanceHistory.Name = "picAttendanceHistory";
            this.picAttendanceHistory.Size = new System.Drawing.Size(73, 85);
            this.picAttendanceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAttendanceHistory.TabIndex = 0;
            this.picAttendanceHistory.TabStop = false;
            // 
            // tlpAttendanceHistoryTitle
            // 
            this.tlpAttendanceHistoryTitle.ColumnCount = 1;
            this.tlpAttendanceHistoryTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttendanceHistoryTitle.Controls.Add(this.lblViewAttendanceHistoryDetails, 0, 1);
            this.tlpAttendanceHistoryTitle.Controls.Add(this.lblAttendanceHistory, 0, 0);
            this.tlpAttendanceHistoryTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttendanceHistoryTitle.Location = new System.Drawing.Point(76, 3);
            this.tlpAttendanceHistoryTitle.Name = "tlpAttendanceHistoryTitle";
            this.tlpAttendanceHistoryTitle.RowCount = 3;
            this.tlpAttendanceHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tlpAttendanceHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.84058F));
            this.tlpAttendanceHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08696F));
            this.tlpAttendanceHistoryTitle.Size = new System.Drawing.Size(303, 79);
            this.tlpAttendanceHistoryTitle.TabIndex = 1;
            // 
            // lblViewAttendanceHistoryDetails
            // 
            this.lblViewAttendanceHistoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewAttendanceHistoryDetails.AutoSize = true;
            this.lblViewAttendanceHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAttendanceHistoryDetails.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewAttendanceHistoryDetails.Location = new System.Drawing.Point(3, 42);
            this.lblViewAttendanceHistoryDetails.Name = "lblViewAttendanceHistoryDetails";
            this.lblViewAttendanceHistoryDetails.Size = new System.Drawing.Size(290, 15);
            this.lblViewAttendanceHistoryDetails.TabIndex = 3;
            this.lblViewAttendanceHistoryDetails.Text = "View All Members Attendance Details By Date";
            // 
            // lblAttendanceHistory
            // 
            this.lblAttendanceHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttendanceHistory.AutoSize = true;
            this.lblAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceHistory.Location = new System.Drawing.Point(3, 14);
            this.lblAttendanceHistory.Name = "lblAttendanceHistory";
            this.lblAttendanceHistory.Size = new System.Drawing.Size(188, 28);
            this.lblAttendanceHistory.TabIndex = 2;
            this.lblAttendanceHistory.Text = "Attendance History";
            // 
            // tlpDateRangeAttendanceHistory
            // 
            this.tlpDateRangeAttendanceHistory.ColumnCount = 3;
            this.tlpDateRangeAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpDateRangeAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpDateRangeAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangeAttendanceHistory.Controls.Add(this.lblDateRangeAttendanceHistory, 1, 0);
            this.tlpDateRangeAttendanceHistory.Controls.Add(this.picDateRangeAttendanceHistory, 0, 0);
            this.tlpDateRangeAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateRangeAttendanceHistory.Location = new System.Drawing.Point(18, 100);
            this.tlpDateRangeAttendanceHistory.Name = "tlpDateRangeAttendanceHistory";
            this.tlpDateRangeAttendanceHistory.RowCount = 1;
            this.tlpDateRangeAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangeAttendanceHistory.Size = new System.Drawing.Size(1133, 34);
            this.tlpDateRangeAttendanceHistory.TabIndex = 12;
            // 
            // lblDateRangeAttendanceHistory
            // 
            this.lblDateRangeAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateRangeAttendanceHistory.AutoSize = true;
            this.lblDateRangeAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRangeAttendanceHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateRangeAttendanceHistory.Location = new System.Drawing.Point(40, 5);
            this.lblDateRangeAttendanceHistory.Name = "lblDateRangeAttendanceHistory";
            this.lblDateRangeAttendanceHistory.Size = new System.Drawing.Size(105, 23);
            this.lblDateRangeAttendanceHistory.TabIndex = 0;
            this.lblDateRangeAttendanceHistory.Text = "Date Range ";
            // 
            // picDateRangeAttendanceHistory
            // 
            this.picDateRangeAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picDateRangeAttendanceHistory.Image = ((System.Drawing.Image)(resources.GetObject("picDateRangeAttendanceHistory.Image")));
            this.picDateRangeAttendanceHistory.Location = new System.Drawing.Point(3, 3);
            this.picDateRangeAttendanceHistory.Name = "picDateRangeAttendanceHistory";
            this.picDateRangeAttendanceHistory.Size = new System.Drawing.Size(31, 28);
            this.picDateRangeAttendanceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDateRangeAttendanceHistory.TabIndex = 0;
            this.picDateRangeAttendanceHistory.TabStop = false;
            // 
            // tlpStartAndEndDateAttendanceHistory
            // 
            this.tlpStartAndEndDateAttendanceHistory.ColumnCount = 8;
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpStartAndEndDateAttendanceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.btnSearchAttendanceHistory, 6, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.lblStartDateAttendanceHistory, 1, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.dtpStartDateAttendanceHistory, 2, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.lblEndDateAttendanceHistory, 4, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.dtpEndDateAttendanceHistory, 5, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.picStartDateAttendanceHistory, 0, 0);
            this.tlpStartAndEndDateAttendanceHistory.Controls.Add(this.picEndDateAttendanceHistory, 3, 0);
            this.tlpStartAndEndDateAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartAndEndDateAttendanceHistory.Location = new System.Drawing.Point(18, 140);
            this.tlpStartAndEndDateAttendanceHistory.Name = "tlpStartAndEndDateAttendanceHistory";
            this.tlpStartAndEndDateAttendanceHistory.RowCount = 1;
            this.tlpStartAndEndDateAttendanceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDateAttendanceHistory.Size = new System.Drawing.Size(1133, 34);
            this.tlpStartAndEndDateAttendanceHistory.TabIndex = 13;
            // 
            // btnSearchAttendanceHistory
            // 
            this.btnSearchAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchAttendanceHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchAttendanceHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchAttendanceHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchAttendanceHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchAttendanceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAttendanceHistory.ForeColor = System.Drawing.Color.White;
            this.btnSearchAttendanceHistory.Location = new System.Drawing.Point(1006, 0);
            this.btnSearchAttendanceHistory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearchAttendanceHistory.Name = "btnSearchAttendanceHistory";
            this.btnSearchAttendanceHistory.Size = new System.Drawing.Size(107, 34);
            this.btnSearchAttendanceHistory.TabIndex = 5;
            this.btnSearchAttendanceHistory.Text = "Search";
            this.btnSearchAttendanceHistory.UseVisualStyleBackColor = false;
            // 
            // lblStartDateAttendanceHistory
            // 
            this.lblStartDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDateAttendanceHistory.AutoSize = true;
            this.lblStartDateAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateAttendanceHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStartDateAttendanceHistory.Location = new System.Drawing.Point(40, 5);
            this.lblStartDateAttendanceHistory.Name = "lblStartDateAttendanceHistory";
            this.lblStartDateAttendanceHistory.Size = new System.Drawing.Size(96, 23);
            this.lblStartDateAttendanceHistory.TabIndex = 0;
            this.lblStartDateAttendanceHistory.Text = "Start Date :";
            // 
            // dtpStartDateAttendanceHistory
            // 
            this.dtpStartDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDateAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateAttendanceHistory.Location = new System.Drawing.Point(168, 3);
            this.dtpStartDateAttendanceHistory.Name = "dtpStartDateAttendanceHistory";
            this.dtpStartDateAttendanceHistory.Size = new System.Drawing.Size(319, 30);
            this.dtpStartDateAttendanceHistory.TabIndex = 1;
            // 
            // lblEndDateAttendanceHistory
            // 
            this.lblEndDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDateAttendanceHistory.AutoSize = true;
            this.lblEndDateAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateAttendanceHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEndDateAttendanceHistory.Location = new System.Drawing.Point(543, 5);
            this.lblEndDateAttendanceHistory.Name = "lblEndDateAttendanceHistory";
            this.lblEndDateAttendanceHistory.Size = new System.Drawing.Size(89, 23);
            this.lblEndDateAttendanceHistory.TabIndex = 0;
            this.lblEndDateAttendanceHistory.Text = "End Date :";
            // 
            // dtpEndDateAttendanceHistory
            // 
            this.dtpEndDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDateAttendanceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateAttendanceHistory.Location = new System.Drawing.Point(664, 3);
            this.dtpEndDateAttendanceHistory.Name = "dtpEndDateAttendanceHistory";
            this.dtpEndDateAttendanceHistory.Size = new System.Drawing.Size(325, 30);
            this.dtpEndDateAttendanceHistory.TabIndex = 0;
            // 
            // picStartDateAttendanceHistory
            // 
            this.picStartDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picStartDateAttendanceHistory.Image = ((System.Drawing.Image)(resources.GetObject("picStartDateAttendanceHistory.Image")));
            this.picStartDateAttendanceHistory.Location = new System.Drawing.Point(3, 3);
            this.picStartDateAttendanceHistory.Name = "picStartDateAttendanceHistory";
            this.picStartDateAttendanceHistory.Size = new System.Drawing.Size(31, 28);
            this.picStartDateAttendanceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStartDateAttendanceHistory.TabIndex = 2;
            this.picStartDateAttendanceHistory.TabStop = false;
            // 
            // picEndDateAttendanceHistory
            // 
            this.picEndDateAttendanceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picEndDateAttendanceHistory.Image = ((System.Drawing.Image)(resources.GetObject("picEndDateAttendanceHistory.Image")));
            this.picEndDateAttendanceHistory.Location = new System.Drawing.Point(506, 3);
            this.picEndDateAttendanceHistory.Name = "picEndDateAttendanceHistory";
            this.picEndDateAttendanceHistory.Size = new System.Drawing.Size(31, 28);
            this.picEndDateAttendanceHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEndDateAttendanceHistory.TabIndex = 3;
            this.picEndDateAttendanceHistory.TabStop = false;
            // 
            // tlpTotalAttendance
            // 
            this.tlpTotalAttendance.ColumnCount = 3;
            this.tlpTotalAttendance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalAttendance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlpTotalAttendance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTotalAttendance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTotalAttendance.Controls.Add(this.lblTotalAttendancePaymentHistory, 1, 0);
            this.tlpTotalAttendance.Controls.Add(this.lblOutputTotalAttendance, 2, 0);
            this.tlpTotalAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalAttendance.Location = new System.Drawing.Point(18, 180);
            this.tlpTotalAttendance.Name = "tlpTotalAttendance";
            this.tlpTotalAttendance.RowCount = 1;
            this.tlpTotalAttendance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalAttendance.Size = new System.Drawing.Size(1133, 27);
            this.tlpTotalAttendance.TabIndex = 15;
            // 
            // lblTotalAttendancePaymentHistory
            // 
            this.lblTotalAttendancePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalAttendancePaymentHistory.AutoSize = true;
            this.lblTotalAttendancePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAttendancePaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalAttendancePaymentHistory.Location = new System.Drawing.Point(844, 2);
            this.lblTotalAttendancePaymentHistory.Name = "lblTotalAttendancePaymentHistory";
            this.lblTotalAttendancePaymentHistory.Size = new System.Drawing.Size(148, 23);
            this.lblTotalAttendancePaymentHistory.TabIndex = 0;
            this.lblTotalAttendancePaymentHistory.Text = "Total Attendance :";
            // 
            // lblOutputTotalAttendance
            // 
            this.lblOutputTotalAttendance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutputTotalAttendance.AutoSize = true;
            this.lblOutputTotalAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotalAttendance.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputTotalAttendance.Location = new System.Drawing.Point(1016, 2);
            this.lblOutputTotalAttendance.Name = "lblOutputTotalAttendance";
            this.lblOutputTotalAttendance.Size = new System.Drawing.Size(31, 23);
            this.lblOutputTotalAttendance.TabIndex = 2;
            this.lblOutputTotalAttendance.Text = "---";
            // 
            // FrmAttendanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 796);
            this.Controls.Add(this.tlpAttendanceHistory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAttendanceHistory";
            this.Text = "FrmAttendanceHistory";
            this.Load += new System.EventHandler(this.FrmAttendanceHistory_Load);
            this.Shown += new System.EventHandler(this.FrmAttendanceHistory_Shown);
            this.tlpAttendanceHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttendanceHistory)).EndInit();
            this.tlpAttendanceHistoryHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAttendanceHistory)).EndInit();
            this.tlpAttendanceHistoryTitle.ResumeLayout(false);
            this.tlpAttendanceHistoryTitle.PerformLayout();
            this.tlpDateRangeAttendanceHistory.ResumeLayout(false);
            this.tlpDateRangeAttendanceHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangeAttendanceHistory)).EndInit();
            this.tlpStartAndEndDateAttendanceHistory.ResumeLayout(false);
            this.tlpStartAndEndDateAttendanceHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDateAttendanceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDateAttendanceHistory)).EndInit();
            this.tlpTotalAttendance.ResumeLayout(false);
            this.tlpTotalAttendance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAttendanceHistory;
        private System.Windows.Forms.DataGridView dgvViewAttendanceHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceDate;
        private System.Windows.Forms.TableLayoutPanel tlpAttendanceHistoryHeader;
        private System.Windows.Forms.PictureBox picAttendanceHistory;
        private System.Windows.Forms.TableLayoutPanel tlpAttendanceHistoryTitle;
        private System.Windows.Forms.Label lblViewAttendanceHistoryDetails;
        private System.Windows.Forms.Label lblAttendanceHistory;
        private System.Windows.Forms.TableLayoutPanel tlpDateRangeAttendanceHistory;
        private System.Windows.Forms.Label lblDateRangeAttendanceHistory;
        private System.Windows.Forms.PictureBox picDateRangeAttendanceHistory;
        private System.Windows.Forms.TableLayoutPanel tlpStartAndEndDateAttendanceHistory;
        private System.Windows.Forms.Button btnSearchAttendanceHistory;
        private System.Windows.Forms.Label lblStartDateAttendanceHistory;
        private System.Windows.Forms.DateTimePicker dtpStartDateAttendanceHistory;
        private System.Windows.Forms.Label lblEndDateAttendanceHistory;
        private System.Windows.Forms.DateTimePicker dtpEndDateAttendanceHistory;
        private System.Windows.Forms.PictureBox picStartDateAttendanceHistory;
        private System.Windows.Forms.PictureBox picEndDateAttendanceHistory;
        private System.Windows.Forms.TableLayoutPanel tlpTotalAttendance;
        private System.Windows.Forms.Label lblTotalAttendancePaymentHistory;
        private System.Windows.Forms.Label lblOutputTotalAttendance;
    }
}