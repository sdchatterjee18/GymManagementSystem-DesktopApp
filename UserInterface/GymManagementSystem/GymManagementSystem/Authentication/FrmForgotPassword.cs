using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.Authentication.UI;
using System.Net.Mail;
using System.Net;
using GymManagementSystem.Common;

namespace GymManagementSystem.Authentication
{
    public partial class FrmForgotPassword : Form
    {
        private string UserEmail;
        private string GeneratedOTP;
        int CountDown = 30;
        int ClickCountTxtNewPassword= 0;
        int ClickCountTxtConfirmedPassword = 0;
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string Message = null;

            AuthenticationUI authenticationUI = new AuthenticationUI();
            authenticationUI.EmailId = txtEmail.Text.Trim();
            UserEmail = txtEmail.Text.Trim();
            Message = authenticationUI.MatchEmailIdFromDatabaseUI();
            if(Message == "NotFound")
            {
                MessageBox.Show("This Email Id does not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Message == "Active")
            {
                GenerateAndSendOTP();
                CountDownStart();
                ClearOTPTextBox();
            }
            else
            {

            }
        }
        //Generate and send otp
        private void GenerateAndSendOTP()
        {
            Random random = new Random();
            GeneratedOTP = random.Next(100000, 999999).ToString();
            try
            {
                SendOTPEmail(UserEmail, GeneratedOTP);
                MessageBox.Show("OTP has been set to your email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 

        private void SendOTPEmail(string recipientEmail, string otp)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("sanukhaskel2004@gmail.com", "xhee olyl hagf ikjg");


            MailMessage message = new MailMessage();
            message.From = new MailAddress("sanukhaskel2004@gmail.com");
            message.To.Add(recipientEmail);
            message.Subject = "Credential OTP Verification";
            message.Body = "Your OTP is" + otp;
            client.Send(message);
        } 

        //Count down start
        private void CountDownStart()
        {
            lblResndOTP.Enabled = false;
            CountDown = 30;
            timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        //Clear otp text box
        private void ClearOTPTextBox()
        {
            txtOTP.Clear();
        }
        //Get Entered OTP
        private string GetEnteredOTP()
        {
            return txtOTP.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountDown > 0)
            {
                lblCountDown.Text = "Resend OTP in :" + CountDown + "seconds";
                CountDown--;
            }
            else
            {
                timer1.Stop();
                lblResndOTP.Enabled = true;
                lblCountDown.Text = "Re-send OTP";
            }
        }

        private void lblResndOTP_Click(object sender, EventArgs e)
        {
            GenerateAndSendOTP();
            CountDownStart();
            ClearOTPTextBox();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            string enteredOTP = GetEnteredOTP();
            if (enteredOTP == GeneratedOTP)
            {
                DialogResult result = MessageBox.Show("OTP verification Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    pnlPasswordReset.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNewPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !cbNewPasswordShow.Checked;
        }

        private void cbComfirmedPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmedPassword.UseSystemPasswordChar = !cbComfirmedPasswordShow.Checked;
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtNewPassword =
            ValidationUI.ClearTextBoxWhenClicked(
                txtNewPassword,
                ClickCountTxtNewPassword);

            txtNewPassword.ForeColor =
                Color.Black;
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void txtConfirmedPassword_Click(object sender, EventArgs e)
        {
            ClickCountTxtConfirmedPassword =
            ValidationUI.ClearTextBoxWhenClicked(
                txtConfirmedPassword,
                ClickCountTxtConfirmedPassword);

            txtConfirmedPassword.ForeColor =
                Color.Black;
            txtConfirmedPassword.UseSystemPasswordChar = true;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            int Click = 1;
            if (Click == 1)
            {
                txtEmail.Clear();
                Click++;
            }
        }

        public string ChangePasswordByEmailId()
        {
            string Message = null;
            AuthenticationUI authenticationUI = new AuthenticationUI();
            authenticationUI.EmailId = txtEmail.Text.Trim();
            authenticationUI.NewPassword = txtNewPassword.Text.Trim();
            authenticationUI.ConfirmedPassword = txtConfirmedPassword.Text.Trim();
            try
            {
                Message = authenticationUI.ChangePasswordByEmailIdUI();
                return Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string Message = ChangePasswordByEmailId();
            if (Message == "New Password and Confirm Password do not match.")
            {
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Message == "Password is Updated Successfully")
            {
                MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password Fail to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
    }
}
