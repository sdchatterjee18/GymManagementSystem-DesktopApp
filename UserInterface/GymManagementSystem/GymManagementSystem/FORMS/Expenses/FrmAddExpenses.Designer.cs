namespace GymManagementSystem.FORMS.Expenses
{
    partial class FrmAddExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddExpenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpAddExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picAddExpenses = new System.Windows.Forms.PictureBox();
            this.tlpTitleAndSubTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tlpShowMemberTrainerAssignment = new System.Windows.Forms.TableLayoutPanel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.tlpAmount = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tlpSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.tlpSelectCategory = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCateogory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.pnlDefinition = new System.Windows.Forms.Panel();
            this.tlpExpenseDefination = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblExpenseDefination = new System.Windows.Forms.Label();
            this.txtExpenseDefination = new System.Windows.Forms.TextBox();
            this.pnlAddExpenseCategory = new System.Windows.Forms.Panel();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewExpenseCategory = new System.Windows.Forms.Label();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAddExpenses.SuspendLayout();
            this.tlpExpenses.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddExpenses)).BeginInit();
            this.tlpTitleAndSubTitle.SuspendLayout();
            this.tlpShowMemberTrainerAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.tlpAmount.SuspendLayout();
            this.tlpSearchBar.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.tlpSelectCategory.SuspendLayout();
            this.pnlDefinition.SuspendLayout();
            this.tlpExpenseDefination.SuspendLayout();
            this.pnlAddExpenseCategory.SuspendLayout();
            this.tlpAddButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAddExpenses
            // 
            this.tlpAddExpenses.ColumnCount = 3;
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAddExpenses.Controls.Add(this.tlpExpenses, 1, 0);
            this.tlpAddExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddExpenses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpAddExpenses.ForeColor = System.Drawing.Color.Black;
            this.tlpAddExpenses.Location = new System.Drawing.Point(0, 0);
            this.tlpAddExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddExpenses.Name = "tlpAddExpenses";
            this.tlpAddExpenses.RowCount = 1;
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpAddExpenses.Size = new System.Drawing.Size(862, 609);
            this.tlpAddExpenses.TabIndex = 1;
            this.tlpAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpExpenses
            // 
            this.tlpExpenses.ColumnCount = 1;
            this.tlpExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenses.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpExpenses.Controls.Add(this.tlpSearchBar, 0, 1);
            this.tlpExpenses.Controls.Add(this.tlpShowMemberTrainerAssignment, 0, 2);
            this.tlpExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenses.Location = new System.Drawing.Point(43, 0);
            this.tlpExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExpenses.Name = "tlpExpenses";
            this.tlpExpenses.RowCount = 4;
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpExpenses.Size = new System.Drawing.Size(775, 609);
            this.tlpExpenses.TabIndex = 0;
            this.tlpExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Controls.Add(this.picAddExpenses, 0, 0);
            this.tlpHeader.Controls.Add(this.tlpTitleAndSubTitle, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(2, 2);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(771, 63);
            this.tlpHeader.TabIndex = 0;
            this.tlpHeader.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // picAddExpenses
            // 
            this.picAddExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAddExpenses.Image = ((System.Drawing.Image)(resources.GetObject("picAddExpenses.Image")));
            this.picAddExpenses.Location = new System.Drawing.Point(2, 3);
            this.picAddExpenses.Margin = new System.Windows.Forms.Padding(2, 3, 2, 5);
            this.picAddExpenses.Name = "picAddExpenses";
            this.picAddExpenses.Size = new System.Drawing.Size(48, 55);
            this.picAddExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddExpenses.TabIndex = 1;
            this.picAddExpenses.TabStop = false;
            this.picAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpTitleAndSubTitle
            // 
            this.tlpTitleAndSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTitleAndSubTitle.ColumnCount = 1;
            this.tlpTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleAndSubTitle.Controls.Add(this.lblHeader, 0, 0);
            this.tlpTitleAndSubTitle.Controls.Add(this.lblSubTitle, 0, 1);
            this.tlpTitleAndSubTitle.Location = new System.Drawing.Point(52, 0);
            this.tlpTitleAndSubTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleAndSubTitle.Name = "tlpTitleAndSubTitle";
            this.tlpTitleAndSubTitle.RowCount = 2;
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpTitleAndSubTitle.Size = new System.Drawing.Size(359, 63);
            this.tlpTitleAndSubTitle.TabIndex = 0;
            this.tlpTitleAndSubTitle.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(2, 13);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(355, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add New Expense";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeader.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubTitle.Location = new System.Drawing.Point(2, 34);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(355, 13);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Record a new expense and assign it to a category";
            this.lblSubTitle.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpShowMemberTrainerAssignment
            // 
            this.tlpShowMemberTrainerAssignment.ColumnCount = 1;
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpShowMemberTrainerAssignment.Controls.Add(this.dgvExpenses, 0, 0);
            this.tlpShowMemberTrainerAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowMemberTrainerAssignment.Location = new System.Drawing.Point(0, 202);
            this.tlpShowMemberTrainerAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.tlpShowMemberTrainerAssignment.Name = "tlpShowMemberTrainerAssignment";
            this.tlpShowMemberTrainerAssignment.RowCount = 1;
            this.tlpShowMemberTrainerAssignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.Size = new System.Drawing.Size(775, 372);
            this.tlpShowMemberTrainerAssignment.TabIndex = 4;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToResizeColumns = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.ColumnHeadersHeight = 40;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colCategoryName,
            this.colCategory,
            this.colExpenseAmount,
            this.colExpenseDate,
            this.colNotes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExpenses.Location = new System.Drawing.Point(2, 2);
            this.dgvExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExpenses.Name = "dgvExpenses";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenses.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.dgvExpenses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpenses.RowTemplate.Height = 30;
            this.dgvExpenses.Size = new System.Drawing.Size(771, 368);
            this.dgvExpenses.TabIndex = 0;
            this.dgvExpenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvExpenses_CellFormatting);
            this.dgvExpenses.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseEnter);
            this.dgvExpenses.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseLeave);
            // 
            // tlpAmount
            // 
            this.tlpAmount.ColumnCount = 3;
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAmount.Controls.Add(this.lblAmount, 0, 0);
            this.tlpAmount.Controls.Add(this.txtAmount, 1, 0);
            this.tlpAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAmount.Location = new System.Drawing.Point(0, 0);
            this.tlpAmount.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAmount.Name = "tlpAmount";
            this.tlpAmount.RowCount = 1;
            this.tlpAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAmount.Size = new System.Drawing.Size(775, 34);
            this.tlpAmount.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Location = new System.Drawing.Point(182, 9);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(238, 25);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = " Enter Amount";
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click_1);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAmount.Location = new System.Drawing.Point(0, 0);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 34);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount :";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSearchBar
            // 
            this.tlpSearchBar.ColumnCount = 1;
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchBar.Controls.Add(this.tlpAmount, 0, 0);
            this.tlpSearchBar.Controls.Add(this.pnlCategory, 0, 1);
            this.tlpSearchBar.Controls.Add(this.pnlDefinition, 0, 2);
            this.tlpSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchBar.Location = new System.Drawing.Point(0, 67);
            this.tlpSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchBar.Name = "tlpSearchBar";
            this.tlpSearchBar.RowCount = 4;
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchBar.Size = new System.Drawing.Size(775, 135);
            this.tlpSearchBar.TabIndex = 1;
            this.tlpSearchBar.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpSearchBar_Paint);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.tlpSelectCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(0, 34);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(775, 34);
            this.pnlCategory.TabIndex = 3;
            // 
            // tlpSelectCategory
            // 
            this.tlpSelectCategory.ColumnCount = 2;
            this.tlpSelectCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpSelectCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectCategory.Controls.Add(this.lblSelectCategory, 0, 0);
            this.tlpSelectCategory.Controls.Add(this.cmbCateogory, 1, 0);
            this.tlpSelectCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSelectCategory.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectCategory.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSelectCategory.Name = "tlpSelectCategory";
            this.tlpSelectCategory.RowCount = 1;
            this.tlpSelectCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectCategory.Size = new System.Drawing.Size(775, 34);
            this.tlpSelectCategory.TabIndex = 5;
            // 
            // cmbCateogory
            // 
            this.cmbCateogory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCateogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCateogory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCateogory.ForeColor = System.Drawing.Color.Gray;
            this.cmbCateogory.FormattingEnabled = true;
            this.cmbCateogory.Location = new System.Drawing.Point(182, 6);
            this.cmbCateogory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbCateogory.Name = "cmbCateogory";
            this.cmbCateogory.Size = new System.Drawing.Size(238, 25);
            this.cmbCateogory.TabIndex = 1;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSelectCategory.Location = new System.Drawing.Point(0, 0);
            this.lblSelectCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(125, 34);
            this.lblSelectCategory.TabIndex = 0;
            this.lblSelectCategory.Text = "Expense Category :";
            this.lblSelectCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDefinition
            // 
            this.pnlDefinition.Controls.Add(this.tlpExpenseDefination);
            this.pnlDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDefinition.Location = new System.Drawing.Point(0, 68);
            this.pnlDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDefinition.Name = "pnlDefinition";
            this.pnlDefinition.Size = new System.Drawing.Size(775, 46);
            this.pnlDefinition.TabIndex = 4;
            // 
            // tlpExpenseDefination
            // 
            this.tlpExpenseDefination.ColumnCount = 4;
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenseDefination.Controls.Add(this.btnSubmit, 2, 0);
            this.tlpExpenseDefination.Controls.Add(this.lblExpenseDefination, 0, 0);
            this.tlpExpenseDefination.Controls.Add(this.txtExpenseDefination, 1, 0);
            this.tlpExpenseDefination.Controls.Add(this.pnlAddExpenseCategory, 3, 0);
            this.tlpExpenseDefination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenseDefination.Location = new System.Drawing.Point(0, 0);
            this.tlpExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExpenseDefination.Name = "tlpExpenseDefination";
            this.tlpExpenseDefination.RowCount = 1;
            this.tlpExpenseDefination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenseDefination.Size = new System.Drawing.Size(775, 46);
            this.tlpExpenseDefination.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(475, 18);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // lblExpenseDefination
            // 
            this.lblExpenseDefination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpenseDefination.AutoSize = true;
            this.lblExpenseDefination.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseDefination.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExpenseDefination.Location = new System.Drawing.Point(0, 0);
            this.lblExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.lblExpenseDefination.Name = "lblExpenseDefination";
            this.lblExpenseDefination.Size = new System.Drawing.Size(123, 46);
            this.lblExpenseDefination.TabIndex = 0;
            this.lblExpenseDefination.Text = "Expense Definition:";
            this.lblExpenseDefination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpenseDefination
            // 
            this.txtExpenseDefination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExpenseDefination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpenseDefination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseDefination.ForeColor = System.Drawing.Color.Gray;
            this.txtExpenseDefination.Location = new System.Drawing.Point(182, 2);
            this.txtExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.txtExpenseDefination.Multiline = true;
            this.txtExpenseDefination.Name = "txtExpenseDefination";
            this.txtExpenseDefination.Size = new System.Drawing.Size(281, 44);
            this.txtExpenseDefination.TabIndex = 1;
            this.txtExpenseDefination.Text = "Enter a note about expense";
            this.txtExpenseDefination.Click += new System.EventHandler(this.txtExpenseDefination_Click_1);
            // 
            // pnlAddExpenseCategory
            // 
            this.pnlAddExpenseCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddExpenseCategory.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAddExpenseCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddExpenseCategory.Controls.Add(this.tlpAddButton);
            this.pnlAddExpenseCategory.Location = new System.Drawing.Point(663, 21);
            this.pnlAddExpenseCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddExpenseCategory.Name = "pnlAddExpenseCategory";
            this.pnlAddExpenseCategory.Size = new System.Drawing.Size(112, 25);
            this.pnlAddExpenseCategory.TabIndex = 4;
            this.pnlAddExpenseCategory.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.pnlAddExpenseCategory.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.pnlAddExpenseCategory.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.BackColor = System.Drawing.Color.Transparent;
            this.tlpAddButton.ColumnCount = 2;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53933F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.46067F));
            this.tlpAddButton.Controls.Add(this.lblAddNewExpenseCategory, 1, 0);
            this.tlpAddButton.Controls.Add(this.picAddIcon, 0, 0);
            this.tlpAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddButton.Location = new System.Drawing.Point(0, 0);
            this.tlpAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.Size = new System.Drawing.Size(110, 23);
            this.tlpAddButton.TabIndex = 5;
            this.tlpAddButton.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.tlpAddButton.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.tlpAddButton.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            // 
            // lblAddNewExpenseCategory
            // 
            this.lblAddNewExpenseCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewExpenseCategory.AutoSize = true;
            this.lblAddNewExpenseCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewExpenseCategory.ForeColor = System.Drawing.Color.White;
            this.lblAddNewExpenseCategory.Location = new System.Drawing.Point(22, 4);
            this.lblAddNewExpenseCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNewExpenseCategory.Name = "lblAddNewExpenseCategory";
            this.lblAddNewExpenseCategory.Size = new System.Drawing.Size(82, 15);
            this.lblAddNewExpenseCategory.TabIndex = 1;
            this.lblAddNewExpenseCategory.Text = "Add Category";
            this.lblAddNewExpenseCategory.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.lblAddNewExpenseCategory.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.lblAddNewExpenseCategory.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAddIcon.Image = global::GymManagementSystem.Properties.Resources.plus;
            this.picAddIcon.Location = new System.Drawing.Point(2, 2);
            this.picAddIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(16, 19);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 2;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSLNo.Width = 60;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.HeaderText = "Category Name";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExpenseAmount
            // 
            this.colExpenseAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExpenseAmount.DataPropertyName = "ExpenseAmount";
            this.colExpenseAmount.HeaderText = "Amount";
            this.colExpenseAmount.Name = "colExpenseAmount";
            // 
            // colExpenseDate
            // 
            this.colExpenseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExpenseDate.DataPropertyName = "ExpenseDate";
            this.colExpenseDate.HeaderText = "Expense Date";
            this.colExpenseDate.Name = "colExpenseDate";
            this.colExpenseDate.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Note";
            this.colNotes.Name = "colNotes";
            // 
            // FrmAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(862, 609);
            this.Controls.Add(this.tlpAddExpenses);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmAddExpenses";
            this.Text = "FrmAddExpenses";
            this.Load += new System.EventHandler(this.FrmAddExpenses_Load);
            this.tlpAddExpenses.ResumeLayout(false);
            this.tlpExpenses.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddExpenses)).EndInit();
            this.tlpTitleAndSubTitle.ResumeLayout(false);
            this.tlpTitleAndSubTitle.PerformLayout();
            this.tlpShowMemberTrainerAssignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.tlpAmount.ResumeLayout(false);
            this.tlpAmount.PerformLayout();
            this.tlpSearchBar.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.tlpSelectCategory.ResumeLayout(false);
            this.tlpSelectCategory.PerformLayout();
            this.pnlDefinition.ResumeLayout(false);
            this.tlpExpenseDefination.ResumeLayout(false);
            this.tlpExpenseDefination.PerformLayout();
            this.pnlAddExpenseCategory.ResumeLayout(false);
            this.tlpAddButton.ResumeLayout(false);
            this.tlpAddButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpTitleAndSubTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.PictureBox picAddExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpShowMemberTrainerAssignment;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpSearchBar;
        private System.Windows.Forms.TableLayoutPanel tlpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.TableLayoutPanel tlpSelectCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ComboBox cmbCateogory;
        private System.Windows.Forms.Panel pnlDefinition;
        private System.Windows.Forms.TableLayoutPanel tlpExpenseDefination;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblExpenseDefination;
        private System.Windows.Forms.TextBox txtExpenseDefination;
        private System.Windows.Forms.Panel pnlAddExpenseCategory;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.Label lblAddNewExpenseCategory;
        private System.Windows.Forms.PictureBox picAddIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}