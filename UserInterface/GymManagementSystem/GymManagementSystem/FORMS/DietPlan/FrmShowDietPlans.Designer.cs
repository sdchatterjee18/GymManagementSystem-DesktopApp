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
            this.tlpShowDietPlanAndAddNewDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShowDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDietPlan = new System.Windows.Forms.DataGridView();
            this.pnlAddNewDietPlan = new System.Windows.Forms.Panel();
            this.lblAddNewDietPlan = new System.Windows.Forms.Label();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAddDietPlanAndAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDietHeader.SuspendLayout();
            this.pnlDietDetails.SuspendLayout();
            this.tlpShowDietPlanAndAddNewDietPlan.SuspendLayout();
            this.tlpShowDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).BeginInit();
            this.pnlAddNewDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.tlpAddButton.SuspendLayout();
            this.tlpAddDietPlanAndAddButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDietHeader
            // 
            this.pnlDietHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDietHeader.Controls.Add(this.pnlDietDetails);
            this.pnlDietHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlDietHeader.Name = "pnlDietHeader";
            this.pnlDietHeader.Size = new System.Drawing.Size(607, 48);
            this.pnlDietHeader.TabIndex = 0;
            // 
            // pnlDietDetails
            // 
            this.pnlDietDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDietDetails.Controls.Add(this.lblDietPlan);
            this.pnlDietDetails.Location = new System.Drawing.Point(0, 3);
            this.pnlDietDetails.Name = "pnlDietDetails";
            this.pnlDietDetails.Size = new System.Drawing.Size(607, 42);
            this.pnlDietDetails.TabIndex = 0;
            // 
            // lblDietPlan
            // 
            this.lblDietPlan.AutoEllipsis = true;
            this.lblDietPlan.AutoSize = true;
            this.lblDietPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblDietPlan.Location = new System.Drawing.Point(3, 0);
            this.lblDietPlan.Name = "lblDietPlan";
            this.lblDietPlan.Size = new System.Drawing.Size(143, 41);
            this.lblDietPlan.TabIndex = 0;
            this.lblDietPlan.Text = "Diet Plan";
            // 
            // tlpShowDietPlanAndAddNewDietPlan
            // 
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnCount = 1;
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.pnlDietHeader, 0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpShowDietPlan, 0, 1);
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpAddDietPlanAndAddButton, 0, 2);
            this.tlpShowDietPlanAndAddNewDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowDietPlanAndAddNewDietPlan.Location = new System.Drawing.Point(0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Name = "tlpShowDietPlanAndAddNewDietPlan";
            this.tlpShowDietPlanAndAddNewDietPlan.RowCount = 4;
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57143F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.85211F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.64789F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowDietPlanAndAddNewDietPlan.Size = new System.Drawing.Size(613, 452);
            this.tlpShowDietPlanAndAddNewDietPlan.TabIndex = 1;
            // 
            // tlpShowDietPlan
            // 
            this.tlpShowDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowDietPlan.ColumnCount = 3;
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpShowDietPlan.Controls.Add(this.dgvDietPlan, 1, 0);
            this.tlpShowDietPlan.Location = new System.Drawing.Point(3, 57);
            this.tlpShowDietPlan.Name = "tlpShowDietPlan";
            this.tlpShowDietPlan.RowCount = 1;
            this.tlpShowDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowDietPlan.Size = new System.Drawing.Size(607, 265);
            this.tlpShowDietPlan.TabIndex = 0;
            // 
            // dgvDietPlan
            // 
            this.dgvDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDietPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDietPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDietPlan.Location = new System.Drawing.Point(33, 3);
            this.dgvDietPlan.Name = "dgvDietPlan";
            this.dgvDietPlan.RowTemplate.Height = 24;
            this.dgvDietPlan.Size = new System.Drawing.Size(540, 259);
            this.dgvDietPlan.TabIndex = 0;
            // 
            // pnlAddNewDietPlan
            // 
            this.pnlAddNewDietPlan.Controls.Add(this.picAddIcon);
            this.pnlAddNewDietPlan.Controls.Add(this.lblAddNewDietPlan);
            this.pnlAddNewDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddNewDietPlan.Location = new System.Drawing.Point(3, 3);
            this.pnlAddNewDietPlan.Name = "pnlAddNewDietPlan";
            this.pnlAddNewDietPlan.Size = new System.Drawing.Size(277, 41);
            this.pnlAddNewDietPlan.TabIndex = 1;
            // 
            // lblAddNewDietPlan
            // 
            this.lblAddNewDietPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddNewDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddNewDietPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblAddNewDietPlan.Location = new System.Drawing.Point(2, 0);
            this.lblAddNewDietPlan.Name = "lblAddNewDietPlan";
            this.lblAddNewDietPlan.Size = new System.Drawing.Size(274, 40);
            this.lblAddNewDietPlan.TabIndex = 0;
            this.lblAddNewDietPlan.Text = " Add New Diet Plan";
            this.lblAddNewDietPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewDietPlan.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.lblAddNewDietPlan.Enter += new System.EventHandler(this.pnlAddNewDietPlan_Enter);
            this.lblAddNewDietPlan.Leave += new System.EventHandler(this.pnlAddNewDietPlan_Leave);
            this.lblAddNewDietPlan.MouseEnter += new System.EventHandler(this.pnlAddNewDietPlan_MouseEnter);
            this.lblAddNewDietPlan.MouseLeave += new System.EventHandler(this.pnlAddNewDietPlan_MouseLeave);
            this.lblAddNewDietPlan.MouseHover += new System.EventHandler(this.pnlAddNewDietPlan_MouseHover);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(12, 11);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(29, 24);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 1;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.pnlAddNewDietPlan_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.pnlAddNewDietPlan_MouseLeave);
            this.picAddIcon.MouseHover += new System.EventHandler(this.pnlAddNewDietPlan_MouseHover);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpAddButton.ColumnCount = 1;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddButton.Controls.Add(this.pnlAddNewDietPlan, 0, 0);
            this.tlpAddButton.Location = new System.Drawing.Point(162, 26);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddButton.Size = new System.Drawing.Size(283, 47);
            this.tlpAddButton.TabIndex = 1;
            // 
            // tlpAddDietPlanAndAddButton
            // 
            this.tlpAddDietPlanAndAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddDietPlanAndAddButton.ColumnCount = 1;
            this.tlpAddDietPlanAndAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddDietPlanAndAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddDietPlanAndAddButton.Controls.Add(this.tlpAddButton, 0, 0);
            this.tlpAddDietPlanAndAddButton.Location = new System.Drawing.Point(3, 328);
            this.tlpAddDietPlanAndAddButton.Name = "tlpAddDietPlanAndAddButton";
            this.tlpAddDietPlanAndAddButton.RowCount = 1;
            this.tlpAddDietPlanAndAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddDietPlanAndAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddDietPlanAndAddButton.Size = new System.Drawing.Size(607, 100);
            this.tlpAddDietPlanAndAddButton.TabIndex = 2;
            // 
            // FrmShowDietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(613, 452);
            this.Controls.Add(this.tlpShowDietPlanAndAddNewDietPlan);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShowDietPlans";
            this.Text = "FrmShowDietPlans";
            this.Load += new System.EventHandler(this.FrmShowDietPlans_Load);
            this.pnlDietHeader.ResumeLayout(false);
            this.pnlDietDetails.ResumeLayout(false);
            this.pnlDietDetails.PerformLayout();
            this.tlpShowDietPlanAndAddNewDietPlan.ResumeLayout(false);
            this.tlpShowDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).EndInit();
            this.pnlAddNewDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.tlpAddButton.ResumeLayout(false);
            this.tlpAddDietPlanAndAddButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDietHeader;
        private System.Windows.Forms.Panel pnlDietDetails;
        private System.Windows.Forms.Label lblDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlanAndAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlan;
        private System.Windows.Forms.DataGridView dgvDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.Panel pnlAddNewDietPlan;
        private System.Windows.Forms.PictureBox picAddIcon;
        private System.Windows.Forms.Label lblAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddDietPlanAndAddButton;
    }
}