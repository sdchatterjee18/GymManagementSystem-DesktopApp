using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymManagementSystem.FormsSuperAdmin.Financials.UI;
using GymManagementSystem.Common;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Text;

namespace GymManagementSystem.FormsSuperAdmin.Financials
{
    public partial class FrmSAPayment : Form
    {
        private int ClickCountTxtYearPaymentHistory = 0;
        public FrmSAPayment()
        {
            InitializeComponent();
        }

        private void FrmSAPayment_Load(object sender, EventArgs e)
        {
            dgvPaymentHistory.ClearSelection();
            LoadMonthExpensesHistory();
            RetrieveAllMemberSubscriptionPaymentDetails();
        }
        private void LoadMonthExpensesHistory()
        {
            DataTable dataTable = LookupUI.GetMonths();

            cmbMonthPaymentHistory.DataSource = dataTable;
            cmbMonthPaymentHistory.DisplayMember = "MonthName";
            cmbMonthPaymentHistory.ValueMember = "MonthNumber";
        }

        private void dgvPaymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tlpPaymentHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSAPayment_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dgvPaymentHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvPaymentHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvPaymentHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;



            }
        }

        private void dgvPaymentHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colSerialNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }

            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colPaymentDate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Green;

                }
            }

            if (dgvPaymentHistory.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }
        }

        private void txtYearPaymentHistory_Click(object sender, EventArgs e)
        {
            ClickCountTxtYearPaymentHistory =
                ValidationUI.ClearTextBoxWhenClicked(
                    txtYearPaymentHistory,
                    ClickCountTxtYearPaymentHistory);

            txtYearPaymentHistory.ForeColor = Color.Black;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SARetrieveSubscriptionPaymentDetailsByMonth();
            SARetrieveTotalPaidSubscriptionAmountByMonth();
           
        }
        private void RetrieveAllMemberSubscriptionPaymentDetails()
        {
            try
            {
                SAPaymentUI paymentUI = new SAPaymentUI();

                DataTable dataTable =
                    paymentUI.SARetrieveAllMemberSubscriptionPaymentDetailsUI();

                dgvPaymentHistory.AutoGenerateColumns = false;
                dgvPaymentHistory.Rows.Clear();

                int serialNo = 1;

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    dgvPaymentHistory.ClearSelection();
                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dgvPaymentHistory.ClearSelection();
                    return;
                }

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvPaymentHistory.Rows.Add();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colMembershipPlanName"].Value =
                        dataRow["MembershipPlanName"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentDate"].Value =
                        Convert.ToDateTime(
                            dataRow["PaymentDate"])
                            .ToString("dd-MM-yyyy");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentMethod"].Value =
                        dataRow["PaymentMethod"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colAmount"].Value =
                        Convert.ToDecimal(
                            dataRow["Amount"])
                            .ToString("0.00");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colFeesType"].Value =
                        dataRow["FeesType"].ToString();
                }

                dgvPaymentHistory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SARetrieveSubscriptionPaymentDetailsByMonth()
        {
            try
            {
                if (!ValidationUI.ValidateRequiredTextBoxes(
                    txtYearPaymentHistory))
                {
                    return;
                }

                if (!ValidationUI.ValidateRequiredComboBoxes(
                    cmbMonthPaymentHistory))
                {
                    return;
                }

                int year;

                if (!int.TryParse(
                    txtYearPaymentHistory.Text.Trim(),
                    out year))
                {
                    MessageBox.Show(
                        "Please enter a valid year.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtYearPaymentHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearPaymentHistory.Focus();

                    return;
                }

                if (year < 2000 || year > DateTime.Now.Year)
                {
                    MessageBox.Show(
                        "Please enter a valid year between 2000 and " +
                        DateTime.Now.Year + ".",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtYearPaymentHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearPaymentHistory.Focus();

                    return;
                }

                txtYearPaymentHistory.BackColor = Color.White;

                int month = Convert.ToInt32(
                    cmbMonthPaymentHistory.SelectedValue);

                SAPaymentUI paymentUI = new SAPaymentUI();

                DataTable dataTable =
                    paymentUI.SARetrieveSubscriptionPaymentDetailsByMonthUI(
                        month,
                        year);

                dgvPaymentHistory.AutoGenerateColumns = false;
                dgvPaymentHistory.Rows.Clear();

                int serialNo = 1;

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    dgvPaymentHistory.ClearSelection();

                    MessageBox.Show(
                        "No payment found for the selected month and year.",
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dgvPaymentHistory.ClearSelection();

                    return;
                }

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvPaymentHistory.Rows.Add();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentId"].Value =
                        Convert.ToInt32(
                            dataRow["PaymentId"]);

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colMembershipPlanName"].Value =
                        dataRow["MembershipPlanName"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentDate"].Value =
                        Convert.ToDateTime(
                            dataRow["PaymentDate"])
                            .ToString("dd-MM-yyyy");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentMethod"].Value =
                        dataRow["PaymentMethod"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colAmount"].Value =
                        Convert.ToDecimal(
                            dataRow["Amount"])
                            .ToString("0.00");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colFeesType"].Value =
                        dataRow["FeesType"].ToString();
                }

                dgvPaymentHistory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SARetrieveTotalPaidSubscriptionAmountByMonth()
        {
            try
            {
                if (!ValidationUI.ValidateRequiredTextBoxes(
                    txtYearPaymentHistory))
                {
                    return;
                }

                if (!ValidationUI.ValidateRequiredComboBoxes(
                    cmbMonthPaymentHistory))
                {
                    return;
                }

                int year;

                if (!int.TryParse(
                    txtYearPaymentHistory.Text.Trim(),
                    out year))
                {
                    return;
                }

                int month = Convert.ToInt32(
                    cmbMonthPaymentHistory.SelectedValue);

                SAPaymentUI paymentUI = new SAPaymentUI();

                DataTable dataTable =
                    paymentUI.SARetrieveTotalPaidSubscriptionAmountByMonthUI(
                        month,
                        year);

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    lblOutputTotalExpencePaymentHistory.Text = "0.00";
                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblOutputTotalExpencePaymentHistory.Text = "0.00";
                    return;
                }

                if (dataTable.Rows[0]["TotalRevenueThisMonth"] == DBNull.Value)
                {
                    lblOutputTotalExpencePaymentHistory.Text = "0.00";
                    return;
                }

                decimal totalAmount =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalRevenueThisMonth"]);

                lblOutputTotalExpencePaymentHistory.Text =
                    totalAmount.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearchPaymentHistory_Click(object sender, EventArgs e)
        {
            SARetrieveSubscriptionPaymentDetailsBetweenDateRange();
            SARetrieveTotalPaidSubscriptionAmountBetweenDateRange();
        }
        private void SARetrieveSubscriptionPaymentDetailsBetweenDateRange()
        {
            try
            {
                DateTime startDate =
                    dtpStartDatePaymentHistory.Value.Date;

                DateTime endDate =
                    dtpEndDatePaymentHistory.Value.Date;

                if (startDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "Start Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDatePaymentHistory.Focus();
                    return;
                }

                if (endDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "End Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpEndDatePaymentHistory.Focus();
                    return;
                }

                if (startDate > endDate)
                {
                    MessageBox.Show(
                        "Start Date cannot be greater than End Date.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDatePaymentHistory.Focus();
                    return;
                }

                SAPaymentUI paymentUI = new SAPaymentUI();

                DataTable dataTable =
                    paymentUI.SARetrieveSubscriptionPaymentDetailsBetweenDateRangeUI(
                        startDate,
                        endDate);

                dgvPaymentHistory.AutoGenerateColumns = false;
                dgvPaymentHistory.Rows.Clear();

                int serialNo = 1;

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    dgvPaymentHistory.ClearSelection();

                    MessageBox.Show(
                        "No payment found for the selected date range.",
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dgvPaymentHistory.ClearSelection();
                    return;
                }

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvPaymentHistory.Rows.Add();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colSerialNo"].Value =
                        serialNo++;

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentId"].Value =
                        Convert.ToInt32(
                            dataRow["PaymentId"]);

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colMembershipPlanName"].Value =
                        dataRow["MembershipPlanName"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentDate"].Value =
                        Convert.ToDateTime(
                            dataRow["PaymentDate"])
                            .ToString("dd-MM-yyyy");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colPaymentMethod"].Value =
                        dataRow["PaymentMethod"].ToString();

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colAmount"].Value =
                        Convert.ToDecimal(
                            dataRow["Amount"])
                            .ToString("0.00");

                    dgvPaymentHistory.Rows[rowIndex]
                        .Cells["colFeesType"].Value =
                        dataRow["FeesType"].ToString();
                }

                dgvPaymentHistory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SARetrieveTotalPaidSubscriptionAmountBetweenDateRange()
        {
            try
            {
                DateTime startDate =
                    dtpStartDatePaymentHistory.Value.Date;

                DateTime endDate =
                    dtpEndDatePaymentHistory.Value.Date;

                if (startDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "Start Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDatePaymentHistory.Focus();
                    return;
                }

                if (endDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "End Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpEndDatePaymentHistory.Focus();
                    return;
                }

                if (startDate > endDate)
                {
                    MessageBox.Show(
                        "Start Date cannot be greater than End Date.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDatePaymentHistory.Focus();
                    return;
                }

                SAPaymentUI paymentUI =
                    new SAPaymentUI();

                DataTable dataTable =
                    paymentUI.SARetrieveTotalPaidSubscriptionAmountBetweenDateRangeUI(
                        startDate,
                        endDate);

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    lblOutputTotalExpencePaymentHistory.Text =
                        "0.00";

                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Payment History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblOutputTotalExpencePaymentHistory.Text =
                        "0.00";

                    return;
                }

                if (dataTable.Rows[0]["TotalRevenue"] == DBNull.Value)
                {
                    lblOutputTotalExpencePaymentHistory.Text =
                        "0.00";

                    return;
                }

                decimal totalAmount =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalRevenue"]);

                lblOutputTotalExpencePaymentHistory.Text =
                    totalAmount.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExportPaymentHistory_Click(object sender, EventArgs e)
        {
            ExportPaymentHistory();
        }

        private void ExportPaymentHistory()
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            Word.Application wordApp = null;
            Word.Document document = null;
            Word.Table table = null;

            try
            {
                // =========================================================
                // CHECK DATA
                // =========================================================

                if (dgvPaymentHistory.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "There is no payment data to export.",
                        "Export",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =========================================================
                // SAVE FILE DIALOG
                // =========================================================

                SaveFileDialog saveFileDialog =
                    new SaveFileDialog();

                saveFileDialog.Title =
                    "Export Payment History";

                saveFileDialog.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx|" +
                    "Excel 97-2003 Workbook (*.xls)|*.xls|" +
                    "Word Document (*.docx)|*.docx|" +
                    "PDF File (*.pdf)|*.pdf|" +
                    "Text File (*.txt)|*.txt";

                saveFileDialog.FilterIndex = 1;

                saveFileDialog.FileName =
                    "Payment_History";

                if (saveFileDialog.ShowDialog() !=
                    DialogResult.OK)
                {
                    return;
                }

                string filePath =
                    saveFileDialog.FileName;

                string extension =
                    System.IO.Path.GetExtension(
                        filePath).ToLower();

                // =========================================================
                // EXCEL XLSX / XLS
                // =========================================================

                if (extension == ".xlsx" ||
                    extension == ".xls")
                {
                    try
                    {
                        excelApp =
                            new Excel.Application();

                        excelApp.Visible = false;

                        workbook =
                            excelApp.Workbooks.Add();

                        worksheet =
                            (Excel.Worksheet)
                            workbook.Worksheets[1];

                        worksheet.Name =
                            "Payment History";

                        // =================================================
                        // HEADER
                        // =================================================

                        int excelColumn = 1;

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvPaymentHistory.Columns[i];

                            if (!column.Visible)
                                continue;

                            worksheet.Cells[
                                1,
                                excelColumn] =
                                column.HeaderText;

                            excelColumn++;
                        }

                        Excel.Range headerRange =
                            worksheet.Range[
                                worksheet.Cells[1, 1],
                                worksheet.Cells[
                                    1,
                                    excelColumn - 1]
                            ];

                        headerRange.Font.Bold = true;

                        headerRange.HorizontalAlignment =
                            Excel.XlHAlign.xlHAlignCenter;

                        // =================================================
                        // DATA
                        // =================================================

                        int excelRow = 2;

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (row.IsNewRow)
                                continue;

                            excelColumn = 1;

                            for (int i = 0;
                                 i < dgvPaymentHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvPaymentHistory.Columns[i];

                                if (!column.Visible)
                                    continue;

                                object value =
                                    row.Cells[i].Value;

                                worksheet.Cells[
                                    excelRow,
                                    excelColumn] =
                                    value == null
                                    ? ""
                                    : value.ToString();

                                excelColumn++;
                            }

                            excelRow++;
                        }

                        // =================================================
                        // BORDER
                        // =================================================

                        Excel.Range dataRange =
                            worksheet.Range[
                                worksheet.Cells[1, 1],
                                worksheet.Cells[
                                    excelRow - 1,
                                    excelColumn - 1]
                            ];

                        dataRange.Borders.LineStyle =
                            Excel.XlLineStyle.xlContinuous;

                        // =================================================
                        // AUTO FIT
                        // =================================================

                        dataRange.Columns.AutoFit();

                        // =================================================
                        // SAVE
                        // =================================================

                        if (extension == ".xlsx")
                        {
                            workbook.SaveAs(
                                filePath,
                                Excel.XlFileFormat.xlOpenXMLWorkbook);
                        }
                        else
                        {
                            workbook.SaveAs(
                                filePath,
                                Excel.XlFileFormat.xlWorkbookNormal);
                        }

                        workbook.Close(false);
                        excelApp.Quit();

                        MessageBox.Show(
                            "Payment history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        try
                        {
                            if (worksheet != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(worksheet);
                            }

                            if (workbook != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(workbook);
                            }

                            if (excelApp != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(excelApp);
                            }
                        }
                        catch
                        {
                        }

                        worksheet = null;
                        workbook = null;
                        excelApp = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }

                // =========================================================
                // TEXT FILE
                // =========================================================

                if (extension == ".txt")
                {
                    using (
                        System.IO.StreamWriter writer =
                        new System.IO.StreamWriter(
                            filePath,
                            false,
                            Encoding.UTF8))
                    {
                        // =================================================
                        // TITLE
                        // =================================================

                        writer.WriteLine(
                            "PAYMENT HISTORY");

                        writer.WriteLine(
                            "==============================");

                        writer.WriteLine();

                        // =================================================
                        // HEADER
                        // =================================================

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvPaymentHistory.Columns[i];

                            if (!column.Visible)
                                continue;

                            writer.Write(
                                column.HeaderText);

                            writer.Write("\t");
                        }

                        writer.WriteLine();

                        writer.WriteLine(
                            "------------------------------------------------------------");

                        // =================================================
                        // DATA
                        // =================================================

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (row.IsNewRow)
                                continue;

                            for (int i = 0;
                                 i < dgvPaymentHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvPaymentHistory.Columns[i];

                                if (!column.Visible)
                                    continue;

                                object value =
                                    row.Cells[i].Value;

                                writer.Write(
                                    value == null
                                    ? ""
                                    : value.ToString());

                                writer.Write("\t");
                            }

                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show(
                        "Payment history exported successfully.",
                        "Export",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                // =========================================================
                // WORD DOCX
                // =========================================================

                if (extension == ".docx")
                {
                    try
                    {
                        wordApp =
                            new Word.Application();

                        wordApp.Visible = false;

                        document =
                            wordApp.Documents.Add();

                        // =================================================
                        // TITLE
                        // =================================================

                        Word.Paragraph titleParagraph =
                            document.Paragraphs.Add();

                        titleParagraph.Range.Text =
                            "Payment History";

                        titleParagraph.Range.Bold = 1;

                        titleParagraph.Range.InsertParagraphAfter();

                        // =================================================
                        // COUNT VISIBLE COLUMNS
                        // =================================================

                        int visibleColumnCount = 0;

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            if (dgvPaymentHistory.Columns[i].Visible)
                            {
                                visibleColumnCount++;
                            }
                        }

                        // =================================================
                        // COUNT ROWS
                        // =================================================

                        int rowCount = 1;

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                rowCount++;
                            }
                        }

                        // =================================================
                        // CREATE TABLE
                        // =================================================

                        Word.Range range =
                            document.Bookmarks
                            .get_Item("\\endofdoc")
                            .Range;

                        table =
                            document.Tables.Add(
                                range,
                                rowCount,
                                visibleColumnCount);

                        // =================================================
                        // HEADER
                        // =================================================

                        int wordColumn = 1;

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvPaymentHistory.Columns[i];

                            if (!column.Visible)
                                continue;

                            table.Cell(
                                1,
                                wordColumn)
                                .Range.Text =
                                column.HeaderText;

                            wordColumn++;
                        }

                        // =================================================
                        // HEADER BOLD
                        // =================================================

                        for (int i = 1;
                             i <= visibleColumnCount;
                             i++)
                        {
                            table.Cell(
                                1,
                                i)
                                .Range.Bold = 1;
                        }

                        // =================================================
                        // DATA
                        // =================================================

                        int wordRow = 2;

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (row.IsNewRow)
                                continue;

                            wordColumn = 1;

                            for (int i = 0;
                                 i < dgvPaymentHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvPaymentHistory.Columns[i];

                                if (!column.Visible)
                                    continue;

                                object value =
                                    row.Cells[i].Value;

                                table.Cell(
                                    wordRow,
                                    wordColumn)
                                    .Range.Text =
                                    value == null
                                    ? ""
                                    : value.ToString();

                                wordColumn++;
                            }

                            wordRow++;
                        }

                        // =================================================
                        // TABLE BORDER
                        // =================================================

                        table.Borders.Enable = 1;

                        // =================================================
                        // WORD SAVE
                        // IMPORTANT:
                        // VS2010 WORD INTEROP USES SaveAs(ref object)
                        // =================================================

                        object outputFile =
                            filePath;

                        object fileFormat =
                            Word.WdSaveFormat.wdFormatXMLDocument;

                        object missing =
                            Type.Missing;

                        document.SaveAs(
                            ref outputFile,
                            ref fileFormat,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing,
                            ref missing);

                        document.Close(
                            ref missing,
                            ref missing,
                            ref missing);

                        wordApp.Quit(
                            ref missing,
                            ref missing,
                            ref missing);

                        MessageBox.Show(
                            "Payment history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        try
                        {
                            if (table != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(table);
                            }

                            if (document != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(document);
                            }

                            if (wordApp != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(wordApp);
                            }
                        }
                        catch
                        {
                        }

                        table = null;
                        document = null;
                        wordApp = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }

                // =========================================================
                // PDF
                // =========================================================

                if (extension == ".pdf")
                {
                    try
                    {
                        wordApp =
                            new Word.Application();

                        wordApp.Visible = false;

                        document =
                            wordApp.Documents.Add();

                        // =================================================
                        // TITLE
                        // =================================================

                        Word.Paragraph titleParagraph =
                            document.Paragraphs.Add();

                        titleParagraph.Range.Text =
                            "Payment History";

                        titleParagraph.Range.Bold = 1;

                        titleParagraph.Range.InsertParagraphAfter();

                        // =================================================
                        // COUNT COLUMNS
                        // =================================================

                        int visibleColumnCount = 0;

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            if (dgvPaymentHistory.Columns[i].Visible)
                            {
                                visibleColumnCount++;
                            }
                        }

                        // =================================================
                        // COUNT ROWS
                        // =================================================

                        int rowCount = 1;

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                rowCount++;
                            }
                        }

                        // =================================================
                        // CREATE TABLE
                        // =================================================

                        Word.Range range =
                            document.Bookmarks
                            .get_Item("\\endofdoc")
                            .Range;

                        table =
                            document.Tables.Add(
                                range,
                                rowCount,
                                visibleColumnCount);

                        // =================================================
                        // HEADER
                        // =================================================

                        int wordColumn = 1;

                        for (int i = 0;
                             i < dgvPaymentHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvPaymentHistory.Columns[i];

                            if (!column.Visible)
                                continue;

                            table.Cell(
                                1,
                                wordColumn)
                                .Range.Text =
                                column.HeaderText;

                            wordColumn++;
                        }

                        // =================================================
                        // HEADER BOLD
                        // =================================================

                        for (int i = 1;
                             i <= visibleColumnCount;
                             i++)
                        {
                            table.Cell(
                                1,
                                i)
                                .Range.Bold = 1;
                        }

                        // =================================================
                        // DATA
                        // =================================================

                        int pdfRow = 2;

                        foreach (DataGridViewRow row
                            in dgvPaymentHistory.Rows)
                        {
                            if (row.IsNewRow)
                                continue;

                            wordColumn = 1;

                            for (int i = 0;
                                 i < dgvPaymentHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvPaymentHistory.Columns[i];

                                if (!column.Visible)
                                    continue;

                                object value =
                                    row.Cells[i].Value;

                                table.Cell(
                                    pdfRow,
                                    wordColumn)
                                    .Range.Text =
                                    value == null
                                    ? ""
                                    : value.ToString();

                                wordColumn++;
                            }

                            pdfRow++;
                        }

                        // =================================================
                        // BORDER
                        // =================================================

                        table.Borders.Enable = 1;

                        // =================================================
                        // EXPORT PDF
                        // Compatible with older Word Interop
                        // =================================================

                        object pdfFile =
                            filePath;

                        object missing =
                            Type.Missing;

                        document.ExportAsFixedFormat(
                            filePath,
                            Word.WdExportFormat.wdExportFormatPDF,
                            false,
                            Word.WdExportOptimizeFor.wdExportOptimizeForPrint,
                            Word.WdExportRange.wdExportAllDocument,
                            0,
                            0,
                            Word.WdExportItem.wdExportDocumentContent,
                            true,
                            true,
                            Word.WdExportCreateBookmarks.wdExportCreateNoBookmarks,
                            true,
                            true,
                            false,
                            ref missing);

                        document.Close(
                            ref missing,
                            ref missing,
                            ref missing);

                        wordApp.Quit(
                            ref missing,
                            ref missing,
                            ref missing);

                        MessageBox.Show(
                            "Payment history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        try
                        {
                            if (table != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(table);
                            }

                            if (document != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(document);
                            }

                            if (wordApp != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(wordApp);
                            }
                        }
                        catch
                        {
                        }

                        table = null;
                        document = null;
                        wordApp = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }

                // =========================================================
                // UNKNOWN FORMAT
                // =========================================================

                MessageBox.Show(
                    "This file format is not supported.",
                    "Export",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
