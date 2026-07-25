namespace GymManagementSystem.FORMS.Locker
{
    partial class FrmAddLocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLocker));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLockerNumber = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.picBoxSendIcon = new System.Windows.Forms.PictureBox();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picBoxLockerIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSendIcon)).BeginInit();
            this.tlpHeading.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(4, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Locker";
            // 
            // txtLockerNumber
            // 
            this.txtLockerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLockerNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLockerNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLockerNumber.Location = new System.Drawing.Point(42, 153);
            this.txtLockerNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLockerNumber.Name = "txtLockerNumber";
            this.txtLockerNumber.Size = new System.Drawing.Size(293, 39);
            this.txtLockerNumber.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblAsterisk);
            this.pnlMain.Controls.Add(this.tlpButton);
            this.pnlMain.Controls.Add(this.lblAddNewLocker);
            this.pnlMain.Controls.Add(this.tlpHeading);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.txtLockerNumber);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(600, 350);
            this.pnlMain.TabIndex = 0;
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk.Location = new System.Drawing.Point(192, 117);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(15, 20);
            this.lblAsterisk.TabIndex = 10;
            this.lblAsterisk.Text = "*";
            // 
            // tlpButton
            // 
            this.tlpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2069F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.79311F));
            this.tlpButton.Controls.Add(this.pnlButton, 1, 0);
            this.tlpButton.Controls.Add(this.picBoxSendIcon, 0, 0);
            this.tlpButton.Location = new System.Drawing.Point(376, 268);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(145, 41);
            this.tlpButton.TabIndex = 9;
            this.tlpButton.Click += new System.EventHandler(this.tlpButton_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.lblSubmit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(40, 3);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(102, 35);
            this.pnlButton.TabIndex = 0;
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.ForeColor = System.Drawing.Color.White;
            this.lblSubmit.Location = new System.Drawing.Point(5, 1);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(92, 32);
            this.lblSubmit.TabIndex = 0;
            this.lblSubmit.Text = "Submit";
            // 
            // picBoxSendIcon
            // 
            this.picBoxSendIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSendIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSendIcon.BackgroundImage")));
            this.picBoxSendIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSendIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxSendIcon.Location = new System.Drawing.Point(3, 3);
            this.picBoxSendIcon.Name = "picBoxSendIcon";
            this.picBoxSendIcon.Size = new System.Drawing.Size(31, 35);
            this.picBoxSendIcon.TabIndex = 1;
            this.picBoxSendIcon.TabStop = false;
            // 
            // lblAddNewLocker
            // 
            this.lblAddNewLocker.AutoSize = true;
            this.lblAddNewLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewLocker.Location = new System.Drawing.Point(35, 113);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(159, 28);
            this.lblAddNewLocker.TabIndex = 7;
            this.lblAddNewLocker.Text = "Add new Locker";
            // 
            // tlpHeading
            // 
            this.tlpHeading.ColumnCount = 3;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.07358F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25663F));
            this.tlpHeading.Controls.Add(this.tlpTitle, 1, 0);
            this.tlpHeading.Controls.Add(this.picBoxLockerIcon, 0, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(598, 76);
            this.tlpHeading.TabIndex = 6;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Controls.Add(this.lblSubtitle, 0, 1);
            this.tlpTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(72, 3);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 2;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitle.Size = new System.Drawing.Size(425, 70);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubtitle.Location = new System.Drawing.Point(4, 35);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(151, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Adding new Locker";
            // 
            // picBoxLockerIcon
            // 
            this.picBoxLockerIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLockerIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLockerIcon.BackgroundImage")));
            this.picBoxLockerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLockerIcon.Location = new System.Drawing.Point(13, 13);
            this.picBoxLockerIcon.MaximumSize = new System.Drawing.Size(43, 50);
            this.picBoxLockerIcon.MinimumSize = new System.Drawing.Size(43, 50);
            this.picBoxLockerIcon.Name = "picBoxLockerIcon";
            this.picBoxLockerIcon.Size = new System.Drawing.Size(43, 50);
            this.picBoxLockerIcon.TabIndex = 1;
            this.picBoxLockerIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(732, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmAddLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddLocker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSendIcon)).EndInit();
            this.tlpHeading.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLockerNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tlpHeading;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblAddNewLocker;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Label lblAsterisk;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.PictureBox picBoxSendIcon;
        private System.Windows.Forms.PictureBox picBoxLockerIcon;
    }
}