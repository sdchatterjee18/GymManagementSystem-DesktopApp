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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.tlpAddNewLocker = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.picBoxAddSymbol = new System.Windows.Forms.PictureBox();
            this.tlpSpaceing = new System.Windows.Forms.TableLayoutPanel();
            this.lblLockerManagement = new System.Windows.Forms.Label();
            this.pnlSpaceing = new System.Windows.Forms.Panel();
            this.tlpDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayLocker = new System.Windows.Forms.DataGridView();
            this.colSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllocatedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.tlpAddNewLocker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).BeginInit();
            this.tlpSpaceing.SuspendLayout();
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
            this.pnlHeading.Size = new System.Drawing.Size(1094, 79);
            this.pnlHeading.TabIndex = 0;
            // 
            // tlpHeading
            // 
            this.tlpHeading.ColumnCount = 4;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.24113F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75887F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
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
            this.tlpHeading.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlButton.Controls.Add(this.tlpAddNewLocker);
            this.pnlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(749, 14);
            this.pnlButton.MinimumSize = new System.Drawing.Size(180, 50);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
            this.pnlButton.Size = new System.Drawing.Size(281, 50);
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
            this.tlpAddNewLocker.Size = new System.Drawing.Size(233, 34);
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
            this.lblAddNewLocker.Location = new System.Drawing.Point(44, 2);
            this.lblAddNewLocker.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(178, 30);
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
            this.tlpSpaceing.Size = new System.Drawing.Size(488, 73);
            this.tlpSpaceing.TabIndex = 2;
            // 
            // lblLockerManagement
            // 
            this.lblLockerManagement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLockerManagement.AutoSize = true;
            this.lblLockerManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerManagement.Location = new System.Drawing.Point(54, 9);
            this.lblLockerManagement.Name = "lblLockerManagement";
            this.lblLockerManagement.Size = new System.Drawing.Size(393, 54);
            this.lblLockerManagement.TabIndex = 1;
            this.lblLockerManagement.Text = "Locker Management";
            this.lblLockerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLockerManagement.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // pnlSpaceing
            // 
            this.pnlSpaceing.Controls.Add(this.tlpDataGridView);
            this.pnlSpaceing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpaceing.Location = new System.Drawing.Point(0, 79);
            this.pnlSpaceing.Name = "pnlSpaceing";
            this.pnlSpaceing.Size = new System.Drawing.Size(1094, 417);
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
            this.tlpDataGridView.Size = new System.Drawing.Size(1094, 417);
            this.tlpDataGridView.TabIndex = 0;
            this.tlpDataGridView.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // dgvDisplayLocker
            // 
            this.dgvDisplayLocker.AllowUserToAddRows = false;
            this.dgvDisplayLocker.AllowUserToDeleteRows = false;
            this.dgvDisplayLocker.AllowUserToResizeColumns = false;
            this.dgvDisplayLocker.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDisplayLocker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayLocker.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisplayLocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayLocker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayLocker.ColumnHeadersHeight = 50;
            this.dgvDisplayLocker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlNo,
            this.colLNo,
            this.colAllocatedTo,
            this.colLStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayLocker.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplayLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayLocker.EnableHeadersVisualStyles = false;
            this.dgvDisplayLocker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dgvDisplayLocker.Location = new System.Drawing.Point(57, 3);
            this.dgvDisplayLocker.Name = "dgvDisplayLocker";
            this.dgvDisplayLocker.ReadOnly = true;
            this.dgvDisplayLocker.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayLocker.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDisplayLocker.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDisplayLocker.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDisplayLocker.RowTemplate.Height = 50;
            this.dgvDisplayLocker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDisplayLocker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDisplayLocker.Size = new System.Drawing.Size(978, 411);
            this.dgvDisplayLocker.StandardTab = true;
            this.dgvDisplayLocker.TabIndex = 0;
            this.dgvDisplayLocker.TabStop = false;
            this.dgvDisplayLocker.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseEnter);
            this.dgvDisplayLocker.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLocker_CellMouseLeave);
            this.dgvDisplayLocker.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // colSlNo
            // 
            this.colSlNo.FillWeight = 50F;
            this.colSlNo.HeaderText = "SL No.";
            this.colSlNo.MaxInputLength = 32;
            this.colSlNo.Name = "colSlNo";
            this.colSlNo.ReadOnly = true;
            this.colSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLNo
            // 
            this.colLNo.DataPropertyName = "LNo";
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
            this.colLStatus.DataPropertyName = "LStatus";
            this.colLStatus.FillWeight = 110F;
            this.colLStatus.HeaderText = "Locker Status";
            this.colLStatus.Name = "colLStatus";
            this.colLStatus.ReadOnly = true;
            this.colLStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 496);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1094, 47);
            this.pnlFooter.TabIndex = 2;
            this.pnlFooter.Click += new System.EventHandler(this.dgvDisplayLocker_Click);
            // 
            // FrmDisplayLocker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1094, 543);
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
            this.Resize += new System.EventHandler(this.FrmDisplayLocker_Resize);
            this.pnlHeading.ResumeLayout(false);
            this.tlpHeading.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.tlpAddNewLocker.ResumeLayout(false);
            this.tlpAddNewLocker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddSymbol)).EndInit();
            this.tlpSpaceing.ResumeLayout(false);
            this.tlpSpaceing.PerformLayout();
            this.pnlSpaceing.ResumeLayout(false);
            this.tlpDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLocker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.TableLayoutPanel tlpSpaceing;
        private System.Windows.Forms.Label lblLockerManagement;
        private System.Windows.Forms.Panel pnlSpaceing;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewLocker;
        private System.Windows.Forms.Label lblAddNewLocker;
        private System.Windows.Forms.PictureBox picBoxAddSymbol;
        private System.Windows.Forms.TableLayoutPanel tlpDataGridView;
        private System.Windows.Forms.DataGridView dgvDisplayLocker;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllocatedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLStatus;
    }
}
