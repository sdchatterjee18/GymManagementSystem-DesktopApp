namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    partial class FrmSAPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPaymentHistory = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPaymentHistoryHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPaymentHistory = new System.Windows.Forms.PictureBox();
            this.tlpPaymentHistoryTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewPaymentHistoryDetails = new System.Windows.Forms.Label();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.tlpMonthYearSearchPaymentHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonthPaymentHistory = new System.Windows.Forms.Label();
            this.cmbMonthPaymentHistory = new System.Windows.Forms.ComboBox();
            this.lblYearPaymentHistory = new System.Windows.Forms.Label();
            this.txtYearPaymentHistory = new System.Windows.Forms.TextBox();
            this.picMonthPaymentHistory = new System.Windows.Forms.PictureBox();
            this.picYearPaymentHistory = new System.Windows.Forms.PictureBox();
            this.tlpDateRangePaymentHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRangePaymentHistory = new System.Windows.Forms.Label();
            this.picDateRangePaymentHistory = new System.Windows.Forms.PictureBox();
            this.tlpStartAndEndDatePaymentHistory = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchPaymentHistory = new System.Windows.Forms.Button();
            this.lblStartDatePaymentHistory = new System.Windows.Forms.Label();
            this.dtpStartDatePaymentHistory = new System.Windows.Forms.DateTimePicker();
            this.lblEndDatePaymentHistory = new System.Windows.Forms.Label();
            this.dtpEndDatePaymentHistory = new System.Windows.Forms.DateTimePicker();
            this.picStartDatePaymentHistory = new System.Windows.Forms.PictureBox();
            this.picEndDatePaymentHistory = new System.Windows.Forms.PictureBox();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.tlpTotalPaymentHistoryAndExport = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportPaymentHistory = new System.Windows.Forms.Button();
            this.lblTotalPaymentHistory = new System.Windows.Forms.Label();
            this.lblOutputTotalExpencePaymentHistory = new System.Windows.Forms.Label();
            this.picTotalPaymentHistory = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembershipPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPaymentHistory.SuspendLayout();
            this.tlpPaymentHistoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentHistory)).BeginInit();
            this.tlpPaymentHistoryTitle.SuspendLayout();
            this.tlpMonthYearSearchPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYearPaymentHistory)).BeginInit();
            this.tlpDateRangePaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangePaymentHistory)).BeginInit();
            this.tlpStartAndEndDatePaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDatePaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDatePaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.tlpTotalPaymentHistoryAndExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPaymentHistory
            // 
            this.tlpPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpPaymentHistory.ColumnCount = 3;
            this.tlpPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.30662F));
            this.tlpPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.21255F));
            this.tlpPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.480836F));
            this.tlpPaymentHistory.Controls.Add(this.tlpPaymentHistoryHeader, 1, 1);
            this.tlpPaymentHistory.Controls.Add(this.tlpMonthYearSearchPaymentHistory, 1, 2);
            this.tlpPaymentHistory.Controls.Add(this.tlpDateRangePaymentHistory, 1, 3);
            this.tlpPaymentHistory.Controls.Add(this.tlpStartAndEndDatePaymentHistory, 1, 4);
            this.tlpPaymentHistory.Controls.Add(this.dgvPaymentHistory, 1, 6);
            this.tlpPaymentHistory.Controls.Add(this.tlpTotalPaymentHistoryAndExport, 1, 5);
            this.tlpPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentHistory.Name = "tlpPaymentHistory";
            this.tlpPaymentHistory.RowCount = 8;
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.323657F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98751F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.34283F));
            this.tlpPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.346005F));
            this.tlpPaymentHistory.Size = new System.Drawing.Size(1149, 788);
            this.tlpPaymentHistory.TabIndex = 3;
            // 
            // tlpPaymentHistoryHeader
            // 
            this.tlpPaymentHistoryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpPaymentHistoryHeader.ColumnCount = 4;
            this.tlpPaymentHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpPaymentHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tlpPaymentHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.16434F));
            this.tlpPaymentHistoryHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83566F));
            this.tlpPaymentHistoryHeader.Controls.Add(this.picPaymentHistory, 0, 0);
            this.tlpPaymentHistoryHeader.Controls.Add(this.tlpPaymentHistoryTitle, 1, 0);
            this.tlpPaymentHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentHistoryHeader.Location = new System.Drawing.Point(18, 9);
            this.tlpPaymentHistoryHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPaymentHistoryHeader.Name = "tlpPaymentHistoryHeader";
            this.tlpPaymentHistoryHeader.RowCount = 1;
            this.tlpPaymentHistoryHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentHistoryHeader.Size = new System.Drawing.Size(1110, 72);
            this.tlpPaymentHistoryHeader.TabIndex = 10;
            // 
            // picPaymentHistory
            // 
            this.picPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picPaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picPaymentHistory.Image")));
            this.picPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.picPaymentHistory.Margin = new System.Windows.Forms.Padding(0);
            this.picPaymentHistory.Name = "picPaymentHistory";
            this.picPaymentHistory.Size = new System.Drawing.Size(67, 72);
            this.picPaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaymentHistory.TabIndex = 0;
            this.picPaymentHistory.TabStop = false;
            // 
            // tlpPaymentHistoryTitle
            // 
            this.tlpPaymentHistoryTitle.ColumnCount = 1;
            this.tlpPaymentHistoryTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentHistoryTitle.Controls.Add(this.lblViewPaymentHistoryDetails, 0, 1);
            this.tlpPaymentHistoryTitle.Controls.Add(this.lblPaymentHistory, 0, 0);
            this.tlpPaymentHistoryTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentHistoryTitle.Location = new System.Drawing.Point(71, 3);
            this.tlpPaymentHistoryTitle.Name = "tlpPaymentHistoryTitle";
            this.tlpPaymentHistoryTitle.RowCount = 3;
            this.tlpPaymentHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tlpPaymentHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5082F));
            this.tlpPaymentHistoryTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tlpPaymentHistoryTitle.Size = new System.Drawing.Size(308, 66);
            this.tlpPaymentHistoryTitle.TabIndex = 1;
            // 
            // lblViewPaymentHistoryDetails
            // 
            this.lblViewPaymentHistoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewPaymentHistoryDetails.AutoSize = true;
            this.lblViewPaymentHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPaymentHistoryDetails.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewPaymentHistoryDetails.Location = new System.Drawing.Point(3, 34);
            this.lblViewPaymentHistoryDetails.Name = "lblViewPaymentHistoryDetails";
            this.lblViewPaymentHistoryDetails.Size = new System.Drawing.Size(244, 19);
            this.lblViewPaymentHistoryDetails.TabIndex = 3;
            this.lblViewPaymentHistoryDetails.Text = "View All Type Payment Details By Date";
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.Location = new System.Drawing.Point(3, 6);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(163, 28);
            this.lblPaymentHistory.TabIndex = 2;
            this.lblPaymentHistory.Text = "Payment History";
            // 
            // tlpMonthYearSearchPaymentHistory
            // 
            this.tlpMonthYearSearchPaymentHistory.ColumnCount = 7;
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMonthYearSearchPaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.btnSearch, 6, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.lblMonthPaymentHistory, 1, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.cmbMonthPaymentHistory, 2, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.lblYearPaymentHistory, 4, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.txtYearPaymentHistory, 5, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.picMonthPaymentHistory, 0, 0);
            this.tlpMonthYearSearchPaymentHistory.Controls.Add(this.picYearPaymentHistory, 3, 0);
            this.tlpMonthYearSearchPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMonthYearSearchPaymentHistory.Location = new System.Drawing.Point(18, 86);
            this.tlpMonthYearSearchPaymentHistory.Name = "tlpMonthYearSearchPaymentHistory";
            this.tlpMonthYearSearchPaymentHistory.RowCount = 1;
            this.tlpMonthYearSearchPaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMonthYearSearchPaymentHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpMonthYearSearchPaymentHistory.TabIndex = 11;
            // 
            // lblMonthPaymentHistory
            // 
            this.lblMonthPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonthPaymentHistory.AutoSize = true;
            this.lblMonthPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMonthPaymentHistory.Location = new System.Drawing.Point(40, 10);
            this.lblMonthPaymentHistory.Name = "lblMonthPaymentHistory";
            this.lblMonthPaymentHistory.Size = new System.Drawing.Size(81, 23);
            this.lblMonthPaymentHistory.TabIndex = 0;
            this.lblMonthPaymentHistory.Text = "Mounth :";
            // 
            // cmbMonthPaymentHistory
            // 
            this.cmbMonthPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbMonthPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonthPaymentHistory.ForeColor = System.Drawing.Color.Gray;
            this.cmbMonthPaymentHistory.FormattingEnabled = true;
            this.cmbMonthPaymentHistory.Location = new System.Drawing.Point(145, 6);
            this.cmbMonthPaymentHistory.Name = "cmbMonthPaymentHistory";
            this.cmbMonthPaymentHistory.Size = new System.Drawing.Size(259, 31);
            this.cmbMonthPaymentHistory.TabIndex = 3;
            this.cmbMonthPaymentHistory.Text = "Select Month";
            // 
            // lblYearPaymentHistory
            // 
            this.lblYearPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYearPaymentHistory.AutoSize = true;
            this.lblYearPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearPaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblYearPaymentHistory.Location = new System.Drawing.Point(456, 10);
            this.lblYearPaymentHistory.Name = "lblYearPaymentHistory";
            this.lblYearPaymentHistory.Size = new System.Drawing.Size(51, 23);
            this.lblYearPaymentHistory.TabIndex = 0;
            this.lblYearPaymentHistory.Text = "Year :";
            // 
            // txtYearPaymentHistory
            // 
            this.txtYearPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtYearPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearPaymentHistory.ForeColor = System.Drawing.Color.Gray;
            this.txtYearPaymentHistory.Location = new System.Drawing.Point(529, 7);
            this.txtYearPaymentHistory.Name = "txtYearPaymentHistory";
            this.txtYearPaymentHistory.Size = new System.Drawing.Size(190, 30);
            this.txtYearPaymentHistory.TabIndex = 4;
            this.txtYearPaymentHistory.Text = "Enter Year";
            this.txtYearPaymentHistory.Click += new System.EventHandler(this.txtYearPaymentHistory_Click);
            // 
            // picMonthPaymentHistory
            // 
            this.picMonthPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picMonthPaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picMonthPaymentHistory.Image")));
            this.picMonthPaymentHistory.Location = new System.Drawing.Point(3, 3);
            this.picMonthPaymentHistory.Name = "picMonthPaymentHistory";
            this.picMonthPaymentHistory.Size = new System.Drawing.Size(31, 37);
            this.picMonthPaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonthPaymentHistory.TabIndex = 2;
            this.picMonthPaymentHistory.TabStop = false;
            // 
            // picYearPaymentHistory
            // 
            this.picYearPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picYearPaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picYearPaymentHistory.Image")));
            this.picYearPaymentHistory.Location = new System.Drawing.Point(420, 3);
            this.picYearPaymentHistory.Name = "picYearPaymentHistory";
            this.picYearPaymentHistory.Size = new System.Drawing.Size(30, 37);
            this.picYearPaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYearPaymentHistory.TabIndex = 2;
            this.picYearPaymentHistory.TabStop = false;
            // 
            // tlpDateRangePaymentHistory
            // 
            this.tlpDateRangePaymentHistory.ColumnCount = 3;
            this.tlpDateRangePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpDateRangePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpDateRangePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangePaymentHistory.Controls.Add(this.lblDateRangePaymentHistory, 1, 0);
            this.tlpDateRangePaymentHistory.Controls.Add(this.picDateRangePaymentHistory, 0, 0);
            this.tlpDateRangePaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateRangePaymentHistory.Location = new System.Drawing.Point(18, 136);
            this.tlpDateRangePaymentHistory.Name = "tlpDateRangePaymentHistory";
            this.tlpDateRangePaymentHistory.RowCount = 1;
            this.tlpDateRangePaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDateRangePaymentHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpDateRangePaymentHistory.TabIndex = 12;
            // 
            // lblDateRangePaymentHistory
            // 
            this.lblDateRangePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateRangePaymentHistory.AutoSize = true;
            this.lblDateRangePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRangePaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateRangePaymentHistory.Location = new System.Drawing.Point(40, 10);
            this.lblDateRangePaymentHistory.Name = "lblDateRangePaymentHistory";
            this.lblDateRangePaymentHistory.Size = new System.Drawing.Size(136, 23);
            this.lblDateRangePaymentHistory.TabIndex = 0;
            this.lblDateRangePaymentHistory.Text = "Date Range - - -";
            // 
            // picDateRangePaymentHistory
            // 
            this.picDateRangePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picDateRangePaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picDateRangePaymentHistory.Image")));
            this.picDateRangePaymentHistory.Location = new System.Drawing.Point(3, 3);
            this.picDateRangePaymentHistory.Name = "picDateRangePaymentHistory";
            this.picDateRangePaymentHistory.Size = new System.Drawing.Size(31, 37);
            this.picDateRangePaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDateRangePaymentHistory.TabIndex = 0;
            this.picDateRangePaymentHistory.TabStop = false;
            // 
            // tlpStartAndEndDatePaymentHistory
            // 
            this.tlpStartAndEndDatePaymentHistory.ColumnCount = 8;
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpStartAndEndDatePaymentHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.btnSearchPaymentHistory, 6, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.lblStartDatePaymentHistory, 1, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.dtpStartDatePaymentHistory, 2, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.lblEndDatePaymentHistory, 4, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.dtpEndDatePaymentHistory, 5, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.picStartDatePaymentHistory, 0, 0);
            this.tlpStartAndEndDatePaymentHistory.Controls.Add(this.picEndDatePaymentHistory, 3, 0);
            this.tlpStartAndEndDatePaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartAndEndDatePaymentHistory.Location = new System.Drawing.Point(18, 186);
            this.tlpStartAndEndDatePaymentHistory.Name = "tlpStartAndEndDatePaymentHistory";
            this.tlpStartAndEndDatePaymentHistory.RowCount = 1;
            this.tlpStartAndEndDatePaymentHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartAndEndDatePaymentHistory.Size = new System.Drawing.Size(1110, 44);
            this.tlpStartAndEndDatePaymentHistory.TabIndex = 13;
            // 
            // btnSearchPaymentHistory
            // 
            this.btnSearchPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchPaymentHistory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchPaymentHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchPaymentHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchPaymentHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.btnSearchPaymentHistory.Location = new System.Drawing.Point(1006, 2);
            this.btnSearchPaymentHistory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearchPaymentHistory.Name = "btnSearchPaymentHistory";
            this.btnSearchPaymentHistory.Size = new System.Drawing.Size(107, 40);
            this.btnSearchPaymentHistory.TabIndex = 5;
            this.btnSearchPaymentHistory.Text = "Search";
            this.btnSearchPaymentHistory.UseVisualStyleBackColor = false;
            this.btnSearchPaymentHistory.Click += new System.EventHandler(this.btnSearchPaymentHistory_Click);
            // 
            // lblStartDatePaymentHistory
            // 
            this.lblStartDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStartDatePaymentHistory.AutoSize = true;
            this.lblStartDatePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDatePaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStartDatePaymentHistory.Location = new System.Drawing.Point(40, 10);
            this.lblStartDatePaymentHistory.Name = "lblStartDatePaymentHistory";
            this.lblStartDatePaymentHistory.Size = new System.Drawing.Size(96, 23);
            this.lblStartDatePaymentHistory.TabIndex = 0;
            this.lblStartDatePaymentHistory.Text = "Start Date :";
            // 
            // dtpStartDatePaymentHistory
            // 
            this.dtpStartDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDatePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDatePaymentHistory.Location = new System.Drawing.Point(168, 7);
            this.dtpStartDatePaymentHistory.Name = "dtpStartDatePaymentHistory";
            this.dtpStartDatePaymentHistory.Size = new System.Drawing.Size(319, 30);
            this.dtpStartDatePaymentHistory.TabIndex = 1;
            // 
            // lblEndDatePaymentHistory
            // 
            this.lblEndDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndDatePaymentHistory.AutoSize = true;
            this.lblEndDatePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDatePaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEndDatePaymentHistory.Location = new System.Drawing.Point(543, 10);
            this.lblEndDatePaymentHistory.Name = "lblEndDatePaymentHistory";
            this.lblEndDatePaymentHistory.Size = new System.Drawing.Size(89, 23);
            this.lblEndDatePaymentHistory.TabIndex = 0;
            this.lblEndDatePaymentHistory.Text = "End Date :";
            // 
            // dtpEndDatePaymentHistory
            // 
            this.dtpEndDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDatePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDatePaymentHistory.Location = new System.Drawing.Point(664, 7);
            this.dtpEndDatePaymentHistory.Name = "dtpEndDatePaymentHistory";
            this.dtpEndDatePaymentHistory.Size = new System.Drawing.Size(325, 30);
            this.dtpEndDatePaymentHistory.TabIndex = 0;
            // 
            // picStartDatePaymentHistory
            // 
            this.picStartDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picStartDatePaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picStartDatePaymentHistory.Image")));
            this.picStartDatePaymentHistory.Location = new System.Drawing.Point(3, 4);
            this.picStartDatePaymentHistory.Name = "picStartDatePaymentHistory";
            this.picStartDatePaymentHistory.Size = new System.Drawing.Size(31, 36);
            this.picStartDatePaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStartDatePaymentHistory.TabIndex = 2;
            this.picStartDatePaymentHistory.TabStop = false;
            // 
            // picEndDatePaymentHistory
            // 
            this.picEndDatePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picEndDatePaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picEndDatePaymentHistory.Image")));
            this.picEndDatePaymentHistory.Location = new System.Drawing.Point(506, 4);
            this.picEndDatePaymentHistory.Name = "picEndDatePaymentHistory";
            this.picEndDatePaymentHistory.Size = new System.Drawing.Size(31, 36);
            this.picEndDatePaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEndDatePaymentHistory.TabIndex = 3;
            this.picEndDatePaymentHistory.TabStop = false;
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPaymentHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPaymentHistory.ColumnHeadersHeight = 50;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colPaymentId,
            this.colMembershipPlanName,
            this.colPaymentDate,
            this.colPaymentMethod,
            this.colAmount,
            this.colFeesType});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentHistory.EnableHeadersVisualStyles = false;
            this.dgvPaymentHistory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(18, 285);
            this.dgvPaymentHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentHistory.MultiSelect = false;
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPaymentHistory.RowHeadersVisible = false;
            this.dgvPaymentHistory.RowHeadersWidth = 50;
            this.dgvPaymentHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentHistory.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPaymentHistory.RowTemplate.Height = 50;
            this.dgvPaymentHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(1110, 474);
            this.dgvPaymentHistory.TabIndex = 17;
            this.dgvPaymentHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPaymentHistory_CellFormatting);
            this.dgvPaymentHistory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentHistory_CellMouseEnter);
            this.dgvPaymentHistory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentHistory_CellMouseLeave);
            // 
            // tlpTotalPaymentHistoryAndExport
            // 
            this.tlpTotalPaymentHistoryAndExport.ColumnCount = 5;
            this.tlpTotalPaymentHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpTotalPaymentHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpTotalPaymentHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpTotalPaymentHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalPaymentHistoryAndExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTotalPaymentHistoryAndExport.Controls.Add(this.btnExportPaymentHistory, 4, 0);
            this.tlpTotalPaymentHistoryAndExport.Controls.Add(this.lblTotalPaymentHistory, 1, 0);
            this.tlpTotalPaymentHistoryAndExport.Controls.Add(this.lblOutputTotalExpencePaymentHistory, 2, 0);
            this.tlpTotalPaymentHistoryAndExport.Controls.Add(this.picTotalPaymentHistory, 0, 0);
            this.tlpTotalPaymentHistoryAndExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotalPaymentHistoryAndExport.Location = new System.Drawing.Point(18, 236);
            this.tlpTotalPaymentHistoryAndExport.Name = "tlpTotalPaymentHistoryAndExport";
            this.tlpTotalPaymentHistoryAndExport.RowCount = 1;
            this.tlpTotalPaymentHistoryAndExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalPaymentHistoryAndExport.Size = new System.Drawing.Size(1110, 44);
            this.tlpTotalPaymentHistoryAndExport.TabIndex = 18;
            // 
            // btnExportPaymentHistory
            // 
            this.btnExportPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportPaymentHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExportPaymentHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportPaymentHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportPaymentHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExportPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.btnExportPaymentHistory.Location = new System.Drawing.Point(992, 2);
            this.btnExportPaymentHistory.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnExportPaymentHistory.Name = "btnExportPaymentHistory";
            this.btnExportPaymentHistory.Size = new System.Drawing.Size(118, 40);
            this.btnExportPaymentHistory.TabIndex = 5;
            this.btnExportPaymentHistory.Text = "Export";
            this.btnExportPaymentHistory.UseVisualStyleBackColor = false;
            this.btnExportPaymentHistory.Click += new System.EventHandler(this.btnExportPaymentHistory_Click);
            // 
            // lblTotalPaymentHistory
            // 
            this.lblTotalPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalPaymentHistory.AutoSize = true;
            this.lblTotalPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalPaymentHistory.Location = new System.Drawing.Point(40, 10);
            this.lblTotalPaymentHistory.Name = "lblTotalPaymentHistory";
            this.lblTotalPaymentHistory.Size = new System.Drawing.Size(135, 23);
            this.lblTotalPaymentHistory.TabIndex = 0;
            this.lblTotalPaymentHistory.Text = "Total Payments :";
            // 
            // lblOutputTotalExpencePaymentHistory
            // 
            this.lblOutputTotalExpencePaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutputTotalExpencePaymentHistory.AutoSize = true;
            this.lblOutputTotalExpencePaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotalExpencePaymentHistory.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputTotalExpencePaymentHistory.Location = new System.Drawing.Point(190, 10);
            this.lblOutputTotalExpencePaymentHistory.Name = "lblOutputTotalExpencePaymentHistory";
            this.lblOutputTotalExpencePaymentHistory.Size = new System.Drawing.Size(31, 23);
            this.lblOutputTotalExpencePaymentHistory.TabIndex = 2;
            this.lblOutputTotalExpencePaymentHistory.Text = "---";
            // 
            // picTotalPaymentHistory
            // 
            this.picTotalPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picTotalPaymentHistory.Image = ((System.Drawing.Image)(resources.GetObject("picTotalPaymentHistory.Image")));
            this.picTotalPaymentHistory.Location = new System.Drawing.Point(3, 4);
            this.picTotalPaymentHistory.Name = "picTotalPaymentHistory";
            this.picTotalPaymentHistory.Size = new System.Drawing.Size(31, 35);
            this.picTotalPaymentHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTotalPaymentHistory.TabIndex = 3;
            this.picTotalPaymentHistory.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(733, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle15;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPaymentId
            // 
            this.colPaymentId.HeaderText = "PaymentId";
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.ReadOnly = true;
            this.colPaymentId.Visible = false;
            // 
            // colMembershipPlanName
            // 
            this.colMembershipPlanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMembershipPlanName.DataPropertyName = "MembershipPlanName";
            this.colMembershipPlanName.FillWeight = 180F;
            this.colMembershipPlanName.HeaderText = "Membership Plan Name";
            this.colMembershipPlanName.Name = "colMembershipPlanName";
            this.colMembershipPlanName.ReadOnly = true;
            this.colMembershipPlanName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMembershipPlanName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "Payment Date";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            this.colPaymentDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPaymentDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaymentMethod.DataPropertyName = "PaymentMethod";
            this.colPaymentMethod.FillWeight = 130F;
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPaymentMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFeesType
            // 
            this.colFeesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFeesType.DataPropertyName = "FeesType";
            this.colFeesType.HeaderText = "Fees Type";
            this.colFeesType.Name = "colFeesType";
            this.colFeesType.ReadOnly = true;
            this.colFeesType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFeesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmSAPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpPaymentHistory);
            this.Name = "FrmSAPayment";
            this.Text = "FrmSAPayment";
            this.Load += new System.EventHandler(this.FrmSAPayment_Load);
            this.Shown += new System.EventHandler(this.FrmSAPayment_Shown);
            this.tlpPaymentHistory.ResumeLayout(false);
            this.tlpPaymentHistoryHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPaymentHistory)).EndInit();
            this.tlpPaymentHistoryTitle.ResumeLayout(false);
            this.tlpPaymentHistoryTitle.PerformLayout();
            this.tlpMonthYearSearchPaymentHistory.ResumeLayout(false);
            this.tlpMonthYearSearchPaymentHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYearPaymentHistory)).EndInit();
            this.tlpDateRangePaymentHistory.ResumeLayout(false);
            this.tlpDateRangePaymentHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDateRangePaymentHistory)).EndInit();
            this.tlpStartAndEndDatePaymentHistory.ResumeLayout(false);
            this.tlpStartAndEndDatePaymentHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartDatePaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndDatePaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.tlpTotalPaymentHistoryAndExport.ResumeLayout(false);
            this.tlpTotalPaymentHistoryAndExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotalPaymentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentHistoryHeader;
        private System.Windows.Forms.PictureBox picPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentHistoryTitle;
        private System.Windows.Forms.Label lblViewPaymentHistoryDetails;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpMonthYearSearchPaymentHistory;
        private System.Windows.Forms.Label lblMonthPaymentHistory;
        private System.Windows.Forms.ComboBox cmbMonthPaymentHistory;
        private System.Windows.Forms.Label lblYearPaymentHistory;
        private System.Windows.Forms.TextBox txtYearPaymentHistory;
        private System.Windows.Forms.PictureBox picMonthPaymentHistory;
        private System.Windows.Forms.PictureBox picYearPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpDateRangePaymentHistory;
        private System.Windows.Forms.Label lblDateRangePaymentHistory;
        private System.Windows.Forms.PictureBox picDateRangePaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpStartAndEndDatePaymentHistory;
        private System.Windows.Forms.Button btnSearchPaymentHistory;
        private System.Windows.Forms.Label lblStartDatePaymentHistory;
        private System.Windows.Forms.DateTimePicker dtpStartDatePaymentHistory;
        private System.Windows.Forms.Label lblEndDatePaymentHistory;
        private System.Windows.Forms.DateTimePicker dtpEndDatePaymentHistory;
        private System.Windows.Forms.PictureBox picStartDatePaymentHistory;
        private System.Windows.Forms.PictureBox picEndDatePaymentHistory;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel tlpTotalPaymentHistoryAndExport;
        private System.Windows.Forms.Button btnExportPaymentHistory;
        private System.Windows.Forms.Label lblTotalPaymentHistory;
        private System.Windows.Forms.Label lblOutputTotalExpencePaymentHistory;
        private System.Windows.Forms.PictureBox picTotalPaymentHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembershipPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeesType;

    }
}