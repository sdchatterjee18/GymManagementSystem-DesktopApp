namespace GymManagementSystem.FORMS.RegistrationFees
{
    partial class RegFeesForm
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
            this.pnlTopDisplayRegistrationFees = new System.Windows.Forms.Panel();
            this.lblDisplayRegistrationFees = new System.Windows.Forms.Label();
            this.pnlMiddleDisplayRegistrationFees = new System.Windows.Forms.Panel();
            this.dgvDisplayRegistrationFees = new System.Windows.Forms.DataGridView();
            this.pnlButtomDisplayRegistrationFees = new System.Windows.Forms.Panel();
            this.lblDisplayAddNewRegistrationFees = new System.Windows.Forms.Label();
            this.picDisplayAddNewRegistrationFees = new System.Windows.Forms.PictureBox();
            this.pnlTopDisplayRegistrationFees.SuspendLayout();
            this.pnlMiddleDisplayRegistrationFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRegistrationFees)).BeginInit();
            this.pnlButtomDisplayRegistrationFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayAddNewRegistrationFees)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopDisplayRegistrationFees
            // 
            this.pnlTopDisplayRegistrationFees.Controls.Add(this.lblDisplayRegistrationFees);
            this.pnlTopDisplayRegistrationFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDisplayRegistrationFees.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDisplayRegistrationFees.Name = "pnlTopDisplayRegistrationFees";
            this.pnlTopDisplayRegistrationFees.Size = new System.Drawing.Size(812, 71);
            this.pnlTopDisplayRegistrationFees.TabIndex = 0;
            // 
            // lblDisplayRegistrationFees
            // 
            this.lblDisplayRegistrationFees.AutoSize = true;
            this.lblDisplayRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRegistrationFees.Location = new System.Drawing.Point(12, 21);
            this.lblDisplayRegistrationFees.Name = "lblDisplayRegistrationFees";
            this.lblDisplayRegistrationFees.Size = new System.Drawing.Size(233, 38);
            this.lblDisplayRegistrationFees.TabIndex = 0;
            this.lblDisplayRegistrationFees.Text = "Registration Fees";
            // 
            // pnlMiddleDisplayRegistrationFees
            // 
            this.pnlMiddleDisplayRegistrationFees.Controls.Add(this.dgvDisplayRegistrationFees);
            this.pnlMiddleDisplayRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddleDisplayRegistrationFees.Location = new System.Drawing.Point(0, 71);
            this.pnlMiddleDisplayRegistrationFees.Name = "pnlMiddleDisplayRegistrationFees";
            this.pnlMiddleDisplayRegistrationFees.Size = new System.Drawing.Size(812, 493);
            this.pnlMiddleDisplayRegistrationFees.TabIndex = 1;
            // 
            // dgvDisplayRegistrationFees
            // 
            this.dgvDisplayRegistrationFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayRegistrationFees.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplayRegistrationFees.Margin = new System.Windows.Forms.Padding(20);
            this.dgvDisplayRegistrationFees.Name = "dgvDisplayRegistrationFees";
            this.dgvDisplayRegistrationFees.RowTemplate.Height = 24;
            this.dgvDisplayRegistrationFees.Size = new System.Drawing.Size(812, 493);
            this.dgvDisplayRegistrationFees.TabIndex = 0;
            // 
            // pnlButtomDisplayRegistrationFees
            // 
            this.pnlButtomDisplayRegistrationFees.Controls.Add(this.lblDisplayAddNewRegistrationFees);
            this.pnlButtomDisplayRegistrationFees.Controls.Add(this.picDisplayAddNewRegistrationFees);
            this.pnlButtomDisplayRegistrationFees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtomDisplayRegistrationFees.Location = new System.Drawing.Point(0, 485);
            this.pnlButtomDisplayRegistrationFees.Name = "pnlButtomDisplayRegistrationFees";
            this.pnlButtomDisplayRegistrationFees.Size = new System.Drawing.Size(812, 79);
            this.pnlButtomDisplayRegistrationFees.TabIndex = 2;
            // 
            // lblDisplayAddNewRegistrationFees
            // 
            this.lblDisplayAddNewRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayAddNewRegistrationFees.AutoSize = true;
            this.lblDisplayAddNewRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAddNewRegistrationFees.Location = new System.Drawing.Point(174, 32);
            this.lblDisplayAddNewRegistrationFees.Name = "lblDisplayAddNewRegistrationFees";
            this.lblDisplayAddNewRegistrationFees.Size = new System.Drawing.Size(257, 28);
            this.lblDisplayAddNewRegistrationFees.TabIndex = 1;
            this.lblDisplayAddNewRegistrationFees.Text = "Add New Registration Fees";
            this.lblDisplayAddNewRegistrationFees.Click += new System.EventHandler(this.label1_Click);
            // 
            // picDisplayAddNewRegistrationFees
            // 
            this.picDisplayAddNewRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDisplayAddNewRegistrationFees.Location = new System.Drawing.Point(113, 23);
            this.picDisplayAddNewRegistrationFees.Name = "picDisplayAddNewRegistrationFees";
            this.picDisplayAddNewRegistrationFees.Size = new System.Drawing.Size(57, 43);
            this.picDisplayAddNewRegistrationFees.TabIndex = 0;
            this.picDisplayAddNewRegistrationFees.TabStop = false;
            // 
            // RegFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 564);
            this.Controls.Add(this.pnlButtomDisplayRegistrationFees);
            this.Controls.Add(this.pnlMiddleDisplayRegistrationFees);
            this.Controls.Add(this.pnlTopDisplayRegistrationFees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegFeesForm";
            this.Text = "RegFeesForm";
            this.pnlTopDisplayRegistrationFees.ResumeLayout(false);
            this.pnlTopDisplayRegistrationFees.PerformLayout();
            this.pnlMiddleDisplayRegistrationFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayRegistrationFees)).EndInit();
            this.pnlButtomDisplayRegistrationFees.ResumeLayout(false);
            this.pnlButtomDisplayRegistrationFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayAddNewRegistrationFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopDisplayRegistrationFees;
        private System.Windows.Forms.Label lblDisplayRegistrationFees;
        private System.Windows.Forms.Panel pnlMiddleDisplayRegistrationFees;
        private System.Windows.Forms.DataGridView dgvDisplayRegistrationFees;
        private System.Windows.Forms.Panel pnlButtomDisplayRegistrationFees;
        private System.Windows.Forms.Label lblDisplayAddNewRegistrationFees;
        private System.Windows.Forms.PictureBox picDisplayAddNewRegistrationFees;
    }
}