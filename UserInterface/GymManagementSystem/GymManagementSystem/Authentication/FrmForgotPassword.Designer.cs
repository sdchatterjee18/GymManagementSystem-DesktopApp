namespace GymManagementSystem.Authentication
{
    partial class FrmForgotPassword
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.lblResndOTP = new System.Windows.Forms.Label();
            this.pnlPasswordReset = new System.Windows.Forms.Panel();
            this.cbNewPasswordShow = new System.Windows.Forms.CheckBox();
            this.cbComfirmedPasswordShow = new System.Windows.Forms.CheckBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmedPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmedPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pbLockIcon = new System.Windows.Forms.PictureBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnSendOTP = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPasswordReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(572, 53);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gym Management System - Forgot Password";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(524, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.btnConfirmation);
            this.pnlBody.Controls.Add(this.lblResndOTP);
            this.pnlBody.Controls.Add(this.pnlPasswordReset);
            this.pnlBody.Controls.Add(this.pbLockIcon);
            this.pnlBody.Controls.Add(this.lblForgotPassword);
            this.pnlBody.Controls.Add(this.lblSubtitle);
            this.pnlBody.Controls.Add(this.lblCountDown);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblPhone);
            this.pnlBody.Controls.Add(this.txtOTP);
            this.pnlBody.Controls.Add(this.btnSendOTP);
            this.pnlBody.Controls.Add(this.btnBackToLogin);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 53);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(45, 32, 45, 32);
            this.pnlBody.Size = new System.Drawing.Size(572, 697);
            this.pnlBody.TabIndex = 2;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnConfirmation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmation.Location = new System.Drawing.Point(188, 356);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(136, 34);
            this.btnConfirmation.TabIndex = 11;
            this.btnConfirmation.Text = "CONFIRM";
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // lblResndOTP
            // 
            this.lblResndOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResndOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblResndOTP.Location = new System.Drawing.Point(247, 265);
            this.lblResndOTP.Name = "lblResndOTP";
            this.lblResndOTP.Size = new System.Drawing.Size(104, 25);
            this.lblResndOTP.TabIndex = 10;
            this.lblResndOTP.Text = "Resend OTP";
            this.lblResndOTP.Click += new System.EventHandler(this.lblResndOTP_Click);
            // 
            // pnlPasswordReset
            // 
            this.pnlPasswordReset.Controls.Add(this.cbNewPasswordShow);
            this.pnlPasswordReset.Controls.Add(this.cbComfirmedPasswordShow);
            this.pnlPasswordReset.Controls.Add(this.txtNewPassword);
            this.pnlPasswordReset.Controls.Add(this.txtConfirmedPassword);
            this.pnlPasswordReset.Controls.Add(this.lblConfirmedPassword);
            this.pnlPasswordReset.Controls.Add(this.lblNewPassword);
            this.pnlPasswordReset.Controls.Add(this.btnResetPassword);
            this.pnlPasswordReset.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPasswordReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.pnlPasswordReset.Location = new System.Drawing.Point(68, 401);
            this.pnlPasswordReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPasswordReset.Name = "pnlPasswordReset";
            this.pnlPasswordReset.Size = new System.Drawing.Size(413, 249);
            this.pnlPasswordReset.TabIndex = 9;
            this.pnlPasswordReset.Visible = false;
            // 
            // cbNewPasswordShow
            // 
            this.cbNewPasswordShow.AutoSize = true;
            this.cbNewPasswordShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.cbNewPasswordShow.Location = new System.Drawing.Point(340, 91);
            this.cbNewPasswordShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNewPasswordShow.Name = "cbNewPasswordShow";
            this.cbNewPasswordShow.Size = new System.Drawing.Size(66, 23);
            this.cbNewPasswordShow.TabIndex = 8;
            this.cbNewPasswordShow.Text = "Show";
            this.cbNewPasswordShow.UseVisualStyleBackColor = true;
            this.cbNewPasswordShow.CheckedChanged += new System.EventHandler(this.cbNewPasswordShow_CheckedChanged);
            // 
            // cbComfirmedPasswordShow
            // 
            this.cbComfirmedPasswordShow.AutoSize = true;
            this.cbComfirmedPasswordShow.Location = new System.Drawing.Point(341, 175);
            this.cbComfirmedPasswordShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbComfirmedPasswordShow.Name = "cbComfirmedPasswordShow";
            this.cbComfirmedPasswordShow.Size = new System.Drawing.Size(66, 23);
            this.cbComfirmedPasswordShow.TabIndex = 8;
            this.cbComfirmedPasswordShow.Text = "Show";
            this.cbComfirmedPasswordShow.UseVisualStyleBackColor = true;
            this.cbComfirmedPasswordShow.CheckedChanged += new System.EventHandler(this.cbComfirmedPasswordShow_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPassword.Location = new System.Drawing.Point(29, 55);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(371, 30);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Text = "Enter new Password";
            this.txtNewPassword.Click += new System.EventHandler(this.txtNewPassword_Click);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmedPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmedPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmedPassword.Location = new System.Drawing.Point(29, 139);
            this.txtConfirmedPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.Size = new System.Drawing.Size(371, 30);
            this.txtConfirmedPassword.TabIndex = 6;
            this.txtConfirmedPassword.Text = "Enter Confirm Password";
            this.txtConfirmedPassword.Click += new System.EventHandler(this.txtConfirmedPassword_Click);
            this.txtConfirmedPassword.Leave += new System.EventHandler(this.txtConfirmedPassword_Leave);
            // 
            // lblConfirmedPassword
            // 
            this.lblConfirmedPassword.AutoSize = true;
            this.lblConfirmedPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmedPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblConfirmedPassword.Location = new System.Drawing.Point(25, 107);
            this.lblConfirmedPassword.Name = "lblConfirmedPassword";
            this.lblConfirmedPassword.Size = new System.Drawing.Size(176, 23);
            this.lblConfirmedPassword.TabIndex = 5;
            this.lblConfirmedPassword.Text = "Confirmed Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblNewPassword.Location = new System.Drawing.Point(25, 22);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(126, 23);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(120, 198);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(163, 39);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pbLockIcon
            // 
            this.pbLockIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.pbLockIcon.Location = new System.Drawing.Point(248, 12);
            this.pbLockIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLockIcon.Name = "pbLockIcon";
            this.pbLockIcon.Size = new System.Drawing.Size(69, 64);
            this.pbLockIcon.TabIndex = 0;
            this.pbLockIcon.TabStop = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(165, 81);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(234, 37);
            this.lblForgotPassword.TabIndex = 1;
            this.lblForgotPassword.Text = "Forgot password";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblSubtitle.Location = new System.Drawing.Point(101, 123);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(361, 21);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Enter your registered email to reset your password";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblCountDown.Location = new System.Drawing.Point(93, 222);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(285, 30);
            this.lblCountDown.TabIndex = 3;
            this.lblCountDown.Text = "00:00";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblEmail.Location = new System.Drawing.Point(93, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email address";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(97, 185);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 30);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "name@example.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblPhone.Location = new System.Drawing.Point(93, 287);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(42, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOTP.ForeColor = System.Drawing.Color.Gray;
            this.txtOTP.Location = new System.Drawing.Point(97, 318);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOTP.MaxLength = 10;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(371, 30);
            this.txtOTP.TabIndex = 6;
            this.txtOTP.Text = "Enter otp";
            this.txtOTP.Click += new System.EventHandler(this.txtOTP_Click);
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.ForeColor = System.Drawing.Color.White;
            this.btnSendOTP.Location = new System.Drawing.Point(385, 222);
            this.btnSendOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(83, 30);
            this.btnSendOTP.TabIndex = 7;
            this.btnSendOTP.Text = "Send OTP";
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.White;
            this.btnBackToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnBackToLogin.Location = new System.Drawing.Point(188, 654);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(163, 39);
            this.btnBackToLogin.TabIndex = 8;
            this.btnBackToLogin.Text = "Back to login";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 750);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmForgotPassword";
            this.Load += new System.EventHandler(this.FrmForgotPassword_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlPasswordReset.ResumeLayout(false);
            this.pnlPasswordReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Label lblResndOTP;
        private System.Windows.Forms.Panel pnlPasswordReset;
        private System.Windows.Forms.CheckBox cbNewPasswordShow;
        private System.Windows.Forms.CheckBox cbComfirmedPasswordShow;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmedPassword;
        private System.Windows.Forms.Label lblConfirmedPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox pbLockIcon;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Timer timer1;
    }
}