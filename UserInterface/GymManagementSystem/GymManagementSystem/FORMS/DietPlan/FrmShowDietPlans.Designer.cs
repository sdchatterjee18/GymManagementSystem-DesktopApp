namespace GymManagementSystem.FORMS.DietPlan
{
    partial class FrmShowDietPlans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowDietPlans));
            this.tlpShowDietPlanAndAddNewDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.tlpShowDietPlan = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDietPlan = new System.Windows.Forms.DataGridView();
            this.colSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDietPlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCaloriesPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpDietPlanHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleAndSubTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddNewDietPlan = new System.Windows.Forms.Panel();
            this.tlpAddButton = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddNewDietPlan = new System.Windows.Forms.Label();
            this.picAddIcon = new System.Windows.Forms.PictureBox();
            this.tlpDietPlanTitleAndSubTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblDietPlan = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.picDietPlan = new System.Windows.Forms.PictureBox();
            this.tlpShowDietPlanAndAddNewDietPlan.SuspendLayout();
            this.tlpShowDietPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).BeginInit();
            this.tlpDietPlanHeader.SuspendLayout();
            this.tlpTitleAndSubTitleBar.SuspendLayout();
            this.pnlAddNewDietPlan.SuspendLayout();
            this.tlpAddButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).BeginInit();
            this.tlpDietPlanTitleAndSubTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDietPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpShowDietPlanAndAddNewDietPlan
            // 
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnCount = 1;
            this.tlpShowDietPlanAndAddNewDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpShowDietPlan, 0, 1);
            this.tlpShowDietPlanAndAddNewDietPlan.Controls.Add(this.tlpDietPlanHeader, 0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowDietPlanAndAddNewDietPlan.Location = new System.Drawing.Point(0, 0);
            this.tlpShowDietPlanAndAddNewDietPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpShowDietPlanAndAddNewDietPlan.Name = "tlpShowDietPlanAndAddNewDietPlan";
            this.tlpShowDietPlanAndAddNewDietPlan.RowCount = 3;
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpShowDietPlanAndAddNewDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowDietPlanAndAddNewDietPlan.Size = new System.Drawing.Size(1149, 750);
            this.tlpShowDietPlanAndAddNewDietPlan.TabIndex = 1;
            this.tlpShowDietPlanAndAddNewDietPlan.Click += new System.EventHandler(this.tlpShowDietPlanAndAddNewDietPlan_Click);
            // 
            // tlpShowDietPlan
            // 
            this.tlpShowDietPlan.ColumnCount = 3;
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpShowDietPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpShowDietPlan.Controls.Add(this.dgvDietPlan, 1, 0);
            this.tlpShowDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpShowDietPlan.Location = new System.Drawing.Point(3, 114);
            this.tlpShowDietPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpShowDietPlan.Name = "tlpShowDietPlan";
            this.tlpShowDietPlan.RowCount = 1;
            this.tlpShowDietPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowDietPlan.Size = new System.Drawing.Size(1143, 596);
            this.tlpShowDietPlan.TabIndex = 0;
            this.tlpShowDietPlan.Click += new System.EventHandler(this.tlpShowDietPlan_Click);
            // 
            // dgvDietPlan
            // 
            this.dgvDietPlan.AllowUserToAddRows = false;
            this.dgvDietPlan.AllowUserToResizeColumns = false;
            this.dgvDietPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDietPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDietPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDietPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDietPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDietPlan.ColumnHeadersHeight = 50;
            this.dgvDietPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDietPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSLNo,
            this.colDietPlanId,
            this.ColCaloriesPerDay,
            this.ColDocument,
            this.ColCondition,
            this.ColAction});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDietPlan.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDietPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDietPlan.EnableHeadersVisualStyles = false;
            this.dgvDietPlan.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDietPlan.Location = new System.Drawing.Point(60, 2);
            this.dgvDietPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDietPlan.Name = "dgvDietPlan";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDietPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDietPlan.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvDietPlan.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDietPlan.RowTemplate.Height = 40;
            this.dgvDietPlan.Size = new System.Drawing.Size(1022, 592);
            this.dgvDietPlan.TabIndex = 0;
            this.dgvDietPlan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDietPlan_CellFormatting);
            this.dgvDietPlan.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietPlan_CellMouseEnter);
            this.dgvDietPlan.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDietPlan_CellMouseLeave);
            this.dgvDietPlan.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDietPlan_CellPainting);
            this.dgvDietPlan.Click += new System.EventHandler(this.dgvDietPlan_Click);
            // 
            // colSLNo
            // 
            this.colSLNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colSLNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSLNo.HeaderText = "SL No";
            this.colSLNo.Name = "colSLNo";
            this.colSLNo.ReadOnly = true;
            this.colSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDietPlanId
            // 
            this.colDietPlanId.DataPropertyName = "DietPlanId";
            this.colDietPlanId.HeaderText = "DietPlanId";
            this.colDietPlanId.Name = "colDietPlanId";
            this.colDietPlanId.Visible = false;
            // 
            // ColCaloriesPerDay
            // 
            this.ColCaloriesPerDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCaloriesPerDay.DataPropertyName = "CaloriesPerDay";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCaloriesPerDay.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCaloriesPerDay.HeaderText = "Needed calories";
            this.ColCaloriesPerDay.Name = "ColCaloriesPerDay";
            this.ColCaloriesPerDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDocument
            // 
            this.ColDocument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDocument.DataPropertyName = "DietPlanDocument";
            this.ColDocument.HeaderText = "Document";
            this.ColDocument.Name = "ColDocument";
            this.ColDocument.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCondition
            // 
            this.ColCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCondition.DataPropertyName = "ConditionStatus";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCondition.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCondition.HeaderText = "Condition";
            this.ColCondition.Name = "ColCondition";
            this.ColCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAction
            // 
            this.ColAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LimeGreen;
            this.ColAction.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColAction.HeaderText = "Action";
            this.ColAction.Name = "ColAction";
            this.ColAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAction.Text = "📝Update";
            this.ColAction.ToolTipText = "📝Update";
            this.ColAction.UseColumnTextForButtonValue = true;
            // 
            // tlpDietPlanHeader
            // 
            this.tlpDietPlanHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDietPlanHeader.ColumnCount = 3;
            this.tlpDietPlanHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpDietPlanHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.73684F));
            this.tlpDietPlanHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlpDietPlanHeader.Controls.Add(this.tlpTitleAndSubTitleBar, 1, 0);
            this.tlpDietPlanHeader.Location = new System.Drawing.Point(3, 2);
            this.tlpDietPlanHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpDietPlanHeader.Name = "tlpDietPlanHeader";
            this.tlpDietPlanHeader.RowCount = 1;
            this.tlpDietPlanHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDietPlanHeader.Size = new System.Drawing.Size(1143, 108);
            this.tlpDietPlanHeader.TabIndex = 3;
            this.tlpDietPlanHeader.Click += new System.EventHandler(this.tlpDietPlanHeader_Click);
            this.tlpDietPlanHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpDietPlanHeader_Paint);
            // 
            // tlpTitleAndSubTitleBar
            // 
            this.tlpTitleAndSubTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTitleAndSubTitleBar.ColumnCount = 3;
            this.tlpTitleAndSubTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.542969F));
            this.tlpTitleAndSubTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.80859F));
            this.tlpTitleAndSubTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.64844F));
            this.tlpTitleAndSubTitleBar.Controls.Add(this.pnlAddNewDietPlan, 2, 0);
            this.tlpTitleAndSubTitleBar.Controls.Add(this.tlpDietPlanTitleAndSubTitle, 1, 0);
            this.tlpTitleAndSubTitleBar.Controls.Add(this.picDietPlan, 0, 0);
            this.tlpTitleAndSubTitleBar.Location = new System.Drawing.Point(55, 2);
            this.tlpTitleAndSubTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpTitleAndSubTitleBar.Name = "tlpTitleAndSubTitleBar";
            this.tlpTitleAndSubTitleBar.RowCount = 1;
            this.tlpTitleAndSubTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleAndSubTitleBar.Size = new System.Drawing.Size(1027, 104);
            this.tlpTitleAndSubTitleBar.TabIndex = 2;
            this.tlpTitleAndSubTitleBar.Click += new System.EventHandler(this.tlpTitleAndSubTitleBar_Click_1);
            this.tlpTitleAndSubTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpTitleAndSubTitleBar_Paint);
            // 
            // pnlAddNewDietPlan
            // 
            this.pnlAddNewDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddNewDietPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddNewDietPlan.Controls.Add(this.tlpAddButton);
            this.pnlAddNewDietPlan.Location = new System.Drawing.Point(904, 67);
            this.pnlAddNewDietPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddNewDietPlan.Name = "pnlAddNewDietPlan";
            this.pnlAddNewDietPlan.Size = new System.Drawing.Size(120, 35);
            this.pnlAddNewDietPlan.TabIndex = 3;
            this.pnlAddNewDietPlan.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            // 
            // tlpAddButton
            // 
            this.tlpAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tlpAddButton.ColumnCount = 2;
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82269F));
            this.tlpAddButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.17731F));
            this.tlpAddButton.Controls.Add(this.lblAddNewDietPlan, 1, 0);
            this.tlpAddButton.Controls.Add(this.picAddIcon, 0, 0);
            this.tlpAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddButton.Location = new System.Drawing.Point(0, 0);
            this.tlpAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAddButton.Name = "tlpAddButton";
            this.tlpAddButton.RowCount = 1;
            this.tlpAddButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddButton.Size = new System.Drawing.Size(118, 33);
            this.tlpAddButton.TabIndex = 5;
            this.tlpAddButton.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.tlpAddButton.MouseEnter += new System.EventHandler(this.tlpAddButton_MouseEnter);
            this.tlpAddButton.MouseLeave += new System.EventHandler(this.tlpAddButton_MouseLeave);
            // 
            // lblAddNewDietPlan
            // 
            this.lblAddNewDietPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddNewDietPlan.AutoSize = true;
            this.lblAddNewDietPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDietPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(199)))));
            this.lblAddNewDietPlan.Location = new System.Drawing.Point(32, 6);
            this.lblAddNewDietPlan.Name = "lblAddNewDietPlan";
            this.lblAddNewDietPlan.Size = new System.Drawing.Size(78, 20);
            this.lblAddNewDietPlan.TabIndex = 1;
            this.lblAddNewDietPlan.Text = "Add New ";
            this.lblAddNewDietPlan.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.lblAddNewDietPlan.MouseEnter += new System.EventHandler(this.tlpAddButton_MouseEnter);
            this.lblAddNewDietPlan.MouseLeave += new System.EventHandler(this.tlpAddButton_MouseLeave);
            // 
            // picAddIcon
            // 
            this.picAddIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAddIcon.Image")));
            this.picAddIcon.Location = new System.Drawing.Point(9, 8);
            this.picAddIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAddIcon.Name = "picAddIcon";
            this.picAddIcon.Size = new System.Drawing.Size(17, 17);
            this.picAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddIcon.TabIndex = 2;
            this.picAddIcon.TabStop = false;
            this.picAddIcon.Click += new System.EventHandler(this.pnlAddNewDietPlan_Click);
            this.picAddIcon.MouseEnter += new System.EventHandler(this.tlpAddButton_MouseEnter);
            this.picAddIcon.MouseLeave += new System.EventHandler(this.tlpAddButton_MouseLeave);
            // 
            // tlpDietPlanTitleAndSubTitle
            // 
            this.tlpDietPlanTitleAndSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDietPlanTitleAndSubTitle.ColumnCount = 1;
            this.tlpDietPlanTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDietPlanTitleAndSubTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDietPlanTitleAndSubTitle.Controls.Add(this.lblDietPlan, 0, 0);
            this.tlpDietPlanTitleAndSubTitle.Controls.Add(this.lblSubTitle, 0, 1);
            this.tlpDietPlanTitleAndSubTitle.Location = new System.Drawing.Point(70, 2);
            this.tlpDietPlanTitleAndSubTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpDietPlanTitleAndSubTitle.Name = "tlpDietPlanTitleAndSubTitle";
            this.tlpDietPlanTitleAndSubTitle.RowCount = 3;
            this.tlpDietPlanTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpDietPlanTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDietPlanTitleAndSubTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpDietPlanTitleAndSubTitle.Size = new System.Drawing.Size(289, 100);
            this.tlpDietPlanTitleAndSubTitle.TabIndex = 1;
            this.tlpDietPlanTitleAndSubTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpDietPlanTitleAndSubTitle_Paint);
            // 
            // lblDietPlan
            // 
            this.lblDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDietPlan.AutoEllipsis = true;
            this.lblDietPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblDietPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDietPlan.ForeColor = System.Drawing.Color.Black;
            this.lblDietPlan.Location = new System.Drawing.Point(3, 21);
            this.lblDietPlan.Name = "lblDietPlan";
            this.lblDietPlan.Size = new System.Drawing.Size(147, 34);
            this.lblDietPlan.TabIndex = 0;
            this.lblDietPlan.Text = "Diet Plan";
            this.lblDietPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDietPlan.Click += new System.EventHandler(this.lblDietPlan_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoEllipsis = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubTitle.Location = new System.Drawing.Point(3, 55);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(156, 23);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Fuel your body right";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubTitle.Click += new System.EventHandler(this.lblDietPlan_Click);
            // 
            // picDietPlan
            // 
            this.picDietPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picDietPlan.Image = ((System.Drawing.Image)(resources.GetObject("picDietPlan.Image")));
            this.picDietPlan.Location = new System.Drawing.Point(3, 2);
            this.picDietPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDietPlan.Name = "picDietPlan";
            this.picDietPlan.Size = new System.Drawing.Size(61, 100);
            this.picDietPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDietPlan.TabIndex = 0;
            this.picDietPlan.TabStop = false;
            this.picDietPlan.Click += new System.EventHandler(this.picDietPlan_Click);
            // 
            // FrmShowDietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1149, 750);
            this.Controls.Add(this.tlpShowDietPlanAndAddNewDietPlan);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShowDietPlans";
            this.Text = "FrmShowDietPlans";
            this.Load += new System.EventHandler(this.FrmShowDietPlans_Load);
            this.tlpShowDietPlanAndAddNewDietPlan.ResumeLayout(false);
            this.tlpShowDietPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietPlan)).EndInit();
            this.tlpDietPlanHeader.ResumeLayout(false);
            this.tlpTitleAndSubTitleBar.ResumeLayout(false);
            this.pnlAddNewDietPlan.ResumeLayout(false);
            this.tlpAddButton.ResumeLayout(false);
            this.tlpAddButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddIcon)).EndInit();
            this.tlpDietPlanTitleAndSubTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDietPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlanAndAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpShowDietPlan;
        private System.Windows.Forms.DataGridView dgvDietPlan;
        private System.Windows.Forms.Label lblDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpDietPlanHeader;
        private System.Windows.Forms.TableLayoutPanel tlpTitleAndSubTitleBar;
        private System.Windows.Forms.PictureBox picDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpDietPlanTitleAndSubTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDietPlanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCaloriesPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCondition;
        private System.Windows.Forms.DataGridViewButtonColumn ColAction;
        private System.Windows.Forms.Panel pnlAddNewDietPlan;
        private System.Windows.Forms.TableLayoutPanel tlpAddButton;
        private System.Windows.Forms.Label lblAddNewDietPlan;
        private System.Windows.Forms.PictureBox picAddIcon;
    }
}