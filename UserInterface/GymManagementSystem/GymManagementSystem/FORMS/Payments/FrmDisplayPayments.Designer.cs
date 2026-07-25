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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPaymentsEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPaymentsHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPayment = new System.Windows.Forms.PictureBox();
            this.tlpPaymentsTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewPayments = new System.Windows.Forms.Label();
            this.lblPaymentManagement = new System.Windows.Forms.Label();
            this.tlpMembersPaymentsSearch = new System.Windows.Forms.TableLayoutPanel();
            this.picSearchIconPayment = new System.Windows.Forms.PictureBox();
            this.txtSearchPayment = new System.Windows.Forms.TextBox();
            this.dgvPaymentsManagement = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMembershipPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPaymentsEntireForm.SuspendLayout();
            this.tlpPaymentsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).BeginInit();
            this.tlpPaymentsTitle.SuspendLayout();
            this.tlpMembersPaymentsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIconPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPaymentsEntireForm
            // 
            this.tlpPaymentsEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpPaymentsEntireForm.ColumnCount = 3;
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.989362F));
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.01064F));
            this.tlpPaymentsEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpPaymentsEntireForm.Controls.Add(this.tlpPaymentsHeader, 1, 1);
            this.tlpPaymentsEntireForm.Controls.Add(this.dgvPaymentsManagement, 1, 3);
            this.tlpPaymentsEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentsEntireForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPaymentsEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentsEntireForm.Name = "tlpPaymentsEntireForm";
            this.tlpPaymentsEntireForm.RowCount = 5;
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.66447F));
            this.tlpPaymentsEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33553F));
            this.tlpPaymentsEntireForm.Size = new System.Drawing.Size(1149, 788);
            this.tlpPaymentsEntireForm.TabIndex = 2;
            // 
            // tlpPaymentsHeader
            // 
            this.tlpPaymentsHeader.ColumnCount = 5;
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tlpPaymentsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlpPaymentsHeader.Controls.Add(this.picPayment, 0, 0);
            this.tlpPaymentsHeader.Controls.Add(this.tlpPaymentsTitle, 1, 0);
            this.tlpPaymentsHeader.Controls.Add(this.tlpMembersPaymentsSearch, 3, 0);
            this.tlpPaymentsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentsHeader.Location = new System.Drawing.Point(46, 52);
            this.tlpPaymentsHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPaymentsHeader.Name = "tlpPaymentsHeader";
            this.tlpPaymentsHeader.RowCount = 1;
            this.tlpPaymentsHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentsHeader.Size = new System.Drawing.Size(1050, 96);
            this.tlpPaymentsHeader.TabIndex = 8;
            // 
            // picPayment
            // 
            this.picPayment.Image = ((System.Drawing.Image)(resources.GetObject("picPayment.Image")));
            this.picPayment.Location = new System.Drawing.Point(3, 3);
            this.picPayment.Name = "picPayment";
            this.picPayment.Size = new System.Drawing.Size(70, 90);
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
            this.tlpPaymentsTitle.Location = new System.Drawing.Point(79, 3);
            this.tlpPaymentsTitle.Name = "tlpPaymentsTitle";
            this.tlpPaymentsTitle.RowCount = 3;
            this.tlpPaymentsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tlpPaymentsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.44444F));
            this.tlpPaymentsTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tlpPaymentsTitle.Size = new System.Drawing.Size(300, 90);
            this.tlpPaymentsTitle.TabIndex = 1;
            // 
            // lblViewPayments
            // 
            this.lblViewPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViewPayments.AutoSize = true;
            this.lblViewPayments.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPayments.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblViewPayments.Location = new System.Drawing.Point(3, 45);
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
            this.lblPaymentManagement.Location = new System.Drawing.Point(3, 15);
            this.lblPaymentManagement.Name = "lblPaymentManagement";
            this.lblPaymentManagement.Size = new System.Drawing.Size(227, 28);
            this.lblPaymentManagement.TabIndex = 2;
            this.lblPaymentManagement.Text = "Payments Management";
            // 
            // tlpMembersPaymentsSearch
            // 
            this.tlpMembersPaymentsSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpMembersPaymentsSearch.ColumnCount = 2;
            this.tlpMembersPaymentsSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.22449F));
            this.tlpMembersPaymentsSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.77551F));
            this.tlpMembersPaymentsSearch.Controls.Add(this.picSearchIconPayment, 1, 0);
            this.tlpMembersPaymentsSearch.Controls.Add(this.txtSearchPayment, 0, 0);
            this.tlpMembersPaymentsSearch.Location = new System.Drawing.Point(518, 23);
            this.tlpMembersPaymentsSearch.Name = "tlpMembersPaymentsSearch";
            this.tlpMembersPaymentsSearch.RowCount = 1;
            this.tlpMembersPaymentsSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMembersPaymentsSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMembersPaymentsSearch.Size = new System.Drawing.Size(392, 49);
            this.tlpMembersPaymentsSearch.TabIndex = 2;
            // 
            // picSearchIconPayment
            // 
            this.picSearchIconPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picSearchIconPayment.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIconPayment.Image")));
            this.picSearchIconPayment.Location = new System.Drawing.Point(349, 3);
            this.picSearchIconPayment.Name = "picSearchIconPayment";
            this.picSearchIconPayment.Size = new System.Drawing.Size(40, 42);
            this.picSearchIconPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchIconPayment.TabIndex = 1;
            this.picSearchIconPayment.TabStop = false;
            // 
            // txtSearchPayment
            // 
            this.txtSearchPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchPayment.BackColor = System.Drawing.Color.White;
            this.txtSearchPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPayment.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchPayment.Location = new System.Drawing.Point(3, 9);
            this.txtSearchPayment.Name = "txtSearchPayment";
            this.txtSearchPayment.Size = new System.Drawing.Size(331, 30);
            this.txtSearchPayment.TabIndex = 0;
            this.txtSearchPayment.Text = "Enter Mobile no .";
            // 
            // dgvPaymentsManagement
            // 
            this.dgvPaymentsManagement.AllowUserToAddRows = false;
            this.dgvPaymentsManagement.AllowUserToDeleteRows = false;
            this.dgvPaymentsManagement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentsManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentsManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPaymentsManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentsManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentsManagement.ColumnHeadersHeight = 50;
            this.dgvPaymentsManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colMembershipPlanName,
            this.colPaymentDate,
            this.colPaymentMethod,
            this.colAmount,
            this.colFeesType});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsManagement.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentsManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentsManagement.EnableHeadersVisualStyles = false;
            this.dgvPaymentsManagement.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPaymentsManagement.Location = new System.Drawing.Point(46, 182);
            this.dgvPaymentsManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPaymentsManagement.MultiSelect = false;
            this.dgvPaymentsManagement.Name = "dgvPaymentsManagement";
            this.dgvPaymentsManagement.ReadOnly = true;
            this.dgvPaymentsManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaymentsManagement.RowHeadersVisible = false;
            this.dgvPaymentsManagement.RowHeadersWidth = 50;
            this.dgvPaymentsManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvPaymentsManagement.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaymentsManagement.RowTemplate.Height = 50;
            this.dgvPaymentsManagement.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentsManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaymentsManagement.Size = new System.Drawing.Size(1050, 528);
            this.dgvPaymentsManagement.TabIndex = 9;
            this.dgvPaymentsManagement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPaymentsManagement_CellFormatting);
            this.dgvPaymentsManagement.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseEnter);
            this.dgvPaymentsManagement.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentsManagement_CellMouseLeave);
            // 
            // colSerialNo
            // 
            this.colSerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNo.DataPropertyName = "SerialNo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.colSerialNo.DefaultCellStyle = dataGridViewCellStyle3;
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
            // FrmDisplayPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpPaymentsEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1167, 835);
            this.Name = "FrmDisplayPayments";
            this.Text = "FrmDisplayPayments";
            this.Load += new System.EventHandler(this.FrmDisplayPayments_Load);
            this.tlpPaymentsEntireForm.ResumeLayout(false);
            this.tlpPaymentsHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).EndInit();
            this.tlpPaymentsTitle.ResumeLayout(false);
            this.tlpPaymentsTitle.PerformLayout();
            this.tlpMembersPaymentsSearch.ResumeLayout(false);
            this.tlpMembersPaymentsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIconPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPaymentsEntireForm;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentsHeader;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentsTitle;
        private System.Windows.Forms.Label lblViewPayments;
        private System.Windows.Forms.Label lblPaymentManagement;
        private System.Windows.Forms.TableLayoutPanel tlpMembersPaymentsSearch;
        private System.Windows.Forms.PictureBox picSearchIconPayment;
        private System.Windows.Forms.TextBox txtSearchPayment;
        private System.Windows.Forms.DataGridView dgvPaymentsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMembershipPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeesType;


    }
}