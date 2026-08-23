namespace GymManagementSystem.FORMS.Locker
{
    partial class FrmDisplayLocker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayLocker));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlplSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picBoxLockerIcon = new System.Windows.Forms.PictureBox();
            this.pnlAddNew = new System.Windows.Forms.Panel();
            this.tlpAddNew = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.picAddButton = new System.Windows.Forms.PictureBox();
            this.pnlSpaceing = new System.Windows.Forms.Panel();
            this.tlpDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayLocker = new System.Windows.Forms.DataGridView();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllocatedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlplSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).BeginInit();
            this.pnlAddNew.SuspendLayout();
            this.tlpAddNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButton)).BeginInit();
            this.pnlSpaceing.SuspendLayout();
            this.tlpDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLocker)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.Controls.Add(this.tlpHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(1198, 102);
            this.pnlHeading.TabIndex = 0;
            this.pnlHeading.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // tlpHeading
            // 
            this.tlpHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.12354F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85977F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.Controls.Add(this.tlpTitle, 1, 1);
            this.tlpHeading.Controls.Add(this.pnlAddNew, 2, 1);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 2;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpHeading.Size = new System.Drawing.Size(1198, 102);
            this.tlpHeading.TabIndex = 0;
            this.tlpHeading.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 2;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Controls.Add(this.tlplSection, 1, 0);
            this.tlpTitle.Controls.Add(this.picBoxLockerIcon, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(59, 27);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(888, 75);
            this.tlpTitle.TabIndex = 3;
            // 
            // tlplSection
            // 
            this.tlplSection.ColumnCount = 1;
            this.tlplSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplSection.Controls.Add(this.lblTitle, 0, 1);
            this.tlplSection.Controls.Add(this.lblSubtitle, 0, 0);
            this.tlplSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplSection.Location = new System.Drawing.Point(45, 0);
            this.tlplSection.Margin = new System.Windows.Forms.Padding(0);
            this.tlplSection.Name = "tlplSection";
            this.tlplSection.RowCount = 2;
            this.tlplSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlplSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplSection.Size = new System.Drawing.Size(843, 75);
            this.tlplSection.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(3, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(837, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Current status and availability of Lockers.";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Black;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 21);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(160, 21);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Locker Management";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBoxLockerIcon
            // 
            this.picBoxLockerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLockerIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxLockerIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLockerIcon.Image")));
            this.picBoxLockerIcon.Location = new System.Drawing.Point(0, 0);
            this.picBoxLockerIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxLockerIcon.Name = "picBoxLockerIcon";
            this.picBoxLockerIcon.Size = new System.Drawing.Size(45, 75);
            this.picBoxLockerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLockerIcon.TabIndex = 1;
            this.picBoxLockerIcon.TabStop = false;
            // 
            // pnlAddNew
            // 
            this.pnlAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddNew.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAddNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddNew.Controls.Add(this.tlpAddNew);
            this.pnlAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddNew.ForeColor = System.Drawing.Color.White;
            this.pnlAddNew.Location = new System.Drawing.Point(1045, 71);
            this.pnlAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddNew.Name = "pnlAddNew";
            this.pnlAddNew.Size = new System.Drawing.Size(90, 29);
            this.pnlAddNew.TabIndex = 9;
            this.pnlAddNew.Click += new System.EventHandler(this.pnlAddNew_Click);
            this.pnlAddNew.MouseEnter += new System.EventHandler(this.pnlAddNew_MouseEnter);
            this.pnlAddNew.MouseLeave += new System.EventHandler(this.pnlAddNew_MouseLeave);
            // 
            // tlpAddNew
            // 
            this.tlpAddNew.ColumnCount = 2;
            this.tlpAddNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpAddNew.Controls.Add(this.lblAddNew, 1, 0);
            this.tlpAddNew.Controls.Add(this.picAddButton, 0, 0);
            this.tlpAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNew.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddNew.Name = "tlpAddNew";
            this.tlpAddNew.RowCount = 1;
            this.tlpAddNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNew.Size = new System.Drawing.Size(88, 27);
            this.tlpAddNew.TabIndex = 4;
            this.tlpAddNew.Click += new System.EventHandler(this.pnlAddNew_Click);
            this.tlpAddNew.MouseEnter += new System.EventHandler(this.pnlAddNew_MouseEnter);
            this.tlpAddNew.MouseLeave += new System.EventHandler(this.pnlAddNew_MouseLeave);
            // 
            // lblAddNew
            // 
            this.lblAddNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.ForeColor = System.Drawing.Color.White;
            this.lblAddNew.Location = new System.Drawing.Point(24, 6);
            this.lblAddNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(58, 15);
            this.lblAddNew.TabIndex = 0;
            this.lblAddNew.Text = "Add New";
            this.lblAddNew.Click += new System.EventHandler(this.pnlAddNew_Click);
            this.lblAddNew.MouseEnter += new System.EventHandler(this.pnlAddNew_MouseEnter);
            this.lblAddNew.MouseLeave += new System.EventHandler(this.pnlAddNew_MouseLeave);
            // 
            // picAddButton
            // 
            this.picAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddButton.Image = global::GymManagementSystem.Properties.Resources.plus;
            this.picAddButton.Location = new System.Drawing.Point(7, 6);
            this.picAddButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.picAddButton.Name = "picAddButton";
            this.picAddButton.Size = new System.Drawing.Size(13, 14);
            this.picAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddButton.TabIndex = 1;
            this.picAddButton.TabStop = false;
            this.picAddButton.Click += new System.EventHandler(this.pnlAddNew_Click);
            this.picAddButton.MouseEnter += new System.EventHandler(this.pnlAddNew_MouseEnter);
            this.picAddButton.MouseLeave += new System.EventHandler(this.pnlAddNew_MouseLeave);
            // 
            // pnlSpaceing
            // 
            this.pnlSpaceing.Controls.Add(this.tlpDataGridView);
            this.pnlSpaceing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpaceing.Location = new System.Drawing.Point(0, 102);
            this.pnlSpaceing.Name = "pnlSpaceing";
            this.pnlSpaceing.Size = new System.Drawing.Size(1198, 561);
            this.pnlSpaceing.TabIndex = 1;
            this.pnlSpaceing.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // tlpDataGridView
            // 
            this.tlpDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpDataGridView.ColumnCount = 3;
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpDataGridView.Controls.Add(this.dgvDisplayLocker, 1, 0);
            this.tlpDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tlpDataGridView.Name = "tlpDataGridView";
            this.tlpDataGridView.RowCount = 1;
            this.tlpDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataGridView.Size = new System.Drawing.Size(1198, 561);
            this.tlpDataGridView.TabIndex = 0;
            this.tlpDataGridView.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // dgvDisplayLocker
            // 
            this.dgvDisplayLocker.AllowUserToAddRows = false;
            this.dgvDisplayLocker.AllowUserToDeleteRows = false;
            this.dgvDisplayLocker.AllowUserToResizeColumns = false;
            this.dgvDisplayLocker.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDisplayLocker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayLocker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDisplayLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayLocker.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDisplayLocker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayLocker.ColumnHeadersHeight = 40;
            this.dgvDisplayLocker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colLNo,
            this.colAllocatedTo,
            this.colLStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayLocker.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDisplayLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayLocker.EnableHeadersVisualStyles = false;
            this.dgvDisplayLocker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dgvDisplayLocker.Location = new System.Drawing.Point(59, 0);
            this.dgvDisplayLocker.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDisplayLocker.Name = "dgvDisplayLocker";
            this.dgvDisplayLocker.ReadOnly = true;
            this.dgvDisplayLocker.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDisplayLocker.RowHeadersVisible = false;
            this.dgvDisplayLocker.RowHeadersWidth = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisplayLocker.RowTemplate.Height = 30;
            this.dgvDisplayLocker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplayLocker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDisplayLocker.Size = new System.Drawing.Size(1078, 561);
            this.dgvDisplayLocker.StandardTab = true;
            this.dgvDisplayLocker.TabIndex = 0;
            this.dgvDisplayLocker.TabStop = false;
            this.dgvDisplayLocker.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseEnter);
            this.dgvDisplayLocker.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseLeave);
            this.dgvDisplayLocker.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // colSlNo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(220)))));
            this.colSlNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSlNo.FillWeight = 50F;
            this.colSlNo.HeaderText = "SL No.";
            this.colSlNo.MaxInputLength = 32;
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.ReadOnly = true;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLNo
            // 
            this.colLNo.DataPropertyName = "LockerNo";
            this.colLNo.FillWeight = 80F;
            this.colLNo.HeaderText = "Locker No";
            this.colLNo.Name = "colLNo";
            this.colLNo.ReadOnly = true;
            this.colLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAllocatedTo
            // 
            this.colAllocatedTo.DataPropertyName = "MemberName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.colAllocatedTo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAllocatedTo.FillWeight = 180F;
            this.colAllocatedTo.HeaderText = "Allocated Member";
            this.colAllocatedTo.Name = "colAllocatedTo";
            this.colAllocatedTo.ReadOnly = true;
            this.colAllocatedTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLStatus
            // 
            this.colLStatus.DataPropertyName = "LockerStatus";
            this.colLStatus.FillWeight = 110F;
            this.colLStatus.HeaderText = "Status";
            this.colLStatus.Name = "colLStatus";
            this.colLStatus.ReadOnly = true;
            this.colLStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 663);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1198, 29);
            this.pnlFooter.TabIndex = 2;
            this.pnlFooter.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // FrmDisplayLocker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1198, 692);
            this.Controls.Add(this.pnlSpaceing);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeading);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FrmDisplayLocker";
            this.Text = "FrmDisplayLocker";
            this.Load += new System.EventHandler(this.FrmDisplayLocker_Load);
            this.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            this.pnlHeading.ResumeLayout(false);
            this.tlpHeading.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlplSection.ResumeLayout(false);
            this.tlplSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).EndInit();
            this.pnlAddNew.ResumeLayout(false);
            this.tlpAddNew.ResumeLayout(false);
            this.tlpAddNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButton)).EndInit();
            this.pnlSpaceing.ResumeLayout(false);
            this.tlpDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLocker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.Panel pnlSpaceing;
        private System.Windows.Forms.TableLayoutPanel tlpDataGridView;
        private System.Windows.Forms.DataGridView dgvDisplayLocker;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TableLayoutPanel tlplSection;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picBoxLockerIcon;
        private System.Windows.Forms.Panel pnlAddNew;
        private System.Windows.Forms.TableLayoutPanel tlpAddNew;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.PictureBox picAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllocatedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLStatus;
    }
}