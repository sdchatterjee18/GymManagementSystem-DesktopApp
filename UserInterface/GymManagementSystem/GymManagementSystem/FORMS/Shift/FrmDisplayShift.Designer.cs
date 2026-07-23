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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.ColSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpTitleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitleShift = new System.Windows.Forms.Panel();
            this.lblTitleShift = new System.Windows.Forms.Label();
            this.tlpMainLayout.SuspendLayout();
            this.tlpGridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.tlpTitleLayout.SuspendLayout();
            this.pnlTitleShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.tlpGridLayout, 0, 1);
            this.tlpMainLayout.Controls.Add(this.tlpTitleLayout, 0, 0);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(15, 15);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 3;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayout.Size = new System.Drawing.Size(727, 452);
            this.tlpMainLayout.TabIndex = 0;
            this.tlpMainLayout.Click += new System.EventHandler(this.tlpMainLayout_Click);
            // 
            // tlpGridLayout
            // 
            this.tlpGridLayout.ColumnCount = 3;
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpGridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGridLayout.Controls.Add(this.dgvShift, 1, 0);
            this.tlpGridLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGridLayout.Location = new System.Drawing.Point(3, 63);
            this.tlpGridLayout.Name = "tlpGridLayout";
            this.tlpGridLayout.RowCount = 1;
            this.tlpGridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGridLayout.Size = new System.Drawing.Size(721, 366);
            this.tlpGridLayout.TabIndex = 1;
            this.tlpGridLayout.Click += new System.EventHandler(this.tlpGridLayout_Click);
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeRows = false;
            this.dgvShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShift.BackgroundColor = System.Drawing.Color.White;
            this.dgvShift.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvShift.ColumnHeadersHeight = 50;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSerialNo,
            this.ColShiftName,
            this.ColStartTime,
            this.ColEndTime,
            this.ColAction});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShift.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShift.EnableHeadersVisualStyles = false;
            this.dgvShift.GridColor = System.Drawing.Color.Black;
            this.dgvShift.Location = new System.Drawing.Point(39, 3);
            this.dgvShift.Name = "dgvShift";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvShift.RowHeadersVisible = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShift.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvShift.RowTemplate.Height = 40;
            this.dgvShift.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShift.Size = new System.Drawing.Size(642, 360);
            this.dgvShift.TabIndex = 0;
            this.dgvShift.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShift_CellDoubleClick);
            this.dgvShift.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShift_CellMouseEnter);
            this.dgvShift.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShift_CellMouseLeave);
            // 
            // ColSerialNo
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColSerialNo.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColSerialNo.HeaderText = "SL No.";
            this.ColSerialNo.Name = "ColSerialNo";
            this.ColSerialNo.ReadOnly = true;
            // 
            // ColShiftName
            // 
            this.ColShiftName.DataPropertyName = "ShiftName";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColShiftName.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColShiftName.HeaderText = "Shift Name";
            this.ColShiftName.Name = "ColShiftName";
            // 
            // ColStartTime
            // 
            this.ColStartTime.DataPropertyName = "StartTime";
            this.ColStartTime.HeaderText = "Start Time";
            this.ColStartTime.Name = "ColStartTime";
            // 
            // ColEndTime
            // 
            this.ColEndTime.DataPropertyName = "EndTime";
            this.ColEndTime.HeaderText = "End Time";
            this.ColEndTime.Name = "ColEndTime";
            // 
            // ColAction
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Red;
            this.ColAction.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColAction.HeaderText = "Action";
            this.ColAction.Name = "ColAction";
            this.ColAction.Text = "✏️Update";
            this.ColAction.UseColumnTextForButtonValue = true;
            // 
            // tlpTitleLayout
            // 
            this.tlpTitleLayout.ColumnCount = 2;
            this.tlpTitleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpTitleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tlpTitleLayout.Controls.Add(this.pnlTitleShift, 1, 0);
            this.tlpTitleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleLayout.Location = new System.Drawing.Point(3, 3);
            this.tlpTitleLayout.Name = "tlpTitleLayout";
            this.tlpTitleLayout.RowCount = 1;
            this.tlpTitleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleLayout.Size = new System.Drawing.Size(721, 54);
            this.tlpTitleLayout.TabIndex = 2;
            this.tlpTitleLayout.Click += new System.EventHandler(this.tlpTitleLayout_Click);
            // 
            // pnlTitleShift
            // 
            this.pnlTitleShift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlTitleShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlTitleShift.Controls.Add(this.lblTitleShift);
            this.pnlTitleShift.Location = new System.Drawing.Point(31, 3);
            this.pnlTitleShift.Name = "pnlTitleShift";
            this.pnlTitleShift.Size = new System.Drawing.Size(197, 48);
            this.pnlTitleShift.TabIndex = 0;
            this.pnlTitleShift.Click += new System.EventHandler(this.pnlTitleShift_Click);
            // 
            // lblTitleShift
            // 
            this.lblTitleShift.AutoSize = true;
            this.lblTitleShift.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleShift.Location = new System.Drawing.Point(3, 10);
            this.lblTitleShift.Name = "lblTitleShift";
            this.lblTitleShift.Size = new System.Drawing.Size(146, 32);
            this.lblTitleShift.TabIndex = 0;
            this.lblTitleShift.Text = "Shift Details";
            this.lblTitleShift.Click += new System.EventHandler(this.lblTitleShift_Click);
            // 
            // FrmDisplayShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(757, 482);
            this.Controls.Add(this.tlpMainLayout);
            this.Name = "FrmDisplayShift";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FrmDisplayShift";
            this.Load += new System.EventHandler(this.FrmDisplayShift_Load);
            this.Click += new System.EventHandler(this.FrmDisplayShift_Click);
            this.Resize += new System.EventHandler(this.FrmDisplayShift_Resize);
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpGridLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.tlpTitleLayout.ResumeLayout(false);
            this.pnlTitleShift.ResumeLayout(false);
            this.pnlTitleShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.TableLayoutPanel tlpGridLayout;
        private System.Windows.Forms.TableLayoutPanel tlpTitleLayout;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.Panel pnlTitleShift;
        private System.Windows.Forms.Label lblTitleShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndTime;
        private System.Windows.Forms.DataGridViewButtonColumn ColAction;

    }
}