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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowDietPlans));
            this.pnlDietHeader = new System.Windows.Forms.Panel();
            this.pnlDietDetails = new System.Windows.Forms.Panel();
            this.lblDietPlan = new System.Windows.Forms.Label();
            this.pnlDietPlanDataGridView = new System.Windows.Forms.Panel();
            this.dgvDietPlan = new System.Windows.Forms.DataGridView();
            this.pnlAddNewDietPlan = new System.Windows.Forms.Panel();
            this.lblAddNewDietPlan = new System.Windows.Forms.Label();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.pnlDietHeader.SuspendLayout();
            this.pnlDietDetails.SuspendLayout();
            this.pnlDietPlanDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).BeginInit();
            this.pnlAddNewDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDietHeader
            // 
            this.pnlDietHeader.Controls.Add(this.pnlDietDetails);
            this.pnlDietHeader.Location = new System.Drawing.Point(-18, -1);
            this.pnlDietHeader.Name = "pnlDietHeader";
            this.pnlDietHeader.Size = new System.Drawing.Size(677, 74);
            this.pnlDietHeader.TabIndex = 0;
            // 
            // pnlDietDetails
            // 
            this.pnlDietDetails.Controls.Add(this.lblDietPlan);
            this.pnlDietDetails.Location = new System.Drawing.Point(-15, 3);
            this.pnlDietDetails.Name = "pnlDietDetails";
            this.pnlDietDetails.Size = new System.Drawing.Size(705, 42);
            this.pnlDietDetails.TabIndex = 0;
            // 
            // lblDietPlan
            // 
            this.lblDietPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDietPlan.AutoEllipsis = true;
            this.lblDietPlan.AutoSize = true;
            this.lblDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblDietPlan.Location = new System.Drawing.Point(47, 13);
            this.lblDietPlan.Name = "lblDietPlan";
            this.lblDietPlan.Size = new System.Drawing.Size(65, 17);
            this.lblDietPlan.TabIndex = 0;
            this.lblDietPlan.Text = "Diet Plan";
            // 
            // pnlDietPlanDataGridView
            // 
            this.pnlDietPlanDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDietPlanDataGridView.Controls.Add(this.dgvDietPlan);
            this.pnlDietPlanDataGridView.Location = new System.Drawing.Point(6, 99);
            this.pnlDietPlanDataGridView.Name = "pnlDietPlanDataGridView";
            this.pnlDietPlanDataGridView.Size = new System.Drawing.Size(653, 244);
            this.pnlDietPlanDataGridView.TabIndex = 1;
            // 
            // dgvDietPlan
            // 
            this.dgvDietPlan.AllowUserToAddRows = false;
            this.dgvDietPlan.AllowUserToResizeRows = false;
            this.dgvDietPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDietPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDietPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDietPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDietPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDietPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDietPlan.Location = new System.Drawing.Point(1, 0);
            this.dgvDietPlan.MultiSelect = false;
            this.dgvDietPlan.Name = "dgvDietPlan";
            this.dgvDietPlan.RowHeadersVisible = false;
            this.dgvDietPlan.RowTemplate.Height = 55;
            this.dgvDietPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDietPlan.Size = new System.Drawing.Size(652, 244);
            this.dgvDietPlan.TabIndex = 0;
            // 
            // pnlAddNewDietPlan
            // 
            this.pnlAddNewDietPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddNewDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddNewDietPlan.Controls.Add(this.picAddIcon);
            this.pnlAddNewDietPlan.Controls.Add(this.lblAddNewDietPlan);
            this.pnlAddNewDietPlan.Location = new System.Drawing.Point(26, 396);
            this.pnlAddNewDietPlan.Name = "pnlAddNewDietPlan";
            this.pnlAddNewDietPlan.Size = new System.Drawing.Size(379, 65);
            this.pnlAddNewDietPlan.TabIndex = 2;
            this.pnlAddNewDietPlan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddNewDietPlan_Paint);
            this.pnlAddNewDietPlan.MouseEnter += new System.EventHandler(this.lblAddNewDietPlan_MouseEnter);
            this.pnlAddNewDietPlan.MouseLeave += new System.EventHandler(this.lblAddNewDietPlan_MouseLeave);
            this.pnlAddNewDietPlan.MouseHover += new System.EventHandler(this.lblAddNewDietPlan_MouseHover);
            this.pnlAddNewDietPlan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAddNewDietPlan_MouseUp);
            // 
            // lblAddNewDietPlan
            // 
            this.lblAddNewDietPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddNewDietPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblAddNewDietPlan.Location = new System.Drawing.Point(3, -1);
            this.lblAddNewDietPlan.Name = "lblAddNewDietPlan";
            this.lblAddNewDietPlan.Size = new System.Drawing.Size(371, 64);
            this.lblAddNewDietPlan.TabIndex = 0;
            this.lblAddNewDietPlan.Text = " Add New Diet Plan";
            this.lblAddNewDietPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewDietPlan.Click += new System.EventHandler(this.lblAddNewDietPlan_Click);
            this.lblAddNewDietPlan.MouseEnter += new System.EventHandler(this.lblAddNewDietPlan_MouseEnter);
            this.lblAddNewDietPlan.MouseLeave += new System.EventHandler(this.lblAddNewDietPlan_MouseLeave);
            this.lblAddNewDietPlan.MouseHover += new System.EventHandler(this.lblAddNewDietPlan_MouseHover);
            this.lblAddNewDietPlan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAddNewDietPlan_MouseUp);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(4, 9);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(53, 46);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 1;
            this.picAddIcon.TabStop = false;
            // 
            // FrmShowDietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(667, 527);
            this.Controls.Add(this.pnlAddNewDietPlan);
            this.Controls.Add(this.pnlDietPlanDataGridView);
            this.Controls.Add(this.pnlDietHeader);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShowDietPlans";
            this.Text = "FrmShowDietPlans";
            this.Load += new System.EventHandler(this.FrmShowDietPlans_Load);
            this.pnlDietHeader.ResumeLayout(false);
            this.pnlDietDetails.ResumeLayout(false);
            this.pnlDietDetails.PerformLayout();
            this.pnlDietPlanDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).EndInit();
            this.pnlAddNewDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDietHeader;
        private System.Windows.Forms.Panel pnlDietDetails;
        private System.Windows.Forms.Label lblDietPlan;
        private System.Windows.Forms.Panel pnlDietPlanDataGridView;
        private System.Windows.Forms.DataGridView dgvDietPlan;
        private System.Windows.Forms.Panel pnlAddNewDietPlan;
        private System.Windows.Forms.Label lblAddNewDietPlan;
        private System.Windows.Forms.PictureBox picAddIcon;
    }
}