namespace GymManagementSystem.FORMS.MembershipPlan
{
    partial class FrmAddMembershipPlans
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpNewMembarshipPlanDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblPlanType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.cmbPlanType = new System.Windows.Forms.ComboBox();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlSubNewMembarshipPlanTitle = new System.Windows.Forms.Panel();
            this.tlpMainNewMembarshipPlanTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewMembarshipPlanTitle = new System.Windows.Forms.Label();
            this.btnPageRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tlpNewMembarshipPlanDetails.SuspendLayout();
            this.pnlSubNewMembarshipPlanTitle.SuspendLayout();
            this.tlpMainNewMembarshipPlanTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpNewMembarshipPlanDetails);
            this.panel1.Controls.Add(this.pnlSubNewMembarshipPlanTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 534);
            this.panel1.TabIndex = 0;
            // 
            // tlpNewMembarshipPlanDetails
            // 
            this.tlpNewMembarshipPlanDetails.ColumnCount = 4;
            this.tlpNewMembarshipPlanDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.80788F));
            this.tlpNewMembarshipPlanDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.19212F));
            this.tlpNewMembarshipPlanDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tlpNewMembarshipPlanDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.lblPlanName, 1, 0);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.lblPlanType, 1, 1);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.lblDuration, 1, 2);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.lblAmount, 1, 3);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.lblDescription, 1, 4);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.txtAmount, 2, 3);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.txtDescription, 2, 4);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.txtPlanName, 2, 0);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.cmbPlanType, 2, 1);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.cmbDuration, 2, 2);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.btnClear, 1, 5);
            this.tlpNewMembarshipPlanDetails.Controls.Add(this.btnSubmit, 2, 5);
            this.tlpNewMembarshipPlanDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNewMembarshipPlanDetails.Location = new System.Drawing.Point(0, 84);
            this.tlpNewMembarshipPlanDetails.Name = "tlpNewMembarshipPlanDetails";
            this.tlpNewMembarshipPlanDetails.RowCount = 6;
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpNewMembarshipPlanDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpNewMembarshipPlanDetails.Size = new System.Drawing.Size(577, 410);
            this.tlpNewMembarshipPlanDetails.TabIndex = 1;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanName.Location = new System.Drawing.Point(25, 0);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(122, 28);
            this.lblPlanName.TabIndex = 0;
            this.lblPlanName.Text = "Plan Name :";
            // 
            // lblPlanType
            // 
            this.lblPlanType.AutoSize = true;
            this.lblPlanType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanType.Location = new System.Drawing.Point(25, 54);
            this.lblPlanType.Name = "lblPlanType";
            this.lblPlanType.Size = new System.Drawing.Size(111, 28);
            this.lblPlanType.TabIndex = 0;
            this.lblPlanType.Text = "Plan Type :";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(25, 108);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(102, 28);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(25, 167);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 28);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(25, 232);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 28);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description :";
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(175, 170);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(308, 30);
            this.txtAmount.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(175, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(308, 92);
            this.txtDescription.TabIndex = 1;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanName.Location = new System.Drawing.Point(175, 3);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(308, 30);
            this.txtPlanName.TabIndex = 2;
            // 
            // cmbPlanType
            // 
            this.cmbPlanType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPlanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanType.FormattingEnabled = true;
            this.cmbPlanType.Location = new System.Drawing.Point(175, 57);
            this.cmbPlanType.Name = "cmbPlanType";
            this.cmbPlanType.Size = new System.Drawing.Size(308, 33);
            this.cmbPlanType.TabIndex = 3;
            // 
            // cmbDuration
            // 
            this.cmbDuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Location = new System.Drawing.Point(175, 111);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(308, 33);
            this.cmbDuration.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(84, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(391, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // pnlSubNewMembarshipPlanTitle
            // 
            this.pnlSubNewMembarshipPlanTitle.Controls.Add(this.tlpMainNewMembarshipPlanTitle);
            this.pnlSubNewMembarshipPlanTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubNewMembarshipPlanTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubNewMembarshipPlanTitle.Name = "pnlSubNewMembarshipPlanTitle";
            this.pnlSubNewMembarshipPlanTitle.Size = new System.Drawing.Size(577, 84);
            this.pnlSubNewMembarshipPlanTitle.TabIndex = 0;
            // 
            // tlpMainNewMembarshipPlanTitle
            // 
            this.tlpMainNewMembarshipPlanTitle.ColumnCount = 3;
            this.tlpMainNewMembarshipPlanTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.190476F));
            this.tlpMainNewMembarshipPlanTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.80952F));
            this.tlpMainNewMembarshipPlanTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpMainNewMembarshipPlanTitle.Controls.Add(this.lblNewMembarshipPlanTitle, 1, 0);
            this.tlpMainNewMembarshipPlanTitle.Controls.Add(this.btnPageRemove, 2, 0);
            this.tlpMainNewMembarshipPlanTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMainNewMembarshipPlanTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpMainNewMembarshipPlanTitle.Name = "tlpMainNewMembarshipPlanTitle";
            this.tlpMainNewMembarshipPlanTitle.RowCount = 1;
            this.tlpMainNewMembarshipPlanTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainNewMembarshipPlanTitle.Size = new System.Drawing.Size(577, 61);
            this.tlpMainNewMembarshipPlanTitle.TabIndex = 0;
            // 
            // lblNewMembarshipPlanTitle
            // 
            this.lblNewMembarshipPlanTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewMembarshipPlanTitle.AutoSize = true;
            this.lblNewMembarshipPlanTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMembarshipPlanTitle.Location = new System.Drawing.Point(25, 14);
            this.lblNewMembarshipPlanTitle.Name = "lblNewMembarshipPlanTitle";
            this.lblNewMembarshipPlanTitle.Size = new System.Drawing.Size(261, 32);
            this.lblNewMembarshipPlanTitle.TabIndex = 0;
            this.lblNewMembarshipPlanTitle.Text = "New Membarship Plan";
            // 
            // btnPageRemove
            // 
            this.btnPageRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageRemove.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageRemove.Location = new System.Drawing.Point(542, 3);
            this.btnPageRemove.Name = "btnPageRemove";
            this.btnPageRemove.Size = new System.Drawing.Size(32, 35);
            this.btnPageRemove.TabIndex = 1;
            this.btnPageRemove.Text = "X";
            this.btnPageRemove.UseVisualStyleBackColor = true;
            // 
            // FrmAddMembershipPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 534);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(595, 581);
            this.Name = "FrmAddMembershipPlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMembershipPlans";
            this.Load += new System.EventHandler(this.FrmAddMembershipPlans_Load);
            this.panel1.ResumeLayout(false);
            this.tlpNewMembarshipPlanDetails.ResumeLayout(false);
            this.tlpNewMembarshipPlanDetails.PerformLayout();
            this.pnlSubNewMembarshipPlanTitle.ResumeLayout(false);
            this.tlpMainNewMembarshipPlanTitle.ResumeLayout(false);
            this.tlpMainNewMembarshipPlanTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpNewMembarshipPlanDetails;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblPlanType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.ComboBox cmbPlanType;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlSubNewMembarshipPlanTitle;
        private System.Windows.Forms.TableLayoutPanel tlpMainNewMembarshipPlanTitle;
        private System.Windows.Forms.Label lblNewMembarshipPlanTitle;
        private System.Windows.Forms.Button btnPageRemove;
    }
}