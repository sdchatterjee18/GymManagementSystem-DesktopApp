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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrationFees));
            this.tlpMainAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowAllAddRegistrationFees = new System.Windows.Forms.DataGridView();
            this.colSLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrationFeesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddRegFees = new System.Windows.Forms.Panel();
            this.tlpAddRegFees = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddregFee = new System.Windows.Forms.Label();
            this.picAddButton = new System.Windows.Forms.PictureBox();
            this.tlpTopTitleAndSubTitleAndIcon = new System.Windows.Forms.TableLayoutPanel();
            this.lblManageRegistrationFeesSubTitle = new System.Windows.Forms.Label();
            this.lblRegistrationFeesTitle = new System.Windows.Forms.Label();
            this.picRegistrationFeesIcon = new System.Windows.Forms.PictureBox();
            this.tlpMainAddRegistrationFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).BeginInit();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.SuspendLayout();
            this.pnlAddRegFees.SuspendLayout();
            this.tlpAddRegFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButton)).BeginInit();
            this.tlpTopTitleAndSubTitleAndIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistrationFeesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainAddRegistrationFee
            // 
            this.tlpMainAddRegistrationFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMainAddRegistrationFee.ColumnCount = 3;
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMainAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMainAddRegistrationFee.Controls.Add(this.dgvShowAllAddRegistrationFees, 1, 1);
            this.tlpMainAddRegistrationFee.Controls.Add(this.tlpTopRegistrationFeesAndAddNewRegistrationFees, 1, 0);
            this.tlpMainAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainAddRegistrationFee.Location = new System.Drawing.Point(0, 0);
            this.tlpMainAddRegistrationFee.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMainAddRegistrationFee.Name = "tlpMainAddRegistrationFee";
            this.tlpMainAddRegistrationFee.RowCount = 3;
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.24143F));
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.63643F));
            this.tlpMainAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.122139F));
            this.tlpMainAddRegistrationFee.Size = new System.Drawing.Size(862, 609);
            this.tlpMainAddRegistrationFee.TabIndex = 3;
            this.tlpMainAddRegistrationFee.Click += new System.EventHandler(this.tlpMainAddRegistrationFee_Click);
            // 
            // dgvShowAllAddRegistrationFees
            // 
            this.dgvShowAllAddRegistrationFees.AllowUserToAddRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToDeleteRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dgvShowAllAddRegistrationFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAllAddRegistrationFees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvShowAllAddRegistrationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeight = 40;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowAllAddRegistrationFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNO,
            this.colRegistrationFeesId,
            this.colFeeAmount,
            this.colCreatedAt,
            this.colStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowAllAddRegistrationFees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowAllAddRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowAllAddRegistrationFees.EnableHeadersVisualStyles = false;
            this.dgvShowAllAddRegistrationFees.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvShowAllAddRegistrationFees.Location = new System.Drawing.Point(46, 95);
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
            this.dgvShowAllAddRegistrationFees.RowTemplate.Height = 30;
            this.dgvShowAllAddRegistrationFees.RowTemplate.ReadOnly = true;
            this.dgvShowAllAddRegistrationFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShowAllAddRegistrationFees.Size = new System.Drawing.Size(769, 478);
            this.dgvShowAllAddRegistrationFees.TabIndex = 1;
            this.dgvShowAllAddRegistrationFees.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShowAllAddRegistrationFees_CellFormatting);
            this.dgvShowAllAddRegistrationFees.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAllAddRegistrationFees_CellMouseEnter);
            this.dgvShowAllAddRegistrationFees.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAllAddRegistrationFees_CellMouseLeave);
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
            // tlpTopRegistrationFeesAndAddNewRegistrationFees
            // 
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnCount = 3;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96976F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03024F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.pnlAddRegFees, 2, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.tlpTopTitleAndSubTitleAndIcon, 1, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Controls.Add(this.picRegistrationFeesIcon, 0, 0);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Location = new System.Drawing.Point(45, 2);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Name = "tlpTopRegistrationFeesAndAddNewRegistrationFees";
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.RowCount = 1;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Size = new System.Drawing.Size(771, 88);
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.TabIndex = 2;
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.Click += new System.EventHandler(this.tlpTopRegistrationFeesAndAddNewRegistrationFees_Click);
            // 
            // pnlAddRegFees
            // 
            this.pnlAddRegFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddRegFees.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAddRegFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddRegFees.Controls.Add(this.tlpAddRegFees);
            this.pnlAddRegFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddRegFees.ForeColor = System.Drawing.Color.White;
            this.pnlAddRegFees.Location = new System.Drawing.Point(679, 57);
            this.pnlAddRegFees.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddRegFees.Name = "pnlAddRegFees";
            this.pnlAddRegFees.Size = new System.Drawing.Size(90, 29);
            this.pnlAddRegFees.TabIndex = 9;
            this.pnlAddRegFees.Click += new System.EventHandler(this.tlpAddRegFees_Click);
            this.pnlAddRegFees.MouseEnter += new System.EventHandler(this.pnlAddRegFees_MouseEnter);
            this.pnlAddRegFees.MouseLeave += new System.EventHandler(this.pnlAddRegFees_MouseLeave);
            // 
            // tlpAddRegFees
            // 
            this.tlpAddRegFees.ColumnCount = 2;
            this.tlpAddRegFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddRegFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpAddRegFees.Controls.Add(this.lblAddregFee, 1, 0);
            this.tlpAddRegFees.Controls.Add(this.picAddButton, 0, 0);
            this.tlpAddRegFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddRegFees.Location = new System.Drawing.Point(0, 0);
            this.tlpAddRegFees.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddRegFees.Name = "tlpAddRegFees";
            this.tlpAddRegFees.RowCount = 1;
            this.tlpAddRegFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddRegFees.Size = new System.Drawing.Size(88, 27);
            this.tlpAddRegFees.TabIndex = 4;
            this.tlpAddRegFees.Click += new System.EventHandler(this.tlpAddRegFees_Click);
            this.tlpAddRegFees.MouseEnter += new System.EventHandler(this.pnlAddRegFees_MouseEnter);
            this.tlpAddRegFees.MouseLeave += new System.EventHandler(this.pnlAddRegFees_MouseLeave);
            // 
            // lblAddregFee
            // 
            this.lblAddregFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddregFee.AutoSize = true;
            this.lblAddregFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddregFee.ForeColor = System.Drawing.Color.White;
            this.lblAddregFee.Location = new System.Drawing.Point(24, 6);
            this.lblAddregFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddregFee.Name = "lblAddregFee";
            this.lblAddregFee.Size = new System.Drawing.Size(58, 15);
            this.lblAddregFee.TabIndex = 0;
            this.lblAddregFee.Text = "Add New";
            this.lblAddregFee.Click += new System.EventHandler(this.tlpAddRegFees_Click);
            this.lblAddregFee.MouseEnter += new System.EventHandler(this.pnlAddRegFees_MouseEnter);
            this.lblAddregFee.MouseLeave += new System.EventHandler(this.pnlAddRegFees_MouseLeave);
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
            this.picAddButton.Click += new System.EventHandler(this.tlpAddRegFees_Click);
            this.picAddButton.MouseEnter += new System.EventHandler(this.pnlAddRegFees_MouseEnter);
            this.picAddButton.MouseLeave += new System.EventHandler(this.pnlAddRegFees_MouseLeave);
            // 
            // tlpTopTitleAndSubTitleAndIcon
            // 
            this.tlpTopTitleAndSubTitleAndIcon.ColumnCount = 1;
            this.tlpTopTitleAndSubTitleAndIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopTitleAndSubTitleAndIcon.Controls.Add(this.lblManageRegistrationFeesSubTitle, 0, 1);
            this.tlpTopTitleAndSubTitleAndIcon.Controls.Add(this.lblRegistrationFeesTitle, 0, 0);
            this.tlpTopTitleAndSubTitleAndIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopTitleAndSubTitleAndIcon.Location = new System.Drawing.Point(54, 2);
            this.tlpTopTitleAndSubTitleAndIcon.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTopTitleAndSubTitleAndIcon.Name = "tlpTopTitleAndSubTitleAndIcon";
            this.tlpTopTitleAndSubTitleAndIcon.RowCount = 3;
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29678F));
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.8018F));
            this.tlpTopTitleAndSubTitleAndIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.901412F));
            this.tlpTopTitleAndSubTitleAndIcon.Size = new System.Drawing.Size(197, 84);
            this.tlpTopTitleAndSubTitleAndIcon.TabIndex = 3;
            this.tlpTopTitleAndSubTitleAndIcon.Click += new System.EventHandler(this.tlpTopTitleAndSubTitleAndIcon_Click);
            // 
            // lblManageRegistrationFeesSubTitle
            // 
            this.lblManageRegistrationFeesSubTitle.AutoSize = true;
            this.lblManageRegistrationFeesSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRegistrationFeesSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblManageRegistrationFeesSubTitle.Location = new System.Drawing.Point(2, 46);
            this.lblManageRegistrationFeesSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageRegistrationFeesSubTitle.Name = "lblManageRegistrationFeesSubTitle";
            this.lblManageRegistrationFeesSubTitle.Size = new System.Drawing.Size(139, 13);
            this.lblManageRegistrationFeesSubTitle.TabIndex = 1;
            this.lblManageRegistrationFeesSubTitle.Text = "Manage Registration Fees";
            this.lblManageRegistrationFeesSubTitle.Click += new System.EventHandler(this.lblManageRegistrationFeesSubTitle_Click);
            // 
            // lblRegistrationFeesTitle
            // 
            this.lblRegistrationFeesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrationFeesTitle.AutoSize = true;
            this.lblRegistrationFeesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFeesTitle.Location = new System.Drawing.Point(2, 25);
            this.lblRegistrationFeesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationFeesTitle.Name = "lblRegistrationFeesTitle";
            this.lblRegistrationFeesTitle.Size = new System.Drawing.Size(136, 21);
            this.lblRegistrationFeesTitle.TabIndex = 0;
            this.lblRegistrationFeesTitle.Text = "Registration Fees";
            this.lblRegistrationFeesTitle.Click += new System.EventHandler(this.lblRegistrationFeesTitle_Click);
            // 
            // picRegistrationFeesIcon
            // 
            this.picRegistrationFeesIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRegistrationFeesIcon.Image = ((System.Drawing.Image)(resources.GetObject("picRegistrationFeesIcon.Image")));
            this.picRegistrationFeesIcon.Location = new System.Drawing.Point(2, 2);
            this.picRegistrationFeesIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picRegistrationFeesIcon.Name = "picRegistrationFeesIcon";
            this.picRegistrationFeesIcon.Size = new System.Drawing.Size(48, 84);
            this.picRegistrationFeesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegistrationFeesIcon.TabIndex = 4;
            this.picRegistrationFeesIcon.TabStop = false;
            this.picRegistrationFeesIcon.Click += new System.EventHandler(this.picRegistrationFeesIcon_Click);
            // 
            // FrmRegistrationFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(862, 609);
            this.Controls.Add(this.tlpMainAddRegistrationFee);
            this.Name = "FrmRegistrationFees";
            this.Text = "FrmRegistrationFees";
            this.Load += new System.EventHandler(this.FrmRegistrationFees_Load);
            this.Resize += new System.EventHandler(this.FrmRegistrationFees_Resize);
            this.tlpMainAddRegistrationFee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).EndInit();
            this.tlpTopRegistrationFeesAndAddNewRegistrationFees.ResumeLayout(false);
            this.pnlAddRegFees.ResumeLayout(false);
            this.tlpAddRegFees.ResumeLayout(false);
            this.tlpAddRegFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddButton)).EndInit();
            this.tlpTopTitleAndSubTitleAndIcon.ResumeLayout(false);
            this.tlpTopTitleAndSubTitleAndIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegistrationFeesIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainAddRegistrationFee;
        private System.Windows.Forms.TableLayoutPanel tlpTopRegistrationFeesAndAddNewRegistrationFees;
        private System.Windows.Forms.DataGridView dgvShowAllAddRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpTopTitleAndSubTitleAndIcon;
        private System.Windows.Forms.Label lblRegistrationFeesTitle;
        private System.Windows.Forms.Label lblManageRegistrationFeesSubTitle;
        private System.Windows.Forms.PictureBox picRegistrationFeesIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistrationFeesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlAddRegFees;
        private System.Windows.Forms.TableLayoutPanel tlpAddRegFees;
        private System.Windows.Forms.Label lblAddregFee;
        private System.Windows.Forms.PictureBox picAddButton;

    }
}