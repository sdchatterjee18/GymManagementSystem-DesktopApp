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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.tlpAddNewLocker = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.picBoxAddSymbol = new System.Windows.Forms.PictureBox();
            this.tlpSpaceing = new System.Windows.Forms.TableLayoutPanel();
            this.lblLockerManagement = new System.Windows.Forms.Label();
            this.tlpDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayLocker = new System.Windows.Forms.DataGridView();
            this.pnlSpaceing = new System.Windows.Forms.Panel();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllocatedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDeactivate = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.tlpAddNewLocker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).BeginInit();
            this.tlpSpaceing.SuspendLayout();
            this.tlpDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLocker)).BeginInit();
            this.pnlSpaceing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.Controls.Add(this.tlpHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(1094, 79);
            this.pnlHeading.TabIndex = 0;
            // 
            // tlpHeading
            // 
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.24113F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75887F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpHeading.Controls.Add(this.pnlButton, 2, 0);
            this.tlpHeading.Controls.Add(this.tlpSpaceing, 0, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(1094, 79);
            this.tlpHeading.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlButton.Controls.Add(this.tlpAddNewLocker);
            this.pnlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(713, 14);
            this.pnlButton.MinimumSize = new System.Drawing.Size(180, 50);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
            this.pnlButton.Size = new System.Drawing.Size(297, 50);
            this.pnlButton.TabIndex = 1;
            this.pnlButton.Click += new System.EventHandler(this.pnlButton_Click);
            this.pnlButton.MouseEnter += new System.EventHandler(this.pnlButton_MouseEnter);
            this.pnlButton.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            // 
            // tlpAddNewLocker
            // 
            this.tlpAddNewLocker.ColumnCount = 2;
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewLocker.Controls.Add(this.lblAddNewLocker, 1, 0);
            this.tlpAddNewLocker.Controls.Add(this.picBoxAddSymbol, 0, 0);
            this.tlpAddNewLocker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpAddNewLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewLocker.Location = new System.Drawing.Point(24, 8);
            this.tlpAddNewLocker.Name = "tlpAddNewLocker";
            this.tlpAddNewLocker.RowCount = 1;
            this.tlpAddNewLocker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewLocker.Size = new System.Drawing.Size(249, 34);
            this.tlpAddNewLocker.TabIndex = 0;
            this.tlpAddNewLocker.Click += new System.EventHandler(this.pnlButton_Click);
            this.tlpAddNewLocker.MouseEnter += new System.EventHandler(this.pnlButton_MouseEnter);
            this.tlpAddNewLocker.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            // 
            // lblAddNewLocker
            // 
            this.lblAddNewLocker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewLocker.AutoSize = true;
            this.lblAddNewLocker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewLocker.Location = new System.Drawing.Point(44, 0);
            this.lblAddNewLocker.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(163, 34);
            this.lblAddNewLocker.TabIndex = 1;
            this.lblAddNewLocker.Text = "Add New Locker";
            this.lblAddNewLocker.Click += new System.EventHandler(this.pnlButton_Click);
            this.lblAddNewLocker.MouseEnter += new System.EventHandler(this.pnlButton_MouseEnter);
            this.lblAddNewLocker.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            // 
            // picBoxAddSymbol
            // 
            this.picBoxAddSymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxAddSymbol.BackgroundImage")));
            this.picBoxAddSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxAddSymbol.Location = new System.Drawing.Point(3, 3);
            this.picBoxAddSymbol.Name = "picBoxAddSymbol";
            this.picBoxAddSymbol.Size = new System.Drawing.Size(28, 28);
            this.picBoxAddSymbol.TabIndex = 2;
            this.picBoxAddSymbol.TabStop = false;
            // 
            // tlpSpaceing
            // 
            this.tlpSpaceing.ColumnCount = 2;
            this.tlpSpaceing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.50328F));
            this.tlpSpaceing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.49672F));
            this.tlpSpaceing.Controls.Add(this.lblLockerManagement, 1, 0);
            this.tlpSpaceing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpaceing.Location = new System.Drawing.Point(3, 3);
            this.tlpSpaceing.Name = "tlpSpaceing";
            this.tlpSpaceing.RowCount = 1;
            this.tlpSpaceing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpaceing.Size = new System.Drawing.Size(450, 73);
            this.tlpSpaceing.TabIndex = 2;
            // 
            // lblLockerManagement
            // 
            this.lblLockerManagement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLockerManagement.AutoSize = true;
            this.lblLockerManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerManagement.Location = new System.Drawing.Point(50, 9);
            this.lblLockerManagement.Name = "lblLockerManagement";
            this.lblLockerManagement.Size = new System.Drawing.Size(393, 54);
            this.lblLockerManagement.TabIndex = 1;
            this.lblLockerManagement.Text = "Locker Management";
            // 
            // tlpDataGridView
            // 
            this.tlpDataGridView.ColumnCount = 3;
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.668692F));
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.98943F));
            this.tlpDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.341884F));
            this.tlpDataGridView.Controls.Add(this.dgvDisplayLocker, 1, 0);
            this.tlpDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tlpDataGridView.Name = "tlpDataGridView";
            this.tlpDataGridView.RowCount = 1;
            this.tlpDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataGridView.Size = new System.Drawing.Size(1094, 434);
            this.tlpDataGridView.TabIndex = 0;
            // 
            // dgvDisplayLocker
            // 
            this.dgvDisplayLocker.AllowUserToAddRows = false;
            this.dgvDisplayLocker.AllowUserToResizeRows = false;
            this.dgvDisplayLocker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDisplayLocker.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayLocker.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDisplayLocker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayLocker.ColumnHeadersHeight = 40;
            this.dgvDisplayLocker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colLNo,
            this.colAllocatedTo,
            this.colLStatus,
            this.colUpdate,
            this.colDeactivate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayLocker.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayLocker.EnableHeadersVisualStyles = false;
            this.dgvDisplayLocker.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDisplayLocker.Location = new System.Drawing.Point(54, 3);
            this.dgvDisplayLocker.Name = "dgvDisplayLocker";
            this.dgvDisplayLocker.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDisplayLocker.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplayLocker.RowTemplate.Height = 50;
            this.dgvDisplayLocker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplayLocker.Size = new System.Drawing.Size(989, 428);
            this.dgvDisplayLocker.TabIndex = 0;
            // 
            // pnlSpaceing
            // 
            this.pnlSpaceing.Controls.Add(this.tlpDataGridView);
            this.pnlSpaceing.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpaceing.Location = new System.Drawing.Point(0, 79);
            this.pnlSpaceing.Name = "pnlSpaceing";
            this.pnlSpaceing.Size = new System.Drawing.Size(1094, 468);
            this.pnlSpaceing.TabIndex = 1;
            // 
            // colSlNo
            // 
            this.colSlNo.FillWeight = 18F;
            this.colSlNo.HeaderText = "SL No.";
            this.colSlNo.MaxInputLength = 32;
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.Width = 157;
            // 
            // colLNo
            // 
            this.colLNo.DataPropertyName = "LNo";
            this.colLNo.FillWeight = 20F;
            this.colLNo.HeaderText = "Locker No";
            this.colLNo.Name = "colLNo";
            this.colLNo.Width = 175;
            // 
            // colAllocatedTo
            // 
            this.colAllocatedTo.DataPropertyName = "MemberName";
            this.colAllocatedTo.FillWeight = 20F;
            this.colAllocatedTo.HeaderText = "Allocated To";
            this.colAllocatedTo.Name = "colAllocatedTo";
            this.colAllocatedTo.Width = 175;
            // 
            // colLStatus
            // 
            this.colLStatus.DataPropertyName = "LStatus";
            this.colLStatus.FillWeight = 25F;
            this.colLStatus.HeaderText = "Locker Status";
            this.colLStatus.Name = "colLStatus";
            this.colLStatus.Width = 219;
            // 
            // colUpdate
            // 
            this.colUpdate.FillWeight = 15F;
            this.colUpdate.HeaderText = "Update";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Width = 132;
            // 
            // colDeactivate
            // 
            this.colDeactivate.FillWeight = 15F;
            this.colDeactivate.HeaderText = "Deactivate";
            this.colDeactivate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDeactivate.Name = "colDeactivate";
            this.colDeactivate.Width = 131;
            // 
            // FrmDisplayLocker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1094, 543);
            this.Controls.Add(this.pnlSpaceing);
            this.Controls.Add(this.pnlHeading);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDisplayLocker";
            this.Text = "FrmDisplayLocker";
            this.Load += new System.EventHandler(this.FrmDisplayLocker_Load);
            this.pnlHeading.ResumeLayout(false);
            this.tlpHeading.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.tlpAddNewLocker.ResumeLayout(false);
            this.tlpAddNewLocker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).EndInit();
            this.tlpSpaceing.ResumeLayout(false);
            this.tlpSpaceing.PerformLayout();
            this.tlpDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLocker)).EndInit();
            this.pnlSpaceing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.TableLayoutPanel tlpSpaceing;
        private System.Windows.Forms.Label lblLockerManagement;
        private System.Windows.Forms.TableLayoutPanel tlpDataGridView;
        private System.Windows.Forms.DataGridView dgvDisplayLocker;
        private System.Windows.Forms.Panel pnlSpaceing;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewLocker;
        private System.Windows.Forms.Label lblAddNewLocker;
        private System.Windows.Forms.PictureBox picBoxAddSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllocatedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLStatus;
        private System.Windows.Forms.DataGridViewImageColumn colUpdate;
        private System.Windows.Forms.DataGridViewImageColumn colDeactivate;
    }
}