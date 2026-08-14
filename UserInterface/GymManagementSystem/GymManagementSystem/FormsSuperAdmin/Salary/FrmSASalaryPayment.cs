using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FormsSuperAdmin.Salary.UI;


namespace GymManagementSystem.FormsSuperAdmin.Salary
{
    public partial class FrmSASalaryPayment : Form
    {
        private int paymentModeRowIndex = -1;
        private List<string> allPaymentMethods = new List<string>();
        private bool isFilteringPaymentMode = false;
        private bool isPaymentModeSelected = false;
        private bool isFormLoading = true;

        public FrmSASalaryPayment()
        {
            InitializeComponent();

            cmbPaymentMode.SelectedIndexChanged +=
                cmbPaymentMode_SelectedIndexChanged;

            cmbPaymentMode.TextChanged +=
                cmbPaymentMode_TextChanged;

            cmbPaymentMode.MouseClick +=
                cmbPaymentMode_MouseClick;

            cmbPaymentMode.KeyDown +=
                cmbPaymentMode_KeyDown;
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void FrmSASalaryPayment_Load(object sender, EventArgs e)
        {
            isFormLoading = true;

          
            cmbPaymentMode.DroppedDown = false;
            cmbPaymentMode.Visible = false;
            pnlPaymentMode.Visible = false;

            // Payment methods load
            LoadPaymentMethods();

           
            cmbPaymentMode.DroppedDown = false;

            // Salary data load
            RetrieveAllEmployeeSalary();

            dgvEmployeeSalaryDetails.ClearSelection();

            isFormLoading = false;

            // Final safety
            cmbPaymentMode.DroppedDown = false;
        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            int TextBoxClick = 1;
            if (TextBoxClick == 1)
            {
                txtSearchBar.Clear();
                txtSearchBar.ForeColor = Color.Black;
            }
            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void RetrieveAllEmployeeSalary()
        {
            SalaryUI salaryUI = new SalaryUI();

            DataTable dataTable =
                salaryUI.GetEmployeeSalaryDetailsUI();

            dgvEmployeeSalaryDetails.Rows.Clear();

            int serialNo = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex =
                    dgvEmployeeSalaryDetails.Rows.Add();

                int isPaid =
                    Convert.ToInt32(row["IsPaid"]);

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colSLNo"].Value = serialNo++;

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colEmployeeId"].Value =
                    row["EmployeeId"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colEmployeeFullName"].Value =
                    row["EmployeeName"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colPhoneNo"].Value =
                    row["PhoneNo"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colSalary"].Value =
                    row["Salary"];

                dgvEmployeeSalaryDetails.Rows[rowIndex].Tag = isPaid;

                if (isPaid == 1)
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value = "₹ Paid";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.ForeColor =
                        Color.LimeGreen;
                }
                else
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value = "₹ Pay";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.BackColor =
                        Color.Empty;
                }
            }

            dgvEmployeeSalaryDetails.ClearSelection();

            // Grid repaint
            dgvEmployeeSalaryDetails.Invalidate();
        }

        private void dgvEmployeeSalaryDetails_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex !=
                dgvEmployeeSalaryDetails.Columns["ColAction"].Index)
                return;

            e.PaintBackground(e.CellBounds, true);

            ButtonRenderer.DrawButton(
                e.Graphics,
                e.CellBounds,
                System.Windows.Forms.VisualStyles.PushButtonState.Normal);

            int isPaid = 0;

            if (dgvEmployeeSalaryDetails.Rows[e.RowIndex].Tag != null)
            {
                isPaid =
                    Convert.ToInt32(
                        dgvEmployeeSalaryDetails.Rows[e.RowIndex].Tag);
            }

            string buttonText;
            Color textColor;

            if (isPaid == 1)
            {
                buttonText = "₹ Paid";
                textColor = Color.Green;
            }
            else
            {
                buttonText = "₹ Pay";
                textColor = Color.Red;
            }

            using (Font fixedFont =
                new Font("Segoe UI", 10F, FontStyle.Bold))
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    buttonText,
                    fixedFont,
                    e.CellBounds,
                    textColor,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter);
            }

