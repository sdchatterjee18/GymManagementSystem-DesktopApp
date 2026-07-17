namespace GymManagementSystem.FORMS.MembershipPlan
{
    partial class FrmDisplayMembershipPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayMembershipPlan));
            this.pnlAllMembershipPlanTitleSubPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllMembershipPlan = new System.Windows.Forms.Label();
            this.pnlMembershipPlanGridview = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMembershipPlan = new System.Windows.Forms.DataGridView();
            this.pnlClickAddNewMembershipPlan = new System.Windows.Forms.Panel();
            this.pnlAddNewMembarshipPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewMembershipPlan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAllMembershipPlanTitleSubPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMembershipPlanGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipPlan)).BeginInit();
            this.pnlClickAddNewMembershipPlan.SuspendLayout();
            this.pnlAddNewMembarshipPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllMembershipPlanTitleSubPanel
            // 
            this.pnlAllMembershipPlanTitleSubPanel.Controls.Add(this.tableLayoutPanel1);
            this.pnlAllMembershipPlanTitleSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAllMembershipPlanTitleSubPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlAllMembershipPlanTitleSubPanel.Name = "pnlAllMembershipPlanTitleSubPanel";
            this.pnlAllMembershipPlanTitleSubPanel.Size = new System.Drawing.Size(1248, 89);
            this.pnlAllMembershipPlanTitleSubPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Controls.Add(this.lblAllMembershipPlan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAllMembershipPlan
            // 
            this.lblAllMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllMembershipPlan.AutoSize = true;
            this.lblAllMembershipPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllMembershipPlan.Location = new System.Drawing.Point(65, 14);
            this.lblAllMembershipPlan.Name = "lblAllMembershipPlan";
            this.lblAllMembershipPlan.Size = new System.Drawing.Size(280, 38);
            this.lblAllMembershipPlan.TabIndex = 1;
            this.lblAllMembershipPlan.Text = "All Membership Plan";
            // 
            // pnlMembershipPlanGridview
            // 
            this.pnlMembershipPlanGridview.ColumnCount = 3;
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.pnlMembershipPlanGridview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.pnlMembershipPlanGridview.Controls.Add(this.dgvMembershipPlan, 1, 0);
            this.pnlMembershipPlanGridview.Controls.Add(this.pnlClickAddNewMembershipPlan, 1, 1);
            this.pnlMembershipPlanGridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMembershipPlanGridview.Location = new System.Drawing.Point(0, 89);
            this.pnlMembershipPlanGridview.Name = "pnlMembershipPlanGridview";
            this.pnlMembershipPlanGridview.RowCount = 2;
            this.pnlMembershipPlanGridview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.56165F));
            this.pnlMembershipPlanGridview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43836F));
            this.pnlMembershipPlanGridview.Size = new System.Drawing.Size(1248, 553);
            this.pnlMembershipPlanGridview.TabIndex = 1;
            this.pnlMembershipPlanGridview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMembershipPlanGridview_Paint);
            // 
            // dgvMembershipPlan
            // 
            this.dgvMembershipPlan.AllowUserToAddRows = false;
            this.dgvMembershipPlan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMembershipPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembershipPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembershipPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMembershipPlan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMembershipPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembershipPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembershipPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembershipPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembershipPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanName,
            this.PlanType,
            this.Duration,
            this.Price,
            this.Description,
            this.Update,
            this.Deactivate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembershipPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembershipPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembershipPlan.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvMembershipPlan.Location = new System.Drawing.Point(65, 3);
            this.dgvMembershipPlan.Name = "dgvMembershipPlan";
            this.dgvMembershipPlan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembershipPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembershipPlan.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvMembershipPlan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembershipPlan.RowTemplate.Height = 24;
            this.dgvMembershipPlan.Size = new System.Drawing.Size(1117, 456);
            this.dgvMembershipPlan.TabIndex = 0;
            // 
            // pnlClickAddNewMembershipPlan
            // 
            this.pnlClickAddNewMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewMembershipPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlClickAddNewMembershipPlan.Controls.Add(this.pnlAddNewMembarshipPlan);
            this.pnlClickAddNewMembershipPlan.Location = new System.Drawing.Point(65, 472);
            this.pnlClickAddNewMembershipPlan.Name = "pnlClickAddNewMembershipPlan";
            this.pnlClickAddNewMembershipPlan.Size = new System.Drawing.Size(417, 71);
            this.pnlClickAddNewMembershipPlan.TabIndex = 1;
            // 
            // pnlAddNewMembarshipPlan
            // 
            this.pnlAddNewMembarshipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlAddNewMembarshipPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.pnlAddNewMembarshipPlan.ColumnCount = 2;
            this.pnlAddNewMembarshipPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.38554F));
            this.pnlAddNewMembarshipPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.61446F));
            this.pnlAddNewMembarshipPlan.Controls.Add(this.lblAddNewMembershipPlan, 1, 0);
            this.pnlAddNewMembarshipPlan.Controls.Add(this.pictureBox1, 0, 0);
            this.pnlAddNewMembarshipPlan.Location = new System.Drawing.Point(3, 0);
            this.pnlAddNewMembarshipPlan.Name = "pnlAddNewMembarshipPlan";
            this.pnlAddNewMembarshipPlan.RowCount = 1;
            this.pnlAddNewMembarshipPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAddNewMembarshipPlan.Size = new System.Drawing.Size(415, 71);
            this.pnlAddNewMembarshipPlan.TabIndex = 0;
            // 
            // lblAddNewMembershipPlan
            // 
            this.lblAddNewMembershipPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewMembershipPlan.AutoSize = true;
            this.lblAddNewMembershipPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewMembershipPlan.Location = new System.Drawing.Point(70, 19);
            this.lblAddNewMembershipPlan.Name = "lblAddNewMembershipPlan";
            this.lblAddNewMembershipPlan.Size = new System.Drawing.Size(312, 32);
            this.lblAddNewMembershipPlan.TabIndex = 1;
            this.lblAddNewMembershipPlan.Text = "Add New Membership Plan";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 642);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 88);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PlanName
            // 
            this.PlanName.HeaderText = "Plan Name";
            this.PlanName.Name = "PlanName";
            this.PlanName.ReadOnly = true;
            // 
            // PlanType
            // 
            this.PlanType.HeaderText = "Plan Type";
            this.PlanType.Name = "PlanType";
            this.PlanType.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            // 
            // Deactivate
            // 
            this.Deactivate.HeaderText = "Deactivate";
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            // 
            // FrmDisplayMembershipPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMembershipPlanGridview);
            this.Controls.Add(this.pnlAllMembershipPlanTitleSubPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDisplayMembershipPlan";
            this.Text = "FrmDisplayMembershipPlan";
            this.Load += new System.EventHandler(this.FrmDisplayMembershipPlan_Load);
            this.pnlAllMembershipPlanTitleSubPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlMembershipPlanGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembershipPlan)).EndInit();
            this.pnlClickAddNewMembershipPlan.ResumeLayout(false);
            this.pnlAddNewMembarshipPlan.ResumeLayout(false);
            this.pnlAddNewMembarshipPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAllMembershipPlanTitleSubPanel;
        private System.Windows.Forms.TableLayoutPanel pnlMembershipPlanGridview;
        private System.Windows.Forms.DataGridView dgvMembershipPlan;
        private System.Windows.Forms.Label lblAllMembershipPlan;
        private System.Windows.Forms.Panel pnlClickAddNewMembershipPlan;
        private System.Windows.Forms.TableLayoutPanel pnlAddNewMembarshipPlan;
        private System.Windows.Forms.Label lblAddNewMembershipPlan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Deactivate;
    }
}