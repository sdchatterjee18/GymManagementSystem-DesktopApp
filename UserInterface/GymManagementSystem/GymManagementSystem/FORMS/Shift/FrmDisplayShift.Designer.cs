namespace GymManagementSystem.FORMS.Shift
{
    partial class FrmDisplayShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayShift));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpShiftEntireForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShiftHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShiftTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblShiftManagement = new System.Windows.Forms.Label();
            this.lblShiftDeatails = new System.Windows.Forms.Label();
            this.picShift = new System.Windows.Forms.PictureBox();
            this.dgvShiftManagement = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpShiftEntireForm.SuspendLayout();
            this.tlpShiftHeader.SuspendLayout();
            this.tlpShiftTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpShiftEntireForm
            // 
            this.tlpShiftEntireForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpShiftEntireForm.ColumnCount = 3;
            this.tlpShiftEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.639803F));
            this.tlpShiftEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.453F));
            this.tlpShiftEntireForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.907204F));
            this.tlpShiftEntireForm.Controls.Add(this.tlpShiftHeader, 1, 1);
            this.tlpShiftEntireForm.Controls.Add(this.dgvShiftManagement, 1, 3);
            this.tlpShiftEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShiftEntireForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpShiftEntireForm.Location = new System.Drawing.Point(0, 0);
            this.tlpShiftEntireForm.Margin = new System.Windows.Forms.Padding(2);
            this.tlpShiftEntireForm.Name = "tlpShiftEntireForm";
            this.tlpShiftEntireForm.RowCount = 5;
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.558222F));
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67629F));
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.129235F));
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.0276F));
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.489291F));
            this.tlpShiftEntireForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpShiftEntireForm.Size = new System.Drawing.Size(820, 609);
            this.tlpShiftEntireForm.TabIndex = 6;
            // 
            // tlpShiftHeader
            // 
            this.tlpShiftHeader.ColumnCount = 3;
            this.tlpShiftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpShiftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tlpShiftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShiftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpShiftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpShiftHeader.Controls.Add(this.tlpShiftTitle, 1, 0);
            this.tlpShiftHeader.Controls.Add(this.picShift, 0, 0);
            this.tlpShiftHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShiftHeader.Location = new System.Drawing.Point(40, 17);
            this.tlpShiftHeader.Margin = new System.Windows.Forms.Padding(2);
            this.tlpShiftHeader.Name = "tlpShiftHeader";
            this.tlpShiftHeader.RowCount = 1;
            this.tlpShiftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShiftHeader.Size = new System.Drawing.Size(745, 79);
            this.tlpShiftHeader.TabIndex = 8;
            // 
            // tlpShiftTitle
            // 
            this.tlpShiftTitle.ColumnCount = 1;
            this.tlpShiftTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShiftTitle.Controls.Add(this.lblShiftManagement, 0, 0);
            this.tlpShiftTitle.Controls.Add(this.lblShiftDeatails, 0, 1);
            this.tlpShiftTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShiftTitle.Location = new System.Drawing.Point(64, 2);
            this.tlpShiftTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tlpShiftTitle.Name = "tlpShiftTitle";
            this.tlpShiftTitle.RowCount = 2;
            this.tlpShiftTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.47525F));
            this.tlpShiftTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tlpShiftTitle.Size = new System.Drawing.Size(210, 75);
            this.tlpShiftTitle.TabIndex = 1;
            // 
            // lblShiftManagement
            // 
            this.lblShiftManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShiftManagement.AutoSize = true;
            this.lblShiftManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftManagement.Location = new System.Drawing.Point(2, 18);
            this.lblShiftManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiftManagement.Name = "lblShiftManagement";
            this.lblShiftManagement.Size = new System.Drawing.Size(145, 21);
            this.lblShiftManagement.TabIndex = 2;
            this.lblShiftManagement.Text = "Shift Management";
            this.lblShiftManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblShiftDeatails
            // 
            this.lblShiftDeatails.AutoSize = true;
            this.lblShiftDeatails.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftDeatails.ForeColor = System.Drawing.Color.Gray;
            this.lblShiftDeatails.Location = new System.Drawing.Point(3, 39);
            this.lblShiftDeatails.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblShiftDeatails.Name = "lblShiftDeatails";
            this.lblShiftDeatails.Size = new System.Drawing.Size(174, 13);
            this.lblShiftDeatails.TabIndex = 3;
            this.lblShiftDeatails.Text = "View All Shift Details And Timing";
            // 
            // picShift
            // 
            this.picShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShift.Image = ((System.Drawing.Image)(resources.GetObject("picShift.Image")));
            this.picShift.Location = new System.Drawing.Point(0, 0);
            this.picShift.Margin = new System.Windows.Forms.Padding(0);
            this.picShift.Name = "picShift";
            this.picShift.Size = new System.Drawing.Size(62, 79);
            this.picShift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShift.TabIndex = 0;
            this.picShift.TabStop = false;
            // 
            // dgvShiftManagement
            // 
            this.dgvShiftManagement.AllowUserToAddRows = false;
            this.dgvShiftManagement.AllowUserToDeleteRows = false;
            this.dgvShiftManagement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvShiftManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShiftManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShiftManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvShiftManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShiftManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShiftManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShiftManagement.ColumnHeadersHeight = 40;
            this.dgvShiftManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShiftManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colShiftId,
            this.colShiftName,
            this.colStartTime,
            this.colEndTime,
            this.colUpdate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShiftManagement.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShiftManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShiftManagement.EnableHeadersVisualStyles = false;
            this.dgvShiftManagement.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvShiftManagement.Location = new System.Drawing.Point(40, 106);
            this.dgvShiftManagement.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShiftManagement.MultiSelect = false;
            this.dgvShiftManagement.Name = "dgvShiftManagement";
            this.dgvShiftManagement.ReadOnly = true;
            this.dgvShiftManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShiftManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShiftManagement.RowHeadersVisible = false;
            this.dgvShiftManagement.RowHeadersWidth = 50;
            this.dgvShiftManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvShiftManagement.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShiftManagement.RowTemplate.Height = 30;
            this.dgvShiftManagement.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShiftManagement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShiftManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShiftManagement.Size = new System.Drawing.Size(745, 447);
            this.dgvShiftManagement.TabIndex = 11;
            this.dgvShiftManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShiftManagement_CellClick);
            this.dgvShiftManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShiftManagement_CellContentClick);
            this.dgvShiftManagement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShiftManagement_CellFormatting);
            this.dgvShiftManagement.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShiftManagement_CellMouseEnter);
            this.dgvShiftManagement.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShiftManagement_CellMouseLeave);
            this.dgvShiftManagement.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvShiftManagement_CellPainting);
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
            // colShiftId
            // 
            this.colShiftId.HeaderText = "Shift ID";
            this.colShiftId.Name = "colShiftId";
            this.colShiftId.ReadOnly = true;
            this.colShiftId.Visible = false;
            // 
            // colShiftName
            // 
            this.colShiftName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShiftName.DataPropertyName = " ShiftName";
            this.colShiftName.HeaderText = " Shift Name";
            this.colShiftName.Name = "colShiftName";
            this.colShiftName.ReadOnly = true;
            // 
            // colStartTime
            // 
            this.colStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStartTime.DataPropertyName = "StartTime";
            this.colStartTime.FillWeight = 180F;
            this.colStartTime.HeaderText = "Start Time";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEndTime
            // 
            this.colEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEndTime.DataPropertyName = "EndTime";
            this.colEndTime.HeaderText = "End Time";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            this.colEndTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdate.HeaderText = "Update";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Text = "Update";
            this.colUpdate.ToolTipText = "Update";
            this.colUpdate.UseColumnTextForButtonValue = true;
            // 
            // FrmDisplayShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(820, 609);
            this.Controls.Add(this.tlpShiftEntireForm);
            this.Name = "FrmDisplayShift";
            this.Load += new System.EventHandler(this.FrmDisplayShift_Load);
            this.tlpShiftEntireForm.ResumeLayout(false);
            this.tlpShiftHeader.ResumeLayout(false);
            this.tlpShiftTitle.ResumeLayout(false);
            this.tlpShiftTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShiftManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpShiftEntireForm;
        private System.Windows.Forms.TableLayoutPanel tlpShiftHeader;
        private System.Windows.Forms.TableLayoutPanel tlpShiftTitle;
        private System.Windows.Forms.Label lblShiftManagement;
        private System.Windows.Forms.Label lblShiftDeatails;
        private System.Windows.Forms.PictureBox picShift;
        private System.Windows.Forms.DataGridView dgvShiftManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;





    }
}