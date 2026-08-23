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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLocker));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLockerNumber = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlsubmit = new System.Windows.Forms.Panel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.picSubmit = new System.Windows.Forms.PictureBox();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.lblAddNewLocker = new System.Windows.Forms.Label();
            this.tlpHeading = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picBoxLockerIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlsubmit.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).BeginInit();
            this.tlpHeading.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Locker";
            // 
            // txtLockerNumber
            // 
            this.txtLockerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLockerNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLockerNumber.ForeColor = System.Drawing.Color.Black;
            this.txtLockerNumber.Location = new System.Drawing.Point(26, 99);
            this.txtLockerNumber.Name = "txtLockerNumber";
            this.txtLockerNumber.Size = new System.Drawing.Size(196, 29);
            this.txtLockerNumber.TabIndex = 2;
            this.txtLockerNumber.Click += new System.EventHandler(this.txtLockerNumber_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlsubmit);
            this.pnlMain.Controls.Add(this.lblAsterisk);
            this.pnlMain.Controls.Add(this.lblAddNewLocker);
            this.pnlMain.Controls.Add(this.tlpHeading);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.txtLockerNumber);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(344, 191);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlsubmit
            // 
            this.pnlsubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsubmit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsubmit.Controls.Add(this.tlpButton);
            this.pnlsubmit.Location = new System.Drawing.Point(253, 154);
            this.pnlsubmit.Name = "pnlsubmit";
            this.pnlsubmit.Size = new System.Drawing.Size(79, 25);
            this.pnlsubmit.TabIndex = 11;
            this.pnlsubmit.Click += new System.EventHandler(this.tlpButton_Click);
            // 
            // tlpButton
            // 
            this.tlpButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2069F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.79311F));
            this.tlpButton.Controls.Add(this.pnlButton, 1, 0);
            this.tlpButton.Controls.Add(this.picSubmit, 0, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(0, 0);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(77, 23);
            this.tlpButton.TabIndex = 9;
            this.tlpButton.Click += new System.EventHandler(this.tlpButton_Click);
            this.tlpButton.MouseEnter += new System.EventHandler(this.tlpButton_MouseEnter);
            this.tlpButton.MouseLeave += new System.EventHandler(this.tlpButton_MouseLeave);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.lblSubmit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(22, 2);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(53, 19);
            this.pnlButton.TabIndex = 0;
            this.pnlButton.Click += new System.EventHandler(this.tlpButton_Click);
            this.pnlButton.MouseEnter += new System.EventHandler(this.tlpButton_MouseEnter);
            this.pnlButton.MouseLeave += new System.EventHandler(this.tlpButton_MouseLeave);
            // 
            // lblSubmit
            // 
            this.lblSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.ForeColor = System.Drawing.Color.White;
            this.lblSubmit.Location = new System.Drawing.Point(-2, 3);
            this.lblSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(46, 15);
            this.lblSubmit.TabIndex = 0;
            this.lblSubmit.Text = "Submit";
            this.lblSubmit.Click += new System.EventHandler(this.tlpButton_Click);
            this.lblSubmit.MouseEnter += new System.EventHandler(this.tlpButton_MouseEnter);
            this.lblSubmit.MouseLeave += new System.EventHandler(this.tlpButton_MouseLeave);
            // 
            // picSubmit
            // 
            this.picSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picSubmit.BackColor = System.Drawing.Color.Transparent;
            this.picSubmit.Image = global::GymManagementSystem.Properties.Resources.paper_plane;
            this.picSubmit.Location = new System.Drawing.Point(5, 0);
            this.picSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.picSubmit.Name = "picSubmit";
            this.picSubmit.Size = new System.Drawing.Size(15, 23);
            this.picSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSubmit.TabIndex = 1;
            this.picSubmit.TabStop = false;
            this.picSubmit.Click += new System.EventHandler(this.tlpButton_Click);
            this.picSubmit.MouseEnter += new System.EventHandler(this.tlpButton_MouseEnter);
            this.picSubmit.MouseLeave += new System.EventHandler(this.tlpButton_MouseLeave);
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk.Location = new System.Drawing.Point(128, 76);
            this.lblAsterisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblAsterisk.TabIndex = 10;
            this.lblAsterisk.Text = "*";
            // 
            // lblAddNewLocker
            // 
            this.lblAddNewLocker.AutoSize = true;
            this.lblAddNewLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewLocker.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAddNewLocker.Location = new System.Drawing.Point(23, 73);
            this.lblAddNewLocker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewLocker.Name = "lblAddNewLocker";
            this.lblAddNewLocker.Size = new System.Drawing.Size(109, 19);
            this.lblAddNewLocker.TabIndex = 7;
            this.lblAddNewLocker.Text = "Add new Locker";
            // 
            // tlpHeading
            // 
            this.tlpHeading.ColumnCount = 3;
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.53488F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.89535F));
            this.tlpHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25663F));
            this.tlpHeading.Controls.Add(this.tlpTitle, 1, 0);
            this.tlpHeading.Controls.Add(this.picBoxLockerIcon, 0, 0);
            this.tlpHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpHeading.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHeading.Name = "tlpHeading";
            this.tlpHeading.RowCount = 1;
            this.tlpHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeading.Size = new System.Drawing.Size(344, 49);
            this.tlpHeading.TabIndex = 6;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Controls.Add(this.lblSubtitle, 0, 1);
            this.tlpTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(52, 2);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 2;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpTitle.Size = new System.Drawing.Size(233, 45);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubtitle.Location = new System.Drawing.Point(3, 26);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(87, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Add new Locker";
            // 
            // picBoxLockerIcon
            // 
            this.picBoxLockerIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picBoxLockerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLockerIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLockerIcon.Image")));
            this.picBoxLockerIcon.Location = new System.Drawing.Point(21, 11);
            this.picBoxLockerIcon.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.picBoxLockerIcon.MaximumSize = new System.Drawing.Size(29, 32);
            this.picBoxLockerIcon.MinimumSize = new System.Drawing.Size(29, 32);
            this.picBoxLockerIcon.Name = "picBoxLockerIcon";
            this.picBoxLockerIcon.Size = new System.Drawing.Size(29, 32);
            this.picBoxLockerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLockerIcon.TabIndex = 1;
            this.picBoxLockerIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(488, 124);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 191);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 220);
            this.Name = "FrmAddLocker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlsubmit.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSubmit)).EndInit();
            this.tlpHeading.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLockerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.PictureBox picBoxLockerIcon;
        private System.Windows.Forms.PictureBox picSubmit;
        private System.Windows.Forms.Panel pnlsubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}