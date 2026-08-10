namespace GymManagementSystem.FORMS.Member
{
    partial class FrmMemberTrainerAssignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberTrainerAssignment));
            this.tlpMemberTrainerAssignment = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTrainerAssignToMember = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShowMemberTrainerAssignment = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMemberTrainerAssignmentDetails = new System.Windows.Forms.DataGridView();
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleAndSubTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.picMemberTrainerAssignment = new System.Windows.Forms.PictureBox();
            this.tlpMemberTrainerAssignment.SuspendLayout();
            this.tlpTrainerAssignToMember.SuspendLayout();
            this.tlpShowMemberTrainerAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTrainerAssignmentDetails)).BeginInit();
            this.tlpSearchBar.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.tlpHeader.SuspendLayout();
            this.tlpTitleAndSubTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberTrainerAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMemberTrainerAssignment
            // 
            this.tlpMemberTrainerAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMemberTrainerAssignment.ColumnCount = 3;
            this.tlpMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMemberTrainerAssignment.Controls.Add(this.tlpTrainerAssignToMember, 1, 0);
            this.tlpMemberTrainerAssignment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMemberTrainerAssignment.ForeColor = System.Drawing.Color.Black;
            this.tlpMemberTrainerAssignment.Location = new System.Drawing.Point(1, 1);
            this.tlpMemberTrainerAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMemberTrainerAssignment.Name = "tlpMemberTrainerAssignment";
            this.tlpMemberTrainerAssignment.RowCount = 1;
            this.tlpMemberTrainerAssignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberTrainerAssignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMemberTrainerAssignment.Size = new System.Drawing.Size(1147, 790);
            this.tlpMemberTrainerAssignment.TabIndex = 0;
            this.tlpMemberTrainerAssignment.Click += new System.EventHandler(this.tlpMemberTrainerAssignment_Click);
            // 
            // tlpTrainerAssignToMember
            // 
            this.tlpTrainerAssignToMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTrainerAssignToMember.ColumnCount = 1;
            this.tlpTrainerAssignToMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrainerAssignToMember.Controls.Add(this.tlpShowMemberTrainerAssignment, 0, 2);
            this.tlpTrainerAssignToMember.Controls.Add(this.tlpSearchBar, 0, 1);
            this.tlpTrainerAssignToMember.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpTrainerAssignToMember.Location = new System.Drawing.Point(57, 0);
            this.tlpTrainerAssignToMember.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTrainerAssignToMember.Name = "tlpTrainerAssignToMember";
            this.tlpTrainerAssignToMember.RowCount = 4;
            this.tlpTrainerAssignToMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTrainerAssignToMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.697819F));
            this.tlpTrainerAssignToMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.20872F));
            this.tlpTrainerAssignToMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpTrainerAssignToMember.Size = new System.Drawing.Size(1032, 790);
            this.tlpTrainerAssignToMember.TabIndex = 0;
            // 
            // tlpShowMemberTrainerAssignment
            // 
            this.tlpShowMemberTrainerAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowMemberTrainerAssignment.ColumnCount = 1;
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowMemberTrainerAssignment.Controls.Add(this.dgvMemberTrainerAssignmentDetails, 0, 0);
            this.tlpShowMemberTrainerAssignment.Location = new System.Drawing.Point(0, 170);
            this.tlpShowMemberTrainerAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.tlpShowMemberTrainerAssignment.Name = "tlpShowMemberTrainerAssignment";
            this.tlpShowMemberTrainerAssignment.RowCount = 1;
            this.tlpShowMemberTrainerAssignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.Size = new System.Drawing.Size(1032, 578);
            this.tlpShowMemberTrainerAssignment.TabIndex = 4;
            // 
            // dgvMemberTrainerAssignmentDetails
            // 
            this.dgvMemberTrainerAssignmentDetails.AllowUserToAddRows = false;
            this.dgvMemberTrainerAssignmentDetails.AllowUserToResizeColumns = false;
            this.dgvMemberTrainerAssignmentDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMemberTrainerAssignmentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberTrainerAssignmentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemberTrainerAssignmentDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvMemberTrainerAssignmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberTrainerAssignmentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberTrainerAssignmentDetails.ColumnHeadersHeight = 55;
            this.dgvMemberTrainerAssignmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberTrainerAssignmentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colMemberName,
            this.colPhoneNo,
            this.colTrainerName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberTrainerAssignmentDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberTrainerAssignmentDetails.EnableHeadersVisualStyles = false;
            this.dgvMemberTrainerAssignmentDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMemberTrainerAssignmentDetails.Location = new System.Drawing.Point(3, 2);
            this.dgvMemberTrainerAssignmentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemberTrainerAssignmentDetails.Name = "dgvMemberTrainerAssignmentDetails";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberTrainerAssignmentDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMemberTrainerAssignmentDetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvMemberTrainerAssignmentDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMemberTrainerAssignmentDetails.RowTemplate.Height = 40;
            this.dgvMemberTrainerAssignmentDetails.Size = new System.Drawing.Size(1026, 574);
            this.dgvMemberTrainerAssignmentDetails.TabIndex = 0;
            this.dgvMemberTrainerAssignmentDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberTrainerAssignmentDetails_CellMouseEnter);
            this.dgvMemberTrainerAssignmentDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberTrainerAssignmentDetails_CellMouseLeave);
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSLNo.Width = 72;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.HeaderText = "Member Name";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.HeaderText = "Phone No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTrainerName
            // 
            this.colTrainerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrainerName.DataPropertyName = "TrainerName";
            this.colTrainerName.HeaderText = "Trainer Name";
            this.colTrainerName.Name = "colTrainerName";
            this.colTrainerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpSearchBar
            // 
            this.tlpSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchBar.ColumnCount = 2;
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.44916F));
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.55084F));
            this.tlpSearchBar.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpSearchBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpSearchBar.Location = new System.Drawing.Point(0, 118);
            this.tlpSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchBar.Name = "tlpSearchBar";
            this.tlpSearchBar.RowCount = 1;
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchBar.Size = new System.Drawing.Size(1032, 52);
            this.tlpSearchBar.TabIndex = 1;
            this.tlpSearchBar.Click += new System.EventHandler(this.tlpSearchBar_Click);
            // 
            // tlpSearch
            // 
            this.tlpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearch.ColumnCount = 3;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tlpSearch.Controls.Add(this.picSearch, 0, 0);
            this.tlpSearch.Controls.Add(this.txtSearchBar, 1, 0);
            this.tlpSearch.Controls.Add(this.btnSeach, 2, 0);
            this.tlpSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(675, 52);
            this.tlpSearch.TabIndex = 0;
            this.tlpSearch.Click += new System.EventHandler(this.tlpSearch_Click);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(0, 8);
            this.picSearch.Margin = new System.Windows.Forms.Padding(0);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(44, 35);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchBar.Location = new System.Drawing.Point(44, 11);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(316, 30);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Text = " Enter Member\'s Phone No";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeach.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSeach.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSeach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.ForeColor = System.Drawing.Color.White;
            this.btnSeach.Location = new System.Drawing.Point(363, 6);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(99, 40);
            this.btnSeach.TabIndex = 3;
            this.btnSeach.Text = "Search";
            this.btnSeach.UseVisualStyleBackColor = false;
            // 
            // tlpHeader
            // 
            this.tlpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Controls.Add(this.tlpTitleAndSubTitle, 1, 0);
            this.tlpHeader.Controls.Add(this.picMemberTrainerAssignment, 0, 0);
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1032, 118);
            this.tlpHeader.TabIndex = 0;
            this.tlpHeader.Click += new System.EventHandler(this.tlpHeader_Click);
            // 
            // tlpTitleAndSubTitle
            // 
            this.tlpTitleAndSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTitleAndSubTitle.ColumnCount = 1;
            this.tlpTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleAndSubTitle.Controls.Add(this.lblHeader, 0, 0);
            this.tlpTitleAndSubTitle.Controls.Add(this.lblSubTitle, 0, 1);
            this.tlpTitleAndSubTitle.Location = new System.Drawing.Point(69, 0);
            this.tlpTitleAndSubTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleAndSubTitle.Name = "tlpTitleAndSubTitle";
            this.tlpTitleAndSubTitle.RowCount = 3;
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.70833F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.04167F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tlpTitleAndSubTitle.Size = new System.Drawing.Size(481, 118);
            this.tlpTitleAndSubTitle.TabIndex = 0;
            this.tlpTitleAndSubTitle.Click += new System.EventHandler(this.tlpTitleAndSubTitle_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(3, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(475, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Assign Trainer To Member";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubTitle.Location = new System.Drawing.Point(3, 50);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(475, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Match members with the right trainer for their goals";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // picMemberTrainerAssignment
            // 
            this.picMemberTrainerAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picMemberTrainerAssignment.Image = ((System.Drawing.Image)(resources.GetObject("picMemberTrainerAssignment.Image")));
            this.picMemberTrainerAssignment.Location = new System.Drawing.Point(0, 0);
            this.picMemberTrainerAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.picMemberTrainerAssignment.Name = "picMemberTrainerAssignment";
            this.picMemberTrainerAssignment.Size = new System.Drawing.Size(69, 118);
            this.picMemberTrainerAssignment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMemberTrainerAssignment.TabIndex = 1;
            this.picMemberTrainerAssignment.TabStop = false;
            this.picMemberTrainerAssignment.Click += new System.EventHandler(this.picMemberTrainerAssignment_Click);
            // 
            // FrmMemberTrainerAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1149, 750);
            this.Controls.Add(this.tlpMemberTrainerAssignment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMemberTrainerAssignment";
            this.Text = "FrmMemberTrainerAssignment";
            this.Load += new System.EventHandler(this.FrmMemberTrainerAssignment_Load);
            this.tlpMemberTrainerAssignment.ResumeLayout(false);
            this.tlpTrainerAssignToMember.ResumeLayout(false);
            this.tlpShowMemberTrainerAssignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTrainerAssignmentDetails)).EndInit();
            this.tlpSearchBar.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.tlpHeader.ResumeLayout(false);
            this.tlpTitleAndSubTitle.ResumeLayout(false);
            this.tlpTitleAndSubTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberTrainerAssignment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMemberTrainerAssignment;
        private System.Windows.Forms.TableLayoutPanel tlpTrainerAssignToMember;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpTitleAndSubTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.PictureBox picMemberTrainerAssignment;
        private System.Windows.Forms.TableLayoutPanel tlpShowMemberTrainerAssignment;
        private System.Windows.Forms.DataGridView dgvMemberTrainerAssignmentDetails;
        private System.Windows.Forms.TableLayoutPanel tlpSearchBar;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerName;
    }
}