namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    partial class FrmSAExpense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAExpense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpExpencesHistory = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExpencesHistoryHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picExpencesHistory = new System.Windows.Forms.PictureBox();
            this.tlpExpencesHistoryTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewExpencesHistoryDetails = new System.Windows.Forms.Label();
            this.lblExpencesHistory = new System.Windows.Forms.Label();
            this.dgvExpensesHistory = new System.Windows.Forms.DataGridView();
            this.tlpTotalExpencesHistoryAndExport = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportExpencesHistory = new System.Windows.Forms.Button();
            this.lblTotalExpencesHistory = new System.Windows.Forms.Label();
            this.lblOutputTotalExpenceExpenceHistory = new System.Windows.Forms.Label();
            this.picTotalExpencesHistory = new System.Windows.Forms.PictureBox();
            this.tlpStartAndEndDateExpencesHistory = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchExpencesHistory = new System.Windows.Forms.Button();
            this.lblStartDateExpencesHistory = new System.Windows.Forms.Label();
            this.dtpStartDateExpencesHistory = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateExpencesHistory = new System.Windows.Forms.Label();
            this.dtpEndDateExpencesHistory = new System.Windows.Forms.DateTimePicker();
            this.picStartDateExpencesHistory = new System.Windows.Forms.PictureBox();
            this.picEndDateExpencesHistory = new System.Windows.Forms.PictureBox();
            this.tlpDateRangeExpencesHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRangeExpencesHistory = new System.Windows.Forms.Label();
            this.picDateRangeExpencesHistory = new System.Windows.Forms.PictureBox();
            this.tlpMonthYearSearchExpencesHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonthExpencesHistory = new System.Windows.Forms.Label();
            this.cmbMonthExpencesHistory = new System.Windows.Forms.ComboBox();
            this.lblYearExpencesHistory = new System.Windows.Forms.Label();
            this.txtYearExpencesHistory = new System.Windows.Forms.TextBox();
            this.picMonthExpencesHistory = new System.Windows.Forms.PictureBox();
            this.picYearExpencesHistory = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchExpense = new System.Windows.Forms.Button();
            this.tlpExpencesHistory.SuspendLayout();
            this.tlpExpencesHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpencesHistory)).BeginInit();
            this.tlpExpencesHistoryTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensesHistory)).BeginInit();
            this.tlpTotalExpencesHistoryAndExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalExpencesHistory)).BeginInit();
            this.tlpStartAndEndDateExpencesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDateExpencesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDateExpencesHistory)).BeginInit();
            this.tlpDateRangeExpencesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangeExpencesHistory)).BeginInit();
            this.tlpMonthYearSearchExpencesHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthExpencesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYearExpencesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpExpencesHistory
            // 
            this.tlpExpencesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpExpencesHistory.ColumnCount = 3;
            this.tlpExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.30662F));
            this.tlpExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.21255F));
            this.tlpExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.480836F));
            this.tlpExpencesHistory.Controls.Add(this.tlpExpencesHistoryHeader, 1, 1);
            this.tlpExpencesHistory.Controls.Add(this.dgvExpensesHistory, 1, 6);
            this.tlpExpencesHistory.Controls.Add(this.tlpTotalExpencesHistoryAndExport, 1, 5);
            this.tlpExpencesHistory.Controls.Add(this.tlpStartAndEndDateExpencesHistory, 1, 4);
            this.tlpExpencesHistory.Controls.Add(this.tlpDateRangeExpencesHistory, 1, 3);
            this.tlpExpencesHistory.Controls.Add(this.tlpMonthYearSearchExpencesHistory, 1, 2);
            this.tlpExpencesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpencesHistory.Location = new System.Drawing.Point(0, 0);
            this.tlpExpencesHistory.Name = "tlpExpencesHistory";
            this.tlpExpencesHistory.RowCount = 8;
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.31467F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89934F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.46948F));
            this.tlpExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.3165F));
            this.tlpExpencesHistory.Size = new System.Drawing.Size(1149, 788);
            this.tlpExpencesHistory.TabIndex = 1;
            this.tlpExpencesHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tlpExpencesHistoryHeader
            // 
            this.tlpExpencesHistoryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpExpencesHistoryHeader.ColumnCount = 4;
            this.tlpExpencesHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpExpencesHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tlpExpencesHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16434F));
            this.tlpExpencesHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83566F));
            this.tlpExpencesHistoryHeader.Controls.Add(this.picExpencesHistory, 0, 0);
            this.tlpExpencesHistoryHeader.Controls.Add(this.tlpExpencesHistoryTitle, 1, 0);
            this.tlpExpencesHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpencesHistoryHeader.Location = new System.Drawing.Point(18, 9);
            this.tlpExpencesHistoryHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpExpencesHistoryHeader.Name = "tlpExpencesHistoryHeader";
            this.tlpExpencesHistoryHeader.RowCount = 1;
            this.tlpExpencesHistoryHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpencesHistoryHeader.Size = new System.Drawing.Size(1110, 71);
            this.tlpExpencesHistoryHeader.TabIndex = 10;
            // 
            // picExpencesHistory
            // 
            this.picExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picExpencesHistory.Image")));
            this.picExpencesHistory.Location = new System.Drawing.Point(0, 0);
            this.picExpencesHistory.Margin = new System.Windows.Forms.Padding(0);
            this.picExpencesHistory.Name = "picExpencesHistory";
            this.picExpencesHistory.Size = new System.Drawing.Size(67, 71);
            this.picExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExpencesHistory.TabIndex = 0;
            this.picExpencesHistory.TabStop = false;
            // 
            // tlpExpencesHistoryTitle
            // 
            this.tlpExpencesHistoryTitle.ColumnCount = 1;
            this.tlpExpencesHistoryTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpencesHistoryTitle.Controls.Add(this.lblViewExpencesHistoryDetails, 0, 1);
            this.tlpExpencesHistoryTitle.Controls.Add(this.lblExpencesHistory, 0, 0);
            this.tlpExpencesHistoryTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpencesHistoryTitle.Location = new System.Drawing.Point(71, 3);
            this.tlpExpencesHistoryTitle.Name = "tlpExpencesHistoryTitle";
            this.tlpExpencesHistoryTitle.RowCount = 3;
            this.tlpExpencesHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tlpExpencesHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5082F));
            this.tlpExpencesHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tlpExpencesHistoryTitle.Size = new System.Drawing.Size(308, 65);
            this.tlpExpencesHistoryTitle.TabIndex = 1;
            // 
            // lblViewExpencesHistoryDetails
            // 
            this.lblViewExpencesHistoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewExpencesHistoryDetails.AutoSize = true;
            this.lblViewExpencesHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewExpencesHistoryDetails.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewExpencesHistoryDetails.Location = new System.Drawing.Point(3, 33);
            this.lblViewExpencesHistoryDetails.Name = "lblViewExpencesHistoryDetails";
            this.lblViewExpencesHistoryDetails.Size = new System.Drawing.Size(245, 19);
            this.lblViewExpencesHistoryDetails.TabIndex = 3;
            this.lblViewExpencesHistoryDetails.Text = "View All Type Expences Details By Date";
            // 
            // lblExpencesHistory
            // 
            this.lblExpencesHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpencesHistory.AutoSize = true;
            this.lblExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpencesHistory.Location = new System.Drawing.Point(3, 5);
            this.lblExpencesHistory.Name = "lblExpencesHistory";
            this.lblExpencesHistory.Size = new System.Drawing.Size(168, 28);
            this.lblExpencesHistory.TabIndex = 2;
            this.lblExpencesHistory.Text = "Expences History";
            // 
            // dgvExpensesHistory
            // 
            this.dgvExpensesHistory.AllowUserToAddRows = false;
            this.dgvExpensesHistory.AllowUserToResizeColumns = false;
            this.dgvExpensesHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpensesHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvExpensesHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExpensesHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpensesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvExpensesHistory.ColumnHeadersHeight = 55;
            this.dgvExpensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpensesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colExpenseId,
            this.colCategoryName,
            this.colCategory,
            this.colExpenseAmount,
            this.colExpenseDate,
            this.colNotes});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpensesHistory.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvExpensesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpensesHistory.EnableHeadersVisualStyles = false;
            this.dgvExpensesHistory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExpensesHistory.Location = new System.Drawing.Point(18, 284);
            this.dgvExpensesHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpensesHistory.Name = "dgvExpensesHistory";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvExpensesHistory.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.dgvExpensesHistory.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvExpensesHistory.RowTemplate.Height = 40;
            this.dgvExpensesHistory.Size = new System.Drawing.Size(1110, 475);
            this.dgvExpensesHistory.TabIndex = 14;
            this.dgvExpensesHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvExpensesHistory_CellFormatting);
            this.dgvExpensesHistory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpensesHistory_CellMouseEnter);
            this.dgvExpensesHistory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpensesHistory_CellMouseLeave);
            // 
            // tlpTotalExpencesHistoryAndExport
            // 
            this.tlpTotalExpencesHistoryAndExport.ColumnCount = 5;
            this.tlpTotalExpencesHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpTotalExpencesHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tlpTotalExpencesHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlpTotalExpencesHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalExpencesHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpTotalExpencesHistoryAndExport.Controls.Add(this.btnExportExpencesHistory, 4, 0);
            this.tlpTotalExpencesHistoryAndExport.Controls.Add(this.lblTotalExpencesHistory, 1, 0);
            this.tlpTotalExpencesHistoryAndExport.Controls.Add(this.lblOutputTotalExpenceExpenceHistory, 2, 0);
            this.tlpTotalExpencesHistoryAndExport.Controls.Add(this.picTotalExpencesHistory, 0, 0);
            this.tlpTotalExpencesHistoryAndExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalExpencesHistoryAndExport.Location = new System.Drawing.Point(18, 235);
            this.tlpTotalExpencesHistoryAndExport.Name = "tlpTotalExpencesHistoryAndExport";
            this.tlpTotalExpencesHistoryAndExport.RowCount = 1;
            this.tlpTotalExpencesHistoryAndExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalExpencesHistoryAndExport.Size = new System.Drawing.Size(1110, 44);
            this.tlpTotalExpencesHistoryAndExport.TabIndex = 15;
            // 
            // btnExportExpencesHistory
            // 
            this.btnExportExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportExpencesHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExportExpencesHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportExpencesHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportExpencesHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportExpencesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExpencesHistory.ForeColor = System.Drawing.Color.White;
            this.btnExportExpencesHistory.Location = new System.Drawing.Point(993, 2);
            this.btnExportExpencesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnExportExpencesHistory.Name = "btnExportExpencesHistory";
            this.btnExportExpencesHistory.Size = new System.Drawing.Size(117, 40);
            this.btnExportExpencesHistory.TabIndex = 5;
            this.btnExportExpencesHistory.Text = "Export";
            this.btnExportExpencesHistory.UseVisualStyleBackColor = false;
            this.btnExportExpencesHistory.Click += new System.EventHandler(this.btnExportExpencesHistory_Click);
            // 
            // lblTotalExpencesHistory
            // 
            this.lblTotalExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalExpencesHistory.AutoSize = true;
            this.lblTotalExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalExpencesHistory.Location = new System.Drawing.Point(40, 10);
            this.lblTotalExpencesHistory.Name = "lblTotalExpencesHistory";
            this.lblTotalExpencesHistory.Size = new System.Drawing.Size(124, 23);
            this.lblTotalExpencesHistory.TabIndex = 0;
            this.lblTotalExpencesHistory.Text = "Total Expence :";
            // 
            // lblOutputTotalExpenceExpenceHistory
            // 
            this.lblOutputTotalExpenceExpenceHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutputTotalExpenceExpenceHistory.AutoSize = true;
            this.lblOutputTotalExpenceExpenceHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotalExpenceExpenceHistory.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputTotalExpenceExpenceHistory.Location = new System.Drawing.Point(186, 10);
            this.lblOutputTotalExpenceExpenceHistory.Name = "lblOutputTotalExpenceExpenceHistory";
            this.lblOutputTotalExpenceExpenceHistory.Size = new System.Drawing.Size(31, 23);
            this.lblOutputTotalExpenceExpenceHistory.TabIndex = 2;
            this.lblOutputTotalExpenceExpenceHistory.Text = "---";
            // 
            // picTotalExpencesHistory
            // 
            this.picTotalExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picTotalExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picTotalExpencesHistory.Image")));
            this.picTotalExpencesHistory.Location = new System.Drawing.Point(3, 4);
            this.picTotalExpencesHistory.Name = "picTotalExpencesHistory";
            this.picTotalExpencesHistory.Size = new System.Drawing.Size(31, 35);
            this.picTotalExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTotalExpencesHistory.TabIndex = 3;
            this.picTotalExpencesHistory.TabStop = false;
            // 
            // tlpStartAndEndDateExpencesHistory
            // 
            this.tlpStartAndEndDateExpencesHistory.ColumnCount = 8;
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpStartAndEndDateExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.btnSearchExpencesHistory, 6, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.lblStartDateExpencesHistory, 1, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.dtpStartDateExpencesHistory, 2, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.lblEndDateExpencesHistory, 4, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.dtpEndDateExpencesHistory, 5, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.picStartDateExpencesHistory, 0, 0);
            this.tlpStartAndEndDateExpencesHistory.Controls.Add(this.picEndDateExpencesHistory, 3, 0);
            this.tlpStartAndEndDateExpencesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartAndEndDateExpencesHistory.Location = new System.Drawing.Point(18, 185);
            this.tlpStartAndEndDateExpencesHistory.Name = "tlpStartAndEndDateExpencesHistory";
            this.tlpStartAndEndDateExpencesHistory.RowCount = 1;
            this.tlpStartAndEndDateExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDateExpencesHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpStartAndEndDateExpencesHistory.TabIndex = 16;
            // 
            // btnSearchExpencesHistory
            // 
            this.btnSearchExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchExpencesHistory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchExpencesHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchExpencesHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchExpencesHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchExpencesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExpencesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSearchExpencesHistory.Location = new System.Drawing.Point(1006, 2);
            this.btnSearchExpencesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearchExpencesHistory.Name = "btnSearchExpencesHistory";
            this.btnSearchExpencesHistory.Size = new System.Drawing.Size(107, 40);
            this.btnSearchExpencesHistory.TabIndex = 5;
            this.btnSearchExpencesHistory.Text = "Search";
            this.btnSearchExpencesHistory.UseVisualStyleBackColor = false;
            this.btnSearchExpencesHistory.Click += new System.EventHandler(this.btnSearchExpencesHistory_Click);
            // 
            // lblStartDateExpencesHistory
            // 
            this.lblStartDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDateExpencesHistory.AutoSize = true;
            this.lblStartDateExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStartDateExpencesHistory.Location = new System.Drawing.Point(40, 10);
            this.lblStartDateExpencesHistory.Name = "lblStartDateExpencesHistory";
            this.lblStartDateExpencesHistory.Size = new System.Drawing.Size(96, 23);
            this.lblStartDateExpencesHistory.TabIndex = 0;
            this.lblStartDateExpencesHistory.Text = "Start Date :";
            // 
            // dtpStartDateExpencesHistory
            // 
            this.dtpStartDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDateExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateExpencesHistory.Location = new System.Drawing.Point(168, 7);
            this.dtpStartDateExpencesHistory.Name = "dtpStartDateExpencesHistory";
            this.dtpStartDateExpencesHistory.Size = new System.Drawing.Size(319, 30);
            this.dtpStartDateExpencesHistory.TabIndex = 1;
            // 
            // lblEndDateExpencesHistory
            // 
            this.lblEndDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDateExpencesHistory.AutoSize = true;
            this.lblEndDateExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDateExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEndDateExpencesHistory.Location = new System.Drawing.Point(543, 10);
            this.lblEndDateExpencesHistory.Name = "lblEndDateExpencesHistory";
            this.lblEndDateExpencesHistory.Size = new System.Drawing.Size(89, 23);
            this.lblEndDateExpencesHistory.TabIndex = 0;
            this.lblEndDateExpencesHistory.Text = "End Date :";
            // 
            // dtpEndDateExpencesHistory
            // 
            this.dtpEndDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDateExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateExpencesHistory.Location = new System.Drawing.Point(664, 7);
            this.dtpEndDateExpencesHistory.Name = "dtpEndDateExpencesHistory";
            this.dtpEndDateExpencesHistory.Size = new System.Drawing.Size(325, 30);
            this.dtpEndDateExpencesHistory.TabIndex = 0;
            // 
            // picStartDateExpencesHistory
            // 
            this.picStartDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picStartDateExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picStartDateExpencesHistory.Image")));
            this.picStartDateExpencesHistory.Location = new System.Drawing.Point(3, 4);
            this.picStartDateExpencesHistory.Name = "picStartDateExpencesHistory";
            this.picStartDateExpencesHistory.Size = new System.Drawing.Size(31, 36);
            this.picStartDateExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStartDateExpencesHistory.TabIndex = 2;
            this.picStartDateExpencesHistory.TabStop = false;
            // 
            // picEndDateExpencesHistory
            // 
            this.picEndDateExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picEndDateExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picEndDateExpencesHistory.Image")));
            this.picEndDateExpencesHistory.Location = new System.Drawing.Point(506, 4);
            this.picEndDateExpencesHistory.Name = "picEndDateExpencesHistory";
            this.picEndDateExpencesHistory.Size = new System.Drawing.Size(31, 36);
            this.picEndDateExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEndDateExpencesHistory.TabIndex = 3;
            this.picEndDateExpencesHistory.TabStop = false;
            // 
            // tlpDateRangeExpencesHistory
            // 
            this.tlpDateRangeExpencesHistory.ColumnCount = 3;
            this.tlpDateRangeExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpDateRangeExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpDateRangeExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangeExpencesHistory.Controls.Add(this.lblDateRangeExpencesHistory, 1, 0);
            this.tlpDateRangeExpencesHistory.Controls.Add(this.picDateRangeExpencesHistory, 0, 0);
            this.tlpDateRangeExpencesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateRangeExpencesHistory.Location = new System.Drawing.Point(18, 135);
            this.tlpDateRangeExpencesHistory.Name = "tlpDateRangeExpencesHistory";
            this.tlpDateRangeExpencesHistory.RowCount = 1;
            this.tlpDateRangeExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangeExpencesHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpDateRangeExpencesHistory.TabIndex = 17;
            // 
            // lblDateRangeExpencesHistory
            // 
            this.lblDateRangeExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateRangeExpencesHistory.AutoSize = true;
            this.lblDateRangeExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRangeExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateRangeExpencesHistory.Location = new System.Drawing.Point(40, 10);
            this.lblDateRangeExpencesHistory.Name = "lblDateRangeExpencesHistory";
            this.lblDateRangeExpencesHistory.Size = new System.Drawing.Size(105, 23);
            this.lblDateRangeExpencesHistory.TabIndex = 0;
            this.lblDateRangeExpencesHistory.Text = "Date Range ";
            // 
            // picDateRangeExpencesHistory
            // 
            this.picDateRangeExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picDateRangeExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picDateRangeExpencesHistory.Image")));
            this.picDateRangeExpencesHistory.Location = new System.Drawing.Point(3, 3);
            this.picDateRangeExpencesHistory.Name = "picDateRangeExpencesHistory";
            this.picDateRangeExpencesHistory.Size = new System.Drawing.Size(31, 37);
            this.picDateRangeExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDateRangeExpencesHistory.TabIndex = 0;
            this.picDateRangeExpencesHistory.TabStop = false;
            // 
            // tlpMonthYearSearchExpencesHistory
            // 
            this.tlpMonthYearSearchExpencesHistory.ColumnCount = 7;
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMonthYearSearchExpencesHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.btnSearchExpense, 6, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.lblMonthExpencesHistory, 1, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.cmbMonthExpencesHistory, 2, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.lblYearExpencesHistory, 4, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.txtYearExpencesHistory, 5, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.picMonthExpencesHistory, 0, 0);
            this.tlpMonthYearSearchExpencesHistory.Controls.Add(this.picYearExpencesHistory, 3, 0);
            this.tlpMonthYearSearchExpencesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMonthYearSearchExpencesHistory.Location = new System.Drawing.Point(18, 85);
            this.tlpMonthYearSearchExpencesHistory.Name = "tlpMonthYearSearchExpencesHistory";
            this.tlpMonthYearSearchExpencesHistory.RowCount = 1;
            this.tlpMonthYearSearchExpencesHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMonthYearSearchExpencesHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpMonthYearSearchExpencesHistory.TabIndex = 18;
            // 
            // lblMonthExpencesHistory
            // 
            this.lblMonthExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonthExpencesHistory.AutoSize = true;
            this.lblMonthExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMonthExpencesHistory.Location = new System.Drawing.Point(40, 10);
            this.lblMonthExpencesHistory.Name = "lblMonthExpencesHistory";
            this.lblMonthExpencesHistory.Size = new System.Drawing.Size(81, 23);
            this.lblMonthExpencesHistory.TabIndex = 0;
            this.lblMonthExpencesHistory.Text = "Mounth :";
            // 
            // cmbMonthExpencesHistory
            // 
            this.cmbMonthExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbMonthExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonthExpencesHistory.ForeColor = System.Drawing.Color.Gray;
            this.cmbMonthExpencesHistory.FormattingEnabled = true;
            this.cmbMonthExpencesHistory.Location = new System.Drawing.Point(145, 6);
            this.cmbMonthExpencesHistory.Name = "cmbMonthExpencesHistory";
            this.cmbMonthExpencesHistory.Size = new System.Drawing.Size(259, 31);
            this.cmbMonthExpencesHistory.TabIndex = 3;
            this.cmbMonthExpencesHistory.Text = "Select Month";
            // 
            // lblYearExpencesHistory
            // 
            this.lblYearExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYearExpencesHistory.AutoSize = true;
            this.lblYearExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearExpencesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblYearExpencesHistory.Location = new System.Drawing.Point(456, 10);
            this.lblYearExpencesHistory.Name = "lblYearExpencesHistory";
            this.lblYearExpencesHistory.Size = new System.Drawing.Size(51, 23);
            this.lblYearExpencesHistory.TabIndex = 0;
            this.lblYearExpencesHistory.Text = "Year :";
            // 
            // txtYearExpencesHistory
            // 
            this.txtYearExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtYearExpencesHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearExpencesHistory.ForeColor = System.Drawing.Color.Gray;
            this.txtYearExpencesHistory.Location = new System.Drawing.Point(529, 7);
            this.txtYearExpencesHistory.Name = "txtYearExpencesHistory";
            this.txtYearExpencesHistory.Size = new System.Drawing.Size(190, 30);
            this.txtYearExpencesHistory.TabIndex = 4;
            this.txtYearExpencesHistory.Text = "Enter Year";
            this.txtYearExpencesHistory.Click += new System.EventHandler(this.txtYearExpencesHistory_Click);
            // 
            // picMonthExpencesHistory
            // 
            this.picMonthExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picMonthExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picMonthExpencesHistory.Image")));
            this.picMonthExpencesHistory.Location = new System.Drawing.Point(3, 3);
            this.picMonthExpencesHistory.Name = "picMonthExpencesHistory";
            this.picMonthExpencesHistory.Size = new System.Drawing.Size(31, 37);
            this.picMonthExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonthExpencesHistory.TabIndex = 2;
            this.picMonthExpencesHistory.TabStop = false;
            // 
            // picYearExpencesHistory
            // 
            this.picYearExpencesHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picYearExpencesHistory.Image = ((System.Drawing.Image)(resources.GetObject("picYearExpencesHistory.Image")));
            this.picYearExpencesHistory.Location = new System.Drawing.Point(420, 3);
            this.picYearExpencesHistory.Name = "picYearExpencesHistory";
            this.picYearExpencesHistory.Size = new System.Drawing.Size(30, 37);
            this.picYearExpencesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYearExpencesHistory.TabIndex = 2;
            this.picYearExpencesHistory.TabStop = false;
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSLNo.Width = 71;
            // 
            // colExpenseId
            // 
            this.colExpenseId.HeaderText = "ExpenseId";
            this.colExpenseId.Name = "colExpenseId";
            this.colExpenseId.Visible = false;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoryName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.colCategoryName.DefaultCellStyle = dataGridViewCellStyle21;
            this.colCategoryName.HeaderText = "Category Name";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCategory.Width = 99;
            // 
            // colExpenseAmount
            // 
            this.colExpenseAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colExpenseAmount.DataPropertyName = "ExpenseAmount";
            this.colExpenseAmount.HeaderText = "Amount";
            this.colExpenseAmount.Name = "colExpenseAmount";
            this.colExpenseAmount.Width = 110;
            // 
            // colExpenseDate
            // 
            this.colExpenseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpenseDate.DataPropertyName = "ExpenseDate";
            this.colExpenseDate.HeaderText = "Expense Date";
            this.colExpenseDate.Name = "colExpenseDate";
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Note";
            this.colNotes.Name = "colNotes";
            // 
            // btnSearchExpense
            // 
            this.btnSearchExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchExpense.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchExpense.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExpense.ForeColor = System.Drawing.Color.White;
            this.btnSearchExpense.Location = new System.Drawing.Point(733, 2);
            this.btnSearchExpense.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearchExpense.Name = "btnSearchExpense";
            this.btnSearchExpense.Size = new System.Drawing.Size(107, 40);
            this.btnSearchExpense.TabIndex = 5;
            this.btnSearchExpense.Text = "Search";
            this.btnSearchExpense.UseVisualStyleBackColor = false;
            this.btnSearchExpense.Click += new System.EventHandler(this.btnSearchExpense_Click);
            // 
            // FrmSAExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpExpencesHistory);
            this.MinimumSize = new System.Drawing.Size(1167, 835);
            this.Name = "FrmSAExpense";
            this.Text = "FrmSAExpense";
            this.Load += new System.EventHandler(this.FrmSAExpense_Load);
            this.Shown += new System.EventHandler(this.FrmSAExpense_Shown);
            this.tlpExpencesHistory.ResumeLayout(false);
            this.tlpExpencesHistoryHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExpencesHistory)).EndInit();
            this.tlpExpencesHistoryTitle.ResumeLayout(false);
            this.tlpExpencesHistoryTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensesHistory)).EndInit();
            this.tlpTotalExpencesHistoryAndExport.ResumeLayout(false);
            this.tlpTotalExpencesHistoryAndExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalExpencesHistory)).EndInit();
            this.tlpStartAndEndDateExpencesHistory.ResumeLayout(false);
            this.tlpStartAndEndDateExpencesHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDateExpencesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDateExpencesHistory)).EndInit();
            this.tlpDateRangeExpencesHistory.ResumeLayout(false);
            this.tlpDateRangeExpencesHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangeExpencesHistory)).EndInit();
            this.tlpMonthYearSearchExpencesHistory.ResumeLayout(false);
            this.tlpMonthYearSearchExpencesHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthExpencesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYearExpencesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpExpencesHistory;
        private System.Windows.Forms.TableLayoutPanel tlpExpencesHistoryHeader;
        private System.Windows.Forms.PictureBox picExpencesHistory;
        private System.Windows.Forms.TableLayoutPanel tlpExpencesHistoryTitle;
        private System.Windows.Forms.Label lblViewExpencesHistoryDetails;
        private System.Windows.Forms.Label lblExpencesHistory;
        private System.Windows.Forms.DataGridView dgvExpensesHistory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tlpStartAndEndDateExpencesHistory;
        private System.Windows.Forms.Button btnSearchExpencesHistory;
        private System.Windows.Forms.Label lblStartDateExpencesHistory;
        private System.Windows.Forms.DateTimePicker dtpStartDateExpencesHistory;
        private System.Windows.Forms.Label lblEndDateExpencesHistory;
        private System.Windows.Forms.DateTimePicker dtpEndDateExpencesHistory;
        private System.Windows.Forms.PictureBox picStartDateExpencesHistory;
        private System.Windows.Forms.PictureBox picEndDateExpencesHistory;
        private System.Windows.Forms.TableLayoutPanel tlpDateRangeExpencesHistory;
        private System.Windows.Forms.Label lblDateRangeExpencesHistory;
        private System.Windows.Forms.PictureBox picDateRangeExpencesHistory;
        private System.Windows.Forms.TableLayoutPanel tlpMonthYearSearchExpencesHistory;
        private System.Windows.Forms.Label lblMonthExpencesHistory;
        private System.Windows.Forms.ComboBox cmbMonthExpencesHistory;
        private System.Windows.Forms.Label lblYearExpencesHistory;
        private System.Windows.Forms.TextBox txtYearExpencesHistory;
        private System.Windows.Forms.PictureBox picMonthExpencesHistory;
        private System.Windows.Forms.PictureBox picYearExpencesHistory;
        private System.Windows.Forms.TableLayoutPanel tlpTotalExpencesHistoryAndExport;
        private System.Windows.Forms.Button btnExportExpencesHistory;
        private System.Windows.Forms.Label lblTotalExpencesHistory;
        private System.Windows.Forms.Label lblOutputTotalExpenceExpenceHistory;
        private System.Windows.Forms.PictureBox picTotalExpencesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.Button btnSearchExpense;
    }
}