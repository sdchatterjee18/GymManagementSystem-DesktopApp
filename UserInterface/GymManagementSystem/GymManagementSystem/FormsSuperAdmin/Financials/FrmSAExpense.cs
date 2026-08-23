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
    public partial class FrmSAExpense : Form
    {
        private int serialNo = 1;
        private int ClickCountTxtYearExpencesHistory = 0;
        public FrmSAExpense()
        {
            InitializeComponent();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvExpensesHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }
        }

        private void dgvExpensesHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.FromArgb(210, 215, 255);

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvExpensesHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;



            }
        }

        private void dgvExpensesHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colSLNo")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }

            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colExpenseDate")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Green;

                }
            }

            if (dgvExpensesHistory.Columns[e.ColumnIndex].Name == "colExpenseAmount")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();

                    e.CellStyle.ForeColor = Color.Navy;

                }
            }
        }

        private void RetrieveAllExpenses()
        {
            try
            {
                SAExpencesUI expenseUI = new SAExpencesUI();

                DataTable dataTable =
                    expenseUI.SARetrieveAllExpensesUI();

                dgvExpensesHistory.AutoGenerateColumns = false;
                dgvExpensesHistory.Rows.Clear();

                serialNo = 1;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex = dgvExpensesHistory.Rows.Add();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colSLNo"].Value = serialNo++;

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseId"].Value =
                        Convert.ToInt32(dataRow["ExpenseId"]);

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategoryName"].Value =
                        dataRow["CategoryName"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategory"].Value =
                        dataRow["Category"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseAmount"].Value =
                        Convert.ToDecimal(dataRow["ExpenseAmount"])
                        .ToString("0.00");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseDate"].Value =
                        Convert.ToDateTime(dataRow["ExpenseDate"])
                        .ToString("dd-MM-yyyy");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colNotes"].Value =
                        dataRow["Notes"].ToString();
                }

                dgvExpensesHistory.ClearSelection();
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
        private void LoadMonthExpensesHistory()
        {
            DataTable dataTable = LookupUI.GetMonths();

            cmbMonthExpencesHistory.DataSource = dataTable;
            cmbMonthExpencesHistory.DisplayMember = "MonthName";
            cmbMonthExpencesHistory.ValueMember = "MonthNumber";
        }


        private void FrmSAExpense_Load(object sender, EventArgs e)
        {
            dgvExpensesHistory.ClearSelection();
            RetrieveAllExpenses();
            LoadMonthExpensesHistory();
    
        }

        private void FrmSAExpense_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void SARetrieveExpenseStatementByMonth()
        {
            try
            {
                int year;

                if (!int.TryParse(
                    txtYearExpencesHistory.Text.Trim(),
                    out year))
                {
                    MessageBox.Show(
                        "Please enter a valid year.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtYearExpencesHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearExpencesHistory.Focus();

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

                    txtYearExpencesHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearExpencesHistory.Focus();

                    return;
                }

                txtYearExpencesHistory.BackColor = Color.White;

                int month = Convert.ToInt32(
                    cmbMonthExpencesHistory.SelectedValue);

                SAExpencesUI expenseUI = new SAExpencesUI();

                DataTable dataTable =
                    expenseUI.SARetrieveExpenseStatementByMonthUI(
                        month,
                        year);

                // ==========================================
                // CLEAR OLD DATA
                // ==========================================

                dgvExpensesHistory.AutoGenerateColumns = false;
                dgvExpensesHistory.Rows.Clear();

                serialNo = 1;

                // ==========================================
                // NO DATA
                // ==========================================

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    dgvExpensesHistory.ClearSelection();

                    MessageBox.Show(
                        "No expense found for the selected month and year.",
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                // ==========================================
                // SQL MESSAGE
                // ==========================================

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    dgvExpensesHistory.ClearSelection();

                    return;
                }

                // ==========================================
                // LOAD DATA INTO DATAGRIDVIEW
                // ==========================================

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvExpensesHistory.Rows.Add();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colSLNo"].Value =
                        serialNo++;

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseId"].Value =
                        Convert.ToInt32(
                            dataRow["ExpenseId"]);

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategoryName"].Value =
                        dataRow["CategoryName"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategory"].Value =
                        dataRow["Category"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseAmount"].Value =
                        Convert.ToDecimal(
                            dataRow["ExpenseAmount"])
                            .ToString("0.00");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseDate"].Value =
                        Convert.ToDateTime(
                            dataRow["ExpenseDate"])
                            .ToString("dd-MM-yyyy");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colNotes"].Value =
                        dataRow["Notes"].ToString();
                }

                dgvExpensesHistory.ClearSelection();
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

        private void btnSearchExpense_Click(object sender, EventArgs e)
        {
            SARetrieveExpenseStatementByMonth();
            SARetrieveTotalExpenseByMonth();
        }

        private void txtYearExpencesHistory_Click(object sender, EventArgs e)
        {
            ClickCountTxtYearExpencesHistory =
        ValidationUI.ClearTextBoxWhenClicked(
            txtYearExpencesHistory,
            ClickCountTxtYearExpencesHistory);

            txtYearExpencesHistory.ForeColor = Color.Black;
        }
        private void SARetrieveTotalExpenseByMonth()
        {
            try
            {
                //if (!ValidationUI.ValidateRequiredTextBoxes(
                //    txtYearExpencesHistory))
                //{
                //    return;
                //}

                //if (!ValidationUI.ValidateRequiredComboBoxes(
                //    cmbMonthExpencesHistory))
                //{
                //    return;
                //}

                int year;

                if (!int.TryParse(
                    txtYearExpencesHistory.Text.Trim(),
                    out year))
                {
                    MessageBox.Show(
                        "Please enter a valid year.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtYearExpencesHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearExpencesHistory.Focus();

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

                    txtYearExpencesHistory.BackColor =
                        Color.FromArgb(255, 240, 240);

                    txtYearExpencesHistory.Focus();

                    return;
                }

                txtYearExpencesHistory.BackColor = Color.White;

                int month = Convert.ToInt32(
                    cmbMonthExpencesHistory.SelectedValue);

                SAExpencesUI expenseUI = new SAExpencesUI();

                DataTable dataTable =
                    expenseUI.SARetrieveTotalExpenseByMonthUI(
                        month,
                        year);

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    lblOutputTotalExpenceExpenceHistory.Text =
                        "0.00";

                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblOutputTotalExpenceExpenceHistory.Text =
                        "0.00";

                    return;
                }

                decimal totalExpense =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalExpense"]);

                lblOutputTotalExpenceExpenceHistory.Text =
                    totalExpense.ToString("0.00");
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
        private void SARetrieveExpenseStatementByDateRange()
        {
            try
            {
                DateTime fromDate =
                    dtpStartDateExpencesHistory.Value.Date;

                DateTime toDate =
                    dtpEndDateExpencesHistory.Value.Date;

                if (fromDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "From Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDateExpencesHistory.Focus();
                    return;
                }

                if (toDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "To Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpEndDateExpencesHistory.Focus();
                    return;
                }

                if (fromDate > toDate)
                {
                    MessageBox.Show(
                        "From Date cannot be greater than To Date.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dtpStartDateExpencesHistory.Focus();
                    return;
                }

                SAExpencesUI expenseUI = new SAExpencesUI();

                DataTable dataTable =
                    expenseUI.SARetrieveExpenseStatementByDateRangeUI(
                        fromDate,
                        toDate);

                dgvExpensesHistory.AutoGenerateColumns = false;
                dgvExpensesHistory.Rows.Clear();

                serialNo = 1;

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    dgvExpensesHistory.ClearSelection();

                    MessageBox.Show(
                        "No expense found for the selected date range.",
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    dgvExpensesHistory.ClearSelection();
                    return;
                }

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int rowIndex =
                        dgvExpensesHistory.Rows.Add();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colSLNo"].Value =
                        serialNo++;

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseId"].Value =
                        Convert.ToInt32(dataRow["ExpenseId"]);

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategoryName"].Value =
                        dataRow["CategoryName"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colCategory"].Value =
                        dataRow["Category"].ToString();

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseAmount"].Value =
                        Convert.ToDecimal(
                            dataRow["ExpenseAmount"])
                            .ToString("0.00");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colExpenseDate"].Value =
                        Convert.ToDateTime(
                            dataRow["ExpenseDate"])
                            .ToString("dd-MM-yyyy");

                    dgvExpensesHistory.Rows[rowIndex]
                        .Cells["colNotes"].Value =
                        dataRow["Notes"].ToString();
                }

                dgvExpensesHistory.ClearSelection();
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
        private void SARetrieveTotalExpenseByDateRange()
        {
            try
            {
                DateTime fromDate =
                    dtpStartDateExpencesHistory.Value.Date;

                DateTime toDate =
                    dtpEndDateExpencesHistory.Value.Date;

                if (fromDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "From Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (toDate > DateTime.Today)
                {
                    MessageBox.Show(
                        "To Date cannot be greater than today.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (fromDate > toDate)
                {
                    MessageBox.Show(
                        "From Date cannot be greater than To Date.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                SAExpencesUI expenseUI = new SAExpencesUI();

                DataTable dataTable =
                    expenseUI.SARetrieveTotalExpenseByDateRangeUI(
                        fromDate,
                        toDate);

                if (dataTable == null ||
                    dataTable.Rows.Count == 0)
                {
                    lblOutputTotalExpenceExpenceHistory.Text = "0.00";
                    return;
                }

                if (dataTable.Columns.Contains("Message"))
                {
                    MessageBox.Show(
                        dataTable.Rows[0]["Message"].ToString(),
                        "Expense Statement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lblOutputTotalExpenceExpenceHistory.Text = "0.00";
                    return;
                }

                decimal totalExpense =
                    Convert.ToDecimal(
                        dataTable.Rows[0]["TotalExpense"]);

                lblOutputTotalExpenceExpenceHistory.Text =
                    totalExpense.ToString("0.00");
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
        private void btnSearchExpencesHistory_Click(object sender, EventArgs e)
        {
            SARetrieveExpenseStatementByDateRange();
            SARetrieveTotalExpenseByDateRange();
          
        }

        private void btnExportExpencesHistory_Click(object sender, EventArgs e)
        {
            ExportExpensesHistroy();
        }
        private void ExportExpensesHistroy()
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

                int dataRowCount = 0;

                foreach (DataGridViewRow row in dgvExpensesHistory.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        dataRowCount++;
                    }
                }

                if (dataRowCount == 0)
                {
                    MessageBox.Show(
                        "There is no expense data to export.",
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
                    "Export Expense History";

                saveFileDialog.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx|" +
                    "Excel 97-2003 Workbook (*.xls)|*.xls|" +
                    "Word Document (*.docx)|*.docx|" +
                    "PDF File (*.pdf)|*.pdf|" +
                    "Text File (*.txt)|*.txt";

                saveFileDialog.FilterIndex = 1;

                saveFileDialog.FileName =
                    "Expense_History";

                saveFileDialog.DefaultExt =
                    "xlsx";

                saveFileDialog.AddExtension = true;

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
                        excelApp.DisplayAlerts = false;

                        // =================================================
                        // CREATE WORKBOOK
                        // =================================================

                        workbook =
                            excelApp.Workbooks.Add();

                        worksheet =
                            (Excel.Worksheet)
                            workbook.Worksheets[1];

                        worksheet.Name =
                            "Expense History";

                        // =================================================
                        // HEADER
                        // =================================================

                        int excelColumn = 1;

                        for (int i = 0;
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvExpensesHistory.Columns[i];

                            // Hidden column skip
                            if (!column.Visible)
                            {
                                continue;
                            }

                            worksheet.Cells[
                                1,
                                excelColumn] =
                                column.HeaderText;

                            excelColumn++;
                        }

                        int totalColumns =
                            excelColumn - 1;

                        // =================================================
                        // HEADER FORMAT
                        // =================================================

                        Excel.Range headerRange =
                            worksheet.Range[
                                worksheet.Cells[1, 1],
                                worksheet.Cells[
                                    1,
                                    totalColumns]
                            ];

                        headerRange.Font.Bold = true;

                        headerRange.HorizontalAlignment =
                            Excel.XlHAlign.xlHAlignCenter;

                        headerRange.VerticalAlignment =
                            Excel.XlVAlign.xlVAlignCenter;

                        // =================================================
                        // DATA
                        // =================================================

                        int excelRow = 2;

                        foreach (DataGridViewRow row
                            in dgvExpensesHistory.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            excelColumn = 1;

                            for (int i = 0;
                                 i < dgvExpensesHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvExpensesHistory.Columns[i];

                                // Hidden column skip
                                if (!column.Visible)
                                {
                                    continue;
                                }

                                object value =
                                    row.Cells[i].Value;

                                if (value == null)
                                {
                                    worksheet.Cells[
                                        excelRow,
                                        excelColumn] = "";
                                }
                                else
                                {
                                    worksheet.Cells[
                                        excelRow,
                                        excelColumn] =
                                        value.ToString();
                                }

                                excelColumn++;
                            }

                            excelRow++;
                        }

                        // =================================================
                        // DATA RANGE
                        // =================================================

                        Excel.Range dataRange =
                            worksheet.Range[
                                worksheet.Cells[1, 1],
                                worksheet.Cells[
                                    excelRow - 1,
                                    totalColumns]
                            ];

                        // =================================================
                        // BORDER
                        // =================================================

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

                        // =================================================
                        // CLOSE
                        // =================================================

                        workbook.Close(false);

                        excelApp.Quit();

                        MessageBox.Show(
                            "Expense history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        // =================================================
                        // RELEASE WORKSHEET
                        // =================================================

                        try
                        {
                            if (worksheet != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(worksheet);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE WORKBOOK
                        // =================================================

                        try
                        {
                            if (workbook != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(workbook);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE EXCEL APPLICATION
                        // =================================================

                        try
                        {
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
                            "EXPENSE HISTORY");

                        writer.WriteLine(
                            "==============================");

                        writer.WriteLine();

                        // =================================================
                        // HEADER
                        // =================================================

                        for (int i = 0;
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvExpensesHistory.Columns[i];

                            if (!column.Visible)
                            {
                                continue;
                            }

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
                            in dgvExpensesHistory.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            for (int i = 0;
                                 i < dgvExpensesHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvExpensesHistory.Columns[i];

                                if (!column.Visible)
                                {
                                    continue;
                                }

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
                        "Expense history exported successfully.",
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
                            "Expense History";

                        titleParagraph.Range.Bold = 1;

                        titleParagraph.Range.InsertParagraphAfter();

                        // =================================================
                        // COUNT VISIBLE COLUMNS
                        // =================================================

                        int visibleColumnCount = 0;

                        for (int i = 0;
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            if (dgvExpensesHistory.Columns[i].Visible)
                            {
                                visibleColumnCount++;
                            }
                        }

                        // =================================================
                        // COUNT ROWS
                        // =================================================

                        int rowCount = 1;

                        foreach (DataGridViewRow row
                            in dgvExpensesHistory.Rows)
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
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvExpensesHistory.Columns[i];

                            if (!column.Visible)
                            {
                                continue;
                            }

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
                            in dgvExpensesHistory.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            wordColumn = 1;

                            for (int i = 0;
                                 i < dgvExpensesHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvExpensesHistory.Columns[i];

                                if (!column.Visible)
                                {
                                    continue;
                                }

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
                        // VS2010 COMPATIBLE
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
                            "Expense history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        // =================================================
                        // RELEASE TABLE
                        // =================================================

                        try
                        {
                            if (table != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(table);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE DOCUMENT
                        // =================================================

                        try
                        {
                            if (document != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(document);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE WORD APPLICATION
                        // =================================================

                        try
                        {
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
                            "Expense History";

                        titleParagraph.Range.Bold = 1;

                        titleParagraph.Range.InsertParagraphAfter();

                        // =================================================
                        // COUNT COLUMNS
                        // =================================================

                        int visibleColumnCount = 0;

                        for (int i = 0;
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            if (dgvExpensesHistory.Columns[i].Visible)
                            {
                                visibleColumnCount++;
                            }
                        }

                        // =================================================
                        // COUNT ROWS
                        // =================================================

                        int rowCount = 1;

                        foreach (DataGridViewRow row
                            in dgvExpensesHistory.Rows)
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
                             i < dgvExpensesHistory.Columns.Count;
                             i++)
                        {
                            DataGridViewColumn column =
                                dgvExpensesHistory.Columns[i];

                            if (!column.Visible)
                            {
                                continue;
                            }

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
                            in dgvExpensesHistory.Rows)
                        {
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            wordColumn = 1;

                            for (int i = 0;
                                 i < dgvExpensesHistory.Columns.Count;
                                 i++)
                            {
                                DataGridViewColumn column =
                                    dgvExpensesHistory.Columns[i];

                                if (!column.Visible)
                                {
                                    continue;
                                }

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
                        // VS2010 COMPATIBLE
                        // =================================================

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
                            "Expense history exported successfully.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                    finally
                    {
                        // =================================================
                        // RELEASE TABLE
                        // =================================================

                        try
                        {
                            if (table != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(table);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE DOCUMENT
                        // =================================================

                        try
                        {
                            if (document != null)
                            {
                                System.Runtime.InteropServices.Marshal
                                    .ReleaseComObject(document);
                            }
                        }
                        catch
                        {
                        }

                        // =================================================
                        // RELEASE WORD APPLICATION
                        // =================================================

                        try
                        {
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
