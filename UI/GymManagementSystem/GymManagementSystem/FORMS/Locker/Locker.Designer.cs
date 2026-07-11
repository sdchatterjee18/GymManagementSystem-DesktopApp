namespace GymManagementSystem.FORMS.Locker
{
    partial class Locker
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.pnlDataGridLocker = new System.Windows.Forms.Panel();
            this.dgvLockerList = new System.Windows.Forms.DataGridView();
            this.pnlAddNewLocker = new System.Windows.Forms.Panel();
            this.btnAddNewLocker = new System.Windows.Forms.Button();
            this.pnlHeading.SuspendLayout();
            this.pnlDataGridLocker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockerList)).BeginInit();
            this.pnlAddNewLocker.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(12, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(279, 38);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Locker Management";
            // 
            // pnlHeading
            // 
            this.pnlHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeading.Controls.Add(this.lblHeading);
            this.pnlHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(1211, 67);
            this.pnlHeading.TabIndex = 0;
            // 
            // pnlDataGridLocker
            // 
            this.pnlDataGridLocker.Controls.Add(this.dgvLockerList);
            this.pnlDataGridLocker.Controls.Add(this.pnlAddNewLocker);
            this.pnlDataGridLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataGridLocker.Location = new System.Drawing.Point(0, 73);
            this.pnlDataGridLocker.Name = "pnlDataGridLocker";
            this.pnlDataGridLocker.Size = new System.Drawing.Size(1211, 466);
            this.pnlDataGridLocker.TabIndex = 1;
            // 
            // dgvLockerList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLockerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLockerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLockerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLockerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLockerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLockerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLockerList.Location = new System.Drawing.Point(0, 0);
            this.dgvLockerList.Name = "dgvLockerList";
            this.dgvLockerList.RowTemplate.Height = 28;
            this.dgvLockerList.Size = new System.Drawing.Size(1211, 394);
            this.dgvLockerList.TabIndex = 1;
            // 
            // pnlAddNewLocker
            // 
            this.pnlAddNewLocker.Controls.Add(this.btnAddNewLocker);
            this.pnlAddNewLocker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddNewLocker.Location = new System.Drawing.Point(0, 394);
            this.pnlAddNewLocker.Name = "pnlAddNewLocker";
            this.pnlAddNewLocker.Size = new System.Drawing.Size(1211, 72);
            this.pnlAddNewLocker.TabIndex = 0;
            // 
            // btnAddNewLocker
            // 
            this.btnAddNewLocker.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddNewLocker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLocker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewLocker.Location = new System.Drawing.Point(-95, -41);
            this.btnAddNewLocker.Name = "btnAddNewLocker";
            this.btnAddNewLocker.Size = new System.Drawing.Size(1346, 155);
            this.btnAddNewLocker.TabIndex = 0;
            this.btnAddNewLocker.Text = "Add New Locker";
            this.btnAddNewLocker.UseVisualStyleBackColor = false;
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 539);
            this.Controls.Add(this.pnlDataGridLocker);
            this.Controls.Add(this.pnlHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Locker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locker";
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            this.pnlDataGridLocker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLockerList)).EndInit();
            this.pnlAddNewLocker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.Panel pnlDataGridLocker;
        private System.Windows.Forms.Panel pnlAddNewLocker;
        private System.Windows.Forms.Button btnAddNewLocker;
        private System.Windows.Forms.DataGridView dgvLockerList;

    }
}