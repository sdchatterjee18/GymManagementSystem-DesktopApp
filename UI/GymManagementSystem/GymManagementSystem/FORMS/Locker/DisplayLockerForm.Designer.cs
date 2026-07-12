namespace GymManagementSystem.FORMS.Locker
{
    partial class DisplayLockerForm
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
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.lblLockerManagement = new System.Windows.Forms.Label();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.tlpDataDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDisplayLockerRecords = new System.Windows.Forms.DataGridView();
            this.pnlAddNewLocker = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.tlpAddNewLocker = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlusSign = new System.Windows.Forms.Label();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.pnlHeading.SuspendLayout();
            this.tlpHeading.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            this.tlpDataDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLockerRecords)).BeginInit();
            this.pnlAddNewLocker.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.tlpAddNewLocker.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeading
            // 
            this.pnlHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlHeading.Controls.Add(this.tlpHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(953, 91);
            this.pnlHeading.TabIndex = 0;
            // 
            // tlpHeading
            // 
            this.tlpHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.tlpHeading.ColumnCount = 2;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpHeading.Controls.Add(this.lblLockerManagement, 1, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeading.ForeColor = System.Drawing.Color.Transparent;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(953, 73);
            this.tlpHeading.TabIndex = 0;
            // 
            // lblLockerManagement
            // 
            this.lblLockerManagement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLockerManagement.AutoSize = true;
            this.lblLockerManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerManagement.ForeColor = System.Drawing.Color.Wheat;
            this.lblLockerManagement.Location = new System.Drawing.Point(98, 14);
            this.lblLockerManagement.Name = "lblLockerManagement";
            this.lblLockerManagement.Size = new System.Drawing.Size(319, 45);
            this.lblLockerManagement.TabIndex = 2;
            this.lblLockerManagement.Text = "Locker Management";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.tlpDataDisplay);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 91);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(953, 367);
            this.pnlDataGridView.TabIndex = 1;
            // 
            // tlpDataDisplay
            // 
            this.tlpDataDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.tlpDataDisplay.ColumnCount = 3;
            this.tlpDataDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDataDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpDataDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDataDisplay.Controls.Add(this.dgvDisplayLockerRecords, 1, 0);
            this.tlpDataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataDisplay.Location = new System.Drawing.Point(0, 0);
            this.tlpDataDisplay.Name = "tlpDataDisplay";
            this.tlpDataDisplay.RowCount = 1;
            this.tlpDataDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataDisplay.Size = new System.Drawing.Size(953, 367);
            this.tlpDataDisplay.TabIndex = 0;
            // 
            // dgvDisplayLockerRecords
            // 
            this.dgvDisplayLockerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayLockerRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayLockerRecords.Location = new System.Drawing.Point(98, 3);
            this.dgvDisplayLockerRecords.Name = "dgvDisplayLockerRecords";
            this.dgvDisplayLockerRecords.RowTemplate.Height = 28;
            this.dgvDisplayLockerRecords.Size = new System.Drawing.Size(756, 361);
            this.dgvDisplayLockerRecords.TabIndex = 0;
            // 
            // pnlAddNewLocker
            // 
            this.pnlAddNewLocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlAddNewLocker.Controls.Add(this.pnlButton);
            this.pnlAddNewLocker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddNewLocker.Location = new System.Drawing.Point(0, 458);
            this.pnlAddNewLocker.Name = "pnlAddNewLocker";
            this.pnlAddNewLocker.Size = new System.Drawing.Size(953, 114);
            this.pnlAddNewLocker.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButton.Controls.Add(this.tlpAddNewLocker);
            this.pnlButton.Location = new System.Drawing.Point(252, 30);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(394, 89);
            this.pnlButton.TabIndex = 0;
            this.pnlButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlButton_MouseClick);
            this.pnlButton.MouseEnter += new System.EventHandler(this.pnlButton_MouseEnter);
            this.pnlButton.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            // 
            // tlpAddNewLocker
            // 
            this.tlpAddNewLocker.ColumnCount = 2;
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpAddNewLocker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlpAddNewLocker.Controls.Add(this.lblPlusSign, 0, 0);
            this.tlpAddNewLocker.Controls.Add(this.lblAddNewLocker, 1, 0);
            this.tlpAddNewLocker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewLocker.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewLocker.Name = "tlpAddNewLocker";
            this.tlpAddNewLocker.RowCount = 1;
            this.tlpAddNewLocker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewLocker.Size = new System.Drawing.Size(394, 89);
            this.tlpAddNewLocker.TabIndex = 0;
            // 
            // lblPlusSign
            // 
            this.lblPlusSign.AutoSize = true;
            this.lblPlusSign.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPlusSign.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusSign.ForeColor = System.Drawing.Color.Wheat;
            this.lblPlusSign.Location = new System.Drawing.Point(3, 0);
            this.lblPlusSign.Name = "lblPlusSign";
            this.lblPlusSign.Size = new System.Drawing.Size(88, 89);
            this.lblPlusSign.TabIndex = 1;
            this.lblPlusSign.Text = "+";
            this.lblPlusSign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlButton_MouseClick);
            this.lblPlusSign.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            this.lblPlusSign.MouseHover += new System.EventHandler(this.pnlButton_MouseEnter);
            // 
            // lblAddNewLocker
            // 
            this.lblAddNewLocker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewLocker.AutoSize = true;
            this.lblAddNewLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewLocker.ForeColor = System.Drawing.Color.Wheat;
            this.lblAddNewLocker.Location = new System.Drawing.Point(97, 22);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(258, 45);
            this.lblAddNewLocker.TabIndex = 0;
            this.lblAddNewLocker.Text = "Add New Locker";
            this.lblAddNewLocker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlButton_MouseClick);
            this.lblAddNewLocker.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            this.lblAddNewLocker.MouseHover += new System.EventHandler(this.pnlButton_MouseEnter);
            // 
            // DisplayLockerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 572);
            this.Controls.Add(this.pnlDataGridView); 
            this.Controls.Add(this.pnlHeading);      
            this.Controls.Add(this.pnlAddNewLocker); 
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayLockerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DisplayLockerForm";
            this.pnlHeading.ResumeLayout(false);
            this.tlpHeading.ResumeLayout(false);
            this.tlpHeading.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            this.tlpDataDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLockerRecords)).EndInit();
            this.pnlAddNewLocker.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.tlpAddNewLocker.ResumeLayout(false);
            this.tlpAddNewLocker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.TableLayoutPanel tlpDataDisplay;
        private System.Windows.Forms.DataGridView dgvDisplayLockerRecords;
        private System.Windows.Forms.Panel pnlAddNewLocker;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewLocker;
        private System.Windows.Forms.Label lblPlusSign;
        private System.Windows.Forms.Label lblAddNewLocker;
        private System.Windows.Forms.Label lblLockerManagement;

    }
}