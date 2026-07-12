namespace GymManagementSystem.FORMS.Locker
{
    partial class InsertNewLockerForm
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
            this.pnlNewLockerHeading = new System.Windows.Forms.Panel();
            this.tlpNewLockerHeading = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewLocker = new System.Windows.Forms.Label();
            this.pnlBackSign = new System.Windows.Forms.Panel();
            this.picBoxBack = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tplLockerNumber = new System.Windows.Forms.TableLayoutPanel();
            this.lblLockerNumber = new System.Windows.Forms.Label();
            this.txtBoxLockerNumber = new System.Windows.Forms.TextBox();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlNewLockerHeading.SuspendLayout();
            this.tlpNewLockerHeading.SuspendLayout();
            this.pnlBackSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tplLockerNumber.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlNewLockerHeading
            //
            this.pnlNewLockerHeading.Controls.Add(this.tlpNewLockerHeading);
            this.pnlNewLockerHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewLockerHeading.Location = new System.Drawing.Point(0, 0);
            this.pnlNewLockerHeading.Name = "pnlNewLockerHeading";
            this.pnlNewLockerHeading.Size = new System.Drawing.Size(1041, 82);
            this.pnlNewLockerHeading.TabIndex = 0;
            //
            // tlpNewLockerHeading
            //
            this.tlpNewLockerHeading.ColumnCount = 2;
            this.tlpNewLockerHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04673F));
            this.tlpNewLockerHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.95327F));
            this.tlpNewLockerHeading.Controls.Add(this.lblNewLocker, 1, 0);
            this.tlpNewLockerHeading.Controls.Add(this.pnlBackSign, 0, 0);
            this.tlpNewLockerHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewLockerHeading.Location = new System.Drawing.Point(0, 0);
            this.tlpNewLockerHeading.Name = "tlpNewLockerHeading";
            this.tlpNewLockerHeading.RowCount = 1;
            this.tlpNewLockerHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNewLockerHeading.Size = new System.Drawing.Size(1041, 82);
            this.tlpNewLockerHeading.TabIndex = 0;
            //
            // lblNewLocker
            //
            this.lblNewLocker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewLocker.AutoSize = true;
            this.lblNewLocker.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocker.Location = new System.Drawing.Point(107, 14);
            this.lblNewLocker.Name = "lblNewLocker";
            this.lblNewLocker.Size = new System.Drawing.Size(235, 54);
            this.lblNewLocker.TabIndex = 1;
            this.lblNewLocker.Text = "New Locker";
            //
            // pnlBackSign
            //
            this.pnlBackSign.Controls.Add(this.picBoxBack);
            this.pnlBackSign.Location = new System.Drawing.Point(3, 3);
            this.pnlBackSign.Name = "pnlBackSign";
            this.pnlBackSign.Size = new System.Drawing.Size(98, 76);
            this.pnlBackSign.TabIndex = 2;
            //
            // picBoxBack
            //
            this.picBoxBack.BackgroundImage = global::GymManagementSystem.Properties.Resources.ChatGPT_Image_Jul_12__2026__04_16_02_PM_removebg_preview;
            this.picBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBack.Location = new System.Drawing.Point(0, 0);
            this.picBoxBack.Name = "picBoxBack";
            this.picBoxBack.Size = new System.Drawing.Size(98, 76);
            this.picBoxBack.TabIndex = 1;
            this.picBoxBack.TabStop = false;
            //
            // pnlMain
            //
            this.pnlMain.Controls.Add(this.tplLockerNumber); 
            this.pnlMain.Controls.Add(this.pnlSpacer);       
            this.pnlMain.Controls.Add(this.pnlButton);       
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 82);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlMain.Size = new System.Drawing.Size(1041, 394);
            this.pnlMain.TabIndex = 1;
            //
            // tplLockerNumber
            //
            this.tplLockerNumber.ColumnCount = 2;
            this.tplLockerNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.09379F));
            this.tplLockerNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.90621F));
            this.tplLockerNumber.Controls.Add(this.lblLockerNumber, 0, 0);
            this.tplLockerNumber.Controls.Add(this.txtBoxLockerNumber, 1, 0);
            this.tplLockerNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplLockerNumber.Location = new System.Drawing.Point(20, 0);
            this.tplLockerNumber.Name = "tplLockerNumber";
            this.tplLockerNumber.RowCount = 2;
            this.tplLockerNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLockerNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLockerNumber.Size = new System.Drawing.Size(1001, 259);
            this.tplLockerNumber.TabIndex = 0;
            //
            // lblLockerNumber
            //
            this.lblLockerNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLockerNumber.AutoSize = true;
            this.lblLockerNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockerNumber.ForeColor = System.Drawing.Color.Silver;
            this.lblLockerNumber.Location = new System.Drawing.Point(198, 181);
            this.lblLockerNumber.Name = "lblLockerNumber";
            this.lblLockerNumber.Size = new System.Drawing.Size(196, 32);
            this.lblLockerNumber.TabIndex = 0;
            this.lblLockerNumber.Text = "Locker Number :";
            //
            // txtBoxLockerNumber
            //
            this.txtBoxLockerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLockerNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLockerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.txtBoxLockerNumber.Location = new System.Drawing.Point(407, 174);
            this.txtBoxLockerNumber.Name = "txtBoxLockerNumber";
            this.txtBoxLockerNumber.Size = new System.Drawing.Size(573, 45);
            this.txtBoxLockerNumber.TabIndex = 1;
            //
            // pnlSpacer
            //
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpacer.Height = 20;
            this.pnlSpacer.Location = new System.Drawing.Point(20, 239);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(1001, 20);
            this.pnlSpacer.TabIndex = 2;
            //
            // pnlButton
            //
            this.pnlButton.Controls.Add(this.btnSubmit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(20, 259);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1001, 135);
            this.pnlButton.TabIndex = 1;
            //
            // btnSubmit
            //
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(86)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(20, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(961, 67);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            //
            // InsertNewLockerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1041, 476);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNewLockerHeading);
            this.ForeColor = System.Drawing.Color.Wheat;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertNewLockerForm";
            this.Text = "InsertNewLockerForm";
            this.pnlNewLockerHeading.ResumeLayout(false);
            this.tlpNewLockerHeading.ResumeLayout(false);
            this.tlpNewLockerHeading.PerformLayout();
            this.pnlBackSign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tplLockerNumber.ResumeLayout(false);
            this.tplLockerNumber.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewLockerHeading;
        private System.Windows.Forms.TableLayoutPanel tlpNewLockerHeading;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tplLockerNumber;
        private System.Windows.Forms.Label lblLockerNumber;
        private System.Windows.Forms.TextBox txtBoxLockerNumber;
        private System.Windows.Forms.Label lblNewLocker;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlBackSign;
        private System.Windows.Forms.PictureBox picBoxBack;
    }
}