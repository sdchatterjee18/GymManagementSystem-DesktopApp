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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAttendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpViewAttendanceEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpViewAttendanceHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picViewAttendanceMark = new System.Windows.Forms.PictureBox();
            this.tlpViewAttendanceTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewMemberAttendance = new System.Windows.Forms.Label();
            this.lblViewAttendance = new System.Windows.Forms.Label();
            this.dgvViewAttendance = new System.Windows.Forms.DataGridView();
            this.tlpViewAttendanceSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.picViewAttendanceSearch1 = new System.Windows.Forms.PictureBox();
            this.txtViewMemberMobileNumber = new System.Windows.Forms.TextBox();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpViewAttendanceEntireForm.SuspendLayout();
            this.tlpViewAttendanceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceMark)).BeginInit();
            this.tlpViewAttendanceTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAttendance)).BeginInit();
            this.tlpViewAttendanceSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewAttendanceSearch1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpViewAttendanceEntireForm
            // 
            this.tlpViewAttendanceEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpViewAttendanceEntireForm.ColumnCount = 3;
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpViewAttendanceEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpViewAttendanceEntireForm.Controls.Add(this.tlpViewAttendanceHeader, 1, 1);
            this.tlpViewAttendanceEntireForm.Controls.Add(this.dgvViewAttendance, 1, 4);
            this.tlpViewAttendanceEntireForm.Controls.Add(this.tlpViewAttendanceSearchBar, 1, 3);
            this.tlpViewAttendanceEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewAttendanceEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpViewAttendanceEntireForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceEntireForm.Name = "tlpViewAttendanceEntireForm";
            this.tlpViewAttendanceEntireForm.RowCount = 6;
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.95258F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.46296F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.95258F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.905161F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.46375F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.262968F));
            this.tlpViewAttendanceEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpViewAttendanceEntireForm.Size = new System.Drawing.Size(1151, 750);
            this.tlpViewAttendanceEntireForm.TabIndex = 2;
            // 
            // tlpViewAttendanceHeader
            // 
            this.tlpViewAttendanceHeader.ColumnCount = 3;
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tlpViewAttendanceHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceHeader.Controls.Add(this.picViewAttendanceMark, 0, 0);
            this.tlpViewAttendanceHeader.Controls.Add(this.tlpViewAttendanceTitle, 1, 0);
            this.tlpViewAttendanceHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewAttendanceHeader.Location = new System.Drawing.Point(57, 24);
            this.tlpViewAttendanceHeader.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.tlpViewAttendanceHeader.Name = "tlpViewAttendanceHeader";
            this.tlpViewAttendanceHeader.RowCount = 1;
            this.tlpViewAttendanceHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceHeader.Size = new System.Drawing.Size(1032, 81);
            this.tlpViewAttendanceHeader.TabIndex = 9;
            // 
            // picViewAttendanceMark
            // 
            this.picViewAttendanceMark.Image = ((System.Drawing.Image)(resources.GetObject("picViewAttendanceMark.Image")));
            this.picViewAttendanceMark.Location = new System.Drawing.Point(0, 0);
            this.picViewAttendanceMark.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.picViewAttendanceMark.Name = "picViewAttendanceMark";
            this.picViewAttendanceMark.Size = new System.Drawing.Size(61, 60);
            this.picViewAttendanceMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewAttendanceMark.TabIndex = 0;
            this.picViewAttendanceMark.TabStop = false;
            // 
            // tlpViewAttendanceTitle
            // 
            this.tlpViewAttendanceTitle.ColumnCount = 1;
            this.tlpViewAttendanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceTitle.Controls.Add(this.lblViewMemberAttendance, 0, 1);
            this.tlpViewAttendanceTitle.Controls.Add(this.lblViewAttendance, 0, 0);
            this.tlpViewAttendanceTitle.Location = new System.Drawing.Point(64, 0);
            this.tlpViewAttendanceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceTitle.Name = "tlpViewAttendanceTitle";
            this.tlpViewAttendanceTitle.RowCount = 2;
            this.tlpViewAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.45161F));
            this.tlpViewAttendanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.54839F));
            this.tlpViewAttendanceTitle.Size = new System.Drawing.Size(331, 62);
            this.tlpViewAttendanceTitle.TabIndex = 1;
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
            // 
            // dgvViewAttendance
            // 
            this.dgvViewAttendance.AllowUserToAddRows = false;
            this.dgvViewAttendance.AllowUserToDeleteRows = false;
            this.dgvViewAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dgvViewAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvViewAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewAttendance.ColumnHeadersHeight = 40;
            this.dgvViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMemberId,
            this.colMemberName,
            this.colPhoneNo,
            this.colShiftName,
            this.colAction});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAttendance.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAttendance.EnableHeadersVisualStyles = false;
            this.dgvViewAttendance.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvViewAttendance.Location = new System.Drawing.Point(60, 175);
            this.dgvViewAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvViewAttendance.MultiSelect = false;
            this.dgvViewAttendance.Name = "dgvViewAttendance";
            this.dgvViewAttendance.ReadOnly = true;
            this.dgvViewAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvViewAttendance.RowHeadersVisible = false;
            this.dgvViewAttendance.RowHeadersWidth = 50;
            this.dgvViewAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dgvViewAttendance.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvViewAttendance.RowTemplate.Height = 30;
            this.dgvViewAttendance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvViewAttendance.Size = new System.Drawing.Size(1029, 531);
            this.dgvViewAttendance.TabIndex = 20;
            this.dgvViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAttendance_CellContentClick);
            this.dgvViewAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvViewAttendance_CellFormatting);
            this.dgvViewAttendance.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvViewAttendance_CellPainting);
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
            this.tlpViewAttendanceSearchBar.Location = new System.Drawing.Point(57, 129);
            this.tlpViewAttendanceSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewAttendanceSearchBar.Name = "tlpViewAttendanceSearchBar";
            this.tlpViewAttendanceSearchBar.RowCount = 1;
            this.tlpViewAttendanceSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewAttendanceSearchBar.Size = new System.Drawing.Size(1028, 38);
            this.tlpViewAttendanceSearchBar.TabIndex = 17;
            // 
            // picViewAttendanceSearch1
            // 
            this.picViewAttendanceSearch1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picViewAttendanceSearch1.Image = ((System.Drawing.Image)(resources.GetObject("picViewAttendanceSearch1.Image")));
            this.picViewAttendanceSearch1.Location = new System.Drawing.Point(0, 3);
            this.picViewAttendanceSearch1.Margin = new System.Windows.Forms.Padding(0);
            this.picViewAttendanceSearch1.Name = "picViewAttendanceSearch1";
            this.picViewAttendanceSearch1.Size = new System.Drawing.Size(44, 32);
            this.picViewAttendanceSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewAttendanceSearch1.TabIndex = 3;
            this.picViewAttendanceSearch1.TabStop = false;
            // 
            // txtViewMemberMobileNumber
            // 
            this.txtViewMemberMobileNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtViewMemberMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViewMemberMobileNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewMemberMobileNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtViewMemberMobileNumber.Location = new System.Drawing.Point(44, 5);
            this.txtViewMemberMobileNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtViewMemberMobileNumber.Name = "txtViewMemberMobileNumber";
            this.txtViewMemberMobileNumber.Size = new System.Drawing.Size(315, 27);
            this.txtViewMemberMobileNumber.TabIndex = 5;
            this.txtViewMemberMobileNumber.Text = " Enter Mobile No.";
            this.txtViewMemberMobileNumber.TextChanged += new System.EventHandler(this.txtViewMemberMobileNumber_TextChanged);
            this.txtViewMemberMobileNumber.Enter += new System.EventHandler(this.txtViewMemberMobileNumber_Enter);
            this.txtViewMemberMobileNumber.Leave += new System.EventHandler(this.txtViewMemberMobileNumber_Leave);
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
            // colMemberId
            // 
            this.colMemberId.HeaderText = "MemberId";
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.ReadOnly = true;
            this.colMemberId.Visible = false;
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
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAction.DataPropertyName = "Action";
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAction.Text = "View";
            // 
            // FrmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1151, 750);
            this.Controls.Add(this.tlpViewAttendanceEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1165, 715);
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
        private System.Windows.Forms.DataGridView dgvViewAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftName;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;

    }
}