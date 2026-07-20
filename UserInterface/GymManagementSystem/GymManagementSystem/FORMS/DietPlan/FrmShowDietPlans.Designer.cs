namespace GymManagementSystem.FORMS.DietPlan
{
    partial class FrmShowDietPlans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowDietPlans));
            this.tlpShowDietPlanAndAddNewDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShowDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDietPlan = new System.Windows.Forms.DataGridView();
            this.SL_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaloriesPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpAddDietPlanAndAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddNewDietPlan = new System.Windows.Forms.Panel();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.lblAddNewDietPlan = new System.Windows.Forms.Label();
            this.tlpDietPlanHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblDietPlan = new System.Windows.Forms.Label();
            this.tlpShowDietPlanAndAddNewDietPlan.SuspendLayout();
            this.tlpShowDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).BeginInit();
            this.tlpAddDietPlanAndAddButton.SuspendLayout();
            this.tlpAddButton.SuspendLayout();
            this.pnlAddNewDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.tlpDietPlanHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpShowDietPlanAndAddNewDietPlan
            // 
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnCount = 1;
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpShowDietPlan, 0, 1);
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpAddDietPlanAndAddButton, 0, 2);
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpDietPlanHeader, 0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowDietPlanAndAddNewDietPlan.Location = new System.Drawing.Point(0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Margin = new System.Windows.Forms.Padding(2);
            this.tlpShowDietPlanAndAddNewDietPlan.Name = "tlpShowDietPlanAndAddNewDietPlan";
            this.tlpShowDietPlanAndAddNewDietPlan.RowCount = 4;
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpShowDietPlanAndAddNewDietPlan.Size = new System.Drawing.Size(466, 488);
            this.tlpShowDietPlanAndAddNewDietPlan.TabIndex = 1;
            this.tlpShowDietPlanAndAddNewDietPlan.Click += new System.EventHandler(this.tlpShowDietPlanAndAddNewDietPlan_Click);
            // 
            // tlpShowDietPlan
            // 
            this.tlpShowDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowDietPlan.ColumnCount = 3;
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.99391F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.99716F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.008933F));
            this.tlpShowDietPlan.Controls.Add(this.dgvDietPlan, 1, 0);
            this.tlpShowDietPlan.Location = new System.Drawing.Point(2, 65);
            this.tlpShowDietPlan.Margin = new System.Windows.Forms.Padding(2);
            this.tlpShowDietPlan.Name = "tlpShowDietPlan";
            this.tlpShowDietPlan.RowCount = 1;
            this.tlpShowDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlan.Size = new System.Drawing.Size(462, 337);
            this.tlpShowDietPlan.TabIndex = 0;
            this.tlpShowDietPlan.Click += new System.EventHandler(this.tlpShowDietPlan_Click);
            // 
            // dgvDietPlan
            // 
            this.dgvDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDietPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDietPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDietPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDietPlan.ColumnHeadersHeight = 50;
            this.dgvDietPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDietPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL_No,
            this.CaloriesPerDay,
            this.Document,
            this.Condition,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDietPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDietPlan.GridColor = System.Drawing.Color.Black;
            this.dgvDietPlan.Location = new System.Drawing.Point(25, 2);
            this.dgvDietPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDietPlan.Name = "dgvDietPlan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDietPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvDietPlan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDietPlan.RowTemplate.Height = 40;
            this.dgvDietPlan.Size = new System.Drawing.Size(407, 333);
            this.dgvDietPlan.TabIndex = 0;
            this.dgvDietPlan.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietPlan_CellMouseEnter);
            this.dgvDietPlan.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietPlan_CellMouseLeave);
            this.dgvDietPlan.Click += new System.EventHandler(this.dgvDietPlan_Click);
            // 
            // SL_No
            // 
            this.SL_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.SL_No.DefaultCellStyle = dataGridViewCellStyle2;
            this.SL_No.HeaderText = "SL No";
            this.SL_No.Name = "SL_No";
            this.SL_No.ReadOnly = true;
            this.SL_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CaloriesPerDay
            // 
            this.CaloriesPerDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CaloriesPerDay.HeaderText = "CaloriesPerDay";
            this.CaloriesPerDay.Name = "CaloriesPerDay";
            this.CaloriesPerDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Document
            // 
            this.Document.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Condition
            // 
            this.Condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            this.Condition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.Text = "📝Update";
            this.Action.ToolTipText = "📝Update";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // tlpAddDietPlanAndAddButton
            // 
            this.tlpAddDietPlanAndAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddDietPlanAndAddButton.ColumnCount = 2;
            this.tlpAddDietPlanAndAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.552845F));
            this.tlpAddDietPlanAndAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.44715F));
            this.tlpAddDietPlanAndAddButton.Controls.Add(this.tlpAddButton, 1, 0);
            this.tlpAddDietPlanAndAddButton.Location = new System.Drawing.Point(2, 406);
            this.tlpAddDietPlanAndAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddDietPlanAndAddButton.Name = "tlpAddDietPlanAndAddButton";
            this.tlpAddDietPlanAndAddButton.RowCount = 1;
            this.tlpAddDietPlanAndAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddDietPlanAndAddButton.Size = new System.Drawing.Size(462, 44);
            this.tlpAddDietPlanAndAddButton.TabIndex = 2;
            this.tlpAddDietPlanAndAddButton.Click += new System.EventHandler(this.tlpAddDietPlanAndAddButton_Click);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddButton.ColumnCount = 1;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAddButton.Controls.Add(this.pnlAddNewDietPlan, 0, 0);
            this.tlpAddButton.Location = new System.Drawing.Point(23, 3);
            this.tlpAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpAddButton.Size = new System.Drawing.Size(212, 38);
            this.tlpAddButton.TabIndex = 1;
            // 
            // pnlAddNewDietPlan
            // 
            this.pnlAddNewDietPlan.Controls.Add(this.picAddIcon);
            this.pnlAddNewDietPlan.Controls.Add(this.lblAddNewDietPlan);
            this.pnlAddNewDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddNewDietPlan.Location = new System.Drawing.Point(2, 2);
            this.pnlAddNewDietPlan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddNewDietPlan.Name = "pnlAddNewDietPlan";
            this.pnlAddNewDietPlan.Size = new System.Drawing.Size(208, 34);
            this.pnlAddNewDietPlan.TabIndex = 1;
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(9, 9);
            this.picAddIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(17, 21);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 1;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.pnlAddNewDietPlan_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.pnlAddNewDietPlan_MouseLeave);
            // 
            // lblAddNewDietPlan
            // 
            this.lblAddNewDietPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddNewDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddNewDietPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblAddNewDietPlan.Location = new System.Drawing.Point(0, 1);
            this.lblAddNewDietPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewDietPlan.Name = "lblAddNewDietPlan";
            this.lblAddNewDietPlan.Size = new System.Drawing.Size(208, 33);
            this.lblAddNewDietPlan.TabIndex = 0;
            this.lblAddNewDietPlan.Text = " Add New Diet Plan";
            this.lblAddNewDietPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewDietPlan.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.lblAddNewDietPlan.Enter += new System.EventHandler(this.pnlAddNewDietPlan_Enter);
            this.lblAddNewDietPlan.Leave += new System.EventHandler(this.pnlAddNewDietPlan_Leave);
            this.lblAddNewDietPlan.MouseEnter += new System.EventHandler(this.pnlAddNewDietPlan_MouseEnter);
            this.lblAddNewDietPlan.MouseLeave += new System.EventHandler(this.pnlAddNewDietPlan_MouseLeave);
            // 
            // tlpDietPlanHeader
            // 
            this.tlpDietPlanHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDietPlanHeader.ColumnCount = 2;
            this.tlpDietPlanHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.390244F));
            this.tlpDietPlanHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.60976F));
            this.tlpDietPlanHeader.Controls.Add(this.lblDietPlan, 1, 0);
            this.tlpDietPlanHeader.Location = new System.Drawing.Point(2, 2);
            this.tlpDietPlanHeader.Margin = new System.Windows.Forms.Padding(2);
            this.tlpDietPlanHeader.Name = "tlpDietPlanHeader";
            this.tlpDietPlanHeader.RowCount = 1;
            this.tlpDietPlanHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDietPlanHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpDietPlanHeader.Size = new System.Drawing.Size(462, 59);
            this.tlpDietPlanHeader.TabIndex = 3;
            this.tlpDietPlanHeader.Click += new System.EventHandler(this.tlpDietPlanHeader_Click);
            // 
            // lblDietPlan
            // 
            this.lblDietPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDietPlan.AutoEllipsis = true;
            this.lblDietPlan.AutoSize = true;
            this.lblDietPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblDietPlan.Location = new System.Drawing.Point(22, 13);
            this.lblDietPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDietPlan.Name = "lblDietPlan";
            this.lblDietPlan.Size = new System.Drawing.Size(114, 32);
            this.lblDietPlan.TabIndex = 0;
            this.lblDietPlan.Text = "Diet Plan";
            this.lblDietPlan.Click += new System.EventHandler(this.lblDietPlan_Click);
            // 
            // FrmShowDietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(466, 488);
            this.Controls.Add(this.tlpShowDietPlanAndAddNewDietPlan);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "FrmShowDietPlans";
            this.Text = "FrmShowDietPlans";
            this.Load += new System.EventHandler(this.FrmShowDietPlans_Load);
            this.tlpShowDietPlanAndAddNewDietPlan.ResumeLayout(false);
            this.tlpShowDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).EndInit();
            this.tlpAddDietPlanAndAddButton.ResumeLayout(false);
            this.tlpAddButton.ResumeLayout(false);
            this.pnlAddNewDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.tlpDietPlanHeader.ResumeLayout(false);
            this.tlpDietPlanHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlanAndAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlan;
        private System.Windows.Forms.DataGridView dgvDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.Panel pnlAddNewDietPlan;
        private System.Windows.Forms.PictureBox picAddIcon;
        private System.Windows.Forms.Label lblAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddDietPlanAndAddButton;
        private System.Windows.Forms.Label lblDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpDietPlanHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaloriesPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}