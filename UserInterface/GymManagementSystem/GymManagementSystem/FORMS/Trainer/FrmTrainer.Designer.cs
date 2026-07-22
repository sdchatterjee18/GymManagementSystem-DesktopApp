namespace GymManagementSystem.FORMS.Trainer
{
    partial class FrmTrainer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpTrainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTrainerDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTrainerDetails = new System.Windows.Forms.Panel();
            this.lblTrainerDetails = new System.Windows.Forms.Label();
            this.tlpSelectTrainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGeneralTrainer = new System.Windows.Forms.Panel();
            this.lblGeneralTrainer = new System.Windows.Forms.Label();
            this.picGeneralTrainer = new System.Windows.Forms.PictureBox();
            this.pnlPersonalTrainer = new System.Windows.Forms.Panel();
            this.lblPersonalTrainer = new System.Windows.Forms.Label();
            this.picPersonalTrainer = new System.Windows.Forms.PictureBox();
            this.tlpSearchSection = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tlpShowTrainers = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTrainerDetails = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tlpTrainer.SuspendLayout();
            this.tlpTrainerDetails.SuspendLayout();
            this.pnlTrainerDetails.SuspendLayout();
            this.tlpSelectTrainer.SuspendLayout();
            this.pnlGeneralTrainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralTrainer)).BeginInit();
            this.pnlPersonalTrainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalTrainer)).BeginInit();
            this.tlpSearchSection.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tlpShowTrainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTrainer
            // 
            this.tlpTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTrainer.ColumnCount = 1;
            this.tlpTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrainer.Controls.Add(this.tlpTrainerDetails, 0, 0);
            this.tlpTrainer.Controls.Add(this.tlpSelectTrainer, 0, 2);
            this.tlpTrainer.Controls.Add(this.tlpSearchSection, 0, 4);
            this.tlpTrainer.Controls.Add(this.tlpShowTrainers, 0, 6);
            this.tlpTrainer.Location = new System.Drawing.Point(1, 3);
            this.tlpTrainer.Name = "tlpTrainer";
            this.tlpTrainer.RowCount = 8;
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.383081F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.667344F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.77023F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.273885F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.917197F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.184713F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.49044F));
            this.tlpTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.991236F));
            this.tlpTrainer.Size = new System.Drawing.Size(1148, 785);
            this.tlpTrainer.TabIndex = 0;
            this.tlpTrainer.Click += new System.EventHandler(this.tlpTrainer_Click);
            // 
            // tlpTrainerDetails
            // 
            this.tlpTrainerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTrainerDetails.ColumnCount = 3;
            this.tlpTrainerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.751313F));
            this.tlpTrainerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29247F));
            this.tlpTrainerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.86865F));
            this.tlpTrainerDetails.Controls.Add(this.pnlTrainerDetails, 1, 0);
            this.tlpTrainerDetails.Location = new System.Drawing.Point(3, 3);
            this.tlpTrainerDetails.Name = "tlpTrainerDetails";
            this.tlpTrainerDetails.RowCount = 1;
            this.tlpTrainerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrainerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpTrainerDetails.Size = new System.Drawing.Size(1142, 60);
            this.tlpTrainerDetails.TabIndex = 0;
            this.tlpTrainerDetails.Click += new System.EventHandler(this.tlpTrainerDetails_Click);
            // 
            // pnlTrainerDetails
            // 
            this.pnlTrainerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTrainerDetails.Controls.Add(this.lblTrainerDetails);
            this.pnlTrainerDetails.Location = new System.Drawing.Point(23, 3);
            this.pnlTrainerDetails.Name = "pnlTrainerDetails";
            this.pnlTrainerDetails.Size = new System.Drawing.Size(260, 54);
            this.pnlTrainerDetails.TabIndex = 0;
            // 
            // lblTrainerDetails
            // 
            this.lblTrainerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblTrainerDetails.Location = new System.Drawing.Point(3, 0);
            this.lblTrainerDetails.Name = "lblTrainerDetails";
            this.lblTrainerDetails.Size = new System.Drawing.Size(254, 54);
            this.lblTrainerDetails.TabIndex = 0;
            this.lblTrainerDetails.Text = "Trainer Details";
            this.lblTrainerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSelectTrainer
            // 
            this.tlpSelectTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSelectTrainer.ColumnCount = 5;
            this.tlpSelectTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSelectTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSelectTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSelectTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSelectTrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSelectTrainer.Controls.Add(this.pnlGeneralTrainer, 1, 0);
            this.tlpSelectTrainer.Controls.Add(this.pnlPersonalTrainer, 3, 0);
            this.tlpSelectTrainer.Location = new System.Drawing.Point(3, 90);
            this.tlpSelectTrainer.Name = "tlpSelectTrainer";
            this.tlpSelectTrainer.RowCount = 1;
            this.tlpSelectTrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSelectTrainer.Size = new System.Drawing.Size(1142, 252);
            this.tlpSelectTrainer.TabIndex = 1;
            this.tlpSelectTrainer.Click += new System.EventHandler(this.tlpSelectTrainer_Click);
            // 
            // pnlGeneralTrainer
            // 
            this.pnlGeneralTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGeneralTrainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneralTrainer.Controls.Add(this.lblGeneralTrainer);
            this.pnlGeneralTrainer.Controls.Add(this.picGeneralTrainer);
            this.pnlGeneralTrainer.Location = new System.Drawing.Point(231, 3);
            this.pnlGeneralTrainer.Name = "pnlGeneralTrainer";
            this.pnlGeneralTrainer.Size = new System.Drawing.Size(279, 246);
            this.pnlGeneralTrainer.TabIndex = 0;
            this.pnlGeneralTrainer.MouseEnter += new System.EventHandler(this.pnlGeneralTrainer_MouseEnter);
            this.pnlGeneralTrainer.MouseLeave += new System.EventHandler(this.pnlGeneralTrainer_MouseLeave);
            this.pnlGeneralTrainer.MouseHover += new System.EventHandler(this.pnlGeneralTrainer_MouseHover);
            // 
            // lblGeneralTrainer
            // 
            this.lblGeneralTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneralTrainer.AutoSize = true;
            this.lblGeneralTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblGeneralTrainer.Location = new System.Drawing.Point(65, 195);
            this.lblGeneralTrainer.Name = "lblGeneralTrainer";
            this.lblGeneralTrainer.Size = new System.Drawing.Size(149, 28);
            this.lblGeneralTrainer.TabIndex = 1;
            this.lblGeneralTrainer.Text = "General Trainer";
            this.lblGeneralTrainer.Click += new System.EventHandler(this.lblGeneralTrainer_Click);
            this.lblGeneralTrainer.MouseEnter += new System.EventHandler(this.pnlGeneralTrainer_MouseEnter);
            this.lblGeneralTrainer.MouseLeave += new System.EventHandler(this.pnlGeneralTrainer_MouseLeave);
            this.lblGeneralTrainer.MouseHover += new System.EventHandler(this.pnlGeneralTrainer_MouseHover);
            // 
            // picGeneralTrainer
            // 
            this.picGeneralTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGeneralTrainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGeneralTrainer.Location = new System.Drawing.Point(68, 30);
            this.picGeneralTrainer.Name = "picGeneralTrainer";
            this.picGeneralTrainer.Size = new System.Drawing.Size(145, 146);
            this.picGeneralTrainer.TabIndex = 0;
            this.picGeneralTrainer.TabStop = false;
            this.picGeneralTrainer.MouseEnter += new System.EventHandler(this.pnlGeneralTrainer_MouseEnter);
            this.picGeneralTrainer.MouseLeave += new System.EventHandler(this.pnlGeneralTrainer_MouseLeave);
            this.picGeneralTrainer.MouseHover += new System.EventHandler(this.pnlGeneralTrainer_MouseHover);
            // 
            // pnlPersonalTrainer
            // 
            this.pnlPersonalTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonalTrainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPersonalTrainer.Controls.Add(this.lblPersonalTrainer);
            this.pnlPersonalTrainer.Controls.Add(this.picPersonalTrainer);
            this.pnlPersonalTrainer.Location = new System.Drawing.Point(630, 3);
            this.pnlPersonalTrainer.Name = "pnlPersonalTrainer";
            this.pnlPersonalTrainer.Size = new System.Drawing.Size(279, 246);
            this.pnlPersonalTrainer.TabIndex = 0;
            this.pnlPersonalTrainer.MouseEnter += new System.EventHandler(this.pnlPersonalTrainer_MouseEnter);
            this.pnlPersonalTrainer.MouseLeave += new System.EventHandler(this.pnlPersonalTrainer_MouseLeave);
            this.pnlPersonalTrainer.MouseHover += new System.EventHandler(this.pnlPersonalTrainer_MouseHover);
            // 
            // lblPersonalTrainer
            // 
            this.lblPersonalTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonalTrainer.AutoSize = true;
            this.lblPersonalTrainer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.lblPersonalTrainer.Location = new System.Drawing.Point(65, 195);
            this.lblPersonalTrainer.Name = "lblPersonalTrainer";
            this.lblPersonalTrainer.Size = new System.Drawing.Size(156, 28);
            this.lblPersonalTrainer.TabIndex = 1;
            this.lblPersonalTrainer.Text = "Personal Trainer";
            this.lblPersonalTrainer.Click += new System.EventHandler(this.lblGeneralTrainer_Click);
            this.lblPersonalTrainer.MouseEnter += new System.EventHandler(this.pnlPersonalTrainer_MouseEnter);
            this.lblPersonalTrainer.MouseLeave += new System.EventHandler(this.pnlPersonalTrainer_MouseLeave);
            this.lblPersonalTrainer.MouseHover += new System.EventHandler(this.pnlPersonalTrainer_MouseHover);
            // 
            // picPersonalTrainer
            // 
            this.picPersonalTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPersonalTrainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPersonalTrainer.Location = new System.Drawing.Point(68, 30);
            this.picPersonalTrainer.Name = "picPersonalTrainer";
            this.picPersonalTrainer.Size = new System.Drawing.Size(145, 146);
            this.picPersonalTrainer.TabIndex = 0;
            this.picPersonalTrainer.TabStop = false;
            this.picPersonalTrainer.MouseEnter += new System.EventHandler(this.pnlPersonalTrainer_MouseEnter);
            this.picPersonalTrainer.MouseLeave += new System.EventHandler(this.pnlPersonalTrainer_MouseLeave);
            this.picPersonalTrainer.MouseHover += new System.EventHandler(this.pnlPersonalTrainer_MouseHover);
            // 
            // tlpSearchSection
            // 
            this.tlpSearchSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSearchSection.ColumnCount = 4;
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05254F));
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.91068F));
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.97373F));
            this.tlpSearchSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.23818F));
            this.tlpSearchSection.Controls.Add(this.pnlSearch, 0, 0);
            this.tlpSearchSection.Controls.Add(this.txtSearchBar, 1, 0);
            this.tlpSearchSection.Controls.Add(this.btnSubmit, 2, 0);
            this.tlpSearchSection.Location = new System.Drawing.Point(3, 358);
            this.tlpSearchSection.Name = "tlpSearchSection";
            this.tlpSearchSection.RowCount = 1;
            this.tlpSearchSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpSearchSection.Size = new System.Drawing.Size(1142, 64);
            this.tlpSearchSection.TabIndex = 2;
            this.tlpSearchSection.Click += new System.EventHandler(this.tlpSearchSection_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(222, 58);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(111, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 37);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.txtSearchBar.Location = new System.Drawing.Point(231, 14);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(346, 36);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Text = "Enter Moblie No.";
            this.txtSearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(605, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 42);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tlpShowTrainers
            // 
            this.tlpShowTrainers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpShowTrainers.ColumnCount = 3;
            this.tlpShowTrainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tlpShowTrainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.4762F));
            this.tlpShowTrainers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpShowTrainers.Controls.Add(this.dgvTrainerDetails, 1, 0);
            this.tlpShowTrainers.Location = new System.Drawing.Point(3, 453);
            this.tlpShowTrainers.Name = "tlpShowTrainers";
            this.tlpShowTrainers.RowCount = 1;
            this.tlpShowTrainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpShowTrainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowTrainers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpShowTrainers.Size = new System.Drawing.Size(1142, 305);
            this.tlpShowTrainers.TabIndex = 3;
            this.tlpShowTrainers.Click += new System.EventHandler(this.tlpShowTrainers_Click);
            // 
            // dgvTrainerDetails
            // 
            this.dgvTrainerDetails.AllowUserToAddRows = false;
            this.dgvTrainerDetails.AllowUserToResizeColumns = false;
            this.dgvTrainerDetails.AllowUserToResizeRows = false;
            this.dgvTrainerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainerDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvTrainerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.TrainerId,
            this.TrainerName,
            this.Specialization,
            this.TrainerType,
            this.Document,
            this.PhoneNo,
            this.Gender,
            this.Profile});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 14.8F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainerDetails.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvTrainerDetails.GridColor = System.Drawing.Color.Black;
            this.dgvTrainerDetails.Location = new System.Drawing.Point(57, 3);
            this.dgvTrainerDetails.Name = "dgvTrainerDetails";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainerDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvTrainerDetails.RowHeadersVisible = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.dgvTrainerDetails.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvTrainerDetails.RowTemplate.Height = 40;
            this.dgvTrainerDetails.Size = new System.Drawing.Size(1027, 299);
            this.dgvTrainerDetails.TabIndex = 0;
            this.dgvTrainerDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTrainerDetails_CellFormatting);
            this.dgvTrainerDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainerDetails_CellMouseEnter);
            this.dgvTrainerDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainerDetails_CellMouseLeave);
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TrainerId
            // 
            this.TrainerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainerId.HeaderText = "Trainer Id";
            this.TrainerId.Name = "TrainerId";
            this.TrainerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TrainerName
            // 
            this.TrainerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainerName.DataPropertyName = "ColTrainerName";
            this.TrainerName.HeaderText = "Trainer Name";
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Specialization
            // 
            this.Specialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Specialization.DataPropertyName = "ColSpecialization";
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.Name = "Specialization";
            this.Specialization.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TrainerType
            // 
            this.TrainerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrainerType.DataPropertyName = "colTrainerType";
            this.TrainerType.HeaderText = "Trainer Type";
            this.TrainerType.Name = "TrainerType";
            this.TrainerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Document
            // 
            this.Document.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Document.DataPropertyName = "ColDocument";
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNo.DataPropertyName = "ColPhoneNo";
            this.PhoneNo.HeaderText = "Phone No";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "ColGender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profile
            // 
            this.Profile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profile.HeaderText = "Profile";
            this.Profile.Name = "Profile";
            // 
            // FrmTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1149, 788);
            this.Controls.Add(this.tlpTrainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTrainer";
            this.Text = "FrmTrainer";
            this.Load += new System.EventHandler(this.FrmTrainer_Load);
            this.tlpTrainer.ResumeLayout(false);
            this.tlpTrainerDetails.ResumeLayout(false);
            this.pnlTrainerDetails.ResumeLayout(false);
            this.tlpSelectTrainer.ResumeLayout(false);
            this.pnlGeneralTrainer.ResumeLayout(false);
            this.pnlGeneralTrainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralTrainer)).EndInit();
            this.pnlPersonalTrainer.ResumeLayout(false);
            this.pnlPersonalTrainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalTrainer)).EndInit();
            this.tlpSearchSection.ResumeLayout(false);
            this.tlpSearchSection.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.tlpShowTrainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrainer;
        private System.Windows.Forms.TableLayoutPanel tlpTrainerDetails;
        private System.Windows.Forms.Panel pnlTrainerDetails;
        private System.Windows.Forms.Label lblTrainerDetails;
        private System.Windows.Forms.TableLayoutPanel tlpSelectTrainer;
        private System.Windows.Forms.Panel pnlGeneralTrainer;
        private System.Windows.Forms.PictureBox picGeneralTrainer;
        private System.Windows.Forms.Label lblGeneralTrainer;
        private System.Windows.Forms.Panel pnlPersonalTrainer;
        private System.Windows.Forms.Label lblPersonalTrainer;
        private System.Windows.Forms.PictureBox picPersonalTrainer;
        private System.Windows.Forms.TableLayoutPanel tlpSearchSection;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tlpShowTrainers;
        private System.Windows.Forms.DataGridView dgvTrainerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewButtonColumn Profile;
    }
}