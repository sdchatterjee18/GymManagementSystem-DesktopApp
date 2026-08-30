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
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(429, 43);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 21);
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
            this.btnClose.Location = new System.Drawing.Point(393, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
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
            this.pnlBody.Location = new System.Drawing.Point(0, 43);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(34, 26, 34, 26);
            this.pnlBody.Size = new System.Drawing.Size(429, 566);
            this.pnlBody.TabIndex = 2;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnConfirmation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmation.Location = new System.Drawing.Point(141, 289);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(102, 28);
            this.btnConfirmation.TabIndex = 11;
            this.btnConfirmation.Text = "CONFIRM";
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // lblResndOTP
            // 
            this.lblResndOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResndOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblResndOTP.Location = new System.Drawing.Point(185, 215);
            this.lblResndOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResndOTP.Name = "lblResndOTP";
            this.lblResndOTP.Size = new System.Drawing.Size(78, 20);
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
            this.pnlPasswordReset.Location = new System.Drawing.Point(51, 326);
            this.pnlPasswordReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPasswordReset.Name = "pnlPasswordReset";
            this.pnlPasswordReset.Size = new System.Drawing.Size(310, 202);
            this.pnlPasswordReset.TabIndex = 9;
            this.pnlPasswordReset.Visible = false;
            // 
            // cbNewPasswordShow
            // 
            this.cbNewPasswordShow.AutoSize = true;
            this.cbNewPasswordShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.cbNewPasswordShow.Location = new System.Drawing.Point(255, 74);
            this.cbNewPasswordShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNewPasswordShow.Name = "cbNewPasswordShow";
            this.cbNewPasswordShow.Size = new System.Drawing.Size(53, 17);
            this.cbNewPasswordShow.TabIndex = 8;
            this.cbNewPasswordShow.Text = "Show";
            this.cbNewPasswordShow.UseVisualStyleBackColor = true;
            this.cbNewPasswordShow.CheckedChanged += new System.EventHandler(this.cbNewPasswordShow_CheckedChanged);
            // 
            // cbComfirmedPasswordShow
            // 
            this.cbComfirmedPasswordShow.AutoSize = true;
            this.cbComfirmedPasswordShow.Location = new System.Drawing.Point(256, 142);
            this.cbComfirmedPasswordShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbComfirmedPasswordShow.Name = "cbComfirmedPasswordShow";
            this.cbComfirmedPasswordShow.Size = new System.Drawing.Size(53, 17);
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
            this.txtNewPassword.Location = new System.Drawing.Point(22, 45);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(279, 25);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Text = "Enter new Password";
            this.txtNewPassword.Click += new System.EventHandler(this.txtNewPassword_Click);
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmedPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmedPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmedPassword.Location = new System.Drawing.Point(22, 113);
            this.txtConfirmedPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.Size = new System.Drawing.Size(279, 25);
            this.txtConfirmedPassword.TabIndex = 6;
            this.txtConfirmedPassword.Text = "Enter Confirm Password";
            this.txtConfirmedPassword.Click += new System.EventHandler(this.txtConfirmedPassword_Click);
            // 
            // lblConfirmedPassword
            // 
            this.lblConfirmedPassword.AutoSize = true;
            this.lblConfirmedPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmedPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblConfirmedPassword.Location = new System.Drawing.Point(19, 87);
            this.lblConfirmedPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmedPassword.Name = "lblConfirmedPassword";
            this.lblConfirmedPassword.Size = new System.Drawing.Size(148, 19);
            this.lblConfirmedPassword.TabIndex = 5;
            this.lblConfirmedPassword.Text = "Confirmed Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblNewPassword.Location = new System.Drawing.Point(19, 18);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(107, 19);
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
            this.btnResetPassword.Location = new System.Drawing.Point(90, 161);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(122, 32);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pbLockIcon
            // 
            this.pbLockIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.pbLockIcon.Location = new System.Drawing.Point(186, 10);
            this.pbLockIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLockIcon.Name = "pbLockIcon";
            this.pbLockIcon.Size = new System.Drawing.Size(52, 52);
            this.pbLockIcon.TabIndex = 0;
            this.pbLockIcon.TabStop = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(124, 66);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(188, 30);
            this.lblForgotPassword.TabIndex = 1;
            this.lblForgotPassword.Text = "Forgot password";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblSubtitle.Location = new System.Drawing.Point(76, 100);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(307, 17);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Enter your registered email to reset your password";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblCountDown.Location = new System.Drawing.Point(70, 180);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(214, 24);
            this.lblCountDown.TabIndex = 3;
            this.lblCountDown.Text = "00:00";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblEmail.Location = new System.Drawing.Point(70, 126);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email address";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(73, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 25);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "name@example.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.lblPhone.Location = new System.Drawing.Point(70, 233);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(36, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOTP.ForeColor = System.Drawing.Color.Gray;
            this.txtOTP.Location = new System.Drawing.Point(73, 258);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOTP.MaxLength = 10;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(279, 25);
            this.txtOTP.TabIndex = 6;
            this.txtOTP.Text = "Enter otp";
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(122)))));
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.ForeColor = System.Drawing.Color.White;
            this.btnSendOTP.Location = new System.Drawing.Point(289, 180);
            this.btnSendOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(62, 24);
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
            this.btnBackToLogin.Location = new System.Drawing.Point(141, 531);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(122, 32);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 609);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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