namespace GymManagementSystem.FORMS.Payments
{
    partial class FrmDisplayPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaymentTitle = new System.Windows.Forms.Panel();
            this.lblPaymentManagement = new System.Windows.Forms.Label();
            this.tlpSearchPaymentsSub = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchPaymentsMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.dgvPaymentsManagement = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchPayments = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPaymentTitle.SuspendLayout();
            this.tlpSearchPaymentsSub.SuspendLayout();
            this.tlpSearchPaymentsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPaymentTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpSearchPaymentsSub, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPaymentsManagement, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(946, 599);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // pnlPaymentTitle
            // 
            this.pnlPaymentTitle.Controls.Add(this.lblPaymentManagement);
            this.pnlPaymentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentTitle.Location = new System.Drawing.Point(50, 3);
            this.pnlPaymentTitle.Name = "pnlPaymentTitle";
            this.pnlPaymentTitle.Size = new System.Drawing.Size(845, 65);
            this.pnlPaymentTitle.TabIndex = 4;
            this.pnlPaymentTitle.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // lblPaymentManagement
            // 
            this.lblPaymentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentManagement.AutoSize = true;
            this.lblPaymentManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentManagement.Location = new System.Drawing.Point(3, 18);
            this.lblPaymentManagement.Name = "lblPaymentManagement";
            this.lblPaymentManagement.Size = new System.Drawing.Size(317, 38);
            this.lblPaymentManagement.TabIndex = 0;
            this.lblPaymentManagement.Text = "Payments Management";
            this.lblPaymentManagement.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // tlpSearchPaymentsSub
            // 
            this.tlpSearchPaymentsSub.ColumnCount = 2;
            this.tlpSearchPaymentsSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.78107F));
            this.tlpSearchPaymentsSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.21893F));
            this.tlpSearchPaymentsSub.Controls.Add(this.tlpSearchPaymentsMain, 0, 0);
            this.tlpSearchPaymentsSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchPaymentsSub.Location = new System.Drawing.Point(50, 74);
            this.tlpSearchPaymentsSub.Name = "tlpSearchPaymentsSub";
            this.tlpSearchPaymentsSub.RowCount = 1;
            this.tlpSearchPaymentsSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchPaymentsSub.Size = new System.Drawing.Size(845, 65);
            this.tlpSearchPaymentsSub.TabIndex = 5;
            this.tlpSearchPaymentsSub.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // tlpSearchPaymentsMain
            // 
            this.tlpSearchPaymentsMain.ColumnCount = 2;
            this.tlpSearchPaymentsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tlpSearchPaymentsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpSearchPaymentsMain.Controls.Add(this.btnSearchPayments, 0, 0);
            this.tlpSearchPaymentsMain.Controls.Add(this.txtMobileNo, 0, 0);
            this.tlpSearchPaymentsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchPaymentsMain.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchPaymentsMain.Name = "tlpSearchPaymentsMain";
            this.tlpSearchPaymentsMain.RowCount = 1;
            this.tlpSearchPaymentsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchPaymentsMain.Size = new System.Drawing.Size(440, 59);
            this.tlpSearchPaymentsMain.TabIndex = 2;
            this.tlpSearchPaymentsMain.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(3, 12);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(336, 34);
            this.txtMobileNo.TabIndex = 1;
            this.txtMobileNo.Click += new System.EventHandler(this.pnlPaymentTitle_Click);
            // 
            // dgvPaymentsManagement
            // 
            this.dgvPaymentsManagement.AllowUserToAddRows = false;
            this.dgvPaymentsManagement.AllowUserToDeleteRows = false;
            this.dgvPaymentsManagement.AllowUserToResizeColumns = false;
            this.dgvPaymentsManagement.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPaymentsManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentsManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentsManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentsManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPaymentsManagement.ColumnHeadersHeight = 50;
            this.dgvPaymentsManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.MembershipPlanName,
            this.PaymentDate,
            this.PaymentMethod,
            this.Amount,
            this.FeesType});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsManagement.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPaymentsManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentsManagement.EnableHeadersVisualStyles = false;
            this.dgvPaymentsManagement.GridColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.Location = new System.Drawing.Point(50, 144);
            this.dgvPaymentsManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentsManagement.MultiSelect = false;
            this.dgvPaymentsManagement.Name = "dgvPaymentsManagement";
            this.dgvPaymentsManagement.ReadOnly = true;
            this.dgvPaymentsManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPaymentsManagement.RowHeadersVisible = false;
            this.dgvPaymentsManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPaymentsManagement.RowTemplate.Height = 24;
            this.dgvPaymentsManagement.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentsManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentsManagement.Size = new System.Drawing.Size(845, 391);
            this.dgvPaymentsManagement.TabIndex = 6;
            this.dgvPaymentsManagement.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseEnter);
            this.dgvPaymentsManagement.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseLeave);
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNo.HeaderText = "Sl No.";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MembershipPlanName
            // 
            this.MembershipPlanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MembershipPlanName.HeaderText = "Membership Plan Name";
            this.MembershipPlanName.Name = "MembershipPlanName";
            this.MembershipPlanName.ReadOnly = true;
            this.MembershipPlanName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PaymentDate
            // 
            this.PaymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentDate.HeaderText = "PaymentDate";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FeesType
            // 
            this.FeesType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeesType.HeaderText = "FeesType";
            this.FeesType.Name = "FeesType";
            this.FeesType.ReadOnly = true;
            this.FeesType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSearchPayments
            // 
            this.btnSearchPayments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchPayments.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchPayments.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearchPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSearchPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPayments.Location = new System.Drawing.Point(345, 11);
            this.btnSearchPayments.Name = "btnSearchPayments";
            this.btnSearchPayments.Size = new System.Drawing.Size(92, 36);
            this.btnSearchPayments.TabIndex = 2;
            this.btnSearchPayments.Text = "Search";
            this.btnSearchPayments.UseVisualStyleBackColor = false;
            // 
            // FrmDisplayPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(946, 599);
            this.Name = "FrmDisplayPayments";
            this.Text = "FrmDisplayPayments";
            this.Load += new System.EventHandler(this.FrmDisplayPayments_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPaymentTitle.ResumeLayout(false);
            this.pnlPaymentTitle.PerformLayout();
            this.tlpSearchPaymentsSub.ResumeLayout(false);
            this.tlpSearchPaymentsMain.ResumeLayout(false);
            this.tlpSearchPaymentsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPaymentTitle;
        private System.Windows.Forms.Label lblPaymentManagement;
        private System.Windows.Forms.TableLayoutPanel tlpSearchPaymentsSub;
        private System.Windows.Forms.TableLayoutPanel tlpSearchPaymentsMain;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.DataGridView dgvPaymentsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeesType;
        private System.Windows.Forms.Button btnSearchPayments;

    }
}