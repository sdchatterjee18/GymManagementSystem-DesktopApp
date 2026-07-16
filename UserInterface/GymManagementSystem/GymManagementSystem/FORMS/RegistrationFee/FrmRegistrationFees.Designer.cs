namespace GymManagementSystem.FORMS.RegistrationFee
{
    partial class FrmRegistrationFees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrationFees));
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowAllAddRegistrationFees = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationFeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMiddleFrmAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickAddNewFegistrationFees = new System.Windows.Forms.Panel();
            this.tlpAddNewRegistrationFees = new System.Windows.Forms.TableLayoutPanel();
            this.picAddRegistrationFee = new System.Windows.Forms.PictureBox();
            this.lblAddRegistrationFees = new System.Windows.Forms.Label();
            this.tlpTopFrmAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrationFeesFrmAddRegistrationFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).BeginInit();
            this.tlpMiddleFrmAddRegistrationFee.SuspendLayout();
            this.pnlClickAddNewFegistrationFees.SuspendLayout();
            this.tlpAddNewRegistrationFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRegistrationFee)).BeginInit();
            this.tlpTopFrmAddRegistrationFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatedAt
            // 
            this.CreatedAt.FillWeight = 80.83756F;
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // dgvShowAllAddRegistrationFees
            // 
            this.dgvShowAllAddRegistrationFees.AllowUserToAddRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToDeleteRows = false;
            this.dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAllAddRegistrationFees.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowAllAddRegistrationFees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeight = 50;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowAllAddRegistrationFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.RegistrationFeeId,
            this.FeeAmount,
            this.IsActive,
            this.CreatedAt,
            this.Update,
            this.Deactivate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowAllAddRegistrationFees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowAllAddRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowAllAddRegistrationFees.EnableHeadersVisualStyles = false;
            this.dgvShowAllAddRegistrationFees.GridColor = System.Drawing.Color.White;
            this.dgvShowAllAddRegistrationFees.Location = new System.Drawing.Point(64, 3);
            this.dgvShowAllAddRegistrationFees.Name = "dgvShowAllAddRegistrationFees";
            this.dgvShowAllAddRegistrationFees.ReadOnly = true;
            this.dgvShowAllAddRegistrationFees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAllAddRegistrationFees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowAllAddRegistrationFees.RowHeadersVisible = false;
            this.dgvShowAllAddRegistrationFees.RowTemplate.Height = 24;
            this.dgvShowAllAddRegistrationFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowAllAddRegistrationFees.Size = new System.Drawing.Size(1104, 588);
            this.dgvShowAllAddRegistrationFees.TabIndex = 0;
            // 
            // No
            // 
            this.No.FillWeight = 50F;
            this.No.HeaderText = "";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // RegistrationFeeId
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationFeeId.DefaultCellStyle = dataGridViewCellStyle2;
            this.RegistrationFeeId.FillWeight = 80.83756F;
            this.RegistrationFeeId.HeaderText = "R_id";
            this.RegistrationFeeId.Name = "RegistrationFeeId";
            this.RegistrationFeeId.ReadOnly = true;
            // 
            // FeeAmount
            // 
            this.FeeAmount.FillWeight = 80.83756F;
            this.FeeAmount.HeaderText = "Fee Amount";
            this.FeeAmount.Name = "FeeAmount";
            this.FeeAmount.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.FillWeight = 80.83756F;
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.FillWeight = 80.83756F;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            // 
            // Deactivate
            // 
            this.Deactivate.FillWeight = 80.83756F;
            this.Deactivate.HeaderText = "Deactivate";
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            // 
            // tlpMiddleFrmAddRegistrationFee
            // 
            this.tlpMiddleFrmAddRegistrationFee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tlpMiddleFrmAddRegistrationFee.ColumnCount = 3;
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.dgvShowAllAddRegistrationFees, 1, 0);
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.pnlClickAddNewFegistrationFees, 1, 1);
            this.tlpMiddleFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddleFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 79);
            this.tlpMiddleFrmAddRegistrationFee.Name = "tlpMiddleFrmAddRegistrationFee";
            this.tlpMiddleFrmAddRegistrationFee.RowCount = 2;
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.24176F));
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.75824F));
            this.tlpMiddleFrmAddRegistrationFee.Size = new System.Drawing.Size(1234, 714);
            this.tlpMiddleFrmAddRegistrationFee.TabIndex = 3;
            // 
            // pnlClickAddNewFegistrationFees
            // 
            this.pnlClickAddNewFegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewFegistrationFees.Controls.Add(this.tlpAddNewRegistrationFees);
            this.pnlClickAddNewFegistrationFees.Location = new System.Drawing.Point(64, 616);
            this.pnlClickAddNewFegistrationFees.Name = "pnlClickAddNewFegistrationFees";
            this.pnlClickAddNewFegistrationFees.Size = new System.Drawing.Size(532, 75);
            this.pnlClickAddNewFegistrationFees.TabIndex = 1;
            // 
            // tlpAddNewRegistrationFees
            // 
            this.tlpAddNewRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewRegistrationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewRegistrationFees.ColumnCount = 2;
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.13095F));
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.86905F));
            this.tlpAddNewRegistrationFees.Controls.Add(this.picAddRegistrationFee, 0, 0);
            this.tlpAddNewRegistrationFees.Controls.Add(this.lblAddRegistrationFees, 1, 0);
            this.tlpAddNewRegistrationFees.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewRegistrationFees.Name = "tlpAddNewRegistrationFees";
            this.tlpAddNewRegistrationFees.RowCount = 1;
            this.tlpAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewRegistrationFees.Size = new System.Drawing.Size(528, 74);
            this.tlpAddNewRegistrationFees.TabIndex = 2;
            // 
            // picAddRegistrationFee
            // 
            this.picAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddRegistrationFee.Image = ((System.Drawing.Image)(resources.GetObject("picAddRegistrationFee.Image")));
            this.picAddRegistrationFee.Location = new System.Drawing.Point(67, 16);
            this.picAddRegistrationFee.Name = "picAddRegistrationFee";
            this.picAddRegistrationFee.Size = new System.Drawing.Size(41, 42);
            this.picAddRegistrationFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddRegistrationFee.TabIndex = 0;
            this.picAddRegistrationFee.TabStop = false;
            // 
            // lblAddRegistrationFees
            // 
            this.lblAddRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddRegistrationFees.AutoSize = true;
            this.lblAddRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRegistrationFees.Location = new System.Drawing.Point(114, 18);
            this.lblAddRegistrationFees.Name = "lblAddRegistrationFees";
            this.lblAddRegistrationFees.Size = new System.Drawing.Size(359, 38);
            this.lblAddRegistrationFees.TabIndex = 1;
            this.lblAddRegistrationFees.Text = "Add New Registration Fees";
            // 
            // tlpTopFrmAddRegistrationFee
            // 
            this.tlpTopFrmAddRegistrationFee.ColumnCount = 2;
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpTopFrmAddRegistrationFee.Controls.Add(this.lblRegistrationFeesFrmAddRegistrationFee, 1, 0);
            this.tlpTopFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 0);
            this.tlpTopFrmAddRegistrationFee.Name = "tlpTopFrmAddRegistrationFee";
            this.tlpTopFrmAddRegistrationFee.RowCount = 1;
            this.tlpTopFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopFrmAddRegistrationFee.Size = new System.Drawing.Size(1234, 79);
            this.tlpTopFrmAddRegistrationFee.TabIndex = 2;
            // 
            // lblRegistrationFeesFrmAddRegistrationFee
            // 
            this.lblRegistrationFeesFrmAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegistrationFeesFrmAddRegistrationFee.AutoSize = true;
            this.lblRegistrationFeesFrmAddRegistrationFee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFeesFrmAddRegistrationFee.Location = new System.Drawing.Point(64, 19);
            this.lblRegistrationFeesFrmAddRegistrationFee.Name = "lblRegistrationFeesFrmAddRegistrationFee";
            this.lblRegistrationFeesFrmAddRegistrationFee.Size = new System.Drawing.Size(252, 41);
            this.lblRegistrationFeesFrmAddRegistrationFee.TabIndex = 0;
            this.lblRegistrationFeesFrmAddRegistrationFee.Text = "Registration Fees";
            // 
            // FrmRegistrationFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 793);
            this.Controls.Add(this.tlpMiddleFrmAddRegistrationFee);
            this.Controls.Add(this.tlpTopFrmAddRegistrationFee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrationFees";
            this.Text = "FrmRegistrationFees";
            this.Load += new System.EventHandler(this.FrmRegistrationFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).EndInit();
            this.tlpMiddleFrmAddRegistrationFee.ResumeLayout(false);
            this.pnlClickAddNewFegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRegistrationFee)).EndInit();
            this.tlpTopFrmAddRegistrationFee.ResumeLayout(false);
            this.tlpTopFrmAddRegistrationFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridView dgvShowAllAddRegistrationFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationFeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deactivate;
        private System.Windows.Forms.TableLayoutPanel tlpMiddleFrmAddRegistrationFee;
        private System.Windows.Forms.Panel pnlClickAddNewFegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewRegistrationFees;
        private System.Windows.Forms.PictureBox picAddRegistrationFee;
        private System.Windows.Forms.Label lblAddRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpTopFrmAddRegistrationFee;
        private System.Windows.Forms.Label lblRegistrationFeesFrmAddRegistrationFee;
    }
}