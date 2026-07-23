namespace GymManagementSystem.FORMS.RegistrationFee
{
    partial class FrmRegistrationFees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrationFees));
            this.dgvShowAllAddRegistrationFees = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMiddleFrmAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.pnlClickAddNewFegistrationFees = new System.Windows.Forms.Panel();
            this.tlpAddNewRegistrationFees = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddRegistrationFees = new System.Windows.Forms.Label();
            this.picAddRegistrationFee = new System.Windows.Forms.PictureBox();
            this.tlpTopFrmAddRegistrationFee = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrationFeesFrmAddRegistrationFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).BeginInit();
            this.tlpMiddleFrmAddRegistrationFee.SuspendLayout();
            this.pnlClickAddNewFegistrationFees.SuspendLayout();
            this.tlpAddNewRegistrationFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRegistrationFee)).BeginInit();
            this.tlpTopFrmAddRegistrationFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowAllAddRegistrationFees
            // 
            this.dgvShowAllAddRegistrationFees.AllowUserToAddRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToDeleteRows = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToResizeColumns = false;
            this.dgvShowAllAddRegistrationFees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvShowAllAddRegistrationFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowAllAddRegistrationFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowAllAddRegistrationFees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowAllAddRegistrationFees.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowAllAddRegistrationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeight = 50;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowAllAddRegistrationFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FeeAmount,
            this.IsActive,
            this.CreatedAt});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowAllAddRegistrationFees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowAllAddRegistrationFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowAllAddRegistrationFees.EnableHeadersVisualStyles = false;
            this.dgvShowAllAddRegistrationFees.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvShowAllAddRegistrationFees.Location = new System.Drawing.Point(64, 3);
            this.dgvShowAllAddRegistrationFees.MultiSelect = false;
            this.dgvShowAllAddRegistrationFees.Name = "dgvShowAllAddRegistrationFees";
            this.dgvShowAllAddRegistrationFees.ReadOnly = true;
            this.dgvShowAllAddRegistrationFees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowAllAddRegistrationFees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowAllAddRegistrationFees.RowHeadersVisible = false;
            this.dgvShowAllAddRegistrationFees.RowTemplate.Height = 20;
            this.dgvShowAllAddRegistrationFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvShowAllAddRegistrationFees.Size = new System.Drawing.Size(829, 449);
            this.dgvShowAllAddRegistrationFees.TabIndex = 0;
            this.dgvShowAllAddRegistrationFees.ColumnHeadersBorderStyleChanged += new System.EventHandler(this.FrmRegistrationFees_Load);
            // 
            // No
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.FillWeight = 50F;
            this.No.HeaderText = "SL No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FeeAmount
            // 
            this.FeeAmount.FillWeight = 80.83756F;
            this.FeeAmount.HeaderText = "Registration Fees";
            this.FeeAmount.Name = "FeeAmount";
            this.FeeAmount.ReadOnly = true;
            this.FeeAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsActive
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            this.IsActive.DefaultCellStyle = dataGridViewCellStyle4;
            this.IsActive.FillWeight = 80.83756F;
            this.IsActive.HeaderText = "Status";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedAt
            // 
            this.CreatedAt.FillWeight = 80.83756F;
            this.CreatedAt.HeaderText = "Created On";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpMiddleFrmAddRegistrationFee
            // 
            this.tlpMiddleFrmAddRegistrationFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMiddleFrmAddRegistrationFee.ColumnCount = 3;
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.dgvShowAllAddRegistrationFees, 1, 0);
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.pnlClickAddNewFegistrationFees, 1, 1);
            this.tlpMiddleFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddleFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 79);
            this.tlpMiddleFrmAddRegistrationFee.Name = "tlpMiddleFrmAddRegistrationFee";
            this.tlpMiddleFrmAddRegistrationFee.RowCount = 2;
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.24176F));
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.75824F));
            this.tlpMiddleFrmAddRegistrationFee.Size = new System.Drawing.Size(1234, 714);
            this.tlpMiddleFrmAddRegistrationFee.TabIndex = 3;
            this.tlpMiddleFrmAddRegistrationFee.Click += new System.EventHandler(this.tlpMiddleFrmAddRegistrationFee_Click);
            // 
            // pnlClickAddNewFegistrationFees
            // 
            this.pnlClickAddNewFegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewFegistrationFees.Controls.Add(this.tlpAddNewRegistrationFees);
            this.pnlClickAddNewFegistrationFees.Location = new System.Drawing.Point(64, 630);
            this.pnlClickAddNewFegistrationFees.Name = "pnlClickAddNewFegistrationFees";
            this.pnlClickAddNewFegistrationFees.Size = new System.Drawing.Size(236, 47);
            this.pnlClickAddNewFegistrationFees.TabIndex = 1;
            this.pnlClickAddNewFegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            // 
            // tlpAddNewRegistrationFees
            // 
            this.tlpAddNewRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewRegistrationFees.BackColor = System.Drawing.Color.Lavender;
            this.tlpAddNewRegistrationFees.ColumnCount = 2;
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.26549F));
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.73451F));
            this.tlpAddNewRegistrationFees.Controls.Add(this.lblAddRegistrationFees, 1, 0);
            this.tlpAddNewRegistrationFees.Controls.Add(this.picAddRegistrationFee, 0, 0);
            this.tlpAddNewRegistrationFees.Location = new System.Drawing.Point(0, 3);
            this.tlpAddNewRegistrationFees.Name = "tlpAddNewRegistrationFees";
            this.tlpAddNewRegistrationFees.RowCount = 1;
            this.tlpAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewRegistrationFees.Size = new System.Drawing.Size(233, 43);
            this.tlpAddNewRegistrationFees.TabIndex = 2;
            this.tlpAddNewRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.tlpAddNewRegistrationFees.MouseEnter += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseEnter);
            this.tlpAddNewRegistrationFees.MouseLeave += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseLeave);
            // 
            // lblAddRegistrationFees
            // 
            this.lblAddRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddRegistrationFees.AutoSize = true;
            this.lblAddRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRegistrationFees.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAddRegistrationFees.Location = new System.Drawing.Point(38, 12);
            this.lblAddRegistrationFees.Name = "lblAddRegistrationFees";
            this.lblAddRegistrationFees.Size = new System.Drawing.Size(178, 19);
            this.lblAddRegistrationFees.TabIndex = 1;
            this.lblAddRegistrationFees.Text = "Add New Registration Fees";
            this.lblAddRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.lblAddRegistrationFees.MouseEnter += new System.EventHandler(this.lblAddRegistrationFees_MouseEnter);
            this.lblAddRegistrationFees.MouseLeave += new System.EventHandler(this.lblAddRegistrationFees_MouseLeave);
            // 
            // picAddRegistrationFee
            // 
            this.picAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddRegistrationFee.Image = ((System.Drawing.Image)(resources.GetObject("picAddRegistrationFee.Image")));
            this.picAddRegistrationFee.Location = new System.Drawing.Point(3, 9);
            this.picAddRegistrationFee.Name = "picAddRegistrationFee";
            this.picAddRegistrationFee.Size = new System.Drawing.Size(29, 25);
            this.picAddRegistrationFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddRegistrationFee.TabIndex = 0;
            this.picAddRegistrationFee.TabStop = false;
            this.picAddRegistrationFee.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.picAddRegistrationFee.MouseEnter += new System.EventHandler(this.picAddRegistrationFee_MouseEnter);
            this.picAddRegistrationFee.MouseLeave += new System.EventHandler(this.picAddRegistrationFee_MouseLeave);
            // 
            // tlpTopFrmAddRegistrationFee
            // 
            this.tlpTopFrmAddRegistrationFee.ColumnCount = 2;
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpTopFrmAddRegistrationFee.Controls.Add(this.lblRegistrationFeesFrmAddRegistrationFee, 1, 0);
            this.tlpTopFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 0);
            this.tlpTopFrmAddRegistrationFee.Name = "tlpTopFrmAddRegistrationFee";
            this.tlpTopFrmAddRegistrationFee.RowCount = 1;
            this.tlpTopFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopFrmAddRegistrationFee.Size = new System.Drawing.Size(1234, 79);
            this.tlpTopFrmAddRegistrationFee.TabIndex = 2;
            this.tlpTopFrmAddRegistrationFee.Click += new System.EventHandler(this.tlpTopFrmAddRegistrationFee_Click);
            // 
            // lblRegistrationFeesFrmAddRegistrationFee
            // 
            this.lblRegistrationFeesFrmAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegistrationFeesFrmAddRegistrationFee.AutoSize = true;
            this.lblRegistrationFeesFrmAddRegistrationFee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFeesFrmAddRegistrationFee.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRegistrationFeesFrmAddRegistrationFee.Location = new System.Drawing.Point(64, 19);
            this.lblRegistrationFeesFrmAddRegistrationFee.Name = "lblRegistrationFeesFrmAddRegistrationFee";
            this.lblRegistrationFeesFrmAddRegistrationFee.Size = new System.Drawing.Size(252, 41);
            this.lblRegistrationFeesFrmAddRegistrationFee.TabIndex = 1;
            this.lblRegistrationFeesFrmAddRegistrationFee.Text = "Registration Fees";
            // 
            // tlpMiddleFrmAddRegistrationFee
            // 
            this.tlpMiddleFrmAddRegistrationFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tlpMiddleFrmAddRegistrationFee.ColumnCount = 3;
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMiddleFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.dgvShowAllAddRegistrationFees, 1, 0);
            this.tlpMiddleFrmAddRegistrationFee.Controls.Add(this.pnlClickAddNewFegistrationFees, 1, 1);
            this.tlpMiddleFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddleFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 64);
            this.tlpMiddleFrmAddRegistrationFee.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMiddleFrmAddRegistrationFee.Name = "tlpMiddleFrmAddRegistrationFee";
            this.tlpMiddleFrmAddRegistrationFee.RowCount = 2;
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.24176F));
            this.tlpMiddleFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.75824F));
            this.tlpMiddleFrmAddRegistrationFee.Size = new System.Drawing.Size(926, 545);
            this.tlpMiddleFrmAddRegistrationFee.TabIndex = 3;
            this.tlpMiddleFrmAddRegistrationFee.Click += new System.EventHandler(this.tlpMiddleFrmAddRegistrationFee_Click);
            // 
            // pnlClickAddNewFegistrationFees
            // 
            this.pnlClickAddNewFegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlClickAddNewFegistrationFees.Controls.Add(this.tlpAddNewRegistrationFees);
            this.pnlClickAddNewFegistrationFees.Location = new System.Drawing.Point(48, 468);
            this.pnlClickAddNewFegistrationFees.Margin = new System.Windows.Forms.Padding(2);
            this.pnlClickAddNewFegistrationFees.Name = "pnlClickAddNewFegistrationFees";
            this.pnlClickAddNewFegistrationFees.Size = new System.Drawing.Size(339, 61);
            this.pnlClickAddNewFegistrationFees.TabIndex = 1;
            this.pnlClickAddNewFegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            // 
            // tlpAddNewRegistrationFees
            // 
            this.tlpAddNewRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpAddNewRegistrationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.tlpAddNewRegistrationFees.ColumnCount = 2;
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.26549F));
            this.tlpAddNewRegistrationFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.73451F));
            this.tlpAddNewRegistrationFees.Controls.Add(this.lblAddRegistrationFees, 1, 0);
            this.tlpAddNewRegistrationFees.Controls.Add(this.picAddRegistrationFee, 0, 0);
            this.tlpAddNewRegistrationFees.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewRegistrationFees.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAddNewRegistrationFees.Name = "tlpAddNewRegistrationFees";
            this.tlpAddNewRegistrationFees.RowCount = 1;
            this.tlpAddNewRegistrationFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddNewRegistrationFees.Size = new System.Drawing.Size(339, 60);
            this.tlpAddNewRegistrationFees.TabIndex = 2;
            this.tlpAddNewRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.tlpAddNewRegistrationFees.MouseEnter += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseEnter);
            this.tlpAddNewRegistrationFees.MouseLeave += new System.EventHandler(this.tlpAddNewRegistrationFees_MouseLeave);
            // 
            // lblAddRegistrationFees
            // 
            this.lblAddRegistrationFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddRegistrationFees.AutoSize = true;
            this.lblAddRegistrationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRegistrationFees.Location = new System.Drawing.Point(53, 15);
            this.lblAddRegistrationFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddRegistrationFees.Name = "lblAddRegistrationFees";
            this.lblAddRegistrationFees.Size = new System.Drawing.Size(282, 30);
            this.lblAddRegistrationFees.TabIndex = 1;
            this.lblAddRegistrationFees.Text = "Add New Registration Fees";
            this.lblAddRegistrationFees.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.lblAddRegistrationFees.MouseEnter += new System.EventHandler(this.lblAddRegistrationFees_MouseEnter);
            this.lblAddRegistrationFees.MouseLeave += new System.EventHandler(this.lblAddRegistrationFees_MouseLeave);
            // 
            // picAddRegistrationFee
            // 
            this.picAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAddRegistrationFee.Image = ((System.Drawing.Image)(resources.GetObject("picAddRegistrationFee.Image")));
            this.picAddRegistrationFee.Location = new System.Drawing.Point(18, 17);
            this.picAddRegistrationFee.Margin = new System.Windows.Forms.Padding(2);
            this.picAddRegistrationFee.Name = "picAddRegistrationFee";
            this.picAddRegistrationFee.Size = new System.Drawing.Size(31, 26);
            this.picAddRegistrationFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddRegistrationFee.TabIndex = 0;
            this.picAddRegistrationFee.TabStop = false;
            this.picAddRegistrationFee.Click += new System.EventHandler(this.pnlClickAddNewFegistrationFees_Click);
            this.picAddRegistrationFee.MouseEnter += new System.EventHandler(this.picAddRegistrationFee_MouseEnter);
            this.picAddRegistrationFee.MouseLeave += new System.EventHandler(this.picAddRegistrationFee_MouseLeave);
            // 
            // tlpTopFrmAddRegistrationFee
            // 
            this.tlpTopFrmAddRegistrationFee.ColumnCount = 2;
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpTopFrmAddRegistrationFee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpTopFrmAddRegistrationFee.Controls.Add(this.lblRegistrationFeesFrmAddRegistrationFee, 1, 0);
            this.tlpTopFrmAddRegistrationFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopFrmAddRegistrationFee.Location = new System.Drawing.Point(0, 0);
            this.tlpTopFrmAddRegistrationFee.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTopFrmAddRegistrationFee.Name = "tlpTopFrmAddRegistrationFee";
            this.tlpTopFrmAddRegistrationFee.RowCount = 1;
            this.tlpTopFrmAddRegistrationFee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopFrmAddRegistrationFee.Size = new System.Drawing.Size(926, 64);
            this.tlpTopFrmAddRegistrationFee.TabIndex = 2;
            this.tlpTopFrmAddRegistrationFee.Click += new System.EventHandler(this.tlpTopFrmAddRegistrationFee_Click);
            // 
            // lblRegistrationFeesFrmAddRegistrationFee
            // 
            this.lblRegistrationFeesFrmAddRegistrationFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegistrationFeesFrmAddRegistrationFee.AutoSize = true;
            this.lblRegistrationFeesFrmAddRegistrationFee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFeesFrmAddRegistrationFee.Location = new System.Drawing.Point(48, 16);
            this.lblRegistrationFeesFrmAddRegistrationFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationFeesFrmAddRegistrationFee.Name = "lblRegistrationFeesFrmAddRegistrationFee";
            this.lblRegistrationFeesFrmAddRegistrationFee.Size = new System.Drawing.Size(201, 32);
            this.lblRegistrationFeesFrmAddRegistrationFee.TabIndex = 0;
            this.lblRegistrationFeesFrmAddRegistrationFee.Text = "Registration Fees";
            this.lblRegistrationFeesFrmAddRegistrationFee.Click += new System.EventHandler(this.lblRegistrationFeesFrmAddRegistrationFee_Click);
            // 
            // FrmRegistrationFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(926, 609);
            this.Controls.Add(this.tlpMiddleFrmAddRegistrationFee);
            this.Controls.Add(this.tlpTopFrmAddRegistrationFee);
            this.Name = "FrmRegistrationFees";
            this.Text = "FrmRegistrationFees";
            this.Load += new System.EventHandler(this.FrmRegistrationFees_Load);
            this.Resize += new System.EventHandler(this.FrmRegistrationFees_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllAddRegistrationFees)).EndInit();
            this.tlpMiddleFrmAddRegistrationFee.ResumeLayout(false);
            this.pnlClickAddNewFegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.ResumeLayout(false);
            this.tlpAddNewRegistrationFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRegistrationFee)).EndInit();
            this.tlpTopFrmAddRegistrationFee.ResumeLayout(false);
            this.tlpTopFrmAddRegistrationFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowAllAddRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpMiddleFrmAddRegistrationFee;
        private System.Windows.Forms.Panel pnlClickAddNewFegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpAddNewRegistrationFees;
        private System.Windows.Forms.PictureBox picAddRegistrationFee;
        private System.Windows.Forms.Label lblAddRegistrationFees;
        private System.Windows.Forms.TableLayoutPanel tlpTopFrmAddRegistrationFee;
        private System.Windows.Forms.Label lblRegistrationFeesFrmAddRegistrationFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}