            e.Handled = true;

        }

        private void LoadPaymentMethods()
        {
            SalaryUI salaryUI = new SalaryUI();

            allPaymentMethods =
                salaryUI.GetPaymentMethodsUI();

            cmbPaymentMode.Items.Clear();

            foreach (string paymentMethod in allPaymentMethods)
            {
                cmbPaymentMode.Items.Add(paymentMethod);
            }

            cmbPaymentMode.SelectedIndex = -1;
            cmbPaymentMode.Text = "";
        }
        private void dgvEmployeeSalaryDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }

        }

        private void dgvEmployeeSalaryDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }

        }

        private void tlpSalary_Click(object sender, EventArgs e)
        {
            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void FrmSASalaryPayment_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dgvEmployeeSalaryDetails_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex !=
                dgvEmployeeSalaryDetails.Columns["ColAction"].Index)
                return;

            int isPaid = 0;

            if (dgvEmployeeSalaryDetails.Rows[e.RowIndex].Tag != null)
            {
                isPaid =
                    Convert.ToInt32(
                        dgvEmployeeSalaryDetails.Rows[e.RowIndex].Tag);
            }

            // =========================================
            // Already Paid
            // =========================================
            if (isPaid == 1)
            {
                ClosePaymentModeComboBox();

                MessageBox.Show(
                    "Salary payment has already been completed successfully.",
                    "Payment Already Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }

            // =========================================
            // Same row clicked again
            // =========================================
            if (pnlPaymentMode.Visible &&
                paymentModeRowIndex == e.RowIndex)
            {
                ClosePaymentModeComboBox();

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }

            int employeeId =
                Convert.ToInt32(
                    dgvEmployeeSalaryDetails.Rows[e.RowIndex]
                    .Cells["colEmployeeId"].Value);

            ShowPaymentModeComboBox(
                e.RowIndex,
                employeeId);
        }
        private void ShowPaymentModeComboBox(int rowIndex, int employeeId)
        {
            paymentModeRowIndex = rowIndex;

            isPaymentModeSelected = false;

            // Make sure previous dropdown is closed
            cmbPaymentMode.DroppedDown = false;

            int actionColumnIndex =
                dgvEmployeeSalaryDetails.Columns["ColAction"].Index;

            Rectangle cellRectangle =
                dgvEmployeeSalaryDetails.GetCellDisplayRectangle(
                    actionColumnIndex,
                    rowIndex,
                    true);

            if (cellRectangle.Height <= 0)
                return;

            cmbPaymentMode.Parent =
                dgvEmployeeSalaryDetails;

            pnlPaymentMode.Parent =
                dgvEmployeeSalaryDetails;

            cmbPaymentMode.Tag = employeeId;

            int actionColumnWidth =
                dgvEmployeeSalaryDetails.Columns["ColAction"].Width;

            pnlPaymentMode.Width =
                (int)(actionColumnWidth * 0.70);

            pnlPaymentMode.Height = 110;

            pnlPaymentMode.Location = new Point(
                cellRectangle.X +
                (actionColumnWidth - pnlPaymentMode.Width) / 2,
                cellRectangle.Bottom
            );

            cmbPaymentMode.Width =
                pnlPaymentMode.Width - 20;

            cmbPaymentMode.Height = 30;

            cmbPaymentMode.Location = new Point(
                pnlPaymentMode.Left +
                (pnlPaymentMode.Width - cmbPaymentMode.Width) / 2,
                pnlPaymentMode.Top + 10
            );

            pnlPaymentMode.BackColor =
                Color.LightSkyBlue;

            pnlPaymentMode.BorderStyle =
                BorderStyle.FixedSingle;

            pnlPaymentMode.Visible = true;

            cmbPaymentMode.Visible = true;

            pnlPaymentMode.BringToFront();

            cmbPaymentMode.BringToFront();

            // Reset previous search/selection
            cmbPaymentMode.SelectedIndex = -1;
            cmbPaymentMode.Text = "";

            // Focus ComboBox
            cmbPaymentMode.Focus();

            // Open dropdown
            cmbPaymentMode.DroppedDown = true;
        }

        private void cmbPaymentMode_SelectedIndexChanged(object sender,EventArgs e)
        {
           
            if (isFormLoading)
                return;

            if (isFilteringPaymentMode)
                return;

            if (cmbPaymentMode.SelectedIndex == -1)
                return;

            if (cmbPaymentMode.Tag == null)
                return;

            string selectedPaymentMode =
                Convert.ToString(
                    cmbPaymentMode.SelectedItem);

            if (string.IsNullOrWhiteSpace(selectedPaymentMode))
                return;

            isPaymentModeSelected = true;

            int employeeId =
                Convert.ToInt32(cmbPaymentMode.Tag);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to pay this employee's salary?\n\n" +
                "Payment Mode : " + selectedPaymentMode,
                "Confirm Salary Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // =========================================
            // User clicked NO
            // =========================================
            if (result == DialogResult.No)
            {
                ClosePaymentModeComboBox();

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }

            // =========================================
            // User clicked YES
            // =========================================
            SalaryUI salaryUI = new SalaryUI();

            string message =
                salaryUI.PaySalaryUI(
                    employeeId,
                    selectedPaymentMode);

            MessageBox.Show(
                message,
                "Salary Payment",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // =========================================
            // Close ComboBox + Panel
            // =========================================
            ClosePaymentModeComboBox();

            // =========================================
            // Refresh Data
            // =========================================
            RetrieveAllEmployeeSalary();

            dgvEmployeeSalaryDetails.ClearSelection();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchBar.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                RetrieveAllEmployeeSalary();
                dgvEmployeeSalaryDetails.ClearSelection();
                return;
            }

            SearchEmployeeSalary(search);
            dgvEmployeeSalaryDetails.ClearSelection();
        }
        private void SearchEmployeeSalary(string search)
        {
            SalaryUI salaryUI = new SalaryUI();

            DataTable dataTable =
                salaryUI.RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameUI(search);

            dgvEmployeeSalaryDetails.Rows.Clear();

            int serialNo = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex =
                    dgvEmployeeSalaryDetails.Rows.Add();

                int isPaid =
                    Convert.ToInt32(row["IsPaid"]);

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colSLNo"].Value = serialNo++;

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colEmployeeId"].Value =
                    row["EmployeeId"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colEmployeeFullName"].Value =
                    row["EmployeeName"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colPhoneNo"].Value =
                    row["PhoneNo"];

                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colSalary"].Value =
                    row["Salary"];

                dgvEmployeeSalaryDetails.Rows[rowIndex].Tag = isPaid;

                if (isPaid == 1)
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value = "₹ Paid";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.ForeColor =
                        Color.LimeGreen;
                }
                else
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value = "₹ Pay";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.BackColor =
                        Color.Empty;
                }
            }

            dgvEmployeeSalaryDetails.ClearSelection();
            dgvEmployeeSalaryDetails.Invalidate();
        }

        private void cmbPaymentMode_MouseEnter(object sender, EventArgs e)
        {
            if (!cmbPaymentMode.DroppedDown)
            {
                cmbPaymentMode.DroppedDown = true;
            }
        }

        private void cmbPaymentMode_TextChanged(object sender, EventArgs e)
        {
            if (isFilteringPaymentMode)
                return;

            if (isPaymentModeSelected)
                return;

            if (!cmbPaymentMode.Visible)
                return;

            string searchText = cmbPaymentMode.Text.Trim();

            isFilteringPaymentMode = true;

            try
            {
                // =========================================
                // Save typed text
                // =========================================

                int cursorPosition = searchText.Length;

                // =========================================
                // Close current dropdown
                // =========================================

                cmbPaymentMode.DroppedDown = false;

                // =========================================
                // Clear current items
                // =========================================

                cmbPaymentMode.Items.Clear();

                // =========================================
                // Filter Payment Methods
                // =========================================

                List<string> filteredPaymentMethods;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    filteredPaymentMethods =
                        allPaymentMethods.ToList();
                }
                else
                {
                    filteredPaymentMethods =
                        allPaymentMethods
                        .Where(paymentMethod =>
                            !string.IsNullOrWhiteSpace(paymentMethod) &&
                            paymentMethod.StartsWith(
                                searchText,
                                StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                // =========================================
                // Add filtered items
                // =========================================

                foreach (string paymentMethod in filteredPaymentMethods)
                {
                    cmbPaymentMode.Items.Add(paymentMethod);
                }

                // =========================================
                // Restore typed text BEFORE opening dropdown
                // =========================================

                cmbPaymentMode.SelectedIndex = -1;

                cmbPaymentMode.Text = searchText;

                cmbPaymentMode.SelectionStart = cursorPosition;

                cmbPaymentMode.SelectionLength = 0;

                // =========================================
                // Open dropdown
                // =========================================

                if (filteredPaymentMethods.Count > 0)
                {
                    cmbPaymentMode.DroppedDown = true;

                    cmbPaymentMode.SelectedIndex = -1;

                    cmbPaymentMode.Text = searchText;

                    cmbPaymentMode.SelectionStart = cursorPosition;

                    cmbPaymentMode.SelectionLength = 0;
                }
            }
            finally
            {
                isFilteringPaymentMode = false;
            }
        }
        private void cmbPaymentMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cmbPaymentMode.DroppedDown = true;
            }
        }

        private void cmbPaymentMode_MouseLeave(object sender, EventArgs e)
        {
            if (cmbPaymentMode.DroppedDown)
            {
                cmbPaymentMode.DroppedDown = false;
            }
        }

        private void cmbPaymentMode_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cmbPaymentMode.DroppedDown)
            {
                cmbPaymentMode.DroppedDown = true;
            }
        }
        private void ClosePaymentModeComboBox()
        {
            // Close native ComboBox dropdown first
            cmbPaymentMode.DroppedDown = false;

            // Clear ComboBox
            cmbPaymentMode.SelectedIndex = -1;
            cmbPaymentMode.Text = "";
            cmbPaymentMode.Tag = null;

            // Hide ComboBox
            cmbPaymentMode.Visible = false;

            // Hide Panel
            pnlPaymentMode.Visible = false;

            // Reset variables
            paymentModeRowIndex = -1;
            isPaymentModeSelected = false;

            // Remove focus
            this.ActiveControl = null;
        }
    }
}
