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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddExpenses));
            this.tlpAddExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShowMemberTrainerAssignment = new System.Windows.Forms.TableLayoutPanel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAmount = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tlpSelectCategory = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCateogory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.tlpExpenseDefination = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpenseDefination = new System.Windows.Forms.Label();
            this.txtExpenseDefination = new System.Windows.Forms.TextBox();
            this.tlpSubmit = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picAddExpenses = new System.Windows.Forms.PictureBox();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddExpenseCategory = new System.Windows.Forms.Panel();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.lblAddNewExpenseCategory = new System.Windows.Forms.Label();
            this.tlpTitleAndSubTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.tlpAddExpenses.SuspendLayout();
            this.tlpExpenses.SuspendLayout();
            this.tlpShowMemberTrainerAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.tlpSearchBar.SuspendLayout();
            this.tlpAmount.SuspendLayout();
            this.tlpSelectCategory.SuspendLayout();
            this.tlpExpenseDefination.SuspendLayout();
            this.tlpSubmit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddExpenses)).BeginInit();
            this.tlpAddButton.SuspendLayout();
            this.pnlAddExpenseCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.tlpTitleAndSubTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAddExpenses
            // 
            this.tlpAddExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddExpenses.ColumnCount = 3;
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAddExpenses.Controls.Add(this.tlpExpenses, 1, 0);
            this.tlpAddExpenses.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpAddExpenses.ForeColor = System.Drawing.Color.Black;
            this.tlpAddExpenses.Location = new System.Drawing.Point(1, -1);
            this.tlpAddExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddExpenses.Name = "tlpAddExpenses";
            this.tlpAddExpenses.RowCount = 1;
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddExpenses.Size = new System.Drawing.Size(1147, 790);
            this.tlpAddExpenses.TabIndex = 1;
            this.tlpAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpExpenses
            // 
            this.tlpExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExpenses.ColumnCount = 1;
            this.tlpExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenses.Controls.Add(this.tlpShowMemberTrainerAssignment, 0, 2);
            this.tlpExpenses.Controls.Add(this.tlpSearchBar, 0, 1);
            this.tlpExpenses.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpExpenses.Location = new System.Drawing.Point(57, 0);
            this.tlpExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExpenses.Name = "tlpExpenses";
            this.tlpExpenses.RowCount = 4;
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.63291F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.24051F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpExpenses.Size = new System.Drawing.Size(1032, 790);
            this.tlpExpenses.TabIndex = 0;
            this.tlpExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpShowMemberTrainerAssignment
            // 
            this.tlpShowMemberTrainerAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowMemberTrainerAssignment.ColumnCount = 1;
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowMemberTrainerAssignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowMemberTrainerAssignment.Controls.Add(this.dgvExpenses, 0, 0);
            this.tlpShowMemberTrainerAssignment.Location = new System.Drawing.Point(0, 360);
            this.tlpShowMemberTrainerAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.tlpShowMemberTrainerAssignment.Name = "tlpShowMemberTrainerAssignment";
            this.tlpShowMemberTrainerAssignment.RowCount = 1;
            this.tlpShowMemberTrainerAssignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowMemberTrainerAssignment.Size = new System.Drawing.Size(1032, 389);
            this.tlpShowMemberTrainerAssignment.TabIndex = 4;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToResizeColumns = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.ColumnHeadersHeight = 55;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colExpenseId,
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
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvExpenses.Location = new System.Drawing.Point(3, 3);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvExpenses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpenses.RowTemplate.Height = 40;
            this.dgvExpenses.Size = new System.Drawing.Size(1026, 383);
            this.dgvExpenses.TabIndex = 0;
            this.dgvExpenses.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseEnter);
            this.dgvExpenses.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseLeave);
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSLNo.Width = 72;
            // 
            // colExpenseId
            // 
            this.colExpenseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colExpenseId.DataPropertyName = "ExpenseId";
            this.colExpenseId.HeaderText = "Expense Id";
            this.colExpenseId.Name = "colExpenseId";
            this.colExpenseId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExpenseId.Width = 117;
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
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExpenseAmount
            // 
            this.colExpenseAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colExpenseAmount.DataPropertyName = "ExpenseAmount";
            this.colExpenseAmount.HeaderText = "Amount";
            this.colExpenseAmount.Name = "colExpenseAmount";
            this.colExpenseAmount.Width = 111;
            // 
            // colExpenseDate
            // 
            this.colExpenseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpenseDate.DataPropertyName = "ExpenseDate";
            this.colExpenseDate.HeaderText = "Expense Date";
            this.colExpenseDate.Name = "colExpenseDate";
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Note";
            this.colNotes.Name = "colNotes";
            // 
            // tlpSearchBar
            // 
            this.tlpSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchBar.ColumnCount = 1;
            this.tlpSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchBar.Controls.Add(this.tlpAmount, 0, 0);
            this.tlpSearchBar.Controls.Add(this.tlpSelectCategory, 0, 1);
            this.tlpSearchBar.Controls.Add(this.tlpExpenseDefination, 0, 2);
            this.tlpSearchBar.Controls.Add(this.tlpSubmit, 0, 3);
            this.tlpSearchBar.Location = new System.Drawing.Point(0, 118);
            this.tlpSearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchBar.Name = "tlpSearchBar";
            this.tlpSearchBar.RowCount = 4;
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tlpSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tlpSearchBar.Size = new System.Drawing.Size(1032, 242);
            this.tlpSearchBar.TabIndex = 1;
            // 
            // tlpAmount
            // 
            this.tlpAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAmount.ColumnCount = 2;
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAmount.Controls.Add(this.lblAmount, 0, 0);
            this.tlpAmount.Controls.Add(this.txtAmount, 1, 0);
            this.tlpAmount.Location = new System.Drawing.Point(0, 0);
            this.tlpAmount.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAmount.Name = "tlpAmount";
            this.tlpAmount.RowCount = 1;
            this.tlpAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAmount.Size = new System.Drawing.Size(1032, 54);
            this.tlpAmount.TabIndex = 0;
            this.tlpAmount.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAmount.Location = new System.Drawing.Point(0, 13);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 28);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount :";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAmount.Location = new System.Drawing.Point(309, 12);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(242, 30);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "Enter Amount";
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click);
            // 
            // tlpSelectCategory
            // 
            this.tlpSelectCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectCategory.ColumnCount = 2;
            this.tlpSelectCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSelectCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpSelectCategory.Controls.Add(this.cmbCateogory, 1, 0);
            this.tlpSelectCategory.Controls.Add(this.lblSelectCategory, 0, 0);
            this.tlpSelectCategory.Location = new System.Drawing.Point(0, 54);
            this.tlpSelectCategory.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSelectCategory.Name = "tlpSelectCategory";
            this.tlpSelectCategory.RowCount = 1;
            this.tlpSelectCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectCategory.Size = new System.Drawing.Size(1032, 54);
            this.tlpSelectCategory.TabIndex = 0;
            this.tlpSelectCategory.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // cmbCateogory
            // 
            this.cmbCateogory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCateogory.ForeColor = System.Drawing.Color.Black;
            this.cmbCateogory.FormattingEnabled = true;
            this.cmbCateogory.Location = new System.Drawing.Point(309, 9);
            this.cmbCateogory.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCateogory.Name = "cmbCateogory";
            this.cmbCateogory.Size = new System.Drawing.Size(242, 36);
            this.cmbCateogory.TabIndex = 1;
            this.cmbCateogory.Text = " --Select Category--";
            this.cmbCateogory.Click += new System.EventHandler(this.cmbCateogory_Click);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSelectCategory.Location = new System.Drawing.Point(0, 13);
            this.lblSelectCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(165, 28);
            this.lblSelectCategory.TabIndex = 0;
            this.lblSelectCategory.Text = "Select Category :";
            this.lblSelectCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectCategory.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpExpenseDefination
            // 
            this.tlpExpenseDefination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExpenseDefination.ColumnCount = 2;
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpExpenseDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpExpenseDefination.Controls.Add(this.lblExpenseDefination, 0, 0);
            this.tlpExpenseDefination.Controls.Add(this.txtExpenseDefination, 1, 0);
            this.tlpExpenseDefination.Location = new System.Drawing.Point(0, 108);
            this.tlpExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExpenseDefination.Name = "tlpExpenseDefination";
            this.tlpExpenseDefination.RowCount = 1;
            this.tlpExpenseDefination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenseDefination.Size = new System.Drawing.Size(1032, 77);
            this.tlpExpenseDefination.TabIndex = 0;
            this.tlpExpenseDefination.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblExpenseDefination
            // 
            this.lblExpenseDefination.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpenseDefination.AutoSize = true;
            this.lblExpenseDefination.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblExpenseDefination.Location = new System.Drawing.Point(0, 24);
            this.lblExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.lblExpenseDefination.Name = "lblExpenseDefination";
            this.lblExpenseDefination.Size = new System.Drawing.Size(193, 28);
            this.lblExpenseDefination.TabIndex = 0;
            this.lblExpenseDefination.Text = "Expense Defination:";
            this.lblExpenseDefination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpenseDefination.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // txtExpenseDefination
            // 
            this.txtExpenseDefination.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtExpenseDefination.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtExpenseDefination.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtExpenseDefination.Location = new System.Drawing.Point(309, 10);
            this.txtExpenseDefination.Margin = new System.Windows.Forms.Padding(0);
            this.txtExpenseDefination.Multiline = true;
            this.txtExpenseDefination.Name = "txtExpenseDefination";
            this.txtExpenseDefination.Size = new System.Drawing.Size(324, 57);
            this.txtExpenseDefination.TabIndex = 1;
            this.txtExpenseDefination.Text = " e.g. maintenance for treadmills";
            this.txtExpenseDefination.Click += new System.EventHandler(this.txtExpenseDefination_Click);
            // 
            // tlpSubmit
            // 
            this.tlpSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSubmit.ColumnCount = 2;
            this.tlpSubmit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.77519F));
            this.tlpSubmit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.22481F));
            this.tlpSubmit.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpSubmit.Location = new System.Drawing.Point(0, 185);
            this.tlpSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSubmit.Name = "tlpSubmit";
            this.tlpSubmit.RowCount = 1;
            this.tlpSubmit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubmit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpSubmit.Size = new System.Drawing.Size(1032, 57);
            this.tlpSubmit.TabIndex = 1;
            this.tlpSubmit.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(523, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 57);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 43);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // tlpHeader
            // 
            this.tlpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpHeader.ColumnCount = 3;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Controls.Add(this.picAddExpenses, 0, 0);
            this.tlpHeader.Controls.Add(this.tlpAddButton, 2, 0);
            this.tlpHeader.Controls.Add(this.tlpTitleAndSubTitle, 1, 0);
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1032, 118);
            this.tlpHeader.TabIndex = 0;
            this.tlpHeader.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // picAddExpenses
            // 
            this.picAddExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddExpenses.Image = ((System.Drawing.Image)(resources.GetObject("picAddExpenses.Image")));
            this.picAddExpenses.Location = new System.Drawing.Point(0, 0);
            this.picAddExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.picAddExpenses.Name = "picAddExpenses";
            this.picAddExpenses.Size = new System.Drawing.Size(70, 118);
            this.picAddExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddExpenses.TabIndex = 1;
            this.picAddExpenses.TabStop = false;
            this.picAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpAddButton.ColumnCount = 1;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAddButton.Controls.Add(this.pnlAddExpenseCategory, 0, 0);
            this.tlpAddButton.Location = new System.Drawing.Point(844, 40);
            this.tlpAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpAddButton.Size = new System.Drawing.Size(188, 38);
            this.tlpAddButton.TabIndex = 2;
            // 
            // pnlAddExpenseCategory
            // 
            this.pnlAddExpenseCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.pnlAddExpenseCategory.Controls.Add(this.picAddIcon);
            this.pnlAddExpenseCategory.Controls.Add(this.lblAddNewExpenseCategory);
            this.pnlAddExpenseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddExpenseCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlAddExpenseCategory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddExpenseCategory.Name = "pnlAddExpenseCategory";
            this.pnlAddExpenseCategory.Size = new System.Drawing.Size(188, 38);
            this.pnlAddExpenseCategory.TabIndex = 1;
            this.pnlAddExpenseCategory.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.pnlAddExpenseCategory.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.pnlAddExpenseCategory.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            this.pnlAddExpenseCategory.MouseHover += new System.EventHandler(this.pnlAddExpenseCategory_MouseHover);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(6, 10);
            this.picAddIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(29, 21);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 1;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            this.picAddIcon.MouseHover += new System.EventHandler(this.pnlAddExpenseCategory_MouseHover);
            // 
            // lblAddNewExpenseCategory
            // 
            this.lblAddNewExpenseCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddNewExpenseCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddNewExpenseCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewExpenseCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAddNewExpenseCategory.Location = new System.Drawing.Point(0, 0);
            this.lblAddNewExpenseCategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddNewExpenseCategory.Name = "lblAddNewExpenseCategory";
            this.lblAddNewExpenseCategory.Size = new System.Drawing.Size(187, 38);
            this.lblAddNewExpenseCategory.TabIndex = 0;
            this.lblAddNewExpenseCategory.Text = "    Add Category";
            this.lblAddNewExpenseCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewExpenseCategory.Click += new System.EventHandler(this.pnlAddExpenseCategory_Click);
            this.lblAddNewExpenseCategory.MouseEnter += new System.EventHandler(this.pnlAddExpenseCategory_MouseEnter);
            this.lblAddNewExpenseCategory.MouseLeave += new System.EventHandler(this.pnlAddExpenseCategory_MouseLeave);
            this.lblAddNewExpenseCategory.MouseHover += new System.EventHandler(this.pnlAddExpenseCategory_MouseHover);
            // 
            // tlpTitleAndSubTitle
            // 
            this.tlpTitleAndSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTitleAndSubTitle.ColumnCount = 1;
            this.tlpTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitleAndSubTitle.Controls.Add(this.lblHeader, 0, 0);
            this.tlpTitleAndSubTitle.Controls.Add(this.lblSubTitle, 0, 1);
            this.tlpTitleAndSubTitle.Location = new System.Drawing.Point(70, 0);
            this.tlpTitleAndSubTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitleAndSubTitle.Name = "tlpTitleAndSubTitle";
            this.tlpTitleAndSubTitle.RowCount = 3;
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpTitleAndSubTitle.Size = new System.Drawing.Size(481, 118);
            this.tlpTitleAndSubTitle.TabIndex = 0;
            this.tlpTitleAndSubTitle.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(3, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(475, 28);
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
            this.lblSubTitle.Location = new System.Drawing.Point(3, 64);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(475, 19);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Record a new expense and assign it to a category";
            this.lblSubTitle.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // FrmAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpAddExpenses);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddExpenses";
            this.Text = "FrmAddExpenses";
            this.Load += new System.EventHandler(this.FrmAddExpenses_Load);
            this.tlpAddExpenses.ResumeLayout(false);
            this.tlpExpenses.ResumeLayout(false);
            this.tlpShowMemberTrainerAssignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.tlpSearchBar.ResumeLayout(false);
            this.tlpAmount.ResumeLayout(false);
            this.tlpAmount.PerformLayout();
            this.tlpSelectCategory.ResumeLayout(false);
            this.tlpSelectCategory.PerformLayout();
            this.tlpExpenseDefination.ResumeLayout(false);
            this.tlpExpenseDefination.PerformLayout();
            this.tlpSubmit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddExpenses)).EndInit();
            this.tlpAddButton.ResumeLayout(false);
            this.pnlAddExpenseCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.tlpTitleAndSubTitle.ResumeLayout(false);
            this.tlpTitleAndSubTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpShowMemberTrainerAssignment;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpSearchBar;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.TableLayoutPanel tlpTitleAndSubTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.PictureBox picAddExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.Panel pnlAddExpenseCategory;
        private System.Windows.Forms.PictureBox picAddIcon;
        private System.Windows.Forms.Label lblAddNewExpenseCategory;
        private System.Windows.Forms.TableLayoutPanel tlpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TableLayoutPanel tlpSelectCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ComboBox cmbCateogory;
        private System.Windows.Forms.TableLayoutPanel tlpExpenseDefination;
        private System.Windows.Forms.Label lblExpenseDefination;
        private System.Windows.Forms.TextBox txtExpenseDefination;
        private System.Windows.Forms.TableLayoutPanel tlpSubmit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}