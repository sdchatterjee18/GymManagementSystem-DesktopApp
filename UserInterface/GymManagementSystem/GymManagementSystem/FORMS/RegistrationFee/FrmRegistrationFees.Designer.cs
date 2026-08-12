namespace GymManagementSystem.FORMS.RegistrationFee
{
    partial class FrmRegistrationFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrationFees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMainAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowAllAddRegistrationFees = new System.Windows.Forms.DataGridView();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickAddNewRegistrationFees = new System.Windows.Forms.Panel();
            this.tlpAddNewRegistrationFees = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddRegistrationFees = new System.Windows.Forms.Label();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.tlpTopTitleAndSubTitleAndIcon = new System.Windows.Forms.TableLayoutPanel();
            this.lblManageRegistrationFeesSubTitle = new System.Windows.Forms.Label();
            this.lblRegistrationFeesTitle = new System.Windows.Forms.Label();
            this.picRegistrationFeesIcon = new System.Windows.Forms.PictureBox();
            this.colSLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrationFeesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMainAddRegistrationFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).BeginInit();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.SuspendLayout();
            this.pnlClickAddNewRegistrationFees.SuspendLayout();
            this.tlpAddNewRegistrationFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.tlpTopTitleAndSubTitleAndIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistrationFeesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainAddRegistrationFee
            // 
            this.tlpMainAddRegistrationFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMainAddRegistrationFee.ColumnCount = 3;
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainAddRegistrationFee.Controls.Add(this.dgvShowAllAddRegistrationFees, 1, 1);
            this.tlpMainAddRegistrationFee.Controls.Add(this.tlpTopRegistrationFeesAndAddNewRegistrationFees, 1, 0);
            this.tlpMainAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainAddRegistrationFee.Location = new System.Drawing.Point(0, 0);
            this.tlpMainAddRegistrationFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMainAddRegistrationFee.Name = "tlpMainAddRegistrationFee";
            this.tlpMainAddRegistrationFee.RowCount = 3;
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.22843F));
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.56853F));
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.117772F));
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainAddRegistrationFee.Size = new System.Drawing.Size(1149, 750);
            this.tlpMainAddRegistrationFee.TabIndex = 3;
            this.tlpMainAddRegistrationFee.Click += new System.EventHandler(this.tlpMainAddRegistrationFee_Click);
            // 
            // dgvShowAllAddRegistrationFees
            // 
            this.dgvShowAllAddRegistrationFees.AllowUserToAddRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToDeleteRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToResizeColumns = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dgvShowAllAddRegistrationFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAllAddRegistrationFees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvShowAllAddRegistrationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeight = 50;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowAllAddRegistrationFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNO,
            this.colRegistrationFeesId,
            this.colFeeAmount,
            this.colCreatedAt,
            this.colStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowAllAddRegistrationFees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowAllAddRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowAllAddRegistrationFees.EnableHeadersVisualStyles = false;
            this.dgvShowAllAddRegistrationFees.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvShowAllAddRegistrationFees.Location = new System.Drawing.Point(61, 118);
            this.dgvShowAllAddRegistrationFees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowAllAddRegistrationFees.MultiSelect = false;
            this.dgvShowAllAddRegistrationFees.Name = "dgvShowAllAddRegistrationFees";
            this.dgvShowAllAddRegistrationFees.ReadOnly = true;
            this.dgvShowAllAddRegistrationFees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAllAddRegistrationFees.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowAllAddRegistrationFees.RowHeadersVisible = false;
            this.dgvShowAllAddRegistrationFees.RowHeadersWidth = 50;
            this.dgvShowAllAddRegistrationFees.RowTemplate.Height = 40;
            this.dgvShowAllAddRegistrationFees.RowTemplate.ReadOnly = true;
            this.dgvShowAllAddRegistrationFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShowAllAddRegistrationFees.Size = new System.Drawing.Size(1026, 589);
            this.dgvShowAllAddRegistrationFees.TabIndex = 1;
            this.dgvShowAllAddRegistrationFees.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShowAllAddRegistrationFees_CellFormatting);
            this.dgvShowAllAddRegistrationFees.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAllAddRegistrationFees_CellMouseEnter);
            this.dgvShowAllAddRegistrationFees.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAllAddRegistrationFees_CellMouseLeave);
            // 
            // tlpTopRegistrationFeesAndAddNewRegistrationFees
            // 
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnCount = 3;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96976F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03024F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.pnlClickAddNewRegistrationFees, 2, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.tlpTopTitleAndSubTitleAndIcon, 1, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.picRegistrationFeesIcon, 0, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Location = new System.Drawing.Point(60, 2);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Name = "tlpTopRegistrationFeesAndAddNewRegistrationFees";
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.RowCount = 1;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Size = new System.Drawing.Size(1028, 110);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.TabIndex = 2;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Click += new System.EventHandler(this.tlpTopRegistrationFeesAndAddNewRegistrationFees_Click);
            // 
            // pnlClickAddNewRegistrationFees
            // 
            this.pnlClickAddNewRegistrationFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClickAddNewRegistrationFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClickAddNewRegistrationFees.Controls.Add(this.tlpAddNewRegistrationFees);
            this.pnlClickAddNewRegistrationFees.Location = new System.Drawing.Point(882, 73);
            this.pnlClickAddNewRegistrationFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlClickAddNewRegistrationFees.Name = "pnlClickAddNewRegistrationFees";
            this.pnlClickAddNewRegistrationFees.Size = new System.Drawing.Size(143, 35);
            this.pnlClickAddNewRegistrationFees.TabIndex = 2;
            this.pnlClickAddNewRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            // 
            // tlpAddNewRegistrationFees
            // 
            this.tlpAddNewRegistrationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tlpAddNewRegistrationFees.ColumnCount = 2;
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82269F));
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.17731F));
            this.tlpAddNewRegistrationFees.Controls.Add(this.lblAddRegistrationFees, 1, 0);
            this.tlpAddNewRegistrationFees.Controls.Add(this.picAddIcon, 0, 0);
            this.tlpAddNewRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewRegistrationFees.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewRegistrationFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAddNewRegistrationFees.Name = "tlpAddNewRegistrationFees";
            this.tlpAddNewRegistrationFees.RowCount = 1;
            this.tlpAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewRegistrationFees.Size = new System.Drawing.Size(141, 33);
            this.tlpAddNewRegistrationFees.TabIndex = 5;
            this.tlpAddNewRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.tlpAddNewRegistrationFees.MouseEnter += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseEnter);
            this.tlpAddNewRegistrationFees.MouseLeave += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseLeave);
            // 
            // lblAddRegistrationFees
            // 
            this.lblAddRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddRegistrationFees.AutoSize = true;
            this.lblAddRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRegistrationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(199)))));
            this.lblAddRegistrationFees.Location = new System.Drawing.Point(37, 5);
            this.lblAddRegistrationFees.Name = "lblAddRegistrationFees";
            this.lblAddRegistrationFees.Size = new System.Drawing.Size(86, 23);
            this.lblAddRegistrationFees.TabIndex = 1;
            this.lblAddRegistrationFees.Text = "Add New ";
            this.lblAddRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.lblAddRegistrationFees.MouseEnter += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseEnter);
            this.lblAddRegistrationFees.MouseLeave += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseLeave);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(14, 8);
            this.picAddIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(17, 17);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 2;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseLeave);
            // 
            // tlpTopTitleAndSubTitleAndIcon
            // 
            this.tlpTopTitleAndSubTitleAndIcon.ColumnCount = 1;
            this.tlpTopTitleAndSubTitleAndIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopTitleAndSubTitleAndIcon.Controls.Add(this.lblManageRegistrationFeesSubTitle, 0, 1);
            this.tlpTopTitleAndSubTitleAndIcon.Controls.Add(this.lblRegistrationFeesTitle, 0, 0);
            this.tlpTopTitleAndSubTitleAndIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopTitleAndSubTitleAndIcon.Location = new System.Drawing.Point(72, 2);
            this.tlpTopTitleAndSubTitleAndIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTopTitleAndSubTitleAndIcon.Name = "tlpTopTitleAndSubTitleAndIcon";
            this.tlpTopTitleAndSubTitleAndIcon.RowCount = 3;
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29678F));
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.8018F));
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.901412F));
            this.tlpTopTitleAndSubTitleAndIcon.Size = new System.Drawing.Size(262, 106);
            this.tlpTopTitleAndSubTitleAndIcon.TabIndex = 3;
            this.tlpTopTitleAndSubTitleAndIcon.Click += new System.EventHandler(this.tlpTopTitleAndSubTitleAndIcon_Click);
            // 
            // lblManageRegistrationFeesSubTitle
            // 
            this.lblManageRegistrationFeesSubTitle.AutoSize = true;
            this.lblManageRegistrationFeesSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRegistrationFeesSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblManageRegistrationFeesSubTitle.Location = new System.Drawing.Point(3, 58);
            this.lblManageRegistrationFeesSubTitle.Name = "lblManageRegistrationFeesSubTitle";
            this.lblManageRegistrationFeesSubTitle.Size = new System.Drawing.Size(170, 19);
            this.lblManageRegistrationFeesSubTitle.TabIndex = 1;
            this.lblManageRegistrationFeesSubTitle.Text = "Manage Registration Fees";
            this.lblManageRegistrationFeesSubTitle.Click += new System.EventHandler(this.lblManageRegistrationFeesSubTitle_Click);
            // 
            // lblRegistrationFeesTitle
            // 
            this.lblRegistrationFeesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrationFeesTitle.AutoSize = true;
            this.lblRegistrationFeesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFeesTitle.Location = new System.Drawing.Point(3, 30);
            this.lblRegistrationFeesTitle.Name = "lblRegistrationFeesTitle";
            this.lblRegistrationFeesTitle.Size = new System.Drawing.Size(167, 28);
            this.lblRegistrationFeesTitle.TabIndex = 0;
            this.lblRegistrationFeesTitle.Text = "Registration Fees";
            this.lblRegistrationFeesTitle.Click += new System.EventHandler(this.lblRegistrationFeesTitle_Click);
            // 
            // picRegistrationFeesIcon
            // 
            this.picRegistrationFeesIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRegistrationFeesIcon.Image = ((System.Drawing.Image)(resources.GetObject("picRegistrationFeesIcon.Image")));
            this.picRegistrationFeesIcon.Location = new System.Drawing.Point(3, 2);
            this.picRegistrationFeesIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRegistrationFeesIcon.Name = "picRegistrationFeesIcon";
            this.picRegistrationFeesIcon.Size = new System.Drawing.Size(63, 106);
            this.picRegistrationFeesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegistrationFeesIcon.TabIndex = 4;
            this.picRegistrationFeesIcon.TabStop = false;
            this.picRegistrationFeesIcon.Click += new System.EventHandler(this.picRegistrationFeesIcon_Click);
            // 
            // colSLNO
            // 
            this.colSLNO.DataPropertyName = "colSLNO";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            this.colSLNO.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSLNO.FillWeight = 50F;
            this.colSLNO.HeaderText = "SL No";
            this.colSLNO.Name = "colSLNO";
            this.colSLNO.ReadOnly = true;
            this.colSLNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRegistrationFeesId
            // 
            this.colRegistrationFeesId.HeaderText = "RegistrationFeesId";
            this.colRegistrationFeesId.Name = "colRegistrationFeesId";
            this.colRegistrationFeesId.ReadOnly = true;
            this.colRegistrationFeesId.Visible = false;
            // 
            // colFeeAmount
            // 
            this.colFeeAmount.DataPropertyName = "FeeAmount";
            this.colFeeAmount.FillWeight = 80.83756F;
            this.colFeeAmount.HeaderText = "Registration Fees";
            this.colFeeAmount.Name = "colFeeAmount";
            this.colFeeAmount.ReadOnly = true;
            this.colFeeAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.DataPropertyName = "CreatedAt";
            this.colCreatedAt.FillWeight = 80.83756F;
            this.colCreatedAt.HeaderText = "Created on";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            this.colCreatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // FrmRegistrationFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1149, 750);
            this.Controls.Add(this.tlpMainAddRegistrationFee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrationFees";
            this.Text = "FrmRegistrationFees";
            this.Load += new System.EventHandler(this.FrmRegistrationFees_Load);
            this.Resize += new System.EventHandler(this.FrmRegistrationFees_Resize);
            this.tlpMainAddRegistrationFee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).EndInit();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ResumeLayout(false);
            this.pnlClickAddNewRegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.tlpTopTitleAndSubTitleAndIcon.ResumeLayout(false);
            this.tlpTopTitleAndSubTitleAndIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistrationFeesIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainAddRegistrationFee;
        private System.Windows.Forms.TableLayoutPanel tlpTopRegistrationFeesAndAddNewRegistrationFees;
        private System.Windows.Forms.Panel pnlClickAddNewRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewRegistrationFees;
        private System.Windows.Forms.Label lblAddRegistrationFees;
        private System.Windows.Forms.DataGridView dgvShowAllAddRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpTopTitleAndSubTitleAndIcon;
        private System.Windows.Forms.Label lblRegistrationFeesTitle;
        private System.Windows.Forms.Label lblManageRegistrationFeesSubTitle;
        private System.Windows.Forms.PictureBox picRegistrationFeesIcon;
        private System.Windows.Forms.PictureBox picAddIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistrationFeesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

    }
}