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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tblSpace = new System.Windows.Forms.TableLayoutPanel();
            this.tplSearchFields = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearchElements = new System.Windows.Forms.Panel();
            this.tlpSearchElements = new System.Windows.Forms.TableLayoutPanel();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.comBoxShifts = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tlpFormTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpDisplayDataGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMemberAttendance = new System.Windows.Forms.DataGridView();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeading.SuspendLayout();
            this.tplSearchFields.SuspendLayout();
            this.pnlSearchElements.SuspendLayout();
            this.tlpSearchElements.SuspendLayout();
            this.tlpFormTitle.SuspendLayout();
            this.tlpDisplayDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.Controls.Add(this.tblSpace);
            this.pnlHeading.Controls.Add(this.tplSearchFields);
            this.pnlHeading.Controls.Add(this.tlpFormTitle);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(1145, 166);
            this.pnlHeading.TabIndex = 0;
            this.pnlHeading.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // tblSpace
            // 
            this.tblSpace.ColumnCount = 4;
            this.tblSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.642302F));
            this.tblSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.3577F));
            this.tblSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tblSpace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tblSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSpace.Location = new System.Drawing.Point(0, 126);
            this.tblSpace.Name = "tblSpace";
            this.tblSpace.RowCount = 1;
            this.tblSpace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSpace.Size = new System.Drawing.Size(1145, 40);
            this.tblSpace.TabIndex = 2;
            this.tblSpace.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // tplSearchFields
            // 
            this.tplSearchFields.ColumnCount = 3;
            this.tplSearchFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.366385F));
            this.tplSearchFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.44105F));
            this.tplSearchFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23144F));
            this.tplSearchFields.Controls.Add(this.pnlSearchElements, 1, 0);
            this.tplSearchFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tplSearchFields.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplSearchFields.Location = new System.Drawing.Point(0, 66);
            this.tplSearchFields.Name = "tplSearchFields";
            this.tplSearchFields.RowCount = 1;
            this.tplSearchFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplSearchFields.Size = new System.Drawing.Size(1145, 60);
            this.tplSearchFields.TabIndex = 1;
            this.tplSearchFields.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // pnlSearchElements
            // 
            this.pnlSearchElements.Controls.Add(this.tlpSearchElements);
            this.pnlSearchElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchElements.Location = new System.Drawing.Point(64, 3);
            this.pnlSearchElements.Name = "pnlSearchElements";
            this.pnlSearchElements.Size = new System.Drawing.Size(811, 54);
            this.pnlSearchElements.TabIndex = 0;
            this.pnlSearchElements.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // tlpSearchElements
            // 
            this.tlpSearchElements.ColumnCount = 4;
            this.tlpSearchElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpSearchElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tlpSearchElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tlpSearchElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tlpSearchElements.Controls.Add(this.txtMobileNo, 2, 0);
            this.tlpSearchElements.Controls.Add(this.comBoxShifts, 1, 0);
            this.tlpSearchElements.Controls.Add(this.btnSearch, 3, 0);
            this.tlpSearchElements.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchElements.Name = "tlpSearchElements";
            this.tlpSearchElements.RowCount = 1;
            this.tlpSearchElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpSearchElements.Size = new System.Drawing.Size(811, 60);
            this.tlpSearchElements.TabIndex = 0;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Gray;
            this.txtMobileNo.Location = new System.Drawing.Point(349, 10);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(247, 39);
            this.txtMobileNo.TabIndex = 2;
            this.txtMobileNo.Text = "  Mobile No.";
            this.txtMobileNo.Enter += new System.EventHandler(this.txtMobileNo_Enter);
            this.txtMobileNo.Leave += new System.EventHandler(this.txtMobileNo_Leave);
            // 
            // comBoxShifts
            // 
            this.comBoxShifts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comBoxShifts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxShifts.ForeColor = System.Drawing.Color.Gray;
            this.comBoxShifts.FormattingEnabled = true;
            this.comBoxShifts.Location = new System.Drawing.Point(12, 10);
            this.comBoxShifts.Name = "comBoxShifts";
            this.comBoxShifts.Size = new System.Drawing.Size(308, 40);
            this.comBoxShifts.TabIndex = 3;
            this.comBoxShifts.Text = "   -- Select Shift --";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 13F);
            this.btnSearch.Location = new System.Drawing.Point(645, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tlpFormTitle
            // 
            this.tlpFormTitle.ColumnCount = 2;
            this.tlpFormTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.433647F));
            this.tlpFormTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.56635F));
            this.tlpFormTitle.Controls.Add(this.lblTitle, 1, 0);
            this.tlpFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpFormTitle.ForeColor = System.Drawing.Color.Black;
            this.tlpFormTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpFormTitle.Name = "tlpFormTitle";
            this.tlpFormTitle.RowCount = 1;
            this.tlpFormTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFormTitle.Size = new System.Drawing.Size(1145, 66);
            this.tlpFormTitle.TabIndex = 0;
            this.tlpFormTitle.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(65, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Memeber Attendance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // tlpDisplayDataGrid
            // 
            this.tlpDisplayDataGrid.ColumnCount = 3;
            this.tlpDisplayDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.318089F));
            this.tlpDisplayDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.36134F));
            this.tlpDisplayDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.320571F));
            this.tlpDisplayDataGrid.Controls.Add(this.dgvMemberAttendance, 1, 0);
            this.tlpDisplayDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDisplayDataGrid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDisplayDataGrid.Location = new System.Drawing.Point(0, 166);
            this.tlpDisplayDataGrid.Name = "tlpDisplayDataGrid";
            this.tlpDisplayDataGrid.RowCount = 2;
            this.tlpDisplayDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.65354F));
            this.tlpDisplayDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.346457F));
            this.tlpDisplayDataGrid.Size = new System.Drawing.Size(1145, 635);
            this.tlpDisplayDataGrid.TabIndex = 1;
            this.tlpDisplayDataGrid.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            // 
            // dgvMemberAttendance
            // 
            this.dgvMemberAttendance.AllowUserToAddRows = false;
            this.dgvMemberAttendance.AllowUserToDeleteRows = false;
            this.dgvMemberAttendance.AllowUserToResizeRows = false;
            this.dgvMemberAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMemberAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvMemberAttendance.ColumnHeadersHeight = 50;
            this.dgvMemberAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colMId,
            this.colFullName,
            this.colMobileNo,
            this.colShift,
            this.colAttendance});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberAttendance.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvMemberAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMemberAttendance.EnableHeadersVisualStyles = false;
            this.dgvMemberAttendance.GridColor = System.Drawing.Color.Black;
            this.dgvMemberAttendance.Location = new System.Drawing.Point(63, 3);
            this.dgvMemberAttendance.Name = "dgvMemberAttendance";
            this.dgvMemberAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvMemberAttendance.RowHeadersVisible = false;
            this.dgvMemberAttendance.RowTemplate.Height = 28;
            this.dgvMemberAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMemberAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMemberAttendance.Size = new System.Drawing.Size(1017, 575);
            this.dgvMemberAttendance.TabIndex = 0;
            this.dgvMemberAttendance.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberAttendance_CellMouseEnter);
            this.dgvMemberAttendance.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberAttendance_CellMouseLeave);
            // 
            // colSlNo
            // 
            this.colSlNo.DataPropertyName = "Attendance";
            this.colSlNo.FillWeight = 9.82688F;
            this.colSlNo.HeaderText = "Sl No.";
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMId
            // 
            this.colMId.DataPropertyName = "MemberId";
            this.colMId.FillWeight = 17.50413F;
            this.colMId.HeaderText = "Member Id";
            this.colMId.Name = "colMId";
            this.colMId.ReadOnly = true;
            this.colMId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "MemberName";
            this.colFullName.FillWeight = 30.709F;
            this.colFullName.HeaderText = "Memeber Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMobileNo
            // 
            this.colMobileNo.DataPropertyName = "PhoneNo";
            this.colMobileNo.FillWeight = 20.57503F;
            this.colMobileNo.HeaderText = "Mobile No";
            this.colMobileNo.Name = "colMobileNo";
            this.colMobileNo.ReadOnly = true;
            this.colMobileNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMobileNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colShift
            // 
            this.colShift.DataPropertyName = "ShiftName";
            this.colShift.FillWeight = 15.3545F;
            this.colShift.HeaderText = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.ReadOnly = true;
            this.colShift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAttendance
            // 
            this.colAttendance.FillWeight = 22F;
            this.colAttendance.HeaderText = "Attendance";
            this.colAttendance.Name = "colAttendance";
            this.colAttendance.ReadOnly = true;
            this.colAttendance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1145, 801);
            this.Controls.Add(this.tlpDisplayDataGrid);
            this.Controls.Add(this.pnlHeading);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1167, 835);
            this.Name = "FrmViewAttendance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViewAttendance";
            this.Click += new System.EventHandler(this.dvgMemeberAttendance_Click);
            this.pnlHeading.ResumeLayout(false);
            this.tplSearchFields.ResumeLayout(false);
            this.pnlSearchElements.ResumeLayout(false);
            this.tlpSearchElements.ResumeLayout(false);
            this.tlpSearchElements.PerformLayout();
            this.tlpFormTitle.ResumeLayout(false);
            this.tlpFormTitle.PerformLayout();
            this.tlpDisplayDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpFormTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tplSearchFields;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.ComboBox comBoxShifts;
        private System.Windows.Forms.Panel pnlSearchElements;
        private System.Windows.Forms.TableLayoutPanel tlpSearchElements;
        private System.Windows.Forms.TableLayoutPanel tblSpace;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpDisplayDataGrid;
        private System.Windows.Forms.DataGridView dgvMemberAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendance;
    }
}