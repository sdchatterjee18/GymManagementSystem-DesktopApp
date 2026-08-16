using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FORMS.Member.UI;
using GymManagementSystem.FORMS.DietPlan.UI;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmChangeDietPlan : Form
    {
        string ComfirmationMessage = "Do you want to change DietPlan?";
        string cmbSelectionMessage = "Please select a Calories.";
        string Information = "Info";
        private MemberAllDetailsUI memberAllDetailsUI = null;
        public FrmChangeDietPlan( MemberAllDetailsUI member)
        {
            InitializeComponent();
            memberAllDetailsUI = member;
        }

        private void FrmChangeDietPlan_Load(object sender, EventArgs e)
        {
            SetChangeDietPlanMemberInformation();
            GetDietPlanForComboBox();

        }

        private void SetChangeDietPlanMemberInformation()
        {
            lblRetrieveMemberIDInChangeMemberDietPlan.Text =
                memberAllDetailsUI.MemberId.ToString();
            lblRetrieveMemberName.Text =
                memberAllDetailsUI.MemberName.ToString();
            lblRetrieveCaloriesPerDay.Text =
                memberAllDetailsUI.CaloriesPerDay.ToString();
            lblRetrieveMemberPreviousConditionStatus.Text =
                memberAllDetailsUI.ConditionStatus.ToString();
        }

        private void GetDietPlanForComboBox()
        {
            DataTable dataTable = null;
            try
            {
                DietPlanUI dietPlanUI = new DietPlanUI();
                dataTable = dietPlanUI.GetDietPlansForComboBox();
                cmbCaloriesPerDay.DataSource = null;
                cmbCaloriesPerDay.DisplayMember = "CaloriesPerDay";
                cmbCaloriesPerDay.ValueMember = "DietPlanId";
                cmbCaloriesPerDay.DataSource = dataTable;
                cmbCaloriesPerDay.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                dataTable = null;
            }
        }

        private void RetrieveConditionStatusByDietPlanId()
        {
            DataTable dataTable = null;
            try
            {
                int DietPlanId =
                    Convert.ToInt32(cmbCaloriesPerDay.SelectedValue);

                MemberAllDetailsUI memberAllDetailsUI =
                    new MemberAllDetailsUI();

                dataTable =
                    memberAllDetailsUI.RetrieveConditionStatusByDietPlanIdUI(DietPlanId);

                if (dataTable.Rows.Count > 0)
                {

                    lblMemberConditionStatusRetrieve.Text =
                        dataTable.Rows[0]["ConditionStatus"].ToString();
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void ChangeMemberDietPlan()
        {
            string ChangeDietPlanMessage = null;
            try
            {
                int MemberId = Convert.ToInt32(lblRetrieveMemberIDInChangeMemberDietPlan.Text);
                if (cmbCaloriesPerDay.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        cmbSelectionMessage,
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbCaloriesPerDay.Focus();

                    return;
                }
                int NewDietPlanId = Convert.ToInt32(cmbCaloriesPerDay.SelectedValue);
                DialogResult result = MessageBox.Show(ComfirmationMessage, Information, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    MemberAllDetailsUI memberAllDetailsUI = new MemberAllDetailsUI();
                    ChangeDietPlanMessage = memberAllDetailsUI.ChangeMemberDietPlanUI(MemberId, NewDietPlanId);
                    DialogResult Result = MessageBox.Show(ChangeDietPlanMessage, Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
                
            }
            catch (Exception ex)
            {
               ChangeDietPlanMessage = null;
            }

        }

        private void tlpChangeMemberDietPlansButton_MouseEnter(object sender, EventArgs e)
        {
            this.tlpChangeMemberDietPlansButton.BackColor = Color.DarkGreen;
        }

        private void tlpChangeMemberDietPlansButton_MouseLeave(object sender, EventArgs e)
        {
            this.tlpChangeMemberDietPlansButton.BackColor = Color.ForestGreen;
        }

        private void tlpCancleSectionInChangeMemberDietPlan_MouseEnter(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberDietPlan.BackColor = Color.OrangeRed;
        }

        private void tlpCancleSectionInChangeMemberDietPlan_MouseLeave(object sender, EventArgs e)
        {
            this.tlpCancleSectionInChangeMemberDietPlan.BackColor = Color.Red;
        }

        private void pnlCancleButtomInChangeMemberDietPlan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbCaloriesPerDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveConditionStatusByDietPlanId();
        }

        private void pnlChangeMemberDietPlanButton_Click(object sender, EventArgs e)
        {
            ChangeMemberDietPlan();
        }
    }
}
