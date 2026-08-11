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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tlplSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picBoxLockerIcon = new System.Windows.Forms.PictureBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.tlpAddNewLocker = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxAddSymbol = new System.Windows.Forms.PictureBox();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.pnlSpaceing = new System.Windows.Forms.Panel();
            this.tlpDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayLocker = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllocatedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlplSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.tlpAddNewLocker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).BeginInit();
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
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.12354F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85977F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHeading.Controls.Add(this.tlpTitle, 1, 1);
            this.tlpHeading.Controls.Add(this.pnlButton, 2, 1);
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
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
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
            this.tlplSection.Location = new System.Drawing.Point(69, 0);
            this.tlplSection.Margin = new System.Windows.Forms.Padding(0);
            this.tlplSection.Name = "tlplSection";
            this.tlplSection.RowCount = 2;
            this.tlplSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlplSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplSection.Size = new System.Drawing.Size(819, 75);
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
            this.lblTitle.Size = new System.Drawing.Size(813, 19);
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
            this.lblSubtitle.Location = new System.Drawing.Point(3, 14);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(199, 28);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Locker Management";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBoxLockerIcon
            // 
            this.picBoxLockerIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLockerIcon.BackgroundImage")));
            this.picBoxLockerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLockerIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxLockerIcon.Location = new System.Drawing.Point(9, 9);
            this.picBoxLockerIcon.Margin = new System.Windows.Forms.Padding(9);
            this.picBoxLockerIcon.Name = "picBoxLockerIcon";
            this.picBoxLockerIcon.Size = new System.Drawing.Size(51, 57);
            this.picBoxLockerIcon.TabIndex = 1;
            this.picBoxLockerIcon.TabStop = false;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButton.Controls.Add(this.tlpAddNewLocker);
            this.pnlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.ForeColor = System.Drawing.Color.Blue;
            this.pnlButton.Location = new System.Drawing.Point(1044, 77);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(90, 23);
            this.pnlButton.TabIndex = 4;
            // 
            // tlpAddNewLocker
            // 
            this.tlpAddNewLocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tlpAddNewLocker.ColumnCount = 2;
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAddNewLocker.Controls.Add(this.picBoxAddSymbol, 0, 0);
            this.tlpAddNewLocker.Controls.Add(this.lblAddNewLocker, 1, 0);
            this.tlpAddNewLocker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpAddNewLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewLocker.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewLocker.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddNewLocker.Name = "tlpAddNewLocker";
            this.tlpAddNewLocker.RowCount = 1;
            this.tlpAddNewLocker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewLocker.Size = new System.Drawing.Size(88, 21);
            this.tlpAddNewLocker.TabIndex = 0;
            // 
            // picBoxAddSymbol
            // 
            this.picBoxAddSymbol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picBoxAddSymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxAddSymbol.BackgroundImage")));
            this.picBoxAddSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAddSymbol.Location = new System.Drawing.Point(4, 5);
            this.picBoxAddSymbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxAddSymbol.Name = "picBoxAddSymbol";
            this.picBoxAddSymbol.Size = new System.Drawing.Size(10, 10);
            this.picBoxAddSymbol.TabIndex = 2;
            this.picBoxAddSymbol.TabStop = false;
            // 
            // lblAddNewLocker
            // 
            this.lblAddNewLocker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewLocker.AutoSize = true;
            this.lblAddNewLocker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewLocker.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewLocker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(199)))));
            this.lblAddNewLocker.Location = new System.Drawing.Point(20, 0);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(41, 21);
            this.lblAddNewLocker.TabIndex = 1;
            this.lblAddNewLocker.Text = "Add New";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dgvDisplayLocker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayLocker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDisplayLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayLocker.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDisplayLocker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDisplayLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayLocker.ColumnHeadersHeight = 50;
            this.dgvDisplayLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplayLocker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colLNo,
            this.colAllocatedTo,
            this.colLStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayLocker.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDisplayLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayLocker.EnableHeadersVisualStyles = false;
            this.dgvDisplayLocker.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDisplayLocker.Location = new System.Drawing.Point(63, 4);
            this.dgvDisplayLocker.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisplayLocker.MultiSelect = false;
            this.dgvDisplayLocker.Name = "dgvDisplayLocker";
            this.dgvDisplayLocker.ReadOnly = true;
            this.dgvDisplayLocker.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDisplayLocker.RowHeadersVisible = false;
            this.dgvDisplayLocker.RowHeadersWidth = 50;
            this.dgvDisplayLocker.RowTemplate.Height = 40;
            this.dgvDisplayLocker.RowTemplate.ReadOnly = true;
            this.dgvDisplayLocker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplayLocker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDisplayLocker.Size = new System.Drawing.Size(1070, 553);
            this.dgvDisplayLocker.StandardTab = true;
            this.dgvDisplayLocker.TabIndex = 0;
            this.dgvDisplayLocker.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseEnter);
            this.dgvDisplayLocker.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseLeave);
            this.dgvDisplayLocker.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
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
            // colSlNo
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
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
            this.colAllocatedTo.FillWeight = 180F;
            this.colAllocatedTo.HeaderText = "Allocated To";
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
            this.pnlButton.ResumeLayout(false);
            this.tlpAddNewLocker.ResumeLayout(false);
            this.tlpAddNewLocker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).EndInit();
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
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewLocker;
        private System.Windows.Forms.PictureBox picBoxAddSymbol;
        private System.Windows.Forms.Label lblAddNewLocker;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllocatedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLStatus;
    }
}