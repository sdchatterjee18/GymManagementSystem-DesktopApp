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
            this.tlpAddExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.tblAddExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddNewExpensesCategory = new System.Windows.Forms.Panel();
            this.picAddNewExpensesCategory = new System.Windows.Forms.PictureBox();
            this.lblAddnewExpensesCategory = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.lblAddNewExpenses = new System.Windows.Forms.Label();
            this.tlpAmountSection = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tplAmountSection = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtAmountErrorMessage = new System.Windows.Forms.TextBox();
            this.tlpExpensesCategorySection = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpensesCategory = new System.Windows.Forms.Label();
            this.cmbSelcetCatogory = new System.Windows.Forms.ComboBox();
            this.tlpExpensesDefinationSection = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExpensesDefination = new System.Windows.Forms.TableLayoutPanel();
            this.txtExpensesDefination = new System.Windows.Forms.TextBox();
            this.txtDefinationErrorMessage = new System.Windows.Forms.TextBox();
            this.lblExpensesDefination = new System.Windows.Forms.Label();
            this.tlpSubmit = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tlpShowExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.ExpensesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpensesCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpAddExpenses.SuspendLayout();
            this.tblAddExpenses.SuspendLayout();
            this.pnlAddNewExpensesCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewExpensesCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.tlpAmountSection.SuspendLayout();
            this.tplAmountSection.SuspendLayout();
            this.tlpExpensesCategorySection.SuspendLayout();
            this.tlpExpensesDefinationSection.SuspendLayout();
            this.tlpExpensesDefination.SuspendLayout();
            this.tlpSubmit.SuspendLayout();
            this.tlpShowExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAddExpenses
            // 
            this.tlpAddExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddExpenses.ColumnCount = 1;
            this.tlpAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddExpenses.Controls.Add(this.tblAddExpenses, 0, 1);
            this.tlpAddExpenses.Controls.Add(this.tlpAmountSection, 0, 3);
            this.tlpAddExpenses.Controls.Add(this.tlpExpensesCategorySection, 0, 5);
            this.tlpAddExpenses.Controls.Add(this.tlpExpensesDefinationSection, 0, 7);
            this.tlpAddExpenses.Controls.Add(this.tlpSubmit, 0, 8);
            this.tlpAddExpenses.Controls.Add(this.tlpShowExpenses, 0, 9);
            this.tlpAddExpenses.Location = new System.Drawing.Point(0, 0);
            this.tlpAddExpenses.Name = "tlpAddExpenses";
            this.tlpAddExpenses.RowCount = 11;
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5028527F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.390863F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.142132F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6599F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.77665F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.472081F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.903553F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.56345F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02538F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.79696F));
            this.tlpAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5028527F));
            this.tlpAddExpenses.Size = new System.Drawing.Size(1158, 788);
            this.tlpAddExpenses.TabIndex = 0;
            this.tlpAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tblAddExpenses
            // 
            this.tblAddExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAddExpenses.ColumnCount = 4;
            this.tblAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tblAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89931F));
            this.tblAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75347F));
            this.tblAddExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.96528F));
            this.tblAddExpenses.Controls.Add(this.pnlAddNewExpensesCategory, 3, 0);
            this.tblAddExpenses.Controls.Add(this.picRefresh, 0, 0);
            this.tblAddExpenses.Controls.Add(this.lblAddNewExpenses, 1, 0);
            this.tblAddExpenses.Location = new System.Drawing.Point(3, 6);
            this.tblAddExpenses.Name = "tblAddExpenses";
            this.tblAddExpenses.RowCount = 1;
            this.tblAddExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAddExpenses.Size = new System.Drawing.Size(1152, 68);
            this.tblAddExpenses.TabIndex = 0;
            this.tblAddExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // pnlAddNewExpensesCategory
            // 
            this.pnlAddNewExpensesCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlAddNewExpensesCategory.Controls.Add(this.picAddNewExpensesCategory);
            this.pnlAddNewExpensesCategory.Controls.Add(this.lblAddnewExpensesCategory);
            this.pnlAddNewExpensesCategory.Location = new System.Drawing.Point(636, 7);
            this.pnlAddNewExpensesCategory.Name = "pnlAddNewExpensesCategory";
            this.pnlAddNewExpensesCategory.Size = new System.Drawing.Size(354, 53);
            this.pnlAddNewExpensesCategory.TabIndex = 1;
            this.pnlAddNewExpensesCategory.Click += new System.EventHandler(this.pnlAddNewExpensesCategory_Click);
            this.pnlAddNewExpensesCategory.MouseEnter += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseEnter);
            this.pnlAddNewExpensesCategory.MouseLeave += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseLeave);
            this.pnlAddNewExpensesCategory.MouseHover += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseHover);
            // 
            // picAddNewExpensesCategory
            // 
            this.picAddNewExpensesCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddNewExpensesCategory.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewExpensesCategory.Image")));
            this.picAddNewExpensesCategory.Location = new System.Drawing.Point(7, 10);
            this.picAddNewExpensesCategory.Name = "picAddNewExpensesCategory";
            this.picAddNewExpensesCategory.Size = new System.Drawing.Size(56, 35);
            this.picAddNewExpensesCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewExpensesCategory.TabIndex = 1;
            this.picAddNewExpensesCategory.TabStop = false;
            this.picAddNewExpensesCategory.Click += new System.EventHandler(this.pnlAddNewExpensesCategory_Click);
            this.picAddNewExpensesCategory.MouseEnter += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseEnter);
            this.picAddNewExpensesCategory.MouseLeave += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseLeave);
            this.picAddNewExpensesCategory.MouseHover += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseHover);
            // 
            // lblAddnewExpensesCategory
            // 
            this.lblAddnewExpensesCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddnewExpensesCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblAddnewExpensesCategory.Location = new System.Drawing.Point(0, 0);
            this.lblAddnewExpensesCategory.Name = "lblAddnewExpensesCategory";
            this.lblAddnewExpensesCategory.Size = new System.Drawing.Size(354, 53);
            this.lblAddnewExpensesCategory.TabIndex = 0;
            this.lblAddnewExpensesCategory.Text = "      New Expenses Category";
            this.lblAddnewExpensesCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddnewExpensesCategory.Click += new System.EventHandler(this.pnlAddNewExpensesCategory_Click);
            this.lblAddnewExpensesCategory.MouseEnter += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseEnter);
            this.lblAddnewExpensesCategory.MouseLeave += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseLeave);
            this.lblAddnewExpensesCategory.MouseHover += new System.EventHandler(this.pnlAddNewExpensesCategory_MouseHover);
            // 
            // picRefresh
            // 
            this.picRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(29, 20);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(31, 28);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 2;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // lblAddNewExpenses
            // 
            this.lblAddNewExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddNewExpenses.AutoSize = true;
            this.lblAddNewExpenses.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewExpenses.Location = new System.Drawing.Point(66, 0);
            this.lblAddNewExpenses.Name = "lblAddNewExpenses";
            this.lblAddNewExpenses.Size = new System.Drawing.Size(259, 68);
            this.lblAddNewExpenses.TabIndex = 0;
            this.lblAddNewExpenses.Text = "Add New Expenses";
            this.lblAddNewExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAmountSection
            // 
            this.tlpAmountSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAmountSection.ColumnCount = 4;
            this.tlpAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.208333F));
            this.tlpAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.56944F));
            this.tlpAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.56597F));
            this.tlpAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65625F));
            this.tlpAmountSection.Controls.Add(this.lblAmount, 1, 0);
            this.tlpAmountSection.Controls.Add(this.tplAmountSection, 2, 0);
            this.tlpAmountSection.Location = new System.Drawing.Point(3, 89);
            this.tlpAmountSection.Name = "tlpAmountSection";
            this.tlpAmountSection.RowCount = 1;
            this.tlpAmountSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAmountSection.Size = new System.Drawing.Size(1152, 78);
            this.tlpAmountSection.TabIndex = 1;
            this.tlpAmountSection.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(63, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(253, 78);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount :";
            // 
            // tplAmountSection
            // 
            this.tplAmountSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tplAmountSection.ColumnCount = 1;
            this.tplAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplAmountSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplAmountSection.Controls.Add(this.txtAmount, 0, 0);
            this.tplAmountSection.Controls.Add(this.txtAmountErrorMessage, 0, 1);
            this.tplAmountSection.Location = new System.Drawing.Point(322, 3);
            this.tplAmountSection.Name = "tplAmountSection";
            this.tplAmountSection.RowCount = 2;
            this.tplAmountSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tplAmountSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tplAmountSection.Size = new System.Drawing.Size(276, 72);
            this.tplAmountSection.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(3, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(270, 34);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "Enter Amount";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click);
            // 
            // txtAmountErrorMessage
            // 
            this.txtAmountErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtAmountErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountErrorMessage.Location = new System.Drawing.Point(3, 43);
            this.txtAmountErrorMessage.Name = "txtAmountErrorMessage";
            this.txtAmountErrorMessage.ReadOnly = true;
            this.txtAmountErrorMessage.Size = new System.Drawing.Size(270, 23);
            this.txtAmountErrorMessage.TabIndex = 2;
            // 
            // tlpExpensesCategorySection
            // 
            this.tlpExpensesCategorySection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExpensesCategorySection.ColumnCount = 4;
            this.tlpExpensesCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.034722F));
            this.tlpExpensesCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.00347F));
            this.tlpExpensesCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39236F));
            this.tlpExpensesCategorySection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74306F));
            this.tlpExpensesCategorySection.Controls.Add(this.lblExpensesCategory, 1, 0);
            this.tlpExpensesCategorySection.Controls.Add(this.cmbSelcetCatogory, 2, 0);
            this.tlpExpensesCategorySection.Location = new System.Drawing.Point(3, 187);
            this.tlpExpensesCategorySection.Name = "tlpExpensesCategorySection";
            this.tlpExpensesCategorySection.RowCount = 1;
            this.tlpExpensesCategorySection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpensesCategorySection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpExpensesCategorySection.Size = new System.Drawing.Size(1152, 45);
            this.tlpExpensesCategorySection.TabIndex = 2;
            this.tlpExpensesCategorySection.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            this.tlpExpensesCategorySection.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpExpensesCategorySection_Paint);
            // 
            // lblExpensesCategory
            // 
            this.lblExpensesCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpensesCategory.AutoSize = true;
            this.lblExpensesCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblExpensesCategory.Location = new System.Drawing.Point(60, 0);
            this.lblExpensesCategory.Name = "lblExpensesCategory";
            this.lblExpensesCategory.Size = new System.Drawing.Size(258, 45);
            this.lblExpensesCategory.TabIndex = 0;
            this.lblExpensesCategory.Text = "Expenses Category :";
            this.lblExpensesCategory.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // cmbSelcetCatogory
            // 
            this.cmbSelcetCatogory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelcetCatogory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelcetCatogory.FormattingEnabled = true;
            this.cmbSelcetCatogory.Location = new System.Drawing.Point(324, 3);
            this.cmbSelcetCatogory.Name = "cmbSelcetCatogory";
            this.cmbSelcetCatogory.Size = new System.Drawing.Size(274, 36);
            this.cmbSelcetCatogory.TabIndex = 1;
            this.cmbSelcetCatogory.Text = "             Category";
            this.cmbSelcetCatogory.SelectedIndexChanged += new System.EventHandler(this.cmbSelcetCatogory_SelectedIndexChanged);
            // 
            // tlpExpensesDefinationSection
            // 
            this.tlpExpensesDefinationSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExpensesDefinationSection.ColumnCount = 4;
            this.tlpExpensesDefinationSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.121528F));
            this.tlpExpensesDefinationSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.82986F));
            this.tlpExpensesDefinationSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8125F));
            this.tlpExpensesDefinationSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.40972F));
            this.tlpExpensesDefinationSection.Controls.Add(this.tlpExpensesDefination, 2, 0);
            this.tlpExpensesDefinationSection.Controls.Add(this.lblExpensesDefination, 1, 0);
            this.tlpExpensesDefinationSection.Location = new System.Drawing.Point(3, 253);
            this.tlpExpensesDefinationSection.Name = "tlpExpensesDefinationSection";
            this.tlpExpensesDefinationSection.RowCount = 1;
            this.tlpExpensesDefinationSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpensesDefinationSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tlpExpensesDefinationSection.Size = new System.Drawing.Size(1152, 93);
            this.tlpExpensesDefinationSection.TabIndex = 3;
            this.tlpExpensesDefinationSection.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpExpensesDefination
            // 
            this.tlpExpensesDefination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpExpensesDefination.ColumnCount = 1;
            this.tlpExpensesDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpensesDefination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpensesDefination.Controls.Add(this.txtExpensesDefination, 0, 0);
            this.tlpExpensesDefination.Controls.Add(this.txtDefinationErrorMessage, 0, 1);
            this.tlpExpensesDefination.Location = new System.Drawing.Point(323, 3);
            this.tlpExpensesDefination.Name = "tlpExpensesDefination";
            this.tlpExpensesDefination.RowCount = 2;
            this.tlpExpensesDefination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tlpExpensesDefination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tlpExpensesDefination.Size = new System.Drawing.Size(371, 87);
            this.tlpExpensesDefination.TabIndex = 1;
            // 
            // txtExpensesDefination
            // 
            this.txtExpensesDefination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpensesDefination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpensesDefination.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesDefination.Location = new System.Drawing.Point(3, 3);
            this.txtExpensesDefination.Multiline = true;
            this.txtExpensesDefination.Name = "txtExpensesDefination";
            this.txtExpensesDefination.Size = new System.Drawing.Size(365, 56);
            this.txtExpensesDefination.TabIndex = 1;
            this.txtExpensesDefination.Text = "Defination";
            this.txtExpensesDefination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpensesDefination.Click += new System.EventHandler(this.txtExpensesDefination_Click);
            // 
            // txtDefinationErrorMessage
            // 
            this.txtDefinationErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefinationErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtDefinationErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefinationErrorMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinationErrorMessage.Location = new System.Drawing.Point(3, 65);
            this.txtDefinationErrorMessage.Name = "txtDefinationErrorMessage";
            this.txtDefinationErrorMessage.ReadOnly = true;
            this.txtDefinationErrorMessage.Size = new System.Drawing.Size(365, 23);
            this.txtDefinationErrorMessage.TabIndex = 2;
            // 
            // lblExpensesDefination
            // 
            this.lblExpensesDefination.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpensesDefination.AutoSize = true;
            this.lblExpensesDefination.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensesDefination.Location = new System.Drawing.Point(61, 0);
            this.lblExpensesDefination.Name = "lblExpensesDefination";
            this.lblExpensesDefination.Size = new System.Drawing.Size(256, 93);
            this.lblExpensesDefination.TabIndex = 0;
            this.lblExpensesDefination.Text = "Expense Defination :";
            this.lblExpensesDefination.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // tlpSubmit
            // 
            this.tlpSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSubmit.ColumnCount = 3;
            this.tlpSubmit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tlpSubmit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.tlpSubmit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89931F));
            this.tlpSubmit.Controls.Add(this.btnSubmit, 1, 0);
            this.tlpSubmit.Location = new System.Drawing.Point(3, 352);
            this.tlpSubmit.Name = "tlpSubmit";
            this.tlpSubmit.RowCount = 1;
            this.tlpSubmit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubmit.Size = new System.Drawing.Size(1152, 73);
            this.tlpSubmit.TabIndex = 4;
            this.tlpSubmit.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(639, 16);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 41);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tlpShowExpenses
            // 
            this.tlpShowExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowExpenses.ColumnCount = 3;
            this.tlpShowExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.947917F));
            this.tlpShowExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.27778F));
            this.tlpShowExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tlpShowExpenses.Controls.Add(this.dgvExpenses, 1, 0);
            this.tlpShowExpenses.Location = new System.Drawing.Point(3, 431);
            this.tlpShowExpenses.Name = "tlpShowExpenses";
            this.tlpShowExpenses.RowCount = 1;
            this.tlpShowExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowExpenses.Size = new System.Drawing.Size(1152, 347);
            this.tlpShowExpenses.TabIndex = 5;
            this.tlpShowExpenses.Click += new System.EventHandler(this.tlpAddExpenses_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToResizeColumns = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            this.dgvExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpensesId,
            this.CategoryName,
            this.ExpensesCategory,
            this.Amount,
            this.Date,
            this.Note});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.Silver;
            this.dgvExpenses.Location = new System.Drawing.Point(60, 3);
            this.dgvExpenses.Name = "dgvExpenses";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenses.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvExpenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenses.RowTemplate.Height = 30;
            this.dgvExpenses.Size = new System.Drawing.Size(1034, 341);
            this.dgvExpenses.TabIndex = 0;
            this.dgvExpenses.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseEnter);
            this.dgvExpenses.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellMouseLeave);
            this.dgvExpenses.MouseEnter += new System.EventHandler(this.dgvExpenses_MouseEnter);
            // 
            // ExpensesId
            // 
            this.ExpensesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpensesId.DataPropertyName = "ColExpensesId";
            this.ExpensesId.HeaderText = "Expenses Id";
            this.ExpensesId.Name = "ExpensesId";
            this.ExpensesId.ReadOnly = true;
            this.ExpensesId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "ColCategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpensesCategory
            // 
            this.ExpensesCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpensesCategory.DataPropertyName = "ColCategory";
            this.ExpensesCategory.HeaderText = "Expenses Category";
            this.ExpensesCategory.Name = "ExpensesCategory";
            this.ExpensesCategory.ReadOnly = true;
            this.ExpensesCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "ColExpenseAmount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "ColExpenseDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "ColNotes";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1158, 788);
            this.Controls.Add(this.tlpAddExpenses);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1176, 835);
            this.MinimumSize = new System.Drawing.Size(1176, 835);
            this.Name = "FrmAddExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddExpenses";
            this.Load += new System.EventHandler(this.FrmAddExpenses_Load);
            this.tlpAddExpenses.ResumeLayout(false);
            this.tblAddExpenses.ResumeLayout(false);
            this.tblAddExpenses.PerformLayout();
            this.pnlAddNewExpensesCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewExpensesCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.tlpAmountSection.ResumeLayout(false);
            this.tlpAmountSection.PerformLayout();
            this.tplAmountSection.ResumeLayout(false);
            this.tplAmountSection.PerformLayout();
            this.tlpExpensesCategorySection.ResumeLayout(false);
            this.tlpExpensesCategorySection.PerformLayout();
            this.tlpExpensesDefinationSection.ResumeLayout(false);
            this.tlpExpensesDefinationSection.PerformLayout();
            this.tlpExpensesDefination.ResumeLayout(false);
            this.tlpExpensesDefination.PerformLayout();
            this.tlpSubmit.ResumeLayout(false);
            this.tlpShowExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddExpenses;
        private System.Windows.Forms.TableLayoutPanel tblAddExpenses;
        private System.Windows.Forms.Label lblAddNewExpenses;
        private System.Windows.Forms.Panel pnlAddNewExpensesCategory;
        private System.Windows.Forms.PictureBox picAddNewExpensesCategory;
        private System.Windows.Forms.Label lblAddnewExpensesCategory;
        private System.Windows.Forms.TableLayoutPanel tlpAmountSection;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TableLayoutPanel tlpExpensesCategorySection;
        private System.Windows.Forms.Label lblExpensesCategory;
        private System.Windows.Forms.ComboBox cmbSelcetCatogory;
        private System.Windows.Forms.TableLayoutPanel tlpExpensesDefinationSection;
        private System.Windows.Forms.Label lblExpensesDefination;
        private System.Windows.Forms.TextBox txtExpensesDefination;
        private System.Windows.Forms.TableLayoutPanel tlpSubmit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tlpShowExpenses;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.TableLayoutPanel tplAmountSection;
        private System.Windows.Forms.TextBox txtAmountErrorMessage;
        private System.Windows.Forms.TableLayoutPanel tlpExpensesDefination;
        private System.Windows.Forms.TextBox txtDefinationErrorMessage;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpensesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpensesCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}