using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.FORMS.MembershipPlan.UI;
using GymManagementSystem.Common;


namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmMembershipRenewal : Form
    {
        string RenewalConfirmationMessage = "Are you sure for renewal subscription plan ?";
        public int MembershipPlanId;
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmMembershipRenewal( MemberAllDetailsUI member)
        {
            this.memberAllDetailsUI = member;
            InitializeComponent();
        }

        private void FrmMembershipRenewal_Load(object sender, EventArgs e)
        {
            cmbSelectMembershipPlan.SelectedIndex = -1;
            ShowMemberIdAndName();
            RetrieveCurrentExpiredMembershipPlan();
            LoadMembershipPlanComboBox();
            LoadPaymentMethodComboBox();
        }

        private void ShowMemberIdAndName()
        {
            lblRetrieveMemberIDInChangePersonalTrainer.Text =
                memberAllDetailsUI.MemberId.ToString();
            lblRetrieveMemberName.Text =
                memberAllDetailsUI.MemberName.ToString();
        }

        private void RetrieveCurrentExpiredMembershipPlan()
        {
            int MemberId = Convert.ToInt32(lblRetrieveMemberIDInChangePersonalTrainer.Text);
            DataTable dataTable = null;
            try
            {
                MemberAllDetailsUI memberAllDetailsUI = new MemberAllDetailsUI();
                dataTable = memberAllDetailsUI.RetrieveRecentExpiredMembershipPlanUI(MemberId);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    lblRetrievePreviousMembershipPlan.Text =
                        row["MembershipPlanName"].ToString();
                    lblRetrievePlanExpiredDate.Text =
                        Convert.ToDateTime(row["ExpiryDate"]).ToString("dd-MM-yyyy");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadMembershipPlanComboBox()
        {
            MembershipPlanUI memberShipPlanUI = new MembershipPlanUI();
            DataTable dataTable = memberShipPlanUI.GetMembershipPlanDetailsForComboBox();
            
            cmbSelectMembershipPlan.DataSource = dataTable;
            
            cmbSelectMembershipPlan.DisplayMember = "MembershipPlanName";
            cmbSelectMembershipPlan.ValueMember = "MembershipPlanId";
            cmbSelectMembershipPlan.SelectedIndex = -1;
            
        }

        private void LoadPaymentMethodComboBox()
        {
            cmbSelectMemberPaymentMethod.DataSource = LookupUI.GetPaymentMethods();
            cmbSelectMemberPaymentMethod.SelectedIndex = -1;
        }
        private void RenewalMemberShipPlan()
        {
            ComboBox[] combobox = new ComboBox[]
            {
                cmbSelectMembershipPlan,
                cmbSelectMemberPaymentMethod
            };
            //if (!ValidationUI.ValidateRequiredComboBoxes(combobox))
            //{
            //    return;
            //}
            //else
            //{
            //    int MemberId = Convert.ToInt32(lblRetrieveMemberIDInChangePersonalTrainer.Text);
            //    int MemberShipPlanId = Convert.ToInt32(cmbSelectMembershipPlan.SelectedIndex + 1);
            //    string PaymentMethod = cmbSelectMemberPaymentMethod.Text;


            //    string RenewalMessage = null;
            //    DialogResult result = MessageBox.Show(RenewalConfirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result != DialogResult.Yes)
            //    {
            //        return;
            //    }
            //    try
            //    {
            //        MemberAllDetailsUI MemberAllDetailsUI = new MemberAllDetailsUI();
            //        RenewalMessage = MemberAllDetailsUI.RenewalMemberShipPlanUI(MemberId, MemberShipPlanId, PaymentMethod);
            //        DialogResult Result = MessageBox.Show(RenewalMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            if (Result == DialogResult.OK)
            //            {
            //                this.Dispose();
            //            }
            //    }
            //    catch (Exception ex)
            //    {
            //        RenewalMessage = null;
            //    }
            //}
        }

        private void tlpChangeMembershipButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeMembershipButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeMembershipButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeMembershipButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMembership_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMembership.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSectionInChangeMembership_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMembership.BackColor = Color.Red;
        }

        private void cmbSelectMembershipPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            cmbSelectMembershipPlan.ForeColor = Color.Black;
            //CHANGE PRICE IN PAYMENT SECTION BASED ON SELECTED MEMBERSHIP PLAN
            if (cmbSelectMembershipPlan.SelectedIndex >= 0)
            {
                MembershipPlanId = Convert.ToInt32(((DataRowView)cmbSelectMembershipPlan.SelectedItem)["MembershipPlanId"]);
                string MembershipPlanPrice = MembershipPlanUI.GetPriceByMembershipPlanId(MembershipPlanId).ToString();

                lblRetrieveMemberPaymentAmount.Text = string.Format("₹ {0:N2}", MembershipPlanPrice);
            }
        }

        private void pnlChangeMembershipButton_Click(object sender, EventArgs e)
        {
            RenewalMemberShipPlan();
        }

        private void pnlCancleButtomInChangeMembership_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblMemberPaymentAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
