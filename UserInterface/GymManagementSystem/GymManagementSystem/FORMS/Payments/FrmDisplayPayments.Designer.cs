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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayPayments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPaymentsEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPaymentsHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPayment = new System.Windows.Forms.PictureBox();
            this.tlpPaymentsTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewPayments = new System.Windows.Forms.Label();
            this.lblPaymentManagement = new System.Windows.Forms.Label();
            this.dgvPaymentsManagement = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembershipPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSearchArea = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEnterPlanName = new System.Windows.Forms.TextBox();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.tlpPaymentsEntireForm.SuspendLayout();
            this.tlpPaymentsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).BeginInit();
            this.tlpPaymentsTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).BeginInit();
            this.tblSearchArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPaymentsEntireForm
            // 
            this.tlpPaymentsEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpPaymentsEntireForm.ColumnCount = 3;
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPaymentsEntireForm.Controls.Add(this.tlpPaymentsHeader, 1, 1);
            this.tlpPaymentsEntireForm.Controls.Add(this.dgvPaymentsManagement, 1, 3);
            this.tlpPaymentsEntireForm.Controls.Add(this.tblSearchArea, 1, 2);
            this.tlpPaymentsEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentsEntireForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPaymentsEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentsEntireForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPaymentsEntireForm.Name = "tlpPaymentsEntireForm";
            this.tlpPaymentsEntireForm.RowCount = 5;
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.170767F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.72214F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.57835F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.220873F));
            this.tlpPaymentsEntireForm.Size = new System.Drawing.Size(1151, 750);
            this.tlpPaymentsEntireForm.TabIndex = 2;
            // 
            // tlpPaymentsHeader
            // 
            this.tlpPaymentsHeader.ColumnCount = 3;
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPaymentsHeader.Controls.Add(this.picPayment, 0, 0);
            this.tlpPaymentsHeader.Controls.Add(this.tlpPaymentsTitle, 1, 0);
            this.tlpPaymentsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentsHeader.Location = new System.Drawing.Point(60, 16);
            this.tlpPaymentsHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPaymentsHeader.Name = "tlpPaymentsHeader";
            this.tlpPaymentsHeader.RowCount = 1;
            this.tlpPaymentsHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentsHeader.Size = new System.Drawing.Size(1029, 75);
            this.tlpPaymentsHeader.TabIndex = 8;
            // 
            // picPayment
            // 
            this.picPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPayment.Image = ((System.Drawing.Image)(resources.GetObject("picPayment.Image")));
            this.picPayment.Location = new System.Drawing.Point(3, 2);
            this.picPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPayment.Name = "picPayment";
            this.picPayment.Size = new System.Drawing.Size(63, 71);
            this.picPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPayment.TabIndex = 0;
            this.picPayment.TabStop = false;
            // 
            // tlpPaymentsTitle
            // 
            this.tlpPaymentsTitle.ColumnCount = 1;
            this.tlpPaymentsTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentsTitle.Controls.Add(this.lblViewPayments, 0, 1);
            this.tlpPaymentsTitle.Controls.Add(this.lblPaymentManagement, 0, 0);
            this.tlpPaymentsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentsTitle.Location = new System.Drawing.Point(72, 2);
            this.tlpPaymentsTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPaymentsTitle.Name = "tlpPaymentsTitle";
            this.tlpPaymentsTitle.RowCount = 2;
            this.tlpPaymentsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.53425F));
            this.tlpPaymentsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.46575F));
            this.tlpPaymentsTitle.Size = new System.Drawing.Size(294, 71);
            this.tlpPaymentsTitle.TabIndex = 1;
            // 
            // lblViewPayments
            // 
            this.lblViewPayments.AutoSize = true;
            this.lblViewPayments.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPayments.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewPayments.Location = new System.Drawing.Point(3, 40);
            this.lblViewPayments.Name = "lblViewPayments";
            this.lblViewPayments.Size = new System.Drawing.Size(166, 19);
            this.lblViewPayments.TabIndex = 3;
            this.lblViewPayments.Text = "View All Payments Details";
            // 
            // lblPaymentManagement
            // 
            this.lblPaymentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentManagement.AutoSize = true;
            this.lblPaymentManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentManagement.Location = new System.Drawing.Point(3, 12);
            this.lblPaymentManagement.Name = "lblPaymentManagement";
            this.lblPaymentManagement.Size = new System.Drawing.Size(227, 28);
            this.lblPaymentManagement.TabIndex = 2;
            this.lblPaymentManagement.Text = "Payments Management";
            // 
            // dgvPaymentsManagement
            // 
            this.dgvPaymentsManagement.AllowUserToAddRows = false;
            this.dgvPaymentsManagement.AllowUserToDeleteRows = false;
            this.dgvPaymentsManagement.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPaymentsManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentsManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPaymentsManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentsManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPaymentsManagement.ColumnHeadersHeight = 50;
            this.dgvPaymentsManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMembershipPlanName,
            this.colPaymentDate,
            this.colPaymentMethod,
            this.colAmount,
            this.colFeesType});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsManagement.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPaymentsManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentsManagement.EnableHeadersVisualStyles = false;
            this.dgvPaymentsManagement.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPaymentsManagement.Location = new System.Drawing.Point(60, 170);
            this.dgvPaymentsManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentsManagement.MultiSelect = false;
            this.dgvPaymentsManagement.Name = "dgvPaymentsManagement";
            this.dgvPaymentsManagement.ReadOnly = true;
            this.dgvPaymentsManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPaymentsManagement.RowHeadersVisible = false;
            this.dgvPaymentsManagement.RowHeadersWidth = 50;
            this.dgvPaymentsManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPaymentsManagement.RowTemplate.Height = 50;
            this.dgvPaymentsManagement.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentsManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentsManagement.Size = new System.Drawing.Size(1029, 541);
            this.dgvPaymentsManagement.TabIndex = 9;
            this.dgvPaymentsManagement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPaymentsManagement_CellFormatting);
            this.dgvPaymentsManagement.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseEnter);
            this.dgvPaymentsManagement.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseLeave);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.colSerialNo.FillWeight = 90F;
            this.colSerialNo.HeaderText = "Sl No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSerialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // tblSearchArea
            // 
            this.tblSearchArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tblSearchArea.ColumnCount = 3;
            this.tblSearchArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblSearchArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tblSearchArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tblSearchArea.Controls.Add(this.picSearchIcon, 0, 0);
            this.tblSearchArea.Controls.Add(this.txtEnterPlanName, 1, 0);
            this.tblSearchArea.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearchArea.Location = new System.Drawing.Point(60, 123);
            this.tblSearchArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblSearchArea.Name = "tblSearchArea";
            this.tblSearchArea.RowCount = 1;
            this.tblSearchArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchArea.Size = new System.Drawing.Size(518, 43);
            this.tblSearchArea.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(362, 1);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtEnterPlanName
            // 
            this.txtEnterPlanName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEnterPlanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterPlanName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterPlanName.ForeColor = System.Drawing.Color.Gray;
            this.txtEnterPlanName.Location = new System.Drawing.Point(44, 6);
            this.txtEnterPlanName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEnterPlanName.Name = "txtEnterPlanName";
            this.txtEnterPlanName.Size = new System.Drawing.Size(316, 30);
            this.txtEnterPlanName.TabIndex = 3;
            this.txtEnterPlanName.Text = " Enter mobile no. ";
            this.txtEnterPlanName.Click += new System.EventHandler(this.txtEnterPlanName_Click);
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(3, 2);
            this.picSearchIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(38, 39);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchIcon.TabIndex = 2;
            this.picSearchIcon.TabStop = false;
            // 
            // FrmDisplayPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 750);
            this.Controls.Add(this.tlpPaymentsEntireForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDisplayPayments";
            this.Text = "FrmDisplayPayments";
            this.Load += new System.EventHandler(this.FrmDisplayPayments_Load);
            this.tlpPaymentsEntireForm.ResumeLayout(false);
            this.tlpPaymentsHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).EndInit();
            this.tlpPaymentsTitle.ResumeLayout(false);
            this.tlpPaymentsTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).EndInit();
            this.tblSearchArea.ResumeLayout(false);
            this.tblSearchArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPaymentsEntireForm;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentsHeader;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentsTitle;
        private System.Windows.Forms.Label lblViewPayments;
        private System.Windows.Forms.Label lblPaymentManagement;
        private System.Windows.Forms.DataGridView dgvPaymentsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembershipPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeesType;
        private System.Windows.Forms.TableLayoutPanel tblSearchArea;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.TextBox txtEnterPlanName;


    }
}