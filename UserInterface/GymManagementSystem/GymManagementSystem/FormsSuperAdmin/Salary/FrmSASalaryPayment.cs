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
        private bool isRefreshingSalaryGrid = false;

        private List<string> allPaymentMethods =
            new List<string>();

        private bool isFilteringPaymentMode = false;
        private bool isPaymentModeSelected = false;
        private bool isFormLoading = true;

        // IMPORTANT:
        // Prevent the same click from reaching
        // DataGridView after payment is completed.
        private bool ignoreNextActionCellClick = false;


        public FrmSASalaryPayment()
        {
            InitializeComponent();

            cmbPaymentMode.DropDownStyle =
                ComboBoxStyle.DropDown;

            cmbPaymentMode.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            cmbPaymentMode.AutoCompleteSource =
                AutoCompleteSource.ListItems;
        }


        private void FrmSASalaryPayment_Load(
            object sender,
            EventArgs e)
        {
            isFormLoading = true;

            cmbPaymentMode.DroppedDown = false;
            cmbPaymentMode.Visible = false;
            pnlPaymentMode.Visible = false;

            // =========================================
            // LOAD PAYMENT METHODS
            // =========================================

            LoadPaymentMethods();

            cmbPaymentMode.DroppedDown = false;

            // =========================================
            // LOAD SALARY DATA
            // =========================================
            isFormLoading = false;
            RetrieveAllEmployeeSalary();

            dgvEmployeeSalaryDetails.ClearSelection();

            

            cmbPaymentMode.DroppedDown = false;
        }


        private void txtSearchBar_Click(
            object sender,
            EventArgs e)
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
            isRefreshingSalaryGrid = true;

            try
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

                    // =========================================
                    // SERIAL NUMBER
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["colSLNo"].Value =
                        serialNo++;

                    // =========================================
                    // EMPLOYEE ID
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["colEmployeeId"].Value =
                        row["EmployeeId"];

                    // =========================================
                    // EMPLOYEE NAME
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["colEmployeeFullName"].Value =
                        row["EmployeeName"];

                    // =========================================
                    // PHONE
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["colPhoneNo"].Value =
                        row["PhoneNo"];

                    // =========================================
                    // SALARY
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["colSalary"].Value =
                        row["Salary"];

                    // =========================================
                    // STORE PAYMENT STATUS
                    // =========================================

                    dgvEmployeeSalaryDetails.Rows[rowIndex].Tag =
                        isPaid;

                    // =========================================
                    // ACTION
                    // =========================================

                    if (isPaid == 1)
                    {
                        dgvEmployeeSalaryDetails.Rows[rowIndex]
                            .Cells["ColAction"].Value =
                            "₹ Paid";

                        dgvEmployeeSalaryDetails.Rows[rowIndex]
                            .DefaultCellStyle.ForeColor =
                            Color.LimeGreen;
                    }
                    else
                    {
                        dgvEmployeeSalaryDetails.Rows[rowIndex]
                            .Cells["ColAction"].Value =
                            "₹ Pay";

                        dgvEmployeeSalaryDetails.Rows[rowIndex]
                            .DefaultCellStyle.BackColor =
                            Color.Empty;
                    }
                }

                dgvEmployeeSalaryDetails.ClearSelection();

                dgvEmployeeSalaryDetails.Invalidate();
            }
            finally
            {
                isRefreshingSalaryGrid = false;
            }
        }


        private void dgvEmployeeSalaryDetails_CellPainting(
            object sender,
            DataGridViewCellPaintingEventArgs e)
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
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold))
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
                if (!string.IsNullOrWhiteSpace(paymentMethod))
                {
                    cmbPaymentMode.Items.Add(paymentMethod);
                }
            }

            cmbPaymentMode.SelectedIndex = -1;
            cmbPaymentMode.Text = "";
        }


        private void dgvEmployeeSalaryDetails_CellMouseEnter(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails
                    .Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Style.BackColor =
                    Color.LightBlue;
            }
        }


        private void dgvEmployeeSalaryDetails_CellMouseLeave(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex >= 0)
            {
                dgvEmployeeSalaryDetails
                    .Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Style.BackColor =
                    Color.Empty;
            }
        }


        private void tlpSalary_Click(
            object sender,
            EventArgs e)
        {
            dgvEmployeeSalaryDetails.ClearSelection();
        }


        private void FrmSASalaryPayment_Shown(
            object sender,
            EventArgs e)
        {
            this.ActiveControl = null;
        }


        private void dgvEmployeeSalaryDetails_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // =========================================
            // IGNORE CLICK DURING GRID REFRESH
            // =========================================

            if (isRefreshingSalaryGrid)
                return;


            // =========================================
            // IGNORE THE EXTRA CLICK CAUSED BY
            // PAYMENT COMBOBOX
            // =========================================

            if (ignoreNextActionCellClick)
            {
                ignoreNextActionCellClick = false;
                return;
            }


            // =========================================
            // INVALID ROW
            // =========================================

            if (e.RowIndex < 0)
                return;


            // =========================================
            // ONLY ACTION COLUMN
            // =========================================

            if (e.ColumnIndex !=
                dgvEmployeeSalaryDetails.Columns["ColAction"].Index)
                return;


            // =========================================
            // GET PAYMENT STATUS
            // =========================================

            int isPaid = 0;

            if (dgvEmployeeSalaryDetails
                .Rows[e.RowIndex]
                .Tag != null)
            {
                isPaid =
                    Convert.ToInt32(
                        dgvEmployeeSalaryDetails
                        .Rows[e.RowIndex]
                        .Tag);
            }


            // =========================================
            // ALREADY PAID
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
            // SAME ROW CLICKED AGAIN
            // =========================================

            if (pnlPaymentMode.Visible &&
                paymentModeRowIndex == e.RowIndex)
            {
                ClosePaymentModeComboBox();

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }


            // =========================================
            // GET EMPLOYEE ID
            // =========================================

            int employeeId =
                Convert.ToInt32(
                    dgvEmployeeSalaryDetails
                    .Rows[e.RowIndex]
                    .Cells["colEmployeeId"]
                    .Value);


            // =========================================
            // SHOW PAYMENT MODE
            // =========================================

            ShowPaymentModeComboBox(
                e.RowIndex,
                employeeId);
        }


        private void ShowPaymentModeComboBox(
            int rowIndex,
            int employeeId)
        {
            paymentModeRowIndex = rowIndex;

            isPaymentModeSelected = false;

            // =========================================
            // CLOSE PREVIOUS DROPDOWN
            // =========================================

            cmbPaymentMode.DroppedDown = false;


            // =========================================
            // RESTORE ALL PAYMENT METHODS
            // =========================================

            cmbPaymentMode.Items.Clear();

            foreach (string paymentMethod in allPaymentMethods)
            {
                if (!string.IsNullOrWhiteSpace(paymentMethod))
                {
                    cmbPaymentMode.Items.Add(paymentMethod);
                }
            }


            // =========================================
            // RESET SELECTION
            // =========================================

            cmbPaymentMode.SelectedIndex = -1;
            cmbPaymentMode.Text = "";


            // =========================================
            // STORE EMPLOYEE ID
            // =========================================

            cmbPaymentMode.Tag = employeeId;


            // =========================================
            // GET ACTION COLUMN POSITION
            // =========================================

            int actionColumnIndex =
                dgvEmployeeSalaryDetails
                .Columns["ColAction"]
                .Index;

            Rectangle cellRectangle =
                dgvEmployeeSalaryDetails
                .GetCellDisplayRectangle(
                    actionColumnIndex,
                    rowIndex,
                    true);

            if (cellRectangle.Height <= 0)
                return;


            // =========================================
            // SET PARENT
            // =========================================

            cmbPaymentMode.Parent =
                dgvEmployeeSalaryDetails;

            pnlPaymentMode.Parent =
                dgvEmployeeSalaryDetails;


            // =========================================
            // SET PANEL SIZE
            // =========================================

            int actionColumnWidth =
                dgvEmployeeSalaryDetails
                .Columns["ColAction"]
                .Width;

            pnlPaymentMode.Width =
                (int)(actionColumnWidth * 0.70);

            pnlPaymentMode.Height = 110;


            // =========================================
            // SET PANEL LOCATION
            // =========================================

            pnlPaymentMode.Location =
                new Point(
                    cellRectangle.X +
                    (actionColumnWidth -
                     pnlPaymentMode.Width) / 2,

                    cellRectangle.Bottom
                );


            // =========================================
            // SET COMBOBOX SIZE
            // =========================================

            cmbPaymentMode.Width =
                pnlPaymentMode.Width - 20;

            cmbPaymentMode.Height = 30;


            // =========================================
            // SET COMBOBOX LOCATION
            // =========================================

            cmbPaymentMode.Location =
                new Point(
                    pnlPaymentMode.Left +
                    (pnlPaymentMode.Width -
                     cmbPaymentMode.Width) / 2,

                    pnlPaymentMode.Top + 10
                );


            // =========================================
            // PANEL DESIGN
            // =========================================

            pnlPaymentMode.BackColor =
                Color.LightSkyBlue;

            pnlPaymentMode.BorderStyle =
                BorderStyle.FixedSingle;


            // =========================================
            // SHOW
            // =========================================

            pnlPaymentMode.Visible = true;
            cmbPaymentMode.Visible = true;

            pnlPaymentMode.BringToFront();
            cmbPaymentMode.BringToFront();


            // =========================================
            // FOCUS
            // =========================================

            cmbPaymentMode.Focus();


            // =========================================
            // OPEN DROPDOWN
            // =========================================

            cmbPaymentMode.DroppedDown = true;
        }


        private void txtSearchBar_TextChanged(
            object sender,
            EventArgs e)
        {
            string search =
                txtSearchBar.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                RetrieveAllEmployeeSalary();

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }

            SearchEmployeeSalary(search);

            dgvEmployeeSalaryDetails.ClearSelection();
        }


        private void SearchEmployeeSalary(
            string search)
        {
            SalaryUI salaryUI = new SalaryUI();

            DataTable dataTable =
                salaryUI
                .RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameUI(
                    search);

            dgvEmployeeSalaryDetails.Rows.Clear();

            int serialNo = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex =
                    dgvEmployeeSalaryDetails.Rows.Add();

                int isPaid =
                    Convert.ToInt32(row["IsPaid"]);


                dgvEmployeeSalaryDetails.Rows[rowIndex]
                    .Cells["colSLNo"].Value =
                    serialNo++;


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


                dgvEmployeeSalaryDetails.Rows[rowIndex].Tag =
                    isPaid;


                if (isPaid == 1)
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value =
                        "₹ Paid";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.ForeColor =
                        Color.LimeGreen;
                }
                else
                {
                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .Cells["ColAction"].Value =
                        "₹ Pay";

                    dgvEmployeeSalaryDetails.Rows[rowIndex]
                        .DefaultCellStyle.BackColor =
                        Color.Empty;
                }
            }

            dgvEmployeeSalaryDetails.ClearSelection();

            dgvEmployeeSalaryDetails.Invalidate();
        }


        private void ClosePaymentModeComboBox()
        {
            // =========================================
            // CLOSE DROPDOWN
            // =========================================

            cmbPaymentMode.DroppedDown = false;


            // =========================================
            // HIDE PANEL
            // =========================================

            pnlPaymentMode.Visible = false;


            // =========================================
            // HIDE COMBOBOX
            // =========================================

            cmbPaymentMode.Visible = false;


            // =========================================
            // RESET ROW
            // =========================================

            paymentModeRowIndex = -1;


            // =========================================
            // RESET SELECTION FLAG
            // =========================================

            isPaymentModeSelected = false;


            this.ActiveControl = null;
        }


        private void cmbPaymentMode_SelectionChangeCommitted(
            object sender,
            EventArgs e)
        {
            // =========================================
            // VALIDATION
            // =========================================

            if (cmbPaymentMode.SelectedIndex == -1)
                return;

            if (cmbPaymentMode.Tag == null)
                return;

            if (isPaymentModeSelected)
                return;


            // =========================================
            // GET SELECTED PAYMENT MODE
            // =========================================

            string selectedPaymentMode =
                Convert.ToString(
                    cmbPaymentMode.SelectedItem);

            if (string.IsNullOrWhiteSpace(
                selectedPaymentMode))
                return;


            // =========================================
            // MARK PAYMENT MODE SELECTED
            // =========================================

            isPaymentModeSelected = true;


            // =========================================
            // IMPORTANT
            //
            // Tell DataGridView that the next
            // Action-cell click must be ignored.
            // =========================================

            ignoreNextActionCellClick = true;


            // =========================================
            // KEEP SELECTED ITEM VISIBLE
            // =========================================

            cmbPaymentMode.Text =
                selectedPaymentMode;

            cmbPaymentMode.SelectionStart =
                cmbPaymentMode.Text.Length;

            cmbPaymentMode.SelectionLength = 0;


            // =========================================
            // CLOSE DROPDOWN
            // =========================================

            cmbPaymentMode.DroppedDown = false;


            // =========================================
            // GET EMPLOYEE ID
            // =========================================

            int employeeId =
                Convert.ToInt32(
                    cmbPaymentMode.Tag);


            // =========================================
            // CONFIRM PAYMENT
            // =========================================

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to pay this employee's salary?\n\n" +
                    "Payment Mode : " +
                    selectedPaymentMode,

                    "Confirm Salary Payment",

                    MessageBoxButtons.YesNo,

                    MessageBoxIcon.Question);


            // =========================================
            // USER CLICKED NO
            // =========================================

            if (result == DialogResult.No)
            {
                // The payment was not made.
                // Allow the next normal grid click.

                ignoreNextActionCellClick = false;

                ClosePaymentModeComboBox();

                dgvEmployeeSalaryDetails.ClearSelection();

                return;
            }


            // =========================================
            // USER CLICKED YES
            // =========================================

            SalaryUI salaryUI =
                new SalaryUI();

            string message =
                salaryUI.PaySalaryUI(
                    employeeId,
                    selectedPaymentMode);


            // =========================================
            // SHOW ONLY THE RETURNED MESSAGE
            // =========================================

            MessageBox.Show(
                message,
                "Salary Payment",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            // =========================================
            // CLOSE PAYMENT MODE
            // =========================================

            ClosePaymentModeComboBox();


            // =========================================
            // REFRESH GRID
            // =========================================

            RetrieveAllEmployeeSalary();

            dgvEmployeeSalaryDetails.ClearSelection();


            // =========================================
            // RESET IGNORE FLAG AFTER CURRENT
            // UI EVENT COMPLETES
            // =========================================

            this.BeginInvoke(
                new MethodInvoker(
                    delegate
                    {
                        ignoreNextActionCellClick = false;
                    }));
        }
    }
